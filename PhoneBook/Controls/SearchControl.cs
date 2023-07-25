using Microsoft.EntityFrameworkCore;
using PhoneBook.Services;
using PhoneBook.Types;
using PhoneBook.UserControls;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System.Net.NetworkInformation;

namespace PhoneBook.Controls
{
    public partial class SearchControl : UserControl
    {
        //Маска номеров
        private string maskNumber = "";

        private Dictionary<int, List<NumberPhoneView>> searchResults = new Dictionary<int, List<NumberPhoneView>>();

        public SearchControl()
        {
            InitializeComponent();

            gridPhones.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            gridPhones.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Any;

            autoCompleteControlCountry.AutoCompleteItemSelected += AutoCompleteControlCountry_AutoCompleteItemSelected;
            autoCompleteControlCity.AutoCompleteItemSelected += AutoCompleteControlCity_AutoCompleteItemSelected;
            autoCompleteControlAddress.AutoCompleteItemSelected += AutoCompleteControlAddress_AutoCompleteItemSelected;

            gridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            gridPhones.DataGrid.QueryRowHeight += DataGrid_QueryRowHeight;
        }

        #region Оформление grid для вывода результатов поиска
        RowAutoFitOptions autoFitOptions = new RowAutoFitOptions();
        int autoHeight;
        private void DataGrid_QueryRowHeight(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowHeightEventArgs e)
        {
            if (this.gridPhones.DataGrid.AutoSizeController.GetAutoRowHeight(e.RowIndex, autoFitOptions, out autoHeight))
            {
                if (autoHeight > 24)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
                }
            }
        }

