
namespace CustomerViewer
{
    partial class CustomerEntry
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
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.checkBoxVip = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "",
            "Dr.",
            "Duchess",
            "Duke",
            "Hon.",
            "Lady",
            "Lord",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Sir"});
            this.comboBoxTitle.Location = new System.Drawing.Point(193, 12);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTitle.TabIndex = 12;
            // 
            // checkBoxVip
            // 
            this.checkBoxVip.AutoSize = true;
            this.checkBoxVip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVip.Location = new System.Drawing.Point(155, 127);
            this.checkBoxVip.Name = "checkBoxVip";
            this.checkBoxVip.Size = new System.Drawing.Size(55, 24);
            this.checkBoxVip.TabIndex = 17;
            this.checkBoxVip.Text = "&VIP:";
            this.checkBoxVip.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(194, 88);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 27);
            this.textBoxLastName.TabIndex = 16;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(194, 50);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(150, 27);
            this.textBoxFirstName.TabIndex = 14;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(38, 91);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(150, 20);
            this.labelLastName.TabIndex = 15;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(38, 53);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(150, 20);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(38, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 20);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "&Title:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.checkBoxVip);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Name = "CustomerEntry";
            this.Text = "Customer Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxVip;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTitle;
    }
}