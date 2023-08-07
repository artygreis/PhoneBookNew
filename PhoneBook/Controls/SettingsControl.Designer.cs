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
            pnlContent.Location = new Point(5, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(820, 580);
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
            grpSelectColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSelectColor.ForeColor = Color.White;
            grpSelectColor.Location = new Point(26, 162);
            grpSelectColor.Name = "grpSelectColor";
            grpSelectColor.Size = new Size(773, 177);
            grpSelectColor.TabIndex = 18;
            grpSelectColor.TabStop = false;
            grpSelectColor.Text = "Выберите цвета:";
            // 
            // btnResetColorNotFull
            // 
            btnResetColorNotFull.FontButton = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotFull.ImageButton = (Image)resources.GetObject("btnResetColorNotFull.ImageButton");
            btnResetColorNotFull.Location = new Point(444, 121);
            btnResetColorNotFull.Margin = new Padding(0);
            btnResetColorNotFull.Name = "btnResetColorNotFull";
            btnResetColorNotFull.Size = new Size(120, 35);
            btnResetColorNotFull.TabIndex = 25;
            btnResetColorNotFull.TextButton = " Сбросить";
            btnResetColorNotFull.Load += btnResetColorNotFull_Load;
            // 
            // clrSelectNotFull
            // 
            clrSelectNotFull.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            clrSelectNotFull.BackColor = Color.LightCoral;
            clrSelectNotFull.BeforeTouchSize = new Size(115, 35);
            clrSelectNotFull.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotFull.ColorUISize = new Size(220, 230);
            clrSelectNotFull.FlatAppearance.BorderSize = 5;
            clrSelectNotFull.FlatStyle = FlatStyle.Flat;
            clrSelectNotFull.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotFull.ForeColor = Color.White;
            clrSelectNotFull.Location = new Point(322, 121);
            clrSelectNotFull.MetroColor = Color.LightCoral;
            clrSelectNotFull.Name = "clrSelectNotFull";
            clrSelectNotFull.SelectedAsBackcolor = true;
            clrSelectNotFull.SelectedColor = Color.LightCoral;
            clrSelectNotFull.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotFull.Size = new Size(115, 35);
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
            lblColorNotDisturb.Location = new Point(23, 128);
            lblColorNotDisturb.Name = "lblColorNotDisturb";
            lblColorNotDisturb.Size = new Size(293, 20);
            lblColorNotDisturb.TabIndex = 23;
            lblColorNotDisturb.Text = "Цвет записей где не беспокоить:";
            // 
            // btnResetColorNotDoor
            // 
            btnResetColorNotDoor.FontButton = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotDoor.ImageButton = (Image)resources.GetObject("btnResetColorNotDoor.ImageButton");
            btnResetColorNotDoor.Location = new Point(434, 75);
            btnResetColorNotDoor.Margin = new Padding(0);
            btnResetColorNotDoor.Name = "btnResetColorNotDoor";
            btnResetColorNotDoor.Size = new Size(120, 35);
            btnResetColorNotDoor.TabIndex = 22;
            btnResetColorNotDoor.TextButton = " Сбросить";
            btnResetColorNotDoor.ButtonClick += btnResetColorNotDoor_Click;
            // 
            // btnResetColorNotCall
            // 
            btnResetColorNotCall.FontButton = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetColorNotCall.ImageButton = (Image)resources.GetObject("btnResetColorNotCall.ImageButton");
            btnResetColorNotCall.Location = new Point(423, 29);
            btnResetColorNotCall.Margin = new Padding(0);
            btnResetColorNotCall.Name = "btnResetColorNotCall";
            btnResetColorNotCall.Size = new Size(120, 35);
            btnResetColorNotCall.TabIndex = 21;
            btnResetColorNotCall.TextButton = " Сбросить";
            btnResetColorNotCall.ButtonClick += btnResetColorNotCall_Click;
            // 
            // clrSelectNotDoor
            // 
            clrSelectNotDoor.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            clrSelectNotDoor.BackColor = Color.LightSalmon;
            clrSelectNotDoor.BeforeTouchSize = new Size(115, 35);
            clrSelectNotDoor.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotDoor.ColorUISize = new Size(220, 230);
            clrSelectNotDoor.FlatAppearance.BorderSize = 5;
            clrSelectNotDoor.FlatStyle = FlatStyle.Flat;
            clrSelectNotDoor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotDoor.ForeColor = Color.White;
            clrSelectNotDoor.Location = new Point(312, 75);
            clrSelectNotDoor.MetroColor = Color.LightSalmon;
            clrSelectNotDoor.Name = "clrSelectNotDoor";
            clrSelectNotDoor.SelectedAsBackcolor = true;
            clrSelectNotDoor.SelectedColor = Color.LightSalmon;
            clrSelectNotDoor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotDoor.Size = new Size(115, 35);
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
            clrSelectNotCall.BeforeTouchSize = new Size(115, 35);
            clrSelectNotCall.ColorGroups = Syncfusion.Windows.Forms.ColorUIGroups.StandardColors;
            clrSelectNotCall.ColorUISize = new Size(220, 230);
            clrSelectNotCall.FlatAppearance.BorderSize = 5;
            clrSelectNotCall.FlatStyle = FlatStyle.Flat;
            clrSelectNotCall.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrSelectNotCall.ForeColor = Color.White;
            clrSelectNotCall.Location = new Point(301, 29);
            clrSelectNotCall.MetroColor = Color.LightPink;
            clrSelectNotCall.Name = "clrSelectNotCall";
            clrSelectNotCall.SelectedAsBackcolor = true;
            clrSelectNotCall.SelectedColor = Color.LightPink;
            clrSelectNotCall.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            clrSelectNotCall.Size = new Size(115, 35);
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
            lblColorNotDoor.Location = new Point(23, 82);
            lblColorNotDoor.Name = "lblColorNotDoor";
            lblColorNotDoor.Size = new Size(283, 20);
            lblColorNotDoor.TabIndex = 1;
            lblColorNotDoor.Text = "Цвет записей куда не заходить:";
            // 
            // lblColorNotCall
            // 
            lblColorNotCall.Location = new Point(23, 36);
            lblColorNotCall.Name = "lblColorNotCall";
            lblColorNotCall.Size = new Size(273, 20);
            lblColorNotCall.TabIndex = 0;
            lblColorNotCall.Text = "Цвет записей куда не звонить:";
            // 
            // grpSourceDataBase
            // 
            grpSourceDataBase.Controls.Add(btnSearchFile);
            grpSourceDataBase.Controls.Add(textBoxSourceFile);
            grpSourceDataBase.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSourceDataBase.ForeColor = Color.White;
            grpSourceDataBase.Location = new Point(26, 30);
            grpSourceDataBase.Name = "grpSourceDataBase";
            grpSourceDataBase.Size = new Size(773, 126);
            grpSourceDataBase.TabIndex = 17;
            grpSourceDataBase.TabStop = false;
            grpSourceDataBase.Text = "Путь к справочнику:";
            // 
            // btnSearchFile
            // 
            btnSearchFile.FontButton = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFile.ImageButton = (Image)resources.GetObject("btnSearchFile.ImageButton");
            btnSearchFile.Location = new Point(629, 75);
            btnSearchFile.Margin = new Padding(0);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(120, 34);
            btnSearchFile.TabIndex = 19;
            btnSearchFile.TextButton = " Изменить";
            btnSearchFile.ButtonClick += btnSearchFile_Click;
            // 
            // textBoxSourceFile
            // 
            textBoxSourceFile.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSourceFile.ForeColor = Color.FromArgb(0, 71, 160);
            textBoxSourceFile.Location = new Point(23, 37);
            textBoxSourceFile.Name = "textBoxSourceFile";
            textBoxSourceFile.ReadOnly = true;
            textBoxSourceFile.Size = new Size(726, 24);
            textBoxSourceFile.TabIndex = 13;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(btnApplyUpdate);
            grpUpdate.Controls.Add(linkLabel1);
            grpUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpUpdate.ForeColor = Color.White;
            grpUpdate.Location = new Point(26, 450);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(773, 81);
            grpUpdate.TabIndex = 16;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Обновление:";
            // 
            // btnApplyUpdate
            // 
            btnApplyUpdate.FontButton = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApplyUpdate.ImageButton = (Image)resources.GetObject("btnApplyUpdate.ImageButton");
            btnApplyUpdate.Location = new Point(604, 27);
            btnApplyUpdate.Margin = new Padding(0);
            btnApplyUpdate.Name = "btnApplyUpdate";
            btnApplyUpdate.Size = new Size(145, 35);
            btnApplyUpdate.TabIndex = 19;
            btnApplyUpdate.TextButton = " Обновить !!!";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(41, 36);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(284, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Проверить наличие обновлений";
            linkLabel1.VisitedLinkColor = Color.White;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContent);
            Name = "SettingsControl";
            Padding = new Padding(5);
            Size = new Size(830, 590);
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
