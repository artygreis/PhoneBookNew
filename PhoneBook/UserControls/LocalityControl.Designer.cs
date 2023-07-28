namespace PhoneBook.UserControls
{
    partial class LocalityControl
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
            this.autoCompleteControlLocality = new PhoneBook.UserControls.AutoCompleteControl();
            this.lblLocality = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SuspendLayout();
            // 
            // autoCompleteControlLocality
            // 
            this.autoCompleteControlLocality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCompleteControlLocality.AutoSize = true;
            this.autoCompleteControlLocality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.autoCompleteControlLocality.Location = new System.Drawing.Point(3, 25);
            this.autoCompleteControlLocality.MinimumSize = new System.Drawing.Size(150, 26);
            this.autoCompleteControlLocality.Name = "autoCompleteControlLocality";
            this.autoCompleteControlLocality.Size = new System.Drawing.Size(309, 26);
            this.autoCompleteControlLocality.TabIndex = 0;
            this.autoCompleteControlLocality.TextBoxFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // lblLocality
            // 
            this.lblLocality.DY = -24;
            this.lblLocality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocality.ForeColor = System.Drawing.Color.White;
            this.lblLocality.Gap = 5;
            this.lblLocality.LabeledControl = this.autoCompleteControlLocality;
            this.lblLocality.Location = new System.Drawing.Point(3, 1);
            this.lblLocality.Name = "lblLocality";
            this.lblLocality.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblLocality.Size = new System.Drawing.Size(276, 19);
            this.lblLocality.TabIndex = 6;
            this.lblLocality.Text = "Населенный пункт (если нужно):";
            // 
            // LocalityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblLocality);
            this.Controls.Add(this.autoCompleteControlLocality);
            this.Name = "LocalityControl";
            this.Size = new System.Drawing.Size(315, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoCompleteControl autoCompleteControlLocality;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLocality;
    }
}
