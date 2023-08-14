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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            pnlContent = new Panel();
            grpSelectColor = new GroupBox();
            btnResetColorNotFull = new UserControls.ButtonControl();
            clrSelectNotFull = new Syncfusion.Windows.Forms.ColorPickerButton();
            lblColorNotDisturb = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnResetColorNotDoor = new UserControls.ButtonControl();
            btnResetColorNotCall = new UserControls.ButtonControl();
            clrSelectNotDoor = new Syncfusion.Windows.Forms.ColorPickerButton();
            clrSelectNotCall = new Syncfusion.Windows.Forms.ColorPickerButton();
            lblColorNotDoor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblColorNotCall = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            grpSourceDataBase = new GroupBox();
            btnSearchFile = new UserControls.ButtonControl();
            textBoxSourceFile = new TextBox();
            grpUpdate = new GroupBox();
            btnApplyUpdate = new UserControls.ButtonControl();
            linkLabel1 = new LinkLabel();
            clrDialog = new ColorDialog();
            pnlContent.SuspendLayout();
            grpSelectColor.SuspendLayout();
            grpSourceDataBase.SuspendLayout();
            grpUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(0, 71, 160);
            pnlContent.Controls.Add(grpSelectColor);
            pnlContent.Controls.Add(grpSourceDataBase);
            pnlContent.Controls.Add(grpUpdate);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(6, 7);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(942, 779);
            pnlContent.TabIndex = 0;
            // 
            // grpSelectColor
            // 
            grpSelectColor.Controls.Add(btnResetColorNotFull);
            grpSelectColor.Controls.Add(clrSelectNotFull);
            grpSelectColor.Controls.Add(lblColorNotDisturb);
            grpSelectColor.Controls.Add(btnResetColorNotDoor);
            grpSelectColor.Controls.Add(btnResetColorNotCall);
            grpSelectColor.Controls.Add(clrSelectNotDoor);
            grpSelectColor.Controls.Add(clrSelectNotCall);
            grpSelectColor.Controls.Add(lblColorNotDoor);
            grpSelectColor.Controls.Add(lblColorNotCall);
            grpSelectColor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSelectColor.ForeColor = Color.White;
            grpSelectColor.Location = new Point(30, 216);
            grpSelectColor.Margin = new Padding(3, 4, 3, 4);
            grpSelectColor.Name = "grpSelectColor";
            grpSelectColor.Padding = new Padding(3, 4, 3, 4);
            grpSelectColor.Size = new Size(883, 236);
            grpSelectColor.TabIndex = 18;
            grpSelectColor.TabStop = false;
            grpSelectColor.Text = "Выберите цвета:";
            // 
            // btnResetColorNotFull
            // 
            btnResetColorNotFull.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotFull.FontButton = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotFull.ImageButton = (Image)resources.GetObject("btnResetColorNotFull.ImageButton");
            btnResetColorNotFull.Location = new Point(516, 163);
            btnResetColorNotFull.Margin = new Padding(0);
            btnResetColorNotFull.Name = "btnResetColorNotFull";
            btnResetColorNotFull.Size = new Size(150, 44);
            btnResetColorNotFull.TabIndex = 25;
            btnResetColorNotFull.TextButton = " Сбросить";
            btnResetColorNotFull.Load += btnResetColorNotFull_Load;
            // 
            // clrSelectNotFull
            // 
            clrSelectNotFull.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            clrSelectNotFull.BackColor = Color.LightCoral;
            clrSelectNotFull.BeforeTouchSize = new Size(131, 47);
            clrSelectNotFull.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotFull.ColorUISize = new Size(220, 230);
            clrSelectNotFull.FlatAppearance.BorderSize = 5;
            clrSelectNotFull.FlatStyle = FlatStyle.Flat;
            clrSelectNotFull.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotFull.ForeColor = Color.White;
            clrSelectNotFull.Location = new Point(381, 161);
            clrSelectNotFull.Margin = new Padding(3, 4, 3, 4);
            clrSelectNotFull.MetroColor = Color.LightCoral;
            clrSelectNotFull.Name = "clrSelectNotFull";
            clrSelectNotFull.SelectedAsBackcolor = true;
            clrSelectNotFull.SelectedColor = Color.LightCoral;
            clrSelectNotFull.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotFull.Size = new Size(131, 47);
            clrSelectNotFull.StandardTabName = "Цвета";
            clrSelectNotFull.TabIndex = 24;
            clrSelectNotFull.Text = "Выбрать";
            clrSelectNotFull.ThemeName = "Metro";
            clrSelectNotFull.ThemeStyle.BorderColor = Color.Transparent;
            clrSelectNotFull.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            clrSelectNotFull.UseVisualStyle = false;
            clrSelectNotFull.UseVisualStyleBackColor = false;
            clrSelectNotFull.ColorSelected += clrSelectNotFull_ColorSelected;
            // 
            // lblColorNotDisturb
            // 
            lblColorNotDisturb.Location = new Point(26, 171);
            lblColorNotDisturb.Name = "lblColorNotDisturb";
            lblColorNotDisturb.Size = new Size(354, 23);
            lblColorNotDisturb.TabIndex = 23;
            lblColorNotDisturb.Text = "Цвет записей где не беспокоить:";
            // 
            // btnResetColorNotDoor
            // 
            btnResetColorNotDoor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotDoor.FontButton = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotDoor.ImageButton = (Image)resources.GetObject("btnResetColorNotDoor.ImageButton");
            btnResetColorNotDoor.Location = new Point(504, 101);
            btnResetColorNotDoor.Margin = new Padding(0);
            btnResetColorNotDoor.Name = "btnResetColorNotDoor";
            btnResetColorNotDoor.Size = new Size(150, 44);
            btnResetColorNotDoor.TabIndex = 22;
            btnResetColorNotDoor.TextButton = " Сбросить";
            btnResetColorNotDoor.ButtonClick += btnResetColorNotDoor_Click;
            // 
            // btnResetColorNotCall
            // 
            btnResetColorNotCall.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotCall.FontButton = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotCall.ImageButton = (Image)resources.GetObject("btnResetColorNotCall.ImageButton");
            btnResetColorNotCall.Location = new Point(492, 40);
            btnResetColorNotCall.Margin = new Padding(0);
            btnResetColorNotCall.Name = "btnResetColorNotCall";
            btnResetColorNotCall.Size = new Size(150, 44);
            btnResetColorNotCall.TabIndex = 21;
            btnResetColorNotCall.TextButton = " Сбросить";
            btnResetColorNotCall.ButtonClick += btnResetColorNotCall_Click;
            // 
            // clrSelectNotDoor
            // 
            clrSelectNotDoor.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            clrSelectNotDoor.BackColor = Color.LightSalmon;
            clrSelectNotDoor.BeforeTouchSize = new Size(131, 47);
            clrSelectNotDoor.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotDoor.ColorUISize = new Size(220, 230);
            clrSelectNotDoor.FlatAppearance.BorderSize = 5;
            clrSelectNotDoor.FlatStyle = FlatStyle.Flat;
            clrSelectNotDoor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotDoor.ForeColor = Color.White;
            clrSelectNotDoor.Location = new Point(370, 100);
            clrSelectNotDoor.Margin = new Padding(3, 4, 3, 4);
            clrSelectNotDoor.MetroColor = Color.LightSalmon;
            clrSelectNotDoor.Name = "clrSelectNotDoor";
            clrSelectNotDoor.SelectedAsBackcolor = true;
            clrSelectNotDoor.SelectedColor = Color.LightSalmon;
            clrSelectNotDoor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotDoor.Size = new Size(131, 47);
            clrSelectNotDoor.StandardTabName = "Цвета";
            clrSelectNotDoor.TabIndex = 20;
            clrSelectNotDoor.Text = "Выбрать";
            clrSelectNotDoor.ThemeName = "Metro";
            clrSelectNotDoor.ThemeStyle.BorderColor = Color.Transparent;
            clrSelectNotDoor.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            clrSelectNotDoor.UseVisualStyle = false;
            clrSelectNotDoor.UseVisualStyleBackColor = false;
            clrSelectNotDoor.ColorSelected += clrSelectNotDoor_ColorSelected;
            // 
            // clrSelectNotCall
            // 
            clrSelectNotCall.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            clrSelectNotCall.BackColor = Color.LightPink;
            clrSelectNotCall.BeforeTouchSize = new Size(131, 47);
            clrSelectNotCall.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotCall.ColorUISize = new Size(220, 230);
            clrSelectNotCall.FlatAppearance.BorderSize = 5;
            clrSelectNotCall.FlatStyle = FlatStyle.Flat;
            clrSelectNotCall.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotCall.ForeColor = Color.White;
            clrSelectNotCall.Location = new Point(357, 39);
            clrSelectNotCall.Margin = new Padding(3, 4, 3, 4);
            clrSelectNotCall.MetroColor = Color.LightPink;
            clrSelectNotCall.Name = "clrSelectNotCall";
            clrSelectNotCall.SelectedAsBackcolor = true;
            clrSelectNotCall.SelectedColor = Color.LightPink;
            clrSelectNotCall.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotCall.Size = new Size(131, 47);
            clrSelectNotCall.StandardTabName = "Цвета";
            clrSelectNotCall.TabIndex = 19;
            clrSelectNotCall.Text = "Выбрать";
            clrSelectNotCall.ThemeName = "Metro";
            clrSelectNotCall.ThemeStyle.BorderColor = Color.Transparent;
            clrSelectNotCall.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            clrSelectNotCall.UseVisualStyle = false;
            clrSelectNotCall.UseVisualStyleBackColor = false;
            clrSelectNotCall.ColorSelected += clrSelectNotCall_ColorSelected;
            // 
            // lblColorNotDoor
            // 
            lblColorNotDoor.Location = new Point(26, 109);
            lblColorNotDoor.Name = "lblColorNotDoor";
            lblColorNotDoor.Size = new Size(340, 23);
            lblColorNotDoor.TabIndex = 1;
            lblColorNotDoor.Text = "Цвет записей куда не заходить:";
            // 
            // lblColorNotCall
            // 
            lblColorNotCall.Location = new Point(26, 48);
            lblColorNotCall.Name = "lblColorNotCall";
            lblColorNotCall.Size = new Size(326, 23);
            lblColorNotCall.TabIndex = 0;
            lblColorNotCall.Text = "Цвет записей куда не звонить:";
            // 
            // grpSourceDataBase
            // 
            grpSourceDataBase.Controls.Add(btnSearchFile);
            grpSourceDataBase.Controls.Add(textBoxSourceFile);
            grpSourceDataBase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSourceDataBase.ForeColor = Color.White;
            grpSourceDataBase.Location = new Point(30, 40);
            grpSourceDataBase.Margin = new Padding(3, 4, 3, 4);
            grpSourceDataBase.Name = "grpSourceDataBase";
            grpSourceDataBase.Padding = new Padding(3, 4, 3, 4);
            grpSourceDataBase.Size = new Size(883, 168);
            grpSourceDataBase.TabIndex = 17;
            grpSourceDataBase.TabStop = false;
            grpSourceDataBase.Text = "Путь к справочнику:";
            // 
            // btnSearchFile
            // 
            btnSearchFile.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFile.FontButton = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFile.ImageButton = (Image)resources.GetObject("btnSearchFile.ImageButton");
            btnSearchFile.Location = new Point(706, 100);
            btnSearchFile.Margin = new Padding(0);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(150, 43);
            btnSearchFile.TabIndex = 19;
            btnSearchFile.TextButton = " Изменить";
            btnSearchFile.ButtonClick += btnSearchFile_Click;
            // 
            // textBoxSourceFile
            // 
            textBoxSourceFile.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSourceFile.ForeColor = Color.FromArgb(0, 71, 160);
            textBoxSourceFile.Location = new Point(26, 49);
            textBoxSourceFile.Margin = new Padding(3, 4, 3, 4);
            textBoxSourceFile.Name = "textBoxSourceFile";
            textBoxSourceFile.ReadOnly = true;
            textBoxSourceFile.Size = new Size(829, 29);
            textBoxSourceFile.TabIndex = 13;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(btnApplyUpdate);
            grpUpdate.Controls.Add(linkLabel1);
            grpUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpUpdate.ForeColor = Color.White;
            grpUpdate.Location = new Point(30, 600);
            grpUpdate.Margin = new Padding(3, 4, 3, 4);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Padding = new Padding(3, 4, 3, 4);
            grpUpdate.Size = new Size(883, 108);
            grpUpdate.TabIndex = 16;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Обновление:";
            // 
            // btnApplyUpdate
            // 
            btnApplyUpdate.AutoSize = true;
            btnApplyUpdate.FontButton = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApplyUpdate.ImageButton = (Image)resources.GetObject("btnApplyUpdate.ImageButton");
            btnApplyUpdate.Location = new Point(613, 35);
            btnApplyUpdate.Margin = new Padding(0);
            btnApplyUpdate.Name = "btnApplyUpdate";
            btnApplyUpdate.Size = new Size(199, 44);
            btnApplyUpdate.TabIndex = 19;
            btnApplyUpdate.TextButton = " Обновить !!!";
            btnApplyUpdate.Load += btnApplyUpdate_Load;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(47, 48);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(338, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Проверить наличие обновлений";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingsControl";
            Padding = new Padding(6, 7, 6, 7);
            Size = new Size(954, 793);
            Load += SettingsControl_Load;
            pnlContent.ResumeLayout(false);
            grpSelectColor.ResumeLayout(false);
            grpSelectColor.PerformLayout();
            grpSourceDataBase.ResumeLayout(false);
            grpSourceDataBase.PerformLayout();
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ResumeLayout(false);
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
        private UserControls.ButtonControl btnResetColorNotFull;
        private Syncfusion.Windows.Forms.ColorPickerButton clrSelectNotFull;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblColorNotDisturb;
    }
}
