using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Bases;

namespace CCAuthorizer___AuthorizeAPI
{
    public partial class MainForm : Form
    {
        private string loginID;
        private string transKey;
        private string[,] fileDataArray;    // This will contain organized strings regarding the elements contained in any inputted file.

        public MainForm()
        {
            InitializeComponent();
            this.Enabled = false;   // Disable MainForm until login data is retrieved from LoginForm.

            LoginForm loginForm = new LoginForm();  // Create new LoginForm and display it.
            loginForm.ShowDialog();

            // Initialize private variables.
            if (loginForm.DialogResult == DialogResult.OK)
            {
                loginID = loginForm.GetLogin();             // Update loginID and transKey in MainForm using data from LoginForm.
                transKey = loginForm.GetTransactionKey();

                loginForm.Close();      // Close LoginForm dialog and re-enable MainForm.
                this.Enabled = true;
            }
            else if (loginForm.DialogResult == DialogResult.Cancel)
            {
                Environment.Exit(0); // DialogResult for LoginForm should only be OK when using MainForm. If it's Cancel instead, close entire application since user shouldn't have access without login credentials.
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)   // If the selected file is a CSV format, proceed.
            {
                CSVFileParse();
            }
        }

        private void SearchFileButton_Click(object sender, EventArgs e)
        {
            if (fileDataArray != null && ShopperIDTextBox.Text != "")   // Import ShopperID info so long as a file HAS been imported and the ShopperID text box isn't empty.
            {
                ShopperIDImport();
            }
            else if (fileDataArray == null)
            {
                MessageBox.Show("File has not been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ShopperIDTextBox.Text == "")
            {
                MessageBox.Show("Shopper ID required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthorizeButton_Click(object sender, EventArgs e)
        {
            bool isEmpty = (CCNTextBox.Text == "" || ExpirationDateTextBox.Text == "" || CCVTextBox.Text == "" || AddressTextBox.Text == "" || ZipCodeTextBox.Text == ""); // If any of these are empty, set to true.

            if (!isEmpty)   // So long as the required boxes aren't empty, proceed with authorization. Otherwise, inform user.
            {
                AuthorizeCard();
            }
            else
            {
                MessageBox.Show("Required info missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CSVFileParse()
        {
            int numIndex = 0, elemCount = 0, descCount = 0, elemLineCount = 0, charIndex = 0, xIndex = 0, yIndex = 0, elemStartChar = 0;
            bool newlineFound = false, elemCounted = false, fileOpen = false;
            string fileData = "";                                               // This string will contain all text data in the input file.

            try
            {
                fileData = File.ReadAllText(openFile.FileName);                     // Convert the given file to a string and store it in fileData.
            }
            catch (IOException)
            {
                MessageBox.Show("File is being used by another program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error box if file is open elsewhere.
                fileOpen = true;    // Since an exception was caught we set this to true so the function won't try to parse when there's no data to parse.
            }

            if (fileData.Length == 0 && !fileOpen)
            {
                MessageBox.Show("File is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error box if file isn't open elsewhere but is also empty.
            }

            // ELEMENT COUNTING BEGINS

            if (!fileOpen && fileData.Length != 0)                                  // Makes sure the file isn't open elsewhere and that there is data in the file to work with.
            {
                while (!elemCounted && numIndex < fileData.Length)                  // Scan characters of fileData one-by-one and count elements until either they are all counted or EOF is reached.
                {
                    if (numIndex == (fileData.Length - 1))                          // If numIndex has reached the end of the file...
                    {
                        elemCount++;                                                // Increment elemCount to include data at EOF and exit the loop.
                        elemCounted = true;
                    }
                    else if (fileData[numIndex] == ',')                             // If a comma has been found, an element must've been passed so it needs to be counted.
                    {
                        elemCount++;
                    }
                    else if (fileData[numIndex] == '\n')
                    {
                        elemCount++;                                                // Since newlines can also delimit relevant elements, we count them too.

                        if (fileData[numIndex + 1] == '\n')
                        {
                            elemCounted = true;                                     // When two newlines are found one after the other, this indicates the end of relevant customer info.
                        }

                        if (!newlineFound)                                          // If a newline is found for the first time, descriptor elements must've ended, so the current elemCount is the descCount.
                        {
                            descCount = elemCount;
                            newlineFound = true;
                        }
                    }

                    numIndex++;
                }

                // ELEMENT COUNTING ENDS

                // DESCRIPTOR ELEMENT STORING BEGINS

                elemLineCount = elemCount / descCount;                              // The DescCount divided by the ElemCount is equal to the total number of unique lines in the file. This is because the descCount represents the number of elements per element line.
                String[,] elemArray = new String[descCount, elemLineCount];         // We set the elemArray from earlier to be as wide as a full line of elements (descCount) and as deep as there are lines of elements.
                elemStartChar = 0;                                                  // Ensure we start at the beginning of the file before the upcoming while loop.
                charIndex = 0;                                                      // Same as above line.

                while (xIndex < descCount && charIndex < fileData.Length)           // While there are still descriptor elements to be pulled into elemArray and charIndex hasn't moved past the end of the file...
                {
                    if (fileData[charIndex] == ',')                                 // If the current character is a comma, pull all info between the past comma and the current comma.
                    {
                        elemArray[xIndex, 0] = fileData.Substring(elemStartChar, charIndex - elemStartChar);    // This will pull the necessary element info and put it into its appropriate storage in elemArray.
                        elemStartChar = charIndex + 1;                                                          // We want to start on the first character of the next element. This means AFTER the comma we just hit.
                        xIndex++;                                                                               // Increment xIndex to indicate we've filled an index in elemArray with an element from the file and we'd like to fill another.
                    }
                    else if (fileData[charIndex] == '\n')
                    {
                        elemArray[xIndex, 0] = fileData.Substring(elemStartChar, charIndex - elemStartChar);    // This will pull the necessary element info and put it into its appropriate storage in elemArray.
                        elemStartChar = charIndex + 2;                                                          // We want to start on the first character of the next element. This means two AFTER the newline we just hit.
                        charIndex++;                                                                            // charIndex will be incremented shortly after this so there's no need to add two to char index like above. Therefore we'll just add one.
                        xIndex++;                                                                               // Increment to indicate an index of elemArray has been filled with data from the file.
                    }

                    charIndex++;                                                                                // Proceed on to the next character.
                }

                // DESCRIPTOR ELEMENT STORING ENDS

                // CUSTOMER ELEMENT STORING BEGINS

                yIndex = 1;                                                                                     // yIndex is set to be one as the yIndex of zero was already filled by the descriptor element while loop previously.

                while (yIndex < elemLineCount && charIndex < fileData.Length)                                           // While all element lines have not been read into the array, continue reading.
                {
                    xIndex = 0;

                    while (xIndex < descCount && charIndex < fileData.Length)                                           // While there are still elements to read in the current line, continue reading.
                    {
                        if (fileData[charIndex] == '"')
                        {
                            elemArray[xIndex, yIndex] = fileData.Substring(elemStartChar, charIndex - elemStartChar);   // Since a quote has been found, the end of an element has been reached. Because of this, read in whatever is between elemStartChar and the current character.

                            if (fileData[charIndex + 1] == ',' && fileData[charIndex + 2] == '"')                       // The purpose of both of these if-statements is simply to set both charIndex and elemStartChar into the correct position after an element has just been read.
                            {
                                charIndex += 2;
                                elemStartChar = charIndex + 1;
                            }
                            else if (fileData[charIndex + 1] == '\n' && fileData[charIndex + 2] == '"')
                            {
                                charIndex += 2;
                                elemStartChar = charIndex + 1;
                            }

                            xIndex++;                                                                                   // Since an element was just read we increment xIndex to represent us moving on to fill the next slot in elemArray.
                        }

                        charIndex++;                                                                                    // Regardless whether the end of an element either has or hasn't been found, move on to the next element.
                    }

                    yIndex++;                                                                                           // Since a line element has just been read, move on to the next line.
                }

                // CUSTOMER ELEMENT STORING ENDS

                fileDataArray = elemArray;                                                                              // Finally, after filling elemArray, set the fileDataArray var associated with MainForm equal to elemArray.
                FileText.Text = openFile.SafeFileName;                                                                  // Since we've loaded a file, we set the "File Selected" text to read the file name.
            }
        }

        private void ShopperIDImport()
        {
            int shopperIndex = 0, ccnIndex = 0, expIndex = 0, cvvIndex = 0, addressIndex = 0, zipIndex = 0, customerIndex = 0;
            bool shopperMatch = false;

            int arrayLength = fileDataArray.GetLength(0);                                                           // Store the length of the fileDataArray into arrayLength.

            for (int index = 0; index < arrayLength; index++)
            {
                switch (fileDataArray[index, 0])                                                                    // As the for loop progresses, record the index number of certain specific elements in the array.
                {
                    case "shopperid":
                        shopperIndex = index;
                        break;
                    case "card_number":
                        ccnIndex = index;
                        break;
                    case "card_expires":
                        expIndex = index;
                        break;
                    case "CV2":
                        cvvIndex = index;
                        break;
                    case "inv_address1":
                        addressIndex = index;
                        break;
                    case "inv_pocode":
                        zipIndex = index;
                        break;
                }
            }

            int arrayWidth = fileDataArray.GetLength(1);                                                            // Set the width of the array to be the width of fileDataArray.

            for (customerIndex = 1; customerIndex < arrayWidth; customerIndex++)
            {
                if (fileDataArray[shopperIndex, customerIndex] == ShopperIDTextBox.Text)                            // Check to see if the shopperID on the line we're currently on is equal to the shopperID in the text box in the main form.
                {
                    shopperMatch = true;                                                                            // If the shopper IDs are equal to one another, break the for loop since customerIndex now stores the line number containing our relevant data.
                    break;
                }
            }

            // IMPORT DATA INTO TEXT BOXES BEYOND HERE

            if (shopperMatch)
            {
                CCNTextBox.Text = fileDataArray[ccnIndex, customerIndex];
                ExpirationDateTextBox.Text = fileDataArray[expIndex, customerIndex];
                CCVTextBox.Text = fileDataArray[cvvIndex, customerIndex];
                AddressTextBox.Text = fileDataArray[addressIndex, customerIndex];
                ZipCodeTextBox.Text = fileDataArray[zipIndex, customerIndex];
            }
            else
            {
                MessageBox.Show("Shopper ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthorizeCard()
        {
            if (FirstNameTextBox.Text == "Sandbox") // If the user types "Sandbox" into the text box for the card holder's first name, use the sandbox test environment instead of the production environment.
            {
                ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;
            }
            else
            {
                ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.PRODUCTION;
            }

            // define the merchant information (authentication / transaction id)
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = loginID,
                ItemElementName = ItemChoiceType.transactionKey,
                Item = transKey,
            };

            var creditCard = new creditCardType
            {
                cardNumber = new String ((CCNTextBox.Text).Where(Char.IsDigit).ToArray()),                   // Makes cardNumber equal to a formatted CCN string containing ONLY digits. As Authorize.NET expects.
                expirationDate = new String ((ExpirationDateTextBox.Text).Where(Char.IsDigit).ToArray()),    // Makes expirationDate equal to a formatted exp date string containing ONLY digits. As Authorize.NET expects.
                cardCode = CCVTextBox.Text
            };

            var billingInfo = new customerAddressType
            {
                firstName = FirstNameTextBox.Text,
                lastName = LastNameTextBox.Text,
                address = AddressTextBox.Text,
                city = CityTextBox.Text,
                zip = ZipCodeTextBox.Text
            };

            //standard api call to retrieve response
            var paymentType = new paymentType { Item = creditCard };

            var transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authOnlyTransaction.ToString(),    // authorize only

                payment = paymentType,
                billTo = billingInfo
            };

            var request = new createTransactionRequest { transactionRequest = transactionRequest };

            // instantiate the contoller that will call the service
            var controller = new createTransactionController(request);
            controller.Execute();

            // get the response from the service (errors contained if any)
            var response = controller.GetApiResponse();

            // Initialize all text boxes to "N/A"
            TransactionIDText.Text = "N/A";
            AuthorizationCodeText.Text = "N/A";
            ResponseText.Text = "N/A";
            DescriptionText.Text = "N/A";
            AVSResultText.Text = "N/A";
            CVVResultText.Text = "N/A";
            ErrorMessageText.Text = "N/A";

            //validate
            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    if (response.transactionResponse.messages != null)
                    {
                        TransactionIDText.Text = response.transactionResponse.transId;
                        AuthorizationCodeText.Text = response.transactionResponse.authCode;
                        ResponseText.Text = response.transactionResponse.responseCode;
                        DescriptionText.Text = response.transactionResponse.messages[0].description;
                        AVSResultText.Text = response.transactionResponse.avsResultCode;
                        CVVResultText.Text = response.transactionResponse.cvvResultCode;
                    }
                    else if (response.transactionResponse.errors != null)
                    {
                        ErrorMessageText.Text = response.transactionResponse.errors[0].errorText;
                    }
                }
                else
                {
                    if (response.transactionResponse != null && response.transactionResponse.errors != null)
                    {
                        ErrorMessageText.Text = response.transactionResponse.errors[0].errorText;
                    }
                    else
                    {
                        ErrorMessageText.Text = response.messages.message[0].text;
                    }
                }
            }
            else
            {
                ErrorMessageText.Text = "Null response.";
            }
        }
    }
}
