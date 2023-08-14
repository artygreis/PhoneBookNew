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
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.BackColor = Color.White;
            button.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = Color.FromArgb(0, 71, 160);
            button.Location = new Point(0, 0);
            button.Name = "button";
            button.Size = new Size(120, 35);
            button.TabIndex = 0;
            button.Text = "button1";
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // ButtonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button);
            Margin = new Padding(0);
            Name = "ButtonControl";
            Size = new Size(120, 35);
            ResumeLayout(false);
        }

        #endregion

        private Button button;
    }
}
