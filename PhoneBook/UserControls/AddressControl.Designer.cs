namespace PhoneBook.UserControls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlAddress = new PhoneBook.UserControls.AutoCompleteControl();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.DX = -70;
            this.lblAddress.DY = 3;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.LabeledControl = this.autoCompleteControlAddress;
            this.lblAddress.Location = new System.Drawing.Point(4, 3);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес:";
            // 
            // autoCompleteControlAddress
            // 
            this.autoCompleteControlAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlAddress.AutoSize = true;
            this.autoCompleteControlAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlAddress.Location = new System.Drawing.Point(74, 0);
            this.autoCompleteControlAddress.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlAddress.Name = "autoCompleteControlAddress";
            this.autoCompleteControlAddress.Size = new System.Drawing.Size(219, 26);
            this.autoCompleteControlAddress.TabIndex = 4;
            this.autoCompleteControlAddress.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.autoCompleteControlAddress);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(296, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAddress;
        private AutoCompleteControl autoCompleteControlAddress;
    }
}
