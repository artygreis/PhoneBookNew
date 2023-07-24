namespace PhoneBook.UserControls
{
    partial class AutoCompleteControl
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
            this.components = new System.ComponentModel.Container();
            this.autoComplete = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.txtContent = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            this.SuspendLayout();
            // 
            // autoComplete
            // 
            this.autoComplete.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoComplete.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete.ThemeName = "Default";
            this.autoComplete.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            // 
            // txtContent
            // 
            this.txtContent.BeforeTouchSize = new System.Drawing.Size(150, 26);
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.MinimumSize = new System.Drawing.Size(1, 26);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(150, 26);
            this.txtContent.TabIndex = 1;
            this.txtContent.Resize += new System.EventHandler(this.txtContent_Resize);
            // 
            // AutoCompleteControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.txtContent);
            this.MinimumSize = new System.Drawing.Size(150, 26);
            this.Name = "AutoCompleteControl";
            this.Size = new System.Drawing.Size(150, 26);
            this.Load += new System.EventHandler(this.AutoCompleteControl_Load);
            this.Resize += new System.EventHandler(this.AutoCompleteControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtContent;
    }
}
