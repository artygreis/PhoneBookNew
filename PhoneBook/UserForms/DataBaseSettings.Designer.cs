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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseSettings));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.rdbExist = new System.Windows.Forms.RadioButton();
            this.rdbNew = new System.Windows.Forms.RadioButton();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.textBoxSourceDb = new System.Windows.Forms.TextBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCaption = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContent.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.pnlSettings);
            this.pnlContent.Controls.Add(this.panel2);
            this.pnlContent.Controls.Add(this.pnlTitleBar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(5, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(658, 325);
            this.pnlContent.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(524, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 50);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(658, 220);
            this.pnlSettings.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchFile);
            this.groupBox1.Controls.Add(this.btnChangeFolder);
            this.groupBox1.Controls.Add(this.rdbExist);
            this.groupBox1.Controls.Add(this.rdbNew);
            this.groupBox1.Controls.Add(this.textBoxSourceFile);
            this.groupBox1.Controls.Add(this.textBoxSourceDb);
            this.groupBox1.Controls.Add(this.checkBoxDefault);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к базе данных (справочнику)";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchFile.BackColor = System.Drawing.Color.White;
            this.btnSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearchFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFile.Image")));
            this.btnSearchFile.Location = new System.Drawing.Point(523, 158);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(85, 30);
            this.btnSearchFile.TabIndex = 6;
            this.btnSearchFile.Text = "Обзор";
            this.btnSearchFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFile.UseVisualStyleBackColor = false;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeFolder.BackColor = System.Drawing.Color.White;
            this.btnChangeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFolder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChangeFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeFolder.Image")));
            this.btnChangeFolder.Location = new System.Drawing.Point(523, 87);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(85, 30);
            this.btnChangeFolder.TabIndex = 3;
            this.btnChangeFolder.Text = "Обзор";
            this.btnChangeFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeFolder.UseVisualStyleBackColor = false;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
            // 
            // rdbExist
            // 
            this.rdbExist.AutoSize = true;
            this.rdbExist.Location = new System.Drawing.Point(17, 134);
            this.rdbExist.Name = "rdbExist";
            this.rdbExist.Size = new System.Drawing.Size(311, 22);
            this.rdbExist.TabIndex = 1;
            this.rdbExist.Text = "Указать существующий справочник";
            this.rdbExist.UseVisualStyleBackColor = true;
            this.rdbExist.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbNew
            // 
            this.rdbNew.AutoSize = true;
            this.rdbNew.Checked = true;
            this.rdbNew.Location = new System.Drawing.Point(17, 35);
            this.rdbNew.Name = "rdbNew";
            this.rdbNew.Size = new System.Drawing.Size(291, 22);
            this.rdbNew.TabIndex = 0;
            this.rdbNew.TabStop = true;
            this.rdbNew.Text = "Создать новую базу (справочник)";
            this.rdbNew.UseVisualStyleBackColor = true;
            this.rdbNew.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSourceFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxSourceFile.Location = new System.Drawing.Point(36, 162);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.ReadOnly = true;
            this.textBoxSourceFile.Size = new System.Drawing.Size(481, 22);
            this.textBoxSourceFile.TabIndex = 5;
            // 
            // textBoxSourceDb
            // 
            this.textBoxSourceDb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSourceDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxSourceDb.Location = new System.Drawing.Point(36, 91);
            this.textBoxSourceDb.Name = "textBoxSourceDb";
            this.textBoxSourceDb.ReadOnly = true;
            this.textBoxSourceDb.Size = new System.Drawing.Size(481, 22);
            this.textBoxSourceDb.TabIndex = 2;
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Checked = true;
            this.checkBoxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefault.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDefault.Location = new System.Drawing.Point(36, 63);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(139, 22);
            this.checkBoxDefault.TabIndex = 1;
            this.checkBoxDefault.Text = "По умолчанию";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            this.checkBoxDefault.CheckedChanged += new System.EventHandler(this.checkBoxDefault_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 15);
            this.panel2.TabIndex = 10;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblCaption);
            this.pnlTitleBar.Controls.Add(this.pictureBox1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(658, 35);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(623, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(42, 6);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(392, 23);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Настройка подключения к базе данных";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorValidating
            // 
            this.errorValidating.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValidating.ContainerControl = this;
            // 
            // DataBaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataBaseSettings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBaseSettings";
            this.Load += new System.EventHandler(this.DataBaseSettings_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.ResumeLayout(false);

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