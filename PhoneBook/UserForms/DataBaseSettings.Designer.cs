namespace PhoneBook.UserForms
{
    partial class DataBaseSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseSettings));
            pnlContent = new Panel();
            btnSave = new Button();
            pnlSettings = new Panel();
            groupBox1 = new GroupBox();
            btnSearchFile = new Button();
            btnChangeFolder = new Button();
            rdbExist = new RadioButton();
            rdbNew = new RadioButton();
            textBoxSourceFile = new TextBox();
            textBoxSourceDb = new TextBox();
            checkBoxDefault = new CheckBox();
            panel2 = new Panel();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            lblCaption = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            pictureBox1 = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            errorValidating = new ErrorProvider(components);
            pnlContent.SuspendLayout();
            pnlSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorValidating).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(0, 71, 160);
            pnlContent.Controls.Add(btnSave);
            pnlContent.Controls.Add(pnlSettings);
            pnlContent.Controls.Add(panel2);
            pnlContent.Controls.Add(pnlTitleBar);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(5, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(658, 325);
            pnlContent.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 71, 160);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(524, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "Сохранить";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(groupBox1);
            pnlSettings.Dock = DockStyle.Top;
            pnlSettings.Location = new Point(0, 50);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(658, 220);
            pnlSettings.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchFile);
            groupBox1.Controls.Add(btnChangeFolder);
            groupBox1.Controls.Add(rdbExist);
            groupBox1.Controls.Add(rdbNew);
            groupBox1.Controls.Add(textBoxSourceFile);
            groupBox1.Controls.Add(textBoxSourceDb);
            groupBox1.Controls.Add(checkBoxDefault);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 211);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Путь к базе данных (справочнику)";
            // 
            // btnSearchFile
            // 
            btnSearchFile.Anchor = AnchorStyles.None;
            btnSearchFile.BackColor = Color.White;
            btnSearchFile.FlatStyle = FlatStyle.Flat;
            btnSearchFile.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFile.ForeColor = Color.FromArgb(0, 71, 160);
            btnSearchFile.Image = (Image)resources.GetObject("btnSearchFile.Image");
            btnSearchFile.Location = new Point(523, 158);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(85, 30);
            btnSearchFile.TabIndex = 6;
            btnSearchFile.Text = "Обзор";
            btnSearchFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchFile.UseVisualStyleBackColor = false;
            btnSearchFile.Click += btnSearchFile_Click;
            // 
            // btnChangeFolder
            // 
            btnChangeFolder.Anchor = AnchorStyles.None;
            btnChangeFolder.BackColor = Color.White;
            btnChangeFolder.FlatStyle = FlatStyle.Flat;
            btnChangeFolder.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeFolder.ForeColor = Color.FromArgb(0, 71, 160);
            btnChangeFolder.Image = (Image)resources.GetObject("btnChangeFolder.Image");
            btnChangeFolder.Location = new Point(523, 87);
            btnChangeFolder.Name = "btnChangeFolder";
            btnChangeFolder.Size = new Size(85, 30);
            btnChangeFolder.TabIndex = 3;
            btnChangeFolder.Text = "Обзор";
            btnChangeFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangeFolder.UseVisualStyleBackColor = false;
            btnChangeFolder.Click += btnChangeFolder_Click;
            // 
            // rdbExist
            // 
            rdbExist.AutoSize = true;
            rdbExist.Location = new Point(17, 134);
            rdbExist.Name = "rdbExist";
            rdbExist.Size = new Size(311, 22);
            rdbExist.TabIndex = 1;
            rdbExist.Text = "Указать существующий справочник";
            rdbExist.UseVisualStyleBackColor = true;
            rdbExist.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdbNew
            // 
            rdbNew.AutoSize = true;
            rdbNew.Checked = true;
            rdbNew.Location = new Point(17, 35);
            rdbNew.Name = "rdbNew";
            rdbNew.Size = new Size(291, 22);
            rdbNew.TabIndex = 0;
            rdbNew.TabStop = true;
            rdbNew.Text = "Создать новую базу (справочник)";
            rdbNew.UseVisualStyleBackColor = true;
            rdbNew.CheckedChanged += radioButton_CheckedChanged;
            // 
            // textBoxSourceFile
            // 
            textBoxSourceFile.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSourceFile.ForeColor = Color.FromArgb(0, 71, 160);
            textBoxSourceFile.Location = new Point(36, 162);
            textBoxSourceFile.Name = "textBoxSourceFile";
            textBoxSourceFile.ReadOnly = true;
            textBoxSourceFile.Size = new Size(481, 22);
            textBoxSourceFile.TabIndex = 5;
            // 
            // textBoxSourceDb
            // 
            textBoxSourceDb.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSourceDb.ForeColor = Color.FromArgb(0, 71, 160);
            textBoxSourceDb.Location = new Point(36, 91);
            textBoxSourceDb.Name = "textBoxSourceDb";
            textBoxSourceDb.ReadOnly = true;
            textBoxSourceDb.Size = new Size(481, 22);
            textBoxSourceDb.TabIndex = 2;
            // 
            // checkBoxDefault
            // 
            checkBoxDefault.AutoSize = true;
            checkBoxDefault.Checked = true;
            checkBoxDefault.CheckState = CheckState.Checked;
            checkBoxDefault.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxDefault.Location = new Point(36, 63);
            checkBoxDefault.Name = "checkBoxDefault";
            checkBoxDefault.Size = new Size(139, 22);
            checkBoxDefault.TabIndex = 1;
            checkBoxDefault.Text = "По умолчанию";
            checkBoxDefault.UseVisualStyleBackColor = true;
            checkBoxDefault.CheckedChanged += checkBoxDefault_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 15);
            panel2.TabIndex = 10;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Transparent;
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(lblCaption);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(658, 35);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(625, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblCaption
            // 
            lblCaption.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaption.ForeColor = Color.White;
            lblCaption.Location = new Point(42, 6);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(392, 23);
            lblCaption.TabIndex = 2;
            lblCaption.Text = "Настройка подключения к базе данных";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // errorValidating
            // 
            errorValidating.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorValidating.ContainerControl = this;
            // 
            // DataBaseSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 335);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataBaseSettings";
            Padding = new Padding(5);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataBaseSettings";
            Load += DataBaseSettings_Load;
            pnlContent.ResumeLayout(false);
            pnlSettings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorValidating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Panel pnlTitleBar;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCaption;
        private Panel pnlSettings;
        private GroupBox groupBox1;
        private Button btnSearchFile;
        private Button btnChangeFolder;
        private RadioButton rdbExist;
        private RadioButton rdbNew;
        private TextBox textBoxSourceFile;
        private TextBox textBoxSourceDb;
        private CheckBox checkBoxDefault;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnClose;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
        private ErrorProvider errorValidating;
        private Button btnSave;
    }
}