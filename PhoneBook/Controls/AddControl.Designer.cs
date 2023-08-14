namespace PhoneBook.Controls
{
    partial class AddControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddControl));
            tabControlAddAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            addApartmentsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btnAddRange = new Button();
            btnEditNumber = new Button();
            btnAddSingle = new Button();
            addressControlAddApartments = new UserControls.AddressControl();
            cityControlAddApartments = new UserControls.CityControl();
            countryControlAddApartments = new UserControls.CountryControl();
            chkPrivateHouse = new CheckBox();
            btnEditAddressAdd = new Button();
            btnEditCityAdd = new Button();
            btnEditCountryAdd = new Button();
            addNotDisturbTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btnEditNotDisturb = new Button();
            txtNumberPhone = new MaskedTextBox();
            lblNumberPhone = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnAddNotDisturbByNumberPhone = new Button();
            btnAddNotDisturbByAddress = new Button();
            apartmentControlAddNotDisturb = new UserControls.ApartmentControl();
            addressControlAddNotDisturb = new UserControls.AddressControl();
            cityControlAddNotDisturb = new UserControls.CityControl();
            countryControlAddNotDisturb = new UserControls.CountryControl();
            chkPrivateHouseAddNotDisturb = new CheckBox();
            gridPhones = new UserControls.GridControl();
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).BeginInit();
            tabControlAddAdv.SuspendLayout();
            addApartmentsTab.SuspendLayout();
            addNotDisturbTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddAdv
            // 
            tabControlAddAdv.BackColor = Color.FromArgb(0, 71, 160);
            tabControlAddAdv.BeforeTouchSize = new Size(942, 268);
            tabControlAddAdv.Controls.Add(addApartmentsTab);
            tabControlAddAdv.Controls.Add(addNotDisturbTab);
            tabControlAddAdv.Dock = DockStyle.Fill;
            tabControlAddAdv.Location = new Point(6, 7);
            tabControlAddAdv.Margin = new Padding(3, 4, 3, 4);
            tabControlAddAdv.Name = "tabControlAddAdv";
            tabControlAddAdv.Size = new Size(942, 268);
            tabControlAddAdv.TabIndex = 0;
            tabControlAddAdv.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            tabControlAddAdv.SelectedIndexChanged += tabControlAddAdv_SelectedIndexChanged;
            // 
            // addApartmentsTab
            // 
            addApartmentsTab.Controls.Add(btnAddRange);
            addApartmentsTab.Controls.Add(btnEditNumber);
            addApartmentsTab.Controls.Add(btnAddSingle);
            addApartmentsTab.Controls.Add(addressControlAddApartments);
            addApartmentsTab.Controls.Add(cityControlAddApartments);
            addApartmentsTab.Controls.Add(countryControlAddApartments);
            addApartmentsTab.Controls.Add(chkPrivateHouse);
            addApartmentsTab.Controls.Add(btnEditAddressAdd);
            addApartmentsTab.Controls.Add(btnEditCityAdd);
            addApartmentsTab.Controls.Add(btnEditCountryAdd);
            addApartmentsTab.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addApartmentsTab.ForeColor = Color.White;
            addApartmentsTab.Image = null;
            addApartmentsTab.ImageSize = new Size(16, 16);
            addApartmentsTab.Location = new Point(1, 35);
            addApartmentsTab.Margin = new Padding(3, 4, 3, 4);
            addApartmentsTab.Name = "addApartmentsTab";
            addApartmentsTab.ShowCloseButton = true;
            addApartmentsTab.Size = new Size(939, 231);
            addApartmentsTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addApartmentsTab.TabForeColor = Color.White;
            addApartmentsTab.TabIndex = 1;
            addApartmentsTab.Text = "Добавить квартиры";
            addApartmentsTab.ThemesEnabled = false;
            // 
            // btnAddRange
            // 
            btnAddRange.BackColor = Color.White;
            btnAddRange.FlatAppearance.BorderSize = 0;
            btnAddRange.FlatStyle = FlatStyle.Flat;
            btnAddRange.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRange.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddRange.Image = (Image)resources.GetObject("btnAddRange.Image");
            btnAddRange.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRange.Location = new Point(355, 169);
            btnAddRange.Margin = new Padding(3, 4, 3, 4);
            btnAddRange.Name = "btnAddRange";
            btnAddRange.Size = new Size(311, 44);
            btnAddRange.TabIndex = 23;
            btnAddRange.Text = "      Добавить список квартир";
            btnAddRange.UseVisualStyleBackColor = false;
            btnAddRange.Click += btnAddRange_Click;
            // 
            // btnEditNumber
            // 
            btnEditNumber.BackColor = Color.White;
            btnEditNumber.FlatAppearance.BorderSize = 0;
            btnEditNumber.FlatStyle = FlatStyle.Flat;
            btnEditNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditNumber.ForeColor = Color.FromArgb(0, 71, 160);
            btnEditNumber.Image = (Image)resources.GetObject("btnEditNumber.Image");
            btnEditNumber.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditNumber.Location = new Point(672, 169);
            btnEditNumber.Margin = new Padding(3, 4, 3, 4);
            btnEditNumber.Name = "btnEditNumber";
            btnEditNumber.Size = new Size(202, 44);
            btnEditNumber.TabIndex = 21;
            btnEditNumber.Text = "     Редактировать";
            btnEditNumber.UseVisualStyleBackColor = false;
            btnEditNumber.Click += btnEditNumber_Click;
            // 
            // btnAddSingle
            // 
            btnAddSingle.BackColor = Color.White;
            btnAddSingle.FlatAppearance.BorderSize = 0;
            btnAddSingle.FlatStyle = FlatStyle.Flat;
            btnAddSingle.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSingle.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddSingle.Image = (Image)resources.GetObject("btnAddSingle.Image");
            btnAddSingle.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSingle.Location = new Point(88, 169);
            btnAddSingle.Margin = new Padding(3, 4, 3, 4);
            btnAddSingle.Name = "btnAddSingle";
            btnAddSingle.Size = new Size(261, 44);
            btnAddSingle.TabIndex = 22;
            btnAddSingle.Text = "     Добавить 1 квартиру";
            btnAddSingle.UseVisualStyleBackColor = false;
            btnAddSingle.Click += btnAddSingle_Click;
            // 
            // addressControlAddApartments
            // 
            addressControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            addressControlAddApartments.Location = new Point(147, 91);
            addressControlAddApartments.Margin = new Padding(0, 0, 6, 0);
            addressControlAddApartments.Name = "addressControlAddApartments";
            addressControlAddApartments.Size = new Size(598, 39);
            addressControlAddApartments.TabIndex = 20;
            // 
            // cityControlAddApartments
            // 
            cityControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            cityControlAddApartments.Location = new Point(469, 33);
            cityControlAddApartments.Margin = new Padding(0, 0, 6, 0);
            cityControlAddApartments.Name = "cityControlAddApartments";
            cityControlAddApartments.Size = new Size(277, 39);
            cityControlAddApartments.TabIndex = 19;
            // 
            // countryControlAddApartments
            // 
            countryControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            countryControlAddApartments.Location = new Point(139, 33);
            countryControlAddApartments.Margin = new Padding(0, 0, 6, 0);
            countryControlAddApartments.Name = "countryControlAddApartments";
            countryControlAddApartments.Size = new Size(271, 39);
            countryControlAddApartments.TabIndex = 18;
            // 
            // chkPrivateHouse
            // 
            chkPrivateHouse.AutoSize = true;
            chkPrivateHouse.Enabled = false;
            chkPrivateHouse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouse.Location = new Point(241, 131);
            chkPrivateHouse.Margin = new Padding(3, 4, 3, 4);
            chkPrivateHouse.Name = "chkPrivateHouse";
            chkPrivateHouse.Size = new Size(166, 24);
            chkPrivateHouse.TabIndex = 17;
            chkPrivateHouse.Text = "Частные дома";
            chkPrivateHouse.UseVisualStyleBackColor = true;
            chkPrivateHouse.CheckedChanged += chkPrivateHouse_CheckedChanged;
            // 
            // btnEditAddressAdd
            // 
            btnEditAddressAdd.BackColor = Color.White;
            btnEditAddressAdd.FlatAppearance.BorderSize = 0;
            btnEditAddressAdd.FlatStyle = FlatStyle.Flat;
            btnEditAddressAdd.Image = (Image)resources.GetObject("btnEditAddressAdd.Image");
            btnEditAddressAdd.Location = new Point(754, 87);
            btnEditAddressAdd.Margin = new Padding(3, 4, 3, 4);
            btnEditAddressAdd.Name = "btnEditAddressAdd";
            btnEditAddressAdd.Size = new Size(46, 47);
            btnEditAddressAdd.TabIndex = 16;
            btnEditAddressAdd.UseVisualStyleBackColor = false;
            btnEditAddressAdd.Click += btnEditAddressAdd_Click;
            // 
            // btnEditCityAdd
            // 
            btnEditCityAdd.BackColor = Color.White;
            btnEditCityAdd.FlatAppearance.BorderSize = 0;
            btnEditCityAdd.FlatStyle = FlatStyle.Flat;
            btnEditCityAdd.Image = (Image)resources.GetObject("btnEditCityAdd.Image");
            btnEditCityAdd.Location = new Point(754, 24);
            btnEditCityAdd.Margin = new Padding(3, 4, 3, 4);
            btnEditCityAdd.Name = "btnEditCityAdd";
            btnEditCityAdd.Size = new Size(46, 47);
            btnEditCityAdd.TabIndex = 15;
            btnEditCityAdd.UseVisualStyleBackColor = false;
            btnEditCityAdd.Click += btnEditCityAdd_Click;
            // 
            // btnEditCountryAdd
            // 
            btnEditCountryAdd.BackColor = Color.White;
            btnEditCountryAdd.FlatAppearance.BorderSize = 0;
            btnEditCountryAdd.FlatStyle = FlatStyle.Flat;
            btnEditCountryAdd.Image = (Image)resources.GetObject("btnEditCountryAdd.Image");
            btnEditCountryAdd.Location = new Point(419, 24);
            btnEditCountryAdd.Margin = new Padding(3, 4, 3, 4);
            btnEditCountryAdd.Name = "btnEditCountryAdd";
            btnEditCountryAdd.Size = new Size(46, 47);
            btnEditCountryAdd.TabIndex = 14;
            btnEditCountryAdd.UseVisualStyleBackColor = false;
            btnEditCountryAdd.Click += btnEditCountryAdd_Click;
            // 
            // addNotDisturbTab
            // 
            addNotDisturbTab.Controls.Add(btnEditNotDisturb);
            addNotDisturbTab.Controls.Add(txtNumberPhone);
            addNotDisturbTab.Controls.Add(lblNumberPhone);
            addNotDisturbTab.Controls.Add(btnAddNotDisturbByNumberPhone);
            addNotDisturbTab.Controls.Add(btnAddNotDisturbByAddress);
            addNotDisturbTab.Controls.Add(apartmentControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(addressControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(cityControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(countryControlAddNotDisturb);
            addNotDisturbTab.Controls.Add(chkPrivateHouseAddNotDisturb);
            addNotDisturbTab.ForeColor = Color.White;
            addNotDisturbTab.Image = null;
            addNotDisturbTab.ImageSize = new Size(16, 16);
            addNotDisturbTab.Location = new Point(1, 35);
            addNotDisturbTab.Margin = new Padding(3, 4, 3, 4);
            addNotDisturbTab.Name = "addNotDisturbTab";
            addNotDisturbTab.ShowCloseButton = true;
            addNotDisturbTab.Size = new Size(939, 223);
            addNotDisturbTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addNotDisturbTab.TabForeColor = Color.White;
            addNotDisturbTab.TabIndex = 2;
            addNotDisturbTab.Text = "Добавить \"Не беспокоить\"";
            addNotDisturbTab.ThemesEnabled = false;
            // 
            // btnEditNotDisturb
            // 
            btnEditNotDisturb.BackColor = Color.White;
            btnEditNotDisturb.FlatAppearance.BorderSize = 0;
            btnEditNotDisturb.FlatStyle = FlatStyle.Flat;
            btnEditNotDisturb.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditNotDisturb.ForeColor = Color.FromArgb(0, 71, 160);
            btnEditNotDisturb.Image = (Image)resources.GetObject("btnEditNotDisturb.Image");
            btnEditNotDisturb.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditNotDisturb.Location = new Point(392, 164);
            btnEditNotDisturb.Margin = new Padding(3, 4, 3, 4);
            btnEditNotDisturb.Name = "btnEditNotDisturb";
            btnEditNotDisturb.Size = new Size(192, 44);
            btnEditNotDisturb.TabIndex = 30;
            btnEditNotDisturb.Text = "     Редактировать";
            btnEditNotDisturb.UseVisualStyleBackColor = false;
            btnEditNotDisturb.Click += btnEditNotDisturb_Click;
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPhone.ForeColor = Color.FromArgb(0, 71, 160);
            txtNumberPhone.Location = new Point(682, 91);
            txtNumberPhone.Margin = new Padding(3, 4, 3, 4);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(178, 30);
            txtNumberPhone.TabIndex = 29;
            txtNumberPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumberPhone
            // 
            lblNumberPhone.DY = -33;
            lblNumberPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberPhone.Gap = 10;
            lblNumberPhone.LabeledControl = txtNumberPhone;
            lblNumberPhone.Location = new Point(682, 58);
            lblNumberPhone.Name = "lblNumberPhone";
            lblNumberPhone.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            lblNumberPhone.Size = new Size(197, 23);
            lblNumberPhone.TabIndex = 28;
            lblNumberPhone.Text = "Номер телефона:";
            // 
            // btnAddNotDisturbByNumberPhone
            // 
            btnAddNotDisturbByNumberPhone.BackColor = Color.White;
            btnAddNotDisturbByNumberPhone.FlatAppearance.BorderSize = 0;
            btnAddNotDisturbByNumberPhone.FlatStyle = FlatStyle.Flat;
            btnAddNotDisturbByNumberPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNotDisturbByNumberPhone.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddNotDisturbByNumberPhone.Image = (Image)resources.GetObject("btnAddNotDisturbByNumberPhone.Image");
            btnAddNotDisturbByNumberPhone.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNotDisturbByNumberPhone.Location = new Point(625, 164);
            btnAddNotDisturbByNumberPhone.Margin = new Padding(3, 4, 3, 4);
            btnAddNotDisturbByNumberPhone.Name = "btnAddNotDisturbByNumberPhone";
            btnAddNotDisturbByNumberPhone.Size = new Size(288, 44);
            btnAddNotDisturbByNumberPhone.TabIndex = 27;
            btnAddNotDisturbByNumberPhone.Text = "     Добавить по номеру тел.";
            btnAddNotDisturbByNumberPhone.UseVisualStyleBackColor = false;
            btnAddNotDisturbByNumberPhone.Click += btnAddNotDisturbByNumberPhone_Click;
            // 
            // btnAddNotDisturbByAddress
            // 
            btnAddNotDisturbByAddress.BackColor = Color.White;
            btnAddNotDisturbByAddress.FlatAppearance.BorderSize = 0;
            btnAddNotDisturbByAddress.FlatStyle = FlatStyle.Flat;
            btnAddNotDisturbByAddress.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNotDisturbByAddress.ForeColor = Color.FromArgb(0, 71, 160);
            btnAddNotDisturbByAddress.Image = (Image)resources.GetObject("btnAddNotDisturbByAddress.Image");
            btnAddNotDisturbByAddress.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNotDisturbByAddress.Location = new Point(105, 164);
            btnAddNotDisturbByAddress.Margin = new Padding(3, 4, 3, 4);
            btnAddNotDisturbByAddress.Name = "btnAddNotDisturbByAddress";
            btnAddNotDisturbByAddress.Size = new Size(243, 44);
            btnAddNotDisturbByAddress.TabIndex = 26;
            btnAddNotDisturbByAddress.Text = "     Добавить по адресу";
            btnAddNotDisturbByAddress.UseVisualStyleBackColor = false;
            btnAddNotDisturbByAddress.Click += btnAddNotDisturbByAddress_Click;
            // 
            // apartmentControlAddNotDisturb
            // 
            apartmentControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            apartmentControlAddNotDisturb.Location = new Point(493, 91);
            apartmentControlAddNotDisturb.Margin = new Padding(0, 0, 6, 0);
            apartmentControlAddNotDisturb.Name = "apartmentControlAddNotDisturb";
            apartmentControlAddNotDisturb.Size = new Size(111, 35);
            apartmentControlAddNotDisturb.TabIndex = 25;
            // 
            // addressControlAddNotDisturb
            // 
            addressControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            addressControlAddNotDisturb.Location = new Point(25, 91);
            addressControlAddNotDisturb.Margin = new Padding(0, 0, 6, 0);
            addressControlAddNotDisturb.Name = "addressControlAddNotDisturb";
            addressControlAddNotDisturb.Size = new Size(462, 35);
            addressControlAddNotDisturb.TabIndex = 24;
            // 
            // cityControlAddNotDisturb
            // 
            cityControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            cityControlAddNotDisturb.Location = new Point(323, 28);
            cityControlAddNotDisturb.Margin = new Padding(0, 0, 6, 0);
            cityControlAddNotDisturb.Name = "cityControlAddNotDisturb";
            cityControlAddNotDisturb.Size = new Size(280, 35);
            cityControlAddNotDisturb.TabIndex = 23;
            // 
            // countryControlAddNotDisturb
            // 
            countryControlAddNotDisturb.BackColor = Color.FromArgb(0, 71, 160);
            countryControlAddNotDisturb.Location = new Point(16, 28);
            countryControlAddNotDisturb.Margin = new Padding(0, 0, 6, 0);
            countryControlAddNotDisturb.Name = "countryControlAddNotDisturb";
            countryControlAddNotDisturb.Size = new Size(302, 35);
            countryControlAddNotDisturb.TabIndex = 22;
            // 
            // chkPrivateHouseAddNotDisturb
            // 
            chkPrivateHouseAddNotDisturb.AutoSize = true;
            chkPrivateHouseAddNotDisturb.Enabled = false;
            chkPrivateHouseAddNotDisturb.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouseAddNotDisturb.Location = new Point(118, 129);
            chkPrivateHouseAddNotDisturb.Margin = new Padding(3, 4, 3, 4);
            chkPrivateHouseAddNotDisturb.Name = "chkPrivateHouseAddNotDisturb";
            chkPrivateHouseAddNotDisturb.Size = new Size(157, 23);
            chkPrivateHouseAddNotDisturb.TabIndex = 21;
            chkPrivateHouseAddNotDisturb.Text = "Частные дома";
            chkPrivateHouseAddNotDisturb.UseVisualStyleBackColor = true;
            chkPrivateHouseAddNotDisturb.CheckedChanged += chkPrivateHouseAddNotDisturb_CheckedChanged;
            // 
            // gridPhones
            // 
            gridPhones.BackColor = Color.White;
            gridPhones.Dock = DockStyle.Bottom;
            gridPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridPhones.Location = new Point(6, 275);
            gridPhones.Margin = new Padding(3, 4, 3, 4);
            gridPhones.Name = "gridPhones";
            gridPhones.Padding = new Padding(0, 7, 0, 0);
            gridPhones.Size = new Size(942, 511);
            gridPhones.TabIndex = 1;
            // 
            // AddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddAdv);
            Controls.Add(gridPhones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddControl";
            Padding = new Padding(6, 7, 6, 7);
            Size = new Size(954, 793);
            Load += AddControl_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).EndInit();
            tabControlAddAdv.ResumeLayout(false);
            addApartmentsTab.ResumeLayout(false);
            addApartmentsTab.PerformLayout();
            addNotDisturbTab.ResumeLayout(false);
            addNotDisturbTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAddAdv;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addApartmentsTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addNotDisturbTab;
        private Button btnEditCountryAdd;
        private Button btnEditAddressAdd;
        private Button btnEditCityAdd;
        private CheckBox chkPrivateHouse;
        private UserControls.CountryControl countryControlAddApartments;
        private UserControls.CityControl cityControlAddApartments;
        private UserControls.AddressControl addressControlAddApartments;
        private UserControls.GridControl gridPhones;
        private Button btnAddRange;
        private Button btnEditNumber;
        private Button btnAddSingle;
        private UserControls.AddressControl addressControlAddNotDisturb;
        private UserControls.CityControl cityControlAddNotDisturb;
        private UserControls.CountryControl countryControlAddNotDisturb;
        private CheckBox chkPrivateHouseAddNotDisturb;
        private UserControls.ApartmentControl apartmentControlAddNotDisturb;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumberPhone;
        private Button btnAddNotDisturbByNumberPhone;
        private Button btnAddNotDisturbByAddress;
        private MaskedTextBox txtNumberPhone;
        private Button btnEditNotDisturb;
    }
}
