namespace Implementation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioId = new System.Windows.Forms.RadioButton();
            this.RadioLastname = new System.Windows.Forms.RadioButton();
            this.RadioCity = new System.Windows.Forms.RadioButton();
            this.SelectCombobox = new System.Windows.Forms.ComboBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deletePage = new System.Windows.Forms.TabControl();
            this.insertPage = new System.Windows.Forms.TabPage();
            this._executionStatusLabel = new System.Windows.Forms.Label();
            this._insertButton = new System.Windows.Forms.Button();
            this._insertCityTextbox = new System.Windows.Forms.TextBox();
            this._insertLastnameTextbox = new System.Windows.Forms.TextBox();
            this._insertFirstnameTextbox = new System.Windows.Forms.TextBox();
            this._insertIdTextbox = new System.Windows.Forms.TextBox();
            this.modifyPage = new System.Windows.Forms.TabPage();
            this._updateExecutionStatusLabel = new System.Windows.Forms.Label();
            this._updateButton = new System.Windows.Forms.Button();
            this._updateCityTextbox = new System.Windows.Forms.TextBox();
            this._updateLastnameTextbox = new System.Windows.Forms.TextBox();
            this._updateFirstnameTextbox = new System.Windows.Forms.TextBox();
            this._updateIdTextbox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deletePage.SuspendLayout();
            this.insertPage.SuspendLayout();
            this.modifyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioId
            // 
            this.RadioId.AutoSize = true;
            this.RadioId.Checked = true;
            this.RadioId.Location = new System.Drawing.Point(12, 61);
            this.RadioId.Name = "RadioId";
            this.RadioId.Size = new System.Drawing.Size(95, 19);
            this.RadioId.TabIndex = 0;
            this.RadioId.TabStop = true;
            this.RadioId.Text = "Search  by  Id";
            this.RadioId.UseVisualStyleBackColor = true;
            // 
            // RadioLastname
            // 
            this.RadioLastname.AutoSize = true;
            this.RadioLastname.Location = new System.Drawing.Point(150, 61);
            this.RadioLastname.Name = "RadioLastname";
            this.RadioLastname.Size = new System.Drawing.Size(133, 19);
            this.RadioLastname.TabIndex = 1;
            this.RadioLastname.Text = "Search by  Lastname";
            this.RadioLastname.UseVisualStyleBackColor = true;
            // 
            // RadioCity
            // 
            this.RadioCity.AutoSize = true;
            this.RadioCity.Location = new System.Drawing.Point(323, 61);
            this.RadioCity.Name = "RadioCity";
            this.RadioCity.Size = new System.Drawing.Size(100, 19);
            this.RadioCity.TabIndex = 2;
            this.RadioCity.Text = "Search by City";
            this.RadioCity.UseVisualStyleBackColor = true;
            // 
            // SelectCombobox
            // 
            this.SelectCombobox.FormattingEnabled = true;
            this.SelectCombobox.Location = new System.Drawing.Point(450, 60);
            this.SelectCombobox.Name = "SelectCombobox";
            this.SelectCombobox.Size = new System.Drawing.Size(149, 23);
            this.SelectCombobox.TabIndex = 3;
            this.SelectCombobox.Text = "Select Databases Table";
            this.SelectCombobox.SelectedIndexChanged += new System.EventHandler(this.SelectCombobox_SelectedIndexChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(12, 90);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(587, 379);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(306, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(129, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 23);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(288, 23);
            this.TextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show All  Table Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.insertPage);
            this.deletePage.Controls.Add(this.modifyPage);
            this.deletePage.Controls.Add(this.tabPage3);
            this.deletePage.Location = new System.Drawing.Point(620, 90);
            this.deletePage.Name = "deletePage";
            this.deletePage.SelectedIndex = 0;
            this.deletePage.Size = new System.Drawing.Size(362, 379);
            this.deletePage.TabIndex = 8;
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this._executionStatusLabel);
            this.insertPage.Controls.Add(this._insertButton);
            this.insertPage.Controls.Add(this._insertCityTextbox);
            this.insertPage.Controls.Add(this._insertLastnameTextbox);
            this.insertPage.Controls.Add(this._insertFirstnameTextbox);
            this.insertPage.Controls.Add(this._insertIdTextbox);
            this.insertPage.Location = new System.Drawing.Point(4, 24);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(354, 351);
            this.insertPage.TabIndex = 0;
            this.insertPage.Text = "Insert data";
            this.insertPage.UseVisualStyleBackColor = true;
            // 
            // _executionStatusLabel
            // 
            this._executionStatusLabel.AutoSize = true;
            this._executionStatusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._executionStatusLabel.Location = new System.Drawing.Point(84, 219);
            this._executionStatusLabel.Name = "_executionStatusLabel";
            this._executionStatusLabel.Size = new System.Drawing.Size(188, 32);
            this._executionStatusLabel.TabIndex = 5;
            this._executionStatusLabel.Text = "Execution Status";
            // 
            // _insertButton
            // 
            this._insertButton.Location = new System.Drawing.Point(6, 318);
            this._insertButton.Name = "_insertButton";
            this._insertButton.Size = new System.Drawing.Size(342, 27);
            this._insertButton.TabIndex = 4;
            this._insertButton.Text = "INSERT";
            this._insertButton.UseVisualStyleBackColor = true;
            this._insertButton.Click += new System.EventHandler(this._insertButton_Click);
            // 
            // _insertCityTextbox
            // 
            this._insertCityTextbox.Location = new System.Drawing.Point(6, 133);
            this._insertCityTextbox.Name = "_insertCityTextbox";
            this._insertCityTextbox.Size = new System.Drawing.Size(342, 23);
            this._insertCityTextbox.TabIndex = 3;
            // 
            // _insertLastnameTextbox
            // 
            this._insertLastnameTextbox.Location = new System.Drawing.Point(6, 89);
            this._insertLastnameTextbox.Name = "_insertLastnameTextbox";
            this._insertLastnameTextbox.Size = new System.Drawing.Size(342, 23);
            this._insertLastnameTextbox.TabIndex = 2;
            // 
            // _insertFirstnameTextbox
            // 
            this._insertFirstnameTextbox.Location = new System.Drawing.Point(6, 46);
            this._insertFirstnameTextbox.Name = "_insertFirstnameTextbox";
            this._insertFirstnameTextbox.Size = new System.Drawing.Size(342, 23);
            this._insertFirstnameTextbox.TabIndex = 1;
            // 
            // _insertIdTextbox
            // 
            this._insertIdTextbox.Location = new System.Drawing.Point(6, 6);
            this._insertIdTextbox.Name = "_insertIdTextbox";
            this._insertIdTextbox.Size = new System.Drawing.Size(342, 23);
            this._insertIdTextbox.TabIndex = 0;
            // 
            // modifyPage
            // 
            this.modifyPage.Controls.Add(this._updateExecutionStatusLabel);
            this.modifyPage.Controls.Add(this._updateButton);
            this.modifyPage.Controls.Add(this._updateCityTextbox);
            this.modifyPage.Controls.Add(this._updateLastnameTextbox);
            this.modifyPage.Controls.Add(this._updateFirstnameTextbox);
            this.modifyPage.Controls.Add(this._updateIdTextbox);
            this.modifyPage.Location = new System.Drawing.Point(4, 24);
            this.modifyPage.Name = "modifyPage";
            this.modifyPage.Padding = new System.Windows.Forms.Padding(3);
            this.modifyPage.Size = new System.Drawing.Size(354, 351);
            this.modifyPage.TabIndex = 1;
            this.modifyPage.Text = "Modify data";
            this.modifyPage.UseVisualStyleBackColor = true;
            this.modifyPage.Click += new System.EventHandler(this.modifyPage_Click);
            // 
            // _updateExecutionStatusLabel
            // 
            this._updateExecutionStatusLabel.AutoSize = true;
            this._updateExecutionStatusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._updateExecutionStatusLabel.Location = new System.Drawing.Point(82, 223);
            this._updateExecutionStatusLabel.Name = "_updateExecutionStatusLabel";
            this._updateExecutionStatusLabel.Size = new System.Drawing.Size(188, 32);
            this._updateExecutionStatusLabel.TabIndex = 9;
            this._updateExecutionStatusLabel.Text = "Execution Status";
            // 
            // _updateButton
            // 
            this._updateButton.Location = new System.Drawing.Point(6, 318);
            this._updateButton.Name = "_updateButton";
            this._updateButton.Size = new System.Drawing.Size(342, 27);
            this._updateButton.TabIndex = 8;
            this._updateButton.Text = "UPDATE";
            this._updateButton.UseVisualStyleBackColor = true;
            this._updateButton.Click += new System.EventHandler(this._updateButton_Click);
            // 
            // _updateCityTextbox
            // 
            this._updateCityTextbox.Location = new System.Drawing.Point(6, 133);
            this._updateCityTextbox.Name = "_updateCityTextbox";
            this._updateCityTextbox.Size = new System.Drawing.Size(342, 23);
            this._updateCityTextbox.TabIndex = 7;
            // 
            // _updateLastnameTextbox
            // 
            this._updateLastnameTextbox.Location = new System.Drawing.Point(6, 89);
            this._updateLastnameTextbox.Name = "_updateLastnameTextbox";
            this._updateLastnameTextbox.Size = new System.Drawing.Size(342, 23);
            this._updateLastnameTextbox.TabIndex = 6;
            // 
            // _updateFirstnameTextbox
            // 
            this._updateFirstnameTextbox.Location = new System.Drawing.Point(6, 46);
            this._updateFirstnameTextbox.Name = "_updateFirstnameTextbox";
            this._updateFirstnameTextbox.Size = new System.Drawing.Size(342, 23);
            this._updateFirstnameTextbox.TabIndex = 5;
            // 
            // _updateIdTextbox
            // 
            this._updateIdTextbox.Location = new System.Drawing.Point(6, 6);
            this._updateIdTextbox.Name = "_updateIdTextbox";
            this._updateIdTextbox.Size = new System.Drawing.Size(342, 23);
            this._updateIdTextbox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(354, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 481);
            this.Controls.Add(this.deletePage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SelectCombobox);
            this.Controls.Add(this.RadioCity);
            this.Controls.Add(this.RadioLastname);
            this.Controls.Add(this.RadioId);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deletePage.ResumeLayout(false);
            this.insertPage.ResumeLayout(false);
            this.insertPage.PerformLayout();
            this.modifyPage.ResumeLayout(false);
            this.modifyPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton RadioId;
        private RadioButton RadioLastname;
        private RadioButton RadioCity;
        private ComboBox SelectCombobox;
        private ListBox ListBox;
        private Button SearchButton;
        private TextBox TextBox;
        private Button button1;
        private TabControl deletePage;
        private TabPage insertPage;
        private TabPage modifyPage;
        private TabPage tabPage3;
        private TextBox _insertIdTextbox;
        private TextBox _insertLastnameTextbox;
        private TextBox _insertFirstnameTextbox;
        private TextBox _insertCityTextbox;
        private Label _executionStatusLabel;
        private Button _insertButton;
        private Label _updateExecutionStatusLabel;
        private Button _updateButton;
        private TextBox _updateCityTextbox;
        private TextBox _updateLastnameTextbox;
        private TextBox _updateFirstnameTextbox;
        private TextBox _updateIdTextbox;
    }
}