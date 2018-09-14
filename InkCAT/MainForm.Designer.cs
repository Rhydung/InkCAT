namespace CCAuthorizer___AuthorizeAPI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.FileLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.FileText = new System.Windows.Forms.Label();
            this.SearchFileButton = new System.Windows.Forms.Button();
            this.ShopperIDLabel = new System.Windows.Forms.Label();
            this.ShopperIDTextBox = new System.Windows.Forms.TextBox();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.ModifyGroupBox = new System.Windows.Forms.GroupBox();
            this.RequiredInfoLabel = new System.Windows.Forms.Label();
            this.CustomerInfoLabel = new System.Windows.Forms.Label();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.CCVLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CCVTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.CCNLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.CCNTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ReviewGroupBox = new System.Windows.Forms.GroupBox();
            this.ErrorMessageText = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.CVVResultText = new System.Windows.Forms.Label();
            this.CVVResultLabel = new System.Windows.Forms.Label();
            this.AVSResultText = new System.Windows.Forms.Label();
            this.AVSResultLabel = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ResponseText = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.AuthorizationCodeText = new System.Windows.Forms.Label();
            this.AuthorizationCodeLabel = new System.Windows.Forms.Label();
            this.TransactionIDText = new System.Windows.Forms.Label();
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.FileGroupBox.SuspendLayout();
            this.ModifyGroupBox.SuspendLayout();
            this.ReviewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "None";
            this.openFile.Filter = "CSV Files|*.csv";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoEllipsis = true;
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(72, 24);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileLabel.Size = new System.Drawing.Size(63, 13);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "Current File:";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.Location = new System.Drawing.Point(6, 19);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(60, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.FileGroupBox.Controls.Add(this.FileText);
            this.FileGroupBox.Controls.Add(this.SearchFileButton);
            this.FileGroupBox.Controls.Add(this.FileLabel);
            this.FileGroupBox.Controls.Add(this.ShopperIDLabel);
            this.FileGroupBox.Controls.Add(this.OpenFileButton);
            this.FileGroupBox.Controls.Add(this.ShopperIDTextBox);
            this.FileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileGroupBox.Location = new System.Drawing.Point(171, 9);
            this.FileGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FileGroupBox.Size = new System.Drawing.Size(504, 52);
            this.FileGroupBox.TabIndex = 2;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Select File to Search";
            // 
            // FileText
            // 
            this.FileText.AutoEllipsis = true;
            this.FileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileText.Location = new System.Drawing.Point(137, 24);
            this.FileText.Name = "FileText";
            this.FileText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileText.Size = new System.Drawing.Size(130, 13);
            this.FileText.TabIndex = 7;
            this.FileText.Text = "None Selected";
            // 
            // SearchFileButton
            // 
            this.SearchFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFileButton.Location = new System.Drawing.Point(429, 19);
            this.SearchFileButton.Name = "SearchFileButton";
            this.SearchFileButton.Size = new System.Drawing.Size(69, 23);
            this.SearchFileButton.TabIndex = 6;
            this.SearchFileButton.Text = "Search File";
            this.SearchFileButton.UseVisualStyleBackColor = true;
            this.SearchFileButton.Click += new System.EventHandler(this.SearchFileButton_Click);
            // 
            // ShopperIDLabel
            // 
            this.ShopperIDLabel.AutoSize = true;
            this.ShopperIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopperIDLabel.Location = new System.Drawing.Point(279, 24);
            this.ShopperIDLabel.Name = "ShopperIDLabel";
            this.ShopperIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShopperIDLabel.Size = new System.Drawing.Size(64, 13);
            this.ShopperIDLabel.TabIndex = 5;
            this.ShopperIDLabel.Text = "Shopper ID:";
            // 
            // ShopperIDTextBox
            // 
            this.ShopperIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopperIDTextBox.Location = new System.Drawing.Point(349, 21);
            this.ShopperIDTextBox.Name = "ShopperIDTextBox";
            this.ShopperIDTextBox.Size = new System.Drawing.Size(74, 20);
            this.ShopperIDTextBox.TabIndex = 4;
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FormTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.Location = new System.Drawing.Point(12, 29);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(152, 19);
            this.FormTitleLabel.TabIndex = 3;
            this.FormTitleLabel.Text = "Credit Card Authorizer";
            this.FormTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyGroupBox
            // 
            this.ModifyGroupBox.Controls.Add(this.RequiredInfoLabel);
            this.ModifyGroupBox.Controls.Add(this.CustomerInfoLabel);
            this.ModifyGroupBox.Controls.Add(this.AuthorizeButton);
            this.ModifyGroupBox.Controls.Add(this.CCVLabel);
            this.ModifyGroupBox.Controls.Add(this.AddressLabel);
            this.ModifyGroupBox.Controls.Add(this.CCVTextBox);
            this.ModifyGroupBox.Controls.Add(this.AddressTextBox);
            this.ModifyGroupBox.Controls.Add(this.ExpirationDateLabel);
            this.ModifyGroupBox.Controls.Add(this.ZipCodeTextBox);
            this.ModifyGroupBox.Controls.Add(this.CCNLabel);
            this.ModifyGroupBox.Controls.Add(this.CityLabel);
            this.ModifyGroupBox.Controls.Add(this.ZipCodeLabel);
            this.ModifyGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ModifyGroupBox.Controls.Add(this.CCNTextBox);
            this.ModifyGroupBox.Controls.Add(this.FirstNameLabel);
            this.ModifyGroupBox.Controls.Add(this.LastNameTextBox);
            this.ModifyGroupBox.Controls.Add(this.LastNameLabel);
            this.ModifyGroupBox.Controls.Add(this.ExpirationDateTextBox);
            this.ModifyGroupBox.Controls.Add(this.CityTextBox);
            this.ModifyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyGroupBox.Location = new System.Drawing.Point(12, 64);
            this.ModifyGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ModifyGroupBox.Name = "ModifyGroupBox";
            this.ModifyGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ModifyGroupBox.Size = new System.Drawing.Size(663, 146);
            this.ModifyGroupBox.TabIndex = 4;
            this.ModifyGroupBox.TabStop = false;
            this.ModifyGroupBox.Text = "Import, Modify, and Authorize";
            // 
            // RequiredInfoLabel
            // 
            this.RequiredInfoLabel.AutoSize = true;
            this.RequiredInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredInfoLabel.Location = new System.Drawing.Point(358, 93);
            this.RequiredInfoLabel.Name = "RequiredInfoLabel";
            this.RequiredInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RequiredInfoLabel.Size = new System.Drawing.Size(99, 13);
            this.RequiredInfoLabel.TabIndex = 17;
            this.RequiredInfoLabel.Text = "*   --   Required Info";
            // 
            // CustomerInfoLabel
            // 
            this.CustomerInfoLabel.AutoSize = true;
            this.CustomerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoLabel.Location = new System.Drawing.Point(296, 16);
            this.CustomerInfoLabel.Name = "CustomerInfoLabel";
            this.CustomerInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerInfoLabel.Size = new System.Drawing.Size(72, 13);
            this.CustomerInfoLabel.TabIndex = 16;
            this.CustomerInfoLabel.Text = "Customer Info";
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizeButton.Location = new System.Drawing.Point(180, 116);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorizeButton.Size = new System.Drawing.Size(296, 23);
            this.AuthorizeButton.TabIndex = 11;
            this.AuthorizeButton.Text = "Authorize";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // CCVLabel
            // 
            this.CCVLabel.AutoSize = true;
            this.CCVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCVLabel.Location = new System.Drawing.Point(181, 93);
            this.CCVLabel.Name = "CCVLabel";
            this.CCVLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CCVLabel.Size = new System.Drawing.Size(38, 13);
            this.CCVLabel.TabIndex = 14;
            this.CCVLabel.Text = "* CCV:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(358, 41);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressLabel.Size = new System.Drawing.Size(55, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "* Address:";
            // 
            // CCVTextBox
            // 
            this.CCVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCVTextBox.Location = new System.Drawing.Point(225, 90);
            this.CCVTextBox.Name = "CCVTextBox";
            this.CCVTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CCVTextBox.Size = new System.Drawing.Size(80, 20);
            this.CCVTextBox.TabIndex = 15;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(424, 38);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressTextBox.Size = new System.Drawing.Size(233, 20);
            this.AddressTextBox.TabIndex = 6;
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(6, 93);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpirationDateLabel.Size = new System.Drawing.Size(61, 13);
            this.ExpirationDateLabel.TabIndex = 12;
            this.ExpirationDateLabel.Text = "* Exp Date:";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCodeTextBox.Location = new System.Drawing.Point(586, 64);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZipCodeTextBox.Size = new System.Drawing.Size(71, 20);
            this.ZipCodeTextBox.TabIndex = 10;
            // 
            // CCNLabel
            // 
            this.CCNLabel.AutoSize = true;
            this.CCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCNLabel.Location = new System.Drawing.Point(6, 67);
            this.CCNLabel.Name = "CCNLabel";
            this.CCNLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CCNLabel.Size = new System.Drawing.Size(39, 13);
            this.CCNLabel.TabIndex = 9;
            this.CCNLabel.Text = "* CCN:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(358, 67);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 7;
            this.CityLabel.Text = "City:";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCodeLabel.Location = new System.Drawing.Point(520, 67);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZipCodeLabel.Size = new System.Drawing.Size(60, 13);
            this.ZipCodeLabel.TabIndex = 9;
            this.ZipCodeLabel.Text = "* Zip Code:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(72, 38);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstNameTextBox.Size = new System.Drawing.Size(80, 20);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // CCNTextBox
            // 
            this.CCNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCNTextBox.Location = new System.Drawing.Point(72, 64);
            this.CCNTextBox.Name = "CCNTextBox";
            this.CCNTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CCNTextBox.Size = new System.Drawing.Size(233, 20);
            this.CCNTextBox.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 41);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(225, 38);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastNameTextBox.Size = new System.Drawing.Size(80, 20);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(158, 41);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // ExpirationDateTextBox
            // 
            this.ExpirationDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateTextBox.Location = new System.Drawing.Point(73, 90);
            this.ExpirationDateTextBox.Name = "ExpirationDateTextBox";
            this.ExpirationDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpirationDateTextBox.Size = new System.Drawing.Size(79, 20);
            this.ExpirationDateTextBox.TabIndex = 13;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.Location = new System.Drawing.Point(424, 64);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityTextBox.Size = new System.Drawing.Size(90, 20);
            this.CityTextBox.TabIndex = 8;
            // 
            // ReviewGroupBox
            // 
            this.ReviewGroupBox.Controls.Add(this.ErrorMessageText);
            this.ReviewGroupBox.Controls.Add(this.ErrorMessageLabel);
            this.ReviewGroupBox.Controls.Add(this.CVVResultText);
            this.ReviewGroupBox.Controls.Add(this.CVVResultLabel);
            this.ReviewGroupBox.Controls.Add(this.AVSResultText);
            this.ReviewGroupBox.Controls.Add(this.AVSResultLabel);
            this.ReviewGroupBox.Controls.Add(this.DescriptionText);
            this.ReviewGroupBox.Controls.Add(this.DescriptionLabel);
            this.ReviewGroupBox.Controls.Add(this.ResponseText);
            this.ReviewGroupBox.Controls.Add(this.ResponseLabel);
            this.ReviewGroupBox.Controls.Add(this.AuthorizationCodeText);
            this.ReviewGroupBox.Controls.Add(this.AuthorizationCodeLabel);
            this.ReviewGroupBox.Controls.Add(this.TransactionIDText);
            this.ReviewGroupBox.Controls.Add(this.TransactionIDLabel);
            this.ReviewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewGroupBox.Location = new System.Drawing.Point(12, 210);
            this.ReviewGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ReviewGroupBox.Name = "ReviewGroupBox";
            this.ReviewGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReviewGroupBox.Size = new System.Drawing.Size(663, 142);
            this.ReviewGroupBox.TabIndex = 5;
            this.ReviewGroupBox.TabStop = false;
            this.ReviewGroupBox.Text = "Review Response";
            // 
            // ErrorMessageText
            // 
            this.ErrorMessageText.AutoSize = true;
            this.ErrorMessageText.Location = new System.Drawing.Point(92, 116);
            this.ErrorMessageText.Name = "ErrorMessageText";
            this.ErrorMessageText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorMessageText.Size = new System.Drawing.Size(30, 13);
            this.ErrorMessageText.TabIndex = 13;
            this.ErrorMessageText.Text = "N/A";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(6, 116);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorMessageLabel.Size = new System.Drawing.Size(78, 13);
            this.ErrorMessageLabel.TabIndex = 12;
            this.ErrorMessageLabel.Text = "Error Message:";
            // 
            // CVVResultText
            // 
            this.CVVResultText.AutoSize = true;
            this.CVVResultText.Location = new System.Drawing.Point(92, 91);
            this.CVVResultText.Name = "CVVResultText";
            this.CVVResultText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CVVResultText.Size = new System.Drawing.Size(30, 13);
            this.CVVResultText.TabIndex = 11;
            this.CVVResultText.Text = "N/A";
            // 
            // CVVResultLabel
            // 
            this.CVVResultLabel.AutoSize = true;
            this.CVVResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVResultLabel.Location = new System.Drawing.Point(6, 91);
            this.CVVResultLabel.Name = "CVVResultLabel";
            this.CVVResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CVVResultLabel.Size = new System.Drawing.Size(64, 13);
            this.CVVResultLabel.TabIndex = 10;
            this.CVVResultLabel.Text = "CVV Result:";
            // 
            // AVSResultText
            // 
            this.AVSResultText.AutoSize = true;
            this.AVSResultText.Location = new System.Drawing.Point(92, 66);
            this.AVSResultText.Name = "AVSResultText";
            this.AVSResultText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AVSResultText.Size = new System.Drawing.Size(30, 13);
            this.AVSResultText.TabIndex = 9;
            this.AVSResultText.Text = "N/A";
            // 
            // AVSResultLabel
            // 
            this.AVSResultLabel.AutoSize = true;
            this.AVSResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVSResultLabel.Location = new System.Drawing.Point(6, 66);
            this.AVSResultLabel.Name = "AVSResultLabel";
            this.AVSResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AVSResultLabel.Size = new System.Drawing.Size(64, 13);
            this.AVSResultLabel.TabIndex = 8;
            this.AVSResultLabel.Text = "AVS Result:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.AutoSize = true;
            this.DescriptionText.Location = new System.Drawing.Point(92, 41);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionText.Size = new System.Drawing.Size(30, 13);
            this.DescriptionText.TabIndex = 7;
            this.DescriptionText.Text = "N/A";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 41);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ResponseText
            // 
            this.ResponseText.AutoSize = true;
            this.ResponseText.Location = new System.Drawing.Point(559, 16);
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResponseText.Size = new System.Drawing.Size(30, 13);
            this.ResponseText.TabIndex = 5;
            this.ResponseText.Text = "N/A";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.Location = new System.Drawing.Point(495, 16);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResponseLabel.Size = new System.Drawing.Size(58, 13);
            this.ResponseLabel.TabIndex = 4;
            this.ResponseLabel.Text = "Response:";
            // 
            // AuthorizationCodeText
            // 
            this.AuthorizationCodeText.AutoSize = true;
            this.AuthorizationCodeText.Location = new System.Drawing.Point(357, 16);
            this.AuthorizationCodeText.Name = "AuthorizationCodeText";
            this.AuthorizationCodeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorizationCodeText.Size = new System.Drawing.Size(30, 13);
            this.AuthorizationCodeText.TabIndex = 3;
            this.AuthorizationCodeText.Text = "N/A";
            // 
            // AuthorizationCodeLabel
            // 
            this.AuthorizationCodeLabel.AutoSize = true;
            this.AuthorizationCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizationCodeLabel.Location = new System.Drawing.Point(252, 16);
            this.AuthorizationCodeLabel.Name = "AuthorizationCodeLabel";
            this.AuthorizationCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorizationCodeLabel.Size = new System.Drawing.Size(99, 13);
            this.AuthorizationCodeLabel.TabIndex = 2;
            this.AuthorizationCodeLabel.Text = "Authorization Code:";
            // 
            // TransactionIDText
            // 
            this.TransactionIDText.AutoSize = true;
            this.TransactionIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDText.Location = new System.Drawing.Point(92, 16);
            this.TransactionIDText.Name = "TransactionIDText";
            this.TransactionIDText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionIDText.Size = new System.Drawing.Size(30, 13);
            this.TransactionIDText.TabIndex = 1;
            this.TransactionIDText.Text = "N/A";
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDLabel.Location = new System.Drawing.Point(6, 16);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionIDLabel.Size = new System.Drawing.Size(80, 13);
            this.TransactionIDLabel.TabIndex = 0;
            this.TransactionIDLabel.Text = "Transaction ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Controls.Add(this.ReviewGroupBox);
            this.Controls.Add(this.ModifyGroupBox);
            this.Controls.Add(this.FormTitleLabel);
            this.Controls.Add(this.FileGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Card Authorization Tool";
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.ModifyGroupBox.ResumeLayout(false);
            this.ModifyGroupBox.PerformLayout();
            this.ReviewGroupBox.ResumeLayout(false);
            this.ReviewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.TextBox ShopperIDTextBox;
        private System.Windows.Forms.Label ShopperIDLabel;
        private System.Windows.Forms.Button SearchFileButton;
        private System.Windows.Forms.GroupBox ModifyGroupBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label CCNLabel;
        private System.Windows.Forms.TextBox CCNTextBox;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.TextBox ExpirationDateTextBox;
        private System.Windows.Forms.Label CCVLabel;
        private System.Windows.Forms.TextBox CCVTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CustomerInfoLabel;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.GroupBox ReviewGroupBox;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Label AuthorizationCodeText;
        private System.Windows.Forms.Label AuthorizationCodeLabel;
        private System.Windows.Forms.Label TransactionIDText;
        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.Label DescriptionText;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ResponseText;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label CVVResultText;
        private System.Windows.Forms.Label CVVResultLabel;
        private System.Windows.Forms.Label AVSResultText;
        private System.Windows.Forms.Label AVSResultLabel;
        private System.Windows.Forms.Label RequiredInfoLabel;
        private System.Windows.Forms.Label ErrorMessageText;
        private System.Windows.Forms.Label FileText;
    }
}