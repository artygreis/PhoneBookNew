namespace PhoneBook.Controls
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            tabControlAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            searchByAddressTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btnExportToPdf = new Button();
            btnSearch = new Button();
            pnlFilterPrivateHouse = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            rdbOdd = new RadioButton();
            rdbEven = new RadioButton();
            rdbAll = new RadioButton();
            chkPrivateHouse = new CheckBox();
            grpApartment = new GroupBox();
            txtSingle = new TextBox();
            grpApartments = new GroupBox();
            lblTo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtTo = new TextBox();
            lblFrom = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtFrom = new TextBox();
            countryControlSearchByAddress = new UserControls.CountryControl();
            addressControlSearchByAddress = new UserControls.AddressControl();
            cityControlSearchByAddress = new UserControls.CityControl();
            searchByNumberPhone = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtNumberPhone = new MaskedTextBox();
            btnSearchByNumberPhone = new Button();
            countryControlSearchByNumberPhone = new UserControls.CountryControl();
            cityControlSearchByNumberPhone = new UserControls.CityControl();
            gridPhones = new UserControls.GridControl();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv).BeginInit();
            tabControlAdv.SuspendLayout();
            searchByAddressTab.SuspendLayout();
            pnlFilterPrivateHouse.SuspendLayout();
            grpApartment.SuspendLayout();
            grpApartments.SuspendLayout();
            searchByNumberPhone.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAdv
            // 
            tabControlAdv.BackColor = Color.FromArgb(0, 71, 160);
            tabControlAdv.BeforeTouchSize = new Size(825, 230);
            tabControlAdv.Controls.Add(searchByAddressTab);
            tabControlAdv.Controls.Add(searchByNumberPhone);
            tabControlAdv.Dock = DockStyle.Fill;
            tabControlAdv.Location = new Point(5, 5);
            tabControlAdv.Name = "tabControlAdv";
            tabControlAdv.Size = new Size(825, 230);
            tabControlAdv.TabIndex = 0;
            tabControlAdv.SelectedIndexChanged += tabControlAdv_SelectedIndexChanged;
            // 
            // searchByAddressTab
            // 
            searchByAddressTab.Controls.Add(btnExportToPdf);
            searchByAddressTab.Controls.Add(btnSearch);
            searchByAddressTab.Controls.Add(pnlFilterPrivateHouse);
            searchByAddressTab.Controls.Add(chkPrivateHouse);
            searchByAddressTab.Controls.Add(grpApartment);
            searchByAddressTab.Controls.Add(grpApartments);
            searchByAddressTab.Controls.Add(countryControlSearchByAddress);
            searchByAddressTab.Controls.Add(addressControlSearchByAddress);
            searchByAddressTab.Controls.Add(cityControlSearchByAddress);
            searchByAddressTab.ForeColor = Color.White;
            searchByAddressTab.Image = null;
            searchByAddressTab.ImageSize = new Size(16, 16);
            searchByAddressTab.Location = new Point(1, 31);
            searchByAddressTab.Name = "searchByAddressTab";
            searchByAddressTab.ShowCloseButton = true;
            searchByAddressTab.Size = new Size(822, 197);
            searchByAddressTab.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchByAddressTab.TabForeColor = Color.White;
            searchByAddressTab.TabIndex = 1;
            searchByAddressTab.Text = "Поиск по адресу";
            searchByAddressTab.ThemesEnabled = false;
            // 
            // btnExportToPdf
            // 
            btnExportToPdf.BackColor = Color.White;
            btnExportToPdf.FlatStyle = FlatStyle.Flat;
            btnExportToPdf.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportToPdf.ForeColor = Color.FromArgb(0, 71, 160);
            btnExportToPdf.Image = (Image)resources.GetObject("btnExportToPdf.Image");
            btnExportToPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportToPdf.Location = new Point(639, 148);
            btnExportToPdf.Name = "btnExportToPdf";
            btnExportToPdf.Size = new Size(173, 32);
            btnExportToPdf.TabIndex = 17;
            btnExportToPdf.Text = "     Экспорт в PDF";
            btnExportToPdf.UseVisualStyleBackColor = false;
            btnExportToPdf.Click += btnExportToPdf_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(0, 71, 160);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(361, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 32);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "     Найти";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlFilterPrivateHouse
            // 
            pnlFilterPrivateHouse.Controls.Add(panel4);
            pnlFilterPrivateHouse.Controls.Add(panel3);
            pnlFilterPrivateHouse.Controls.Add(panel2);
            pnlFilterPrivateHouse.Controls.Add(panel1);
            pnlFilterPrivateHouse.Controls.Add(rdbOdd);
            pnlFilterPrivateHouse.Controls.Add(rdbEven);
            pnlFilterPrivateHouse.Controls.Add(rdbAll);
            pnlFilterPrivateHouse.Enabled = false;
            pnlFilterPrivateHouse.ForeColor = Color.White;
            pnlFilterPrivateHouse.Location = new Point(517, 104);
            pnlFilterPrivateHouse.Name = "pnlFilterPrivateHouse";
            pnlFilterPrivateHouse.Size = new Size(295, 29);
            pnlFilterPrivateHouse.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(294, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 27);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 27);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 1);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 1);
            panel1.TabIndex = 3;
            // 
            // rdbOdd
            // 
            rdbOdd.AutoSize = true;
            rdbOdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbOdd.Location = new Point(187, 4);
            rdbOdd.Name = "rdbOdd";
            rdbOdd.Size = new Size(90, 20);
            rdbOdd.TabIndex = 2;
            rdbOdd.TabStop = true;
            rdbOdd.Text = "Нечетные";
            rdbOdd.UseVisualStyleBackColor = true;
            // 
            // rdbEven
            // 
            rdbEven.AutoSize = true;
            rdbEven.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbEven.Location = new Point(94, 4);
            rdbEven.Name = "rdbEven";
            rdbEven.Size = new Size(74, 20);
            rdbEven.TabIndex = 1;
            rdbEven.TabStop = true;
            rdbEven.Text = "Четные";
            rdbEven.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Checked = true;
            rdbAll.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAll.Location = new Point(26, 4);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(49, 20);
            rdbAll.TabIndex = 0;
            rdbAll.TabStop = true;
            rdbAll.Text = "Все";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // chkPrivateHouse
            // 
            chkPrivateHouse.AutoSize = true;
            chkPrivateHouse.Enabled = false;
            chkPrivateHouse.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkPrivateHouse.ForeColor = Color.White;
            chkPrivateHouse.Location = new Point(95, 101);
            chkPrivateHouse.Name = "chkPrivateHouse";
            chkPrivateHouse.Size = new Size(123, 20);
            chkPrivateHouse.TabIndex = 14;
            chkPrivateHouse.Text = "Частные дома";
            chkPrivateHouse.UseVisualStyleBackColor = true;
            chkPrivateHouse.CheckedChanged += chkPrivateHouse_CheckedChanged;
            // 
            // grpApartment
            // 
            grpApartment.Controls.Add(txtSingle);
            grpApartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpApartment.ForeColor = Color.White;
            grpApartment.Location = new Point(517, 13);
            grpApartment.Name = "grpApartment";
            grpApartment.Size = new Size(112, 85);
            grpApartment.TabIndex = 13;
            grpApartment.TabStop = false;
            grpApartment.Text = "Квартира:";
            // 
            // txtSingle
            // 
            txtSingle.ForeColor = Color.FromArgb(0, 71, 160);
            txtSingle.Location = new Point(31, 35);
            txtSingle.Name = "txtSingle";
            txtSingle.Size = new Size(50, 27);
            txtSingle.TabIndex = 3;
            txtSingle.TextAlign = HorizontalAlignment.Center;
            txtSingle.TextChanged += txtSingle_TextChanged;
            // 
            // grpApartments
            // 
            grpApartments.Controls.Add(lblTo);
            grpApartments.Controls.Add(lblFrom);
            grpApartments.Controls.Add(txtTo);
            grpApartments.Controls.Add(txtFrom);
            grpApartments.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpApartments.ForeColor = Color.White;
            grpApartments.Location = new Point(635, 13);
            grpApartments.Name = "grpApartments";
            grpApartments.Size = new Size(177, 85);
            grpApartments.TabIndex = 12;
            grpApartments.TabStop = false;
            grpApartments.Text = "Квартиры:";
            // 
            // lblTo
            // 
            lblTo.DX = -33;
            lblTo.DY = 2;
            lblTo.LabeledControl = txtTo;
            lblTo.Location = new Point(84, 37);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(29, 19);
            lblTo.TabIndex = 3;
            lblTo.Text = "по";
            // 
            // txtTo
            // 
            txtTo.Enabled = false;
            txtTo.ForeColor = Color.FromArgb(0, 71, 160);
            txtTo.Location = new Point(117, 35);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(50, 27);
            txtTo.TabIndex = 4;
            txtTo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFrom
            // 
            lblFrom.BackColor = Color.FromArgb(0, 71, 160);
            lblFrom.DX = -23;
            lblFrom.DY = 2;
            lblFrom.LabeledControl = txtFrom;
            lblFrom.Location = new Point(6, 37);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(19, 19);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "с";
            // 
            // txtFrom
            // 
            txtFrom.ForeColor = Color.FromArgb(0, 71, 160);
            txtFrom.Location = new Point(29, 35);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(50, 27);
            txtFrom.TabIndex = 3;
            txtFrom.TextAlign = HorizontalAlignment.Center;
            txtFrom.TextChanged += txtFrom_TextChanged;
            // 
            // countryControlSearchByAddress
            // 
            countryControlSearchByAddress.BackColor = Color.FromArgb(0, 71, 160);
            countryControlSearchByAddress.Location = new Point(13, 25);
            countryControlSearchByAddress.Margin = new Padding(0, 0, 5, 0);
            countryControlSearchByAddress.Name = "countryControlSearchByAddress";
            countryControlSearchByAddress.Size = new Size(234, 26);
            countryControlSearchByAddress.TabIndex = 2;
            // 
            // addressControlSearchByAddress
            // 
            addressControlSearchByAddress.BackColor = Color.FromArgb(0, 71, 160);
            addressControlSearchByAddress.Location = new Point(21, 68);
            addressControlSearchByAddress.Margin = new Padding(0, 0, 5, 0);
            addressControlSearchByAddress.Name = "addressControlSearchByAddress";
            addressControlSearchByAddress.Size = new Size(475, 26);
            addressControlSearchByAddress.TabIndex = 1;
            // 
            // cityControlSearchByAddress
            // 
            cityControlSearchByAddress.BackColor = Color.FromArgb(0, 71, 160);
            cityControlSearchByAddress.Location = new Point(252, 25);
            cityControlSearchByAddress.Margin = new Padding(0, 0, 5, 0);
            cityControlSearchByAddress.Name = "cityControlSearchByAddress";
            cityControlSearchByAddress.Size = new Size(244, 26);
            cityControlSearchByAddress.TabIndex = 0;
            // 
            // searchByNumberPhone
            // 
            searchByNumberPhone.Controls.Add(autoLabel1);
            searchByNumberPhone.Controls.Add(txtNumberPhone);
            searchByNumberPhone.Controls.Add(btnSearchByNumberPhone);
            searchByNumberPhone.Controls.Add(countryControlSearchByNumberPhone);
            searchByNumberPhone.Controls.Add(cityControlSearchByNumberPhone);
            searchByNumberPhone.ForeColor = Color.White;
            searchByNumberPhone.Image = null;
            searchByNumberPhone.ImageSize = new Size(16, 16);
            searchByNumberPhone.Location = new Point(1, 31);
            searchByNumberPhone.Name = "searchByNumberPhone";
            searchByNumberPhone.ShowCloseButton = true;
            searchByNumberPhone.Size = new Size(822, 197);
            searchByNumberPhone.TabFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchByNumberPhone.TabForeColor = Color.White;
            searchByNumberPhone.TabIndex = 2;
            searchByNumberPhone.Text = "Поиск по номеру";
            searchByNumberPhone.ThemesEnabled = false;
            // 
            // autoLabel1
            // 
            autoLabel1.DX = -160;
            autoLabel1.DY = 3;
            autoLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            autoLabel1.LabeledControl = txtNumberPhone;
            autoLabel1.Location = new Point(18, 71);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(156, 19);
            autoLabel1.TabIndex = 23;
            autoLabel1.Text = "Номер телефона:";
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPhone.ForeColor = Color.FromArgb(0, 71, 160);
            txtNumberPhone.Location = new Point(178, 68);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(225, 26);
            txtNumberPhone.TabIndex = 22;
            txtNumberPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearchByNumberPhone
            // 
            btnSearchByNumberPhone.BackColor = Color.White;
            btnSearchByNumberPhone.FlatStyle = FlatStyle.Flat;
            btnSearchByNumberPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchByNumberPhone.ForeColor = Color.FromArgb(0, 71, 160);
            btnSearchByNumberPhone.Image = (Image)resources.GetObject("btnSearchByNumberPhone.Image");
            btnSearchByNumberPhone.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchByNumberPhone.Location = new Point(601, 37);
            btnSearchByNumberPhone.Name = "btnSearchByNumberPhone";
            btnSearchByNumberPhone.Size = new Size(132, 53);
            btnSearchByNumberPhone.TabIndex = 19;
            btnSearchByNumberPhone.Text = "     Найти";
            btnSearchByNumberPhone.UseVisualStyleBackColor = false;
            btnSearchByNumberPhone.Click += btnSearchByNumberPhone_Click;
            // 
            // countryControlSearchByNumberPhone
            // 
            countryControlSearchByNumberPhone.BackColor = Color.FromArgb(0, 71, 160);
            countryControlSearchByNumberPhone.Location = new Point(15, 25);
            countryControlSearchByNumberPhone.Margin = new Padding(0, 0, 5, 0);
            countryControlSearchByNumberPhone.Name = "countryControlSearchByNumberPhone";
            countryControlSearchByNumberPhone.Size = new Size(255, 26);
            countryControlSearchByNumberPhone.TabIndex = 18;
            // 
            // cityControlSearchByNumberPhone
            // 
            cityControlSearchByNumberPhone.BackColor = Color.FromArgb(0, 71, 160);
            cityControlSearchByNumberPhone.Location = new Point(275, 25);
            cityControlSearchByNumberPhone.Margin = new Padding(0, 0, 5, 0);
            cityControlSearchByNumberPhone.Name = "cityControlSearchByNumberPhone";
            cityControlSearchByNumberPhone.Size = new Size(281, 26);
            cityControlSearchByNumberPhone.TabIndex = 17;
            // 
            // gridPhones
            // 
            gridPhones.BackColor = Color.White;
            gridPhones.Dock = DockStyle.Bottom;
            gridPhones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gridPhones.ForeColor = Color.FromArgb(0, 71, 160);
            gridPhones.Location = new Point(5, 235);
            gridPhones.Name = "gridPhones";
            gridPhones.Padding = new Padding(0, 5, 0, 0);
            gridPhones.Size = new Size(825, 355);
            gridPhones.TabIndex = 1;
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAdv);
            Controls.Add(gridPhones);
            Name = "SearchControl";
            Padding = new Padding(5);
            Size = new Size(835, 595);
            Load += SearchControl_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlAdv).EndInit();
            tabControlAdv.ResumeLayout(false);
            searchByAddressTab.ResumeLayout(false);
            searchByAddressTab.PerformLayout();
            pnlFilterPrivateHouse.ResumeLayout(false);
            pnlFilterPrivateHouse.PerformLayout();
            grpApartment.ResumeLayout(false);
            grpApartment.PerformLayout();
            grpApartments.ResumeLayout(false);
            grpApartments.PerformLayout();
            searchByNumberPhone.ResumeLayout(false);
            searchByNumberPhone.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv;
        private UserControls.GridControl gridPhones;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv searchByAddressTab;
        private UserControls.CountryControl countryControlSearchByAddress;
        private UserControls.AddressControl addressControlSearchByAddress;
        private UserControls.CityControl cityControlSearchByAddress;
        private Button btnSearch;
        private Panel pnlFilterPrivateHouse;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private RadioButton rdbOdd;
        private RadioButton rdbEven;
        private RadioButton rdbAll;
        private CheckBox chkPrivateHouse;
        private GroupBox grpApartment;
        private TextBox txtSingle;
        private GroupBox grpApartments;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTo;
        private TextBox txtTo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFrom;
        private TextBox txtFrom;
        private Button btnExportToPdf;
        private SaveFileDialog saveFileDialog;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv searchByNumberPhone;
        private Button btnSearchByNumberPhone;
        private UserControls.CountryControl countryControlSearchByNumberPhone;
        private UserControls.CityControl cityControlSearchByNumberPhone;
        private MaskedTextBox txtNumberPhone;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
