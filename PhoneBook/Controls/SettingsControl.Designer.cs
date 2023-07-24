namespace PhoneBook.Controls
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpSelectColor = new System.Windows.Forms.GroupBox();
            this.btnResetColorNotDoor = new PhoneBook.UserControls.ButtonControl();
            this.btnResetColorNotCall = new PhoneBook.UserControls.ButtonControl();
            this.clrSelectNotDoor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.clrSelectNotCall = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.lblColorNotDoor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblColorNotCall = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.grpSourceDataBase = new System.Windows.Forms.GroupBox();
            this.btnSearchFile = new PhoneBook.UserControls.ButtonControl();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnApplyUpdate = new PhoneBook.UserControls.ButtonControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.pnlContent.SuspendLayout();
            this.grpSelectColor.SuspendLayout();
            this.grpSourceDataBase.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlContent.Controls.Add(this.grpSelectColor);
            this.pnlContent.Controls.Add(this.grpSourceDataBase);
            this.pnlContent.Controls.Add(this.grpUpdate);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(5, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(820, 580);
            this.pnlContent.TabIndex = 0;
            // 
            // grpSelectColor
            // 
            this.grpSelectColor.Controls.Add(this.btnResetColorNotDoor);
            this.grpSelectColor.Controls.Add(this.btnResetColorNotCall);
            this.grpSelectColor.Controls.Add(this.clrSelectNotDoor);
            this.grpSelectColor.Controls.Add(this.clrSelectNotCall);
            this.grpSelectColor.Controls.Add(this.lblColorNotDoor);
            this.grpSelectColor.Controls.Add(this.lblColorNotCall);
            this.grpSelectColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSelectColor.ForeColor = System.Drawing.Color.White;
            this.grpSelectColor.Location = new System.Drawing.Point(26, 162);
            this.grpSelectColor.Name = "grpSelectColor";
            this.grpSelectColor.Size = new System.Drawing.Size(773, 139);
            this.grpSelectColor.TabIndex = 18;
            this.grpSelectColor.TabStop = false;
            this.grpSelectColor.Text = "Выберите цвета:";
            // 
            // btnResetColorNotDoor
            // 
            this.btnResetColorNotDoor.FontButton = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetColorNotDoor.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnResetColorNotDoor.ImageButton")));
            this.btnResetColorNotDoor.Location = new System.Drawing.Point(419, 75);
            this.btnResetColorNotDoor.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetColorNotDoor.Name = "btnResetColorNotDoor";
            this.btnResetColorNotDoor.Size = new System.Drawing.Size(120, 35);
            this.btnResetColorNotDoor.TabIndex = 22;
            this.btnResetColorNotDoor.TextButton = " Сбросить";
            this.btnResetColorNotDoor.ButtonClick += new System.EventHandler(this.btnResetColorNotDoor_Click);
            // 
            // btnResetColorNotCall
            // 
            this.btnResetColorNotCall.FontButton = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetColorNotCall.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnResetColorNotCall.ImageButton")));
            this.btnResetColorNotCall.Location = new System.Drawing.Point(408, 29);
            this.btnResetColorNotCall.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetColorNotCall.Name = "btnResetColorNotCall";
            this.btnResetColorNotCall.Size = new System.Drawing.Size(120, 35);
            this.btnResetColorNotCall.TabIndex = 21;
            this.btnResetColorNotCall.TextButton = " Сбросить";
            this.btnResetColorNotCall.ButtonClick += new System.EventHandler(this.btnResetColorNotCall_Click);
            // 
            // clrSelectNotDoor
            // 
            this.clrSelectNotDoor.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.clrSelectNotDoor.BackColor = System.Drawing.Color.LightSalmon;
            this.clrSelectNotDoor.BeforeTouchSize = new System.Drawing.Size(115, 35);
            this.clrSelectNotDoor.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            this.clrSelectNotDoor.ColorUISize = new System.Drawing.Size(220, 230);
            this.clrSelectNotDoor.FlatAppearance.BorderSize = 5;
            this.clrSelectNotDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrSelectNotDoor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrSelectNotDoor.ForeColor = System.Drawing.Color.White;
            this.clrSelectNotDoor.Location = new System.Drawing.Point(297, 75);
            this.clrSelectNotDoor.MetroColor = System.Drawing.Color.LightSalmon;
            this.clrSelectNotDoor.Name = "clrSelectNotDoor";
            this.clrSelectNotDoor.SelectedAsBackcolor = true;
            this.clrSelectNotDoor.SelectedColor = System.Drawing.Color.LightSalmon;
            this.clrSelectNotDoor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.clrSelectNotDoor.Size = new System.Drawing.Size(115, 35);
            this.clrSelectNotDoor.StandardTabName = "Цвета";
            this.clrSelectNotDoor.TabIndex = 20;
            this.clrSelectNotDoor.Text = "Выбрать";
            this.clrSelectNotDoor.ThemeName = "Metro";
            this.clrSelectNotDoor.ThemeStyle.BorderColor = System.Drawing.Color.Transparent;
            this.clrSelectNotDoor.ThemeStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clrSelectNotDoor.UseVisualStyle = false;
            this.clrSelectNotDoor.UseVisualStyleBackColor = false;
            this.clrSelectNotDoor.ColorSelected += new System.EventHandler(this.clrSelectNotDoor_ColorSelected);
            // 
            // clrSelectNotCall
            // 
            this.clrSelectNotCall.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.clrSelectNotCall.BackColor = System.Drawing.Color.LightCoral;
            this.clrSelectNotCall.BeforeTouchSize = new System.Drawing.Size(115, 35);
            this.clrSelectNotCall.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            this.clrSelectNotCall.ColorUISize = new System.Drawing.Size(220, 230);
            this.clrSelectNotCall.FlatAppearance.BorderSize = 5;
            this.clrSelectNotCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrSelectNotCall.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrSelectNotCall.ForeColor = System.Drawing.Color.White;
            this.clrSelectNotCall.Location = new System.Drawing.Point(286, 29);
            this.clrSelectNotCall.MetroColor = System.Drawing.Color.LightCoral;
            this.clrSelectNotCall.Name = "clrSelectNotCall";
            this.clrSelectNotCall.SelectedAsBackcolor = true;
            this.clrSelectNotCall.SelectedColor = System.Drawing.Color.LightCoral;
            this.clrSelectNotCall.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.clrSelectNotCall.Size = new System.Drawing.Size(115, 35);
            this.clrSelectNotCall.StandardTabName = "Цвета";
            this.clrSelectNotCall.TabIndex = 19;
            this.clrSelectNotCall.Text = "Выбрать";
            this.clrSelectNotCall.ThemeName = "Metro";
            this.clrSelectNotCall.ThemeStyle.BorderColor = System.Drawing.Color.Transparent;
            this.clrSelectNotCall.ThemeStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clrSelectNotCall.UseVisualStyle = false;
            this.clrSelectNotCall.UseVisualStyleBackColor = false;
            this.clrSelectNotCall.ColorSelected += new System.EventHandler(this.clrSelectNotCall_ColorSelected);
            // 
            // lblColorNotDoor
            // 
            this.lblColorNotDoor.Location = new System.Drawing.Point(23, 82);
            this.lblColorNotDoor.Name = "lblColorNotDoor";
            this.lblColorNotDoor.Size = new System.Drawing.Size(268, 19);
            this.lblColorNotDoor.TabIndex = 1;
            this.lblColorNotDoor.Text = "Цвет записей куда не заходить:";
            // 
            // lblColorNotCall
            // 
            this.lblColorNotCall.Location = new System.Drawing.Point(23, 36);
            this.lblColorNotCall.Name = "lblColorNotCall";
            this.lblColorNotCall.Size = new System.Drawing.Size(257, 19);
            this.lblColorNotCall.TabIndex = 0;
            this.lblColorNotCall.Text = "Цвет записей куда не звонить:";
            // 
            // grpSourceDataBase
            // 
            this.grpSourceDataBase.Controls.Add(this.btnSearchFile);
            this.grpSourceDataBase.Controls.Add(this.textBoxSourceFile);
            this.grpSourceDataBase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSourceDataBase.ForeColor = System.Drawing.Color.White;
            this.grpSourceDataBase.Location = new System.Drawing.Point(26, 30);
            this.grpSourceDataBase.Name = "grpSourceDataBase";
            this.grpSourceDataBase.Size = new System.Drawing.Size(773, 126);
            this.grpSourceDataBase.TabIndex = 17;
            this.grpSourceDataBase.TabStop = false;
            this.grpSourceDataBase.Text = "Путь к справочнику:";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.FontButton = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchFile.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnSearchFile.ImageButton")));
            this.btnSearchFile.Location = new System.Drawing.Point(634, 76);
            this.btnSearchFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(115, 34);
            this.btnSearchFile.TabIndex = 19;
            this.btnSearchFile.TextButton = " Изменить";
            this.btnSearchFile.ButtonClick += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSourceFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxSourceFile.Location = new System.Drawing.Point(23, 37);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.ReadOnly = true;
            this.textBoxSourceFile.Size = new System.Drawing.Size(726, 26);
            this.textBoxSourceFile.TabIndex = 13;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnApplyUpdate);
            this.grpUpdate.Controls.Add(this.linkLabel1);
            this.grpUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpUpdate.ForeColor = System.Drawing.Color.White;
            this.grpUpdate.Location = new System.Drawing.Point(26, 450);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(773, 81);
            this.grpUpdate.TabIndex = 16;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Обновление:";
            // 
            // btnApplyUpdate
            // 
            this.btnApplyUpdate.FontButton = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApplyUpdate.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnApplyUpdate.ImageButton")));
            this.btnApplyUpdate.Location = new System.Drawing.Point(611, 27);
            this.btnApplyUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplyUpdate.Name = "btnApplyUpdate";
            this.btnApplyUpdate.Size = new System.Drawing.Size(138, 35);
            this.btnApplyUpdate.TabIndex = 19;
            this.btnApplyUpdate.TextButton = " Обновить !!!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(41, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 21);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Проверить наличие обновлений";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Name = "SettingsControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(830, 590);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.pnlContent.ResumeLayout(false);
            this.grpSelectColor.ResumeLayout(false);
            this.grpSelectColor.PerformLayout();
            this.grpSourceDataBase.ResumeLayout(false);
            this.grpSourceDataBase.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlContent;
        private GroupBox grpSourceDataBase;
        private GroupBox grpUpdate;
        private LinkLabel linkLabel1;
        private TextBox textBoxSourceFile;
        private ColorDialog clrDialog;
        private GroupBox grpSelectColor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblColorNotDoor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblColorNotCall;
        private Syncfusion.Windows.Forms.ColorPickerButton clrSelectNotCall;
        private Syncfusion.Windows.Forms.ColorPickerButton clrSelectNotDoor;
        private UserControls.ButtonControl btnSearchFile;
        private UserControls.ButtonControl btnResetColorNotCall;
        private UserControls.ButtonControl btnResetColorNotDoor;
        private UserControls.ButtonControl btnApplyUpdate;
    }
}