        private void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Number" && !string.IsNullOrEmpty(maskNumber))
            {
                e.Column = new GridMaskColumn() { MappingName = "Number", HeaderText = "Номер телефона", Mask = maskNumber };
            }
        }
        #endregion

        private void SearchControl_Load(object sender, EventArgs e)
        {
            tabControlAdv_SelectedIndexChanged(tabControlAdv, new EventArgs());
        }

        /// <summary>
        /// Обновление информации в результате
        /// </summary>
        /// <param name="numberPhones"></param>
        private void UpdateData(List<NumberPhoneView> numberPhones)
        {
            gridPhones.DataGrid.DataSource = numberPhones;
            gridPhones.DataGrid.Columns["Locality"].Width = 200;
            gridPhones.DataGrid.Columns["TypeName"].Width = 100;
            gridPhones.DataGrid.Columns["StreetName"].Width = 220;
            gridPhones.DataGrid.Columns["House"].Width = 70;
            gridPhones.DataGrid.Columns["Apartment"].Width = 70;
        }

        /// <summary>
        /// Обновление информации в результате
        /// </summary>
        /// <param name="numberPhones"></param>
        private void UpdateData()
        {
            var allNumbers = new List<NumberPhoneView>();
            foreach (var searchResult in searchResults)
            {
                allNumbers.AddRange(searchResult.Value);
            }
            gridPhones.DataGrid.DataSource = allNumbers;
            gridPhones.DataGrid.Columns["Locality"].Width = 200;
            gridPhones.DataGrid.Columns["TypeName"].Width = 100;
            gridPhones.DataGrid.Columns["StreetName"].Width = 220;
            gridPhones.DataGrid.Columns["House"].Width = 70;
            gridPhones.DataGrid.Columns["Apartment"].Width = 70;
        }

        /// <summary>
        /// Выбор необходимой вкладки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlAdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            //if (tabControlAdv.SelectedTab.Name == "searchByPhoneTab")
            //{
            //    LoadDataToCountry(autoCompleteCountry1, textBoxCountry1);
            //}
            if (tabControlAdv.SelectedTab.Name == "searchByAddressTab")
            {
                LoadDataToCountry(autoCompleteControlCountry.AutoComplete, autoCompleteControlCountry.TextBox);
            }
            //if (tabControlAdv.SelectedTab.Name == "searchNotCallTab")
            //{
            //    LoadDataToCountry(autoCompleteCountryNotCall, textBoxCountryNotCall);
            //}
        }

        /// <summary>
        /// Загрузка информации о странах
        /// </summary>
        private void LoadDataToCountry(AutoComplete country, TextBox textBox)
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country
                    .Select(c => new CountryCollection() { Id = c.Id, CountryData = $"{c.CountryName} ({c.CountryCode})" })
                    .ToList();

                country.Columns.Clear();
                country.DataSource = null;

                country.ParentForm = this;
                country.DataSource = countries;
                country.RefreshColumns();
                country.Columns[1].MatchingColumn = true;
                country.Columns[0].Visible = false;

                if (countries.Count == 1)
                {
                    country.ActiveFocusControl = textBox;
                    country.SelectedValue = $"{countries?.FirstOrDefault()?.CountryData}";
                    country.ActiveFocusControl = null;
                }
            }
        }

        /// <summary>
        /// Загрузка городов в зависимости от страны
        /// </summary>
        /// <param name="nameAutoCompletControlCountry"></param>
        /// <param name="nameAutoCompleteControlCity"></param>
        /// <param name="args"></param>
        private void SelectCountryAndComplete(string nameAutoCompletControlCountry, 
            string nameAutoCompleteControlCity, AutoCompleteItemEventArgs args)
        {
            var autoCompleteCountry = ((AutoCompleteControl)Controls.Find(nameAutoCompletControlCountry, true).First()).AutoComplete;
            var autoCompleteCity = ((AutoCompleteControl)Controls.Find(nameAutoCompleteControlCity, true).First()).AutoComplete;

            var textBoxCity = ((AutoCompleteControl)Controls.Find(nameAutoCompleteControlCity, true).First()).TextBox;

            var countryId = autoCompleteCountry.GetItemArray(args.SelectedValue)[0];
                
            var cities = CityCollection.GetCityCollections(Convert.ToInt32(countryId));

            autoCompleteCity.Columns.Clear();
            autoCompleteCity.DataSource = null;

            autoCompleteCity.ParentForm = this;
            autoCompleteCity.DataSource = cities;
            autoCompleteCity.RefreshColumns();
            autoCompleteCity.Columns[1].MatchingColumn = true;
            autoCompleteCity.Columns[0].Visible = false;

            if (cities.Count == 1)
            {
                autoCompleteCity.ActiveFocusControl = textBoxCity;
                autoCompleteCity.SelectedValue = $"{cities.FirstOrDefault()?.CityData}";
                autoCompleteCity.ActiveFocusControl = null;
            }
        }
        
        /// <summary>
        /// Выбор страны и формирование списка городов (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AutoCompleteControlCountry_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearDataOnSearchByAddressTab("autoCompleteControlCountry");
            SelectCountryAndComplete("autoCompleteControlCountry", "autoCompleteControlCity", args);
        }

        /// <summary>
        /// Выбор города и формирование адресов (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void AutoCompleteControlCity_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearDataOnSearchByAddressTab("autoCompleteControlCity");
            using (var db = new ApplicationContext())
            {
                var cityId = autoCompleteControlCity.AutoComplete.GetItemArray(args.SelectedValue)[0];

                var addresses = AddressCollection.GetAddressCollections(Convert.ToInt32(cityId), chkPrivateHouse.Checked);

                maskNumber = City.GetMaskNumberbyCityId(Convert.ToInt32(cityId));

                autoCompleteControlAddress.AutoComplete.Columns.Clear();
                autoCompleteControlAddress.AutoComplete.DataSource = null;
                autoCompleteControlAddress.AutoComplete.ParentForm = this;

                autoCompleteControlAddress.AutoComplete.DataSource = addresses;
                autoCompleteControlAddress.AutoComplete.RefreshColumns();
                autoCompleteControlAddress.AutoComplete.Columns[1].MatchingColumn = true;
                autoCompleteControlAddress.AutoComplete.Columns[0].Visible = false;
                autoCompleteControlAddress.AutoComplete.Columns[2].Visible = false;

                chkPrivateHouse.Enabled = true;
            }
        }

        /// <summary>
        /// Выбор адреса (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void AutoCompleteControlAddress_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearDataOnSearchByAddressTab("autoCompleteControlAddress");
            if (searchResults.Count == 0)
                UpdateData(new List<NumberPhoneView>());
        }

        /// <summary>
        /// Очистка данных на вкладке Поиск по адресу
        /// </summary>
        /// <param name="autoComplete"></param>
        private void ClearDataOnSearchByAddressTab(string autoComplete)
        {
            switch (autoComplete)
            {
                case "autoCompleteControlCountry":
                    autoCompleteControlCity.TextBox.Text = "";
                    autoCompleteControlCity.AutoComplete.DataSource = null;
                    autoCompleteControlCity.AutoComplete.ResetHistory();
                    chkPrivateHouse.Enabled = false;
                    goto case "autoCompleteControlCity";
                case "autoCompleteControlCity":
                    autoCompleteControlAddress.TextBox.Text = "";
                    autoCompleteControlAddress.AutoComplete.DataSource = null;
                    autoCompleteControlAddress.AutoComplete.ResetHistory();
                    goto case "autoCompleteControlAddress";
                case "autoCompleteControlAddress":
                    rdbAll.Checked = true;
                    txtSingle.Text = "";
                    txtFrom.Text = "";
                    txtTo.Text = "";
                    break;
            }
        }

        /// <summary>
        /// Выбор частных домов для поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPrivateHouse_CheckedChanged(object sender, EventArgs e)
        {
            pnlFilterPrivateHouse.Enabled = chkPrivateHouse.Checked;

            if (chkPrivateHouse.Checked)
            {
                grpApartment.Text = "Дом:";
                grpApartments.Text = "Дома:";
            }
            else
            {
                grpApartment.Text = "Квартира:";
                grpApartments.Text = "Квартиры:";
                rdbAll.Checked = true;
            }

            if (!string.IsNullOrEmpty(autoCompleteControlCity.TextBox.Text))
                autoCompleteControlCity.AutoComplete.SelectedValue = autoCompleteControlCity.TextBox.Text;
        }

        /// <summary>
        /// Поиск телефонных номеров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateEnterData())
            {
                MessageBox.Show("Слишком большой диапазон для поиска! Укажите страну, город и адрес.",
                    "Дополнительная информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var addressId = Convert.ToInt32(autoCompleteControlAddress.AutoComplete.GetItemArray(autoCompleteControlAddress.TextBox.Text)[0]);
            var numberPhones = NumberPhoneView.GetNumberPhonesByAddressId(addressId);

            numberPhones = NumberPhonesFiltered(numberPhones);

            numberPhones.Sort();
            searchResults = new Dictionary<int, List<NumberPhoneView>>();

            searchResults.Add(searchResults.Keys.Count, numberPhones);
            UpdateData();

            if (!CheckEmptyResultData())
            {
                btnAddSearch.Enabled = true;
            }
        }

        /// <summary>
        /// Проверка введенных данных (достаточно ли информации для поиска)
        /// </summary>
        /// <returns></returns>
        private bool ValidateEnterData()
        {
            return string.IsNullOrEmpty(autoCompleteControlCountry.AutoComplete.GetItemArray(autoCompleteControlCountry.TextBox.Text)?.ToString()) ||
                string.IsNullOrEmpty(autoCompleteControlCity.AutoComplete.GetItemArray(autoCompleteControlCity.TextBox.Text)?.ToString()) ||
                string.IsNullOrEmpty(autoCompleteControlAddress.AutoComplete.GetItemArray(autoCompleteControlAddress.TextBox.Text)?.ToString());
        }

        /// <summary>
        /// Применение фильтра на поиска данных
        /// </summary>
        /// <param name="numberPhones"></param>
        /// <returns></returns>
        private List<NumberPhoneView> NumberPhonesFiltered(List<NumberPhoneView> numberPhones)
        {
            if (!string.IsNullOrEmpty(txtSingle.Text))
            {
                numberPhones = numberPhones.Where(n => n.Apartment?.GetNumberApartment() == txtSingle.Text.GetNumberApartment()).ToList();
            }
            if (!string.IsNullOrEmpty(txtFrom.Text))
            {
                numberPhones = numberPhones.Where(n => n.Apartment?.GetNumberApartment() >= txtFrom.Text.GetNumberApartment()).ToList();
            }
            if (!string.IsNullOrEmpty(txtTo.Text))
            {
                numberPhones = numberPhones.Where(n => n.Apartment?.GetNumberApartment() <= txtTo.Text.GetNumberApartment()).ToList();
            }
            if (chkPrivateHouse.Checked)
            {
                if (rdbEven.Checked)
                {
                    numberPhones = numberPhones.Where(n => n.Apartment?.GetNumberApartment() % 2 == 0).ToList();
                }
                if (rdbOdd.Checked)
                {
                    numberPhones = numberPhones.Where(n => n.Apartment?.GetNumberApartment() % 2 != 0).ToList();
                }
            }
            return numberPhones;
        }

        private void txtSingle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSingle.Text))
            {
                grpApartments.Enabled = true;
            }
            else
            {
                grpApartments.Enabled = false;
                txtFrom.Text = "";
                txtTo.Text = "";
            }
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                txtTo.Enabled = false;
                txtTo.Text = "";
                txtSingle.Enabled = true;
            }
            else
            {
                txtTo.Enabled = true;
                txtSingle.Text = "";
                txtSingle.Enabled = false;
            }
        }

        /// <summary>
        /// Добавление адреса к результату поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            if (ValidateEnterData())
            {
                MessageBox.Show("Слишком большой диапазон для поиска! Укажите страну, город и адрес.",
                    "Дополнительная информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var addressId = Convert.ToInt32(autoCompleteControlAddress.AutoComplete.GetItemArray(autoCompleteControlAddress.TextBox.Text)[0]);
            var numberPhones = NumberPhoneView.GetNumberPhonesByAddressId(addressId);

            numberPhones = NumberPhonesFiltered(numberPhones);

            numberPhones.Sort();

            searchResults.Add(searchResults.Keys.Count, numberPhones);

            UpdateData();
        }

        /// <summary>
        /// Проверка на наличие данных в результате поиска
        /// </summary>
        /// <returns></returns>
        private bool CheckEmptyResultData()
        {
            return gridPhones.DataGrid.DataSource == null;
        }

        private void btnClearResultSearch_Click(object sender, EventArgs e)
        {
            searchResults = new Dictionary<int, List<NumberPhoneView>>();
            UpdateData(new List<NumberPhoneView>());
        }

        private void btnListResultAddresses_Click(object sender, EventArgs e)
        {

        }
    }
}
