namespace PhoneBook.Controls
{
    partial class ErrorConnectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorConnectControl));
            pnlContent = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(0, 71, 160);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(label1);
            pnlContent.Controls.Add(pictureBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(5, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(820, 580);
            pnlContent.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(281, 384);
            label2.Name = "label2";
            label2.Size = new Size(259, 25);
            label2.TabIndex = 7;
            label2.Text = "Проверьте настройки! ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 331);
            label1.Name = "label1";
            label1.Size = new Size(312, 25);
            label1.TabIndex = 6;
            label1.Text = "Ошибка подключения к БД. ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ErrorConnectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContent);
            Name = "ErrorConnectControl";
            Padding = new Padding(5);
            Size = new Size(830, 590);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
