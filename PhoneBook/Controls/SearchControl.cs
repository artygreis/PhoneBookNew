using PhoneBook.Services;
using PhoneBook.Types;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid;
using System.Data;
using System.Text.RegularExpressions;

namespace PhoneBook.Controls
{
    public partial class SearchControl : UserControl
    {
        //Маска номеров
        private string _maskNumber = "";

        private Dictionary<int, List<NumberPhoneView>> searchResults = new Dictionary<int, List<NumberPhoneView>>();
        public SearchControl()
        {
            InitializeComponent();

            gridPhones.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            gridPhones.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Any;

            countryControlSearchByAddress.CountryChanged += CountryControlSearchByAddress_CountryChanged;
            cityControlSearchByAddress.CityChanged += CityControlSearchByAddress_CityChanged;
            addressControlSearchByAddress.AddressChanged += AddressControlSearchByAddress_AddressChanged;

            gridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            gridPhones.DataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

            saveFileDialog.Filter = "Pdf files(*.pdf)|*.pdf";
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
            if (e.Column.MappingName == "Number" && !string.IsNullOrEmpty(_maskNumber))
            {
                e.Column = new GridMaskColumn() { MappingName = "Number", HeaderText = "Номер телефона", Mask = _maskNumber };
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
            gridPhones.DataGrid.Columns["StreetName"].AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            gridPhones.DataGrid.Columns["House"].Width = 70;
            gridPhones.DataGrid.Columns["House"].Visible = !chkPrivateHouse.Checked;
            gridPhones.DataGrid.Columns["Apartment"].Width = 70;
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
            gridPhones.DataGrid.Columns["StreetName"].AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            gridPhones.DataGrid.Columns["House"].Width = 70;
            gridPhones.DataGrid.Columns["House"].Visible = !chkPrivateHouse.Checked;
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
                countryControlSearchByAddress.LoadCountry();
            }
            //if (tabControlAdv.SelectedTab.Name == "searchNotCallTab")
            //{
            //    LoadDataToCountry(autoCompleteCountryNotCall, textBoxCountryNotCall);
            //}
        }

        /// <summary>
        /// Выбор страны и формирование списка городов (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="countryId"></param>
        private void CountryControlSearchByAddress_CountryChanged(int countryId)
        {
            ClearDataOnSearchByAddressTab("CountryControl");
            cityControlSearchByAddress.LoadCity(countryId);
        }

        /// <summary>
        /// Выбор города и формирование адресов (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="cityId"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void CityControlSearchByAddress_CityChanged(int cityId)
        {
            ClearDataOnSearchByAddressTab("CityControl");

            _maskNumber = City.GetMaskNumberbyCityId(cityId);

            addressControlSearchByAddress.LoadAddress(cityId, chkPrivateHouse.Checked);

            chkPrivateHouse.Enabled = true;
        }

        /// <summary>
        /// Выбор адреса (вкладка Поиск по адресу)
        /// </summary>
        /// <param name="addressId"></param>
        private void AddressControlSearchByAddress_AddressChanged(int addressId)
        {
            ClearDataOnSearchByAddressTab("AddressControl");
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
                case "CountryControl":
                    cityControlSearchByAddress.ClearDataCity();
                    chkPrivateHouse.Enabled = false;
                    goto case "CityControl";
                case "CityControl":
                    addressControlSearchByAddress.ClearDataAddress();
                    goto case "AddressControl";
                case "AddressControl":
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

            if (!string.IsNullOrEmpty(cityControlSearchByAddress.GetTextCity()))
                cityControlSearchByAddress.SelectCity(cityControlSearchByAddress.GetCityId());
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

            var addressId = addressControlSearchByAddress.GetAddressId();
            var numberPhones = NumberPhoneView.GetNumberPhonesByAddressId(addressId);

            numberPhones = NumberPhonesFiltered(numberPhones);

            numberPhones.Sort();
            searchResults = new Dictionary<int, List<NumberPhoneView>>();

            searchResults.Add(searchResults.Keys.Count, numberPhones);
            UpdateData();

            //if (!CheckEmptyResultData())
            //{
            //    btnAddSearch.Enabled = true;
            //}
        }

