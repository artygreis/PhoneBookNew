namespace PhoneBook.UserControls
{
    partial class ButtonControl
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 35);
            this.button.TabIndex = 0;
            this.button.Text = "button1";
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(120, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button;
    }
}
