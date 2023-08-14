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
            components = new System.ComponentModel.Container();
            autoComplete = new Syncfusion.Windows.Forms.Tools.AutoComplete(components);
            txtContent = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)autoComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContent).BeginInit();
            SuspendLayout();
            // 
            // autoComplete
            // 
            autoComplete.HeaderFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.World);
            autoComplete.ItemFont = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            autoComplete.MetroColor = Color.FromArgb(17, 158, 218);
            autoComplete.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            autoComplete.ThemeName = "Default";
            autoComplete.AutoCompleteItemSelected += autoComplete_AutoCompleteItemSelected;
            // 
            // txtContent
            // 
            autoComplete.SetAutoComplete(txtContent, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            txtContent.BeforeTouchSize = new Size(150, 30);
            txtContent.Dock = DockStyle.Fill;
            txtContent.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtContent.ForeColor = Color.FromArgb(0, 71, 160);
            txtContent.Location = new Point(0, 0);
            txtContent.MinimumSize = new Size(1, 26);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(150, 30);
            txtContent.TabIndex = 1;
            txtContent.Resize += txtContent_Resize;
            // 
            // AutoCompleteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 71, 160);
            Controls.Add(txtContent);
            MinimumSize = new Size(50, 26);
            Name = "AutoCompleteControl";
            Size = new Size(150, 26);
            Load += AutoCompleteControl_Load;
            Resize += AutoCompleteControl_Resize;
            ((System.ComponentModel.ISupportInitialize)autoComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtContent;
    }
}