        /// <summary>
        /// Проверка введенных данных (достаточно ли информации для поиска)
        /// </summary>
        /// <returns></returns>
        private bool ValidateEnterData()
        {
            return string.IsNullOrEmpty(countryControlSearchByAddress.GetTextCountry()) ||
                string.IsNullOrEmpty(cityControlSearchByAddress.GetTextCity()) ||
                string.IsNullOrEmpty(addressControlSearchByAddress.GetTextAddress());
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
        /// Экспорт результата в pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            var numberPhones = gridPhones.DataGrid.DataSource as List<NumberPhoneView>;

            var listNotCall = new List<int>();

            if (numberPhones != null)
            {
                if (numberPhones.Count < 2)
                {
                    MessageBox.Show("Нет данных для экспорта", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Create a new PDF document.
                PdfDocument doc = new PdfDocument();
                doc.PageSettings.Margins.All = 15;

                //Add a page.
                PdfPage page = doc.Pages.Add();
                //Create a PdfGrid.
                PdfGrid pdfGrid = new PdfGrid();

                //Create a DataTable.
                DataTable dataTable = new DataTable();
                //Add columns to the DataTable
                dataTable.Columns.Add("Нас. пункт");
                dataTable.Columns.Add("Адрес");
                dataTable.Columns.Add("Дом");
                dataTable.Columns.Add("Кв.");
                dataTable.Columns.Add("Номер телефона");
                //Add rows to the DataTable.
                foreach (var numberPhone in numberPhones)
                {

                    dataTable.Rows.Add(new object[]
                    {
                    numberPhone.Locality ?? "",
                    numberPhone.TypeName + " "+ numberPhone.StreetName,
                    numberPhone.House ?? "",
                    numberPhone.Apartment ?? "",
                    string.IsNullOrEmpty(numberPhone.Number) ? "" : string.Format("{0:"+ _maskNumber +"}", Convert.ToInt64(numberPhone.Number))
                    });

                    Regex regex = new Regex(@"[^0-9]");
                    var currentNumber = regex.Replace(numberPhone.Number ?? "", "");
                    //TODO: Реализовать работу с теми, куда не звонить
                    //using (var db = new ApplicationContext())
                    //{
                    //    var notCallCount = db.NotCall.Where(n => n.Number == currentNumber && n.CityId == Convert.ToInt32(autoCompleteCity.GetItemArray(textBoxCity.Text)[0])).Count();
                    //    if (notCallCount > 0)
                    //    {
                    //        listNotCall.Add(dataTable.Rows.Count - 1);
                    //    }
                    //}
                }

                //Assign data source.
                pdfGrid.DataSource = dataTable;
                pdfGrid.Columns[0].Width = 150;
                pdfGrid.Columns[2].Width = 50;
                pdfGrid.Columns[3].Width = 50;
                pdfGrid.Columns[4].Width = 100;
                for (int i = 0; i < pdfGrid.Columns.Count; i++)
                {
                    pdfGrid.Columns[i].Format = new PdfStringFormat() { Alignment = PdfTextAlignment.Center, LineAlignment = PdfVerticalAlignment.Middle };

                }

                PdfGridRowStyle pdfGridRowStyle = new PdfGridRowStyle();
                pdfGridRowStyle.BackgroundBrush = PdfBrushes.IndianRed;
                foreach (var row in listNotCall)
                {
                    pdfGrid.Rows[row].Style = pdfGridRowStyle;
                }

                //Creates the grid cell styles
                PdfGridRow header = pdfGrid.Headers[0];
                //Creates the header style
                PdfGridCellStyle headerStyle = new PdfGridCellStyle();
                headerStyle.Borders.All = PdfPens.Black;
                headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(0, 71, 160));
                headerStyle.TextBrush = PdfBrushes.White;
                headerStyle.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 14, FontStyle.Bold), true);
                //Adds cell customizations
                for (int i = 0; i < header.Cells.Count; i++)
                {
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                }
                //Applies the header style
                header.ApplyStyle(headerStyle);

                PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                cellStyle.Borders.All = PdfPens.Black;
                cellStyle.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
                cellStyle.TextBrush = PdfBrushes.Black;
                pdfGrid.Rows.ApplyStyle(cellStyle);

                //Draw grid to the page of PDF document.
                pdfGrid.Draw(page, new PointF(10, 10));
                saveFileDialog.FileName = addressControlSearchByAddress.GetTextAddress();
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog.FileName;
                //Save the document.
                doc.Save(filename);
                //close the document
                doc.Close(true);
                MessageBox.Show("Файл успешно сохранен", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
