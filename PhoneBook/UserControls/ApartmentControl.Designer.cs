namespace PhoneBook.UserControls
{
    partial class ApartmentControl
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
            lblApartment = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoCompleteControlApartment = new AutoCompleteControl();
            SuspendLayout();
            // 
            // lblApartment
            // 
            lblApartment.DX = -40;
            lblApartment.DY = 3;
            lblApartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApartment.ForeColor = Color.White;
            lblApartment.LabeledControl = autoCompleteControlApartment;
            lblApartment.Location = new Point(-1, 3);
            lblApartment.Name = "lblApartment";
            lblApartment.Size = new Size(36, 19);
            lblApartment.TabIndex = 5;
            lblApartment.Text = "Кв.:";
            // 
            // autoCompleteControlApartment
            // 
            autoCompleteControlApartment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            autoCompleteControlApartment.AutoSize = true;
            autoCompleteControlApartment.BackColor = Color.FromArgb(0, 71, 160);
            autoCompleteControlApartment.Location = new Point(39, 0);
            autoCompleteControlApartment.MinimumSize = new Size(50, 26);
            autoCompleteControlApartment.Name = "autoCompleteControlApartment";
            autoCompleteControlApartment.Size = new Size(55, 26);
            autoCompleteControlApartment.TabIndex = 4;
            autoCompleteControlApartment.TextBoxFont = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // ApartmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 160);
            Controls.Add(lblApartment);
            Controls.Add(autoCompleteControlApartment);
            Margin = new Padding(0, 0, 5, 0);
            Name = "ApartmentControl";
            Size = new Size(97, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblApartment;
        private AutoCompleteControl autoCompleteControlApartment;
    }
}
