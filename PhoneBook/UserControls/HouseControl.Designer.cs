namespace PhoneBook.UserControls
{
    partial class HouseControl
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
            this.lblHouse = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoCompleteControlHouse = new PhoneBook.UserControls.AutoCompleteControl();
            this.SuspendLayout();
            // 
            // lblHouse
            // 
            this.lblHouse.DY = -24;
            this.lblHouse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHouse.ForeColor = System.Drawing.Color.White;
            this.lblHouse.Gap = 5;
            this.lblHouse.LabeledControl = this.autoCompleteControlHouse;
            this.lblHouse.Location = new System.Drawing.Point(3, 2);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblHouse.Size = new System.Drawing.Size(74, 19);
            this.lblHouse.TabIndex = 10;
            this.lblHouse.Text = "Дом, №:";
            // 
            // autoCompleteControlHouse
            // 
            this.autoCompleteControlHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlHouse.AutoSize = true;
            this.autoCompleteControlHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlHouse.Location = new System.Drawing.Point(3, 26);
            this.autoCompleteControlHouse.MinimumSize = new System.Drawing.Size(80, 26);
            this.autoCompleteControlHouse.Name = "autoCompleteControlHouse";
            this.autoCompleteControlHouse.Size = new System.Drawing.Size(85, 26);
            this.autoCompleteControlHouse.TabIndex = 9;
            this.autoCompleteControlHouse.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // HouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.autoCompleteControlHouse);
            this.Name = "HouseControl";
            this.Size = new System.Drawing.Size(91, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblHouse;
        private AutoCompleteControl autoCompleteControlHouse;
    }
}
