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
            this.components = new System.ComponentModel.Container();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.RadioId = new System.Windows.Forms.RadioButton();
            this.RadioLastname = new System.Windows.Forms.RadioButton();
            this.RadioCity = new System.Windows.Forms.RadioButton();
            this.SelectCombobox = new System.Windows.Forms.ComboBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioId
            // 
            this.RadioId.AutoSize = true;
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
            this.RadioLastname.TabStop = true;
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
            this.RadioCity.TabStop = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SelectCombobox);
            this.Controls.Add(this.RadioCity);
            this.Controls.Add(this.RadioLastname);
            this.Controls.Add(this.RadioId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private RadioButton RadioId;
        private RadioButton RadioLastname;
        private RadioButton RadioCity;
        private ComboBox SelectCombobox;
        private ListBox ListBox;
        private Button SearchButton;
        private TextBox TextBox;
        private Button button1;
    }
}