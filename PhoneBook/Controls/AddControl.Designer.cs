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
            tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            gridPhones = new UserControls.GridControl();
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).BeginInit();
            tabControlAddAdv.SuspendLayout();
            addApartmentsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddAdv
            // 
            tabControlAddAdv.BackColor = Color.FromArgb(0, 71, 160);
            tabControlAddAdv.BeforeTouchSize = new Size(825, 224);
            tabControlAddAdv.Controls.Add(addApartmentsTab);
            tabControlAddAdv.Controls.Add(tabPageAdv2);
            tabControlAddAdv.Dock = DockStyle.Fill;
            tabControlAddAdv.Location = new Point(5, 5);
            tabControlAddAdv.Name = "tabControlAddAdv";
            tabControlAddAdv.Size = new Size(825, 224);
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
            addApartmentsTab.ForeColor = Color.White;
            addApartmentsTab.Image = null;
            addApartmentsTab.ImageSize = new Size(16, 16);
            addApartmentsTab.Location = new Point(1, 31);
            addApartmentsTab.Name = "addApartmentsTab";
            addApartmentsTab.ShowCloseButton = true;
            addApartmentsTab.Size = new Size(822, 191);
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
            btnAddRange.Location = new Point(320, 137);
            btnAddRange.Name = "btnAddRange";
            btnAddRange.Size = new Size(252, 33);
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
            btnEditNumber.Location = new Point(578, 137);
            btnEditNumber.Name = "btnEditNumber";
            btnEditNumber.Size = new Size(168, 33);
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
            btnAddSingle.Location = new Point(101, 137);
            btnAddSingle.Name = "btnAddSingle";
            btnAddSingle.Size = new Size(213, 33);
            btnAddSingle.TabIndex = 22;
            btnAddSingle.Text = "     Добавить 1 квартиру";
            btnAddSingle.UseVisualStyleBackColor = false;
            btnAddSingle.Click += btnAddSingle_Click;
            // 
            // addressControlAddApartments
            // 
            addressControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            addressControlAddApartments.Location = new Point(129, 69);
            addressControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            addressControlAddApartments.Name = "addressControlAddApartments";
            addressControlAddApartments.Size = new Size(523, 26);
            addressControlAddApartments.TabIndex = 20;
            // 
            // cityControlAddApartments
            // 
            cityControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            cityControlAddApartments.Location = new Point(410, 22);
            cityControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            cityControlAddApartments.Name = "cityControlAddApartments";
            cityControlAddApartments.Size = new Size(242, 26);
            cityControlAddApartments.TabIndex = 19;
            // 
            // countryControlAddApartments
            // 
            countryControlAddApartments.BackColor = Color.FromArgb(0, 71, 160);
            countryControlAddApartments.Location = new Point(122, 22);
            countryControlAddApartments.Margin = new Padding(0, 0, 5, 0);
            countryControlAddApartments.Name = "countryControlAddApartments";
            countryControlAddApartments.Size = new Size(237, 26);
            countryControlAddApartments.TabIndex = 18;
            // 
            // chkPrivateHouse
            // 
            chkPrivateHouse.AutoSize = true;
            chkPrivateHouse.Enabled = false;
            chkPrivateHouse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouse.Location = new Point(211, 98);
            chkPrivateHouse.Name = "chkPrivateHouse";
            chkPrivateHouse.Size = new Size(130, 20);
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
            btnEditAddressAdd.Location = new Point(660, 65);
            btnEditAddressAdd.Name = "btnEditAddressAdd";
            btnEditAddressAdd.Size = new Size(40, 35);
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
            btnEditCityAdd.Location = new Point(660, 18);
            btnEditCityAdd.Name = "btnEditCityAdd";
            btnEditCityAdd.Size = new Size(40, 35);
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
            btnEditCountryAdd.Location = new Point(367, 18);
            btnEditCountryAdd.Name = "btnEditCountryAdd";
            btnEditCountryAdd.Size = new Size(40, 35);
            btnEditCountryAdd.TabIndex = 14;
            btnEditCountryAdd.UseVisualStyleBackColor = false;
            btnEditCountryAdd.Click += btnEditCountryAdd_Click;
            // 
            // tabPageAdv2
            // 
            tabPageAdv2.Image = null;
            tabPageAdv2.ImageSize = new Size(16, 16);
            tabPageAdv2.Location = new Point(1, 32);
            tabPageAdv2.Name = "tabPageAdv2";
            tabPageAdv2.ShowCloseButton = true;
            tabPageAdv2.Size = new Size(822, 190);
            tabPageAdv2.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageAdv2.TabForeColor = Color.White;
            tabPageAdv2.TabIndex = 2;
            tabPageAdv2.Text = "tabPageAdv2";
            tabPageAdv2.ThemesEnabled = false;
            // 
            // gridPhones
            // 
            gridPhones.BackColor = Color.White;
            gridPhones.Dock = DockStyle.Bottom;
            gridPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridPhones.Location = new Point(5, 229);
            gridPhones.Name = "gridPhones";
            gridPhones.Padding = new Padding(0, 5, 0, 0);
            gridPhones.Size = new Size(825, 361);
            gridPhones.TabIndex = 1;
            // 
            // AddControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddAdv);
            Controls.Add(gridPhones);
            Name = "AddControl";
            Padding = new Padding(5);
            Size = new Size(835, 595);
            Load += AddControl_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAddAdv).EndInit();
            tabControlAddAdv.ResumeLayout(false);
            addApartmentsTab.ResumeLayout(false);
            addApartmentsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAddAdv;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addApartmentsTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
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
    }
}
