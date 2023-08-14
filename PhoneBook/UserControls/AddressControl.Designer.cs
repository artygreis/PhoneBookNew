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
            lblAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoCompleteControlAddress = new AutoCompleteControl();
            SuspendLayout();
            // 
            // lblAddress
            // 
            lblAddress.DX = -87;
            lblAddress.DY = 6;
            lblAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.White;
            lblAddress.LabeledControl = autoCompleteControlAddress;
            lblAddress.Location = new Point(-2, 6);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 23);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Адрес:";
            // 
            // autoCompleteControlAddress
            // 
            autoCompleteControlAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            autoCompleteControlAddress.AutoSize = true;
            autoCompleteControlAddress.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlAddress.Location = new Point(85, 0);
            autoCompleteControlAddress.Margin = new Padding(3, 4, 3, 4);
            autoCompleteControlAddress.MinimumSize = new Size(171, 35);
            autoCompleteControlAddress.Name = "autoCompleteControlAddress";
            autoCompleteControlAddress.Size = new Size(250, 35);
            autoCompleteControlAddress.TabIndex = 4;
            autoCompleteControlAddress.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 160);
            Controls.Add(lblAddress);
            Controls.Add(autoCompleteControlAddress);
            Margin = new Padding(0, 0, 6, 0);
            Name = "AddressControl";
            Size = new Size(338, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAddress;
        private AutoCompleteControl autoCompleteControlAddress;
    }
}
