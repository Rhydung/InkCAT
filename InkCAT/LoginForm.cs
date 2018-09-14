using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;

namespace CCAuthorizer___AuthorizeAPI
{
    public partial class LoginForm : Form
    {
        private string login = "";
        private string tKey = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        public string GetLogin()
        {
            return login;
        }

        public string GetTransactionKey()
        {
            return tKey;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MerchantLoginRequest();
        }

        private void MerchantLoginRequest()
        {
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            var request = new getMerchantDetailsRequest
            {
                merchantAuthentication = new merchantAuthenticationType()
                {
                    name = LoginBox.Text,
                    Item = TransactionKeyBox.Text,
                    ItemElementName = ItemChoiceType.transactionKey
                }
            };

            // instantiate the controller that will call the service
            var controller = new getMerchantDetailsController(request);
            controller.Execute();

            // get the response from the service (errors contained if any)
            var response = controller.GetApiResponse();

            // validate
            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    login = LoginBox.Text;          // Update these variables for MainForm to use in a little bit.
                    tKey = TransactionKeyBox.Text;

                    ReportingLabel.Text = "Login Successful!";  // Update ReportingLabel to let user know their login information was accepted.

                    // MainForm mainForm = new MainForm(LoginBox.Text, TransactionKeyBox.Text);   // Create mainForm after successful login, pass login info, whether merchant is testing.

                    DialogResult = DialogResult.OK; // Tells MainForm that LoginForm has gotten valid login information.
                }
                else if (response.messages.resultCode == messageTypeEnum.Error)
                {
                    ReportingLabel.Text = "Incorrect Login/Password.";
                }
            }
        }
    }
}
