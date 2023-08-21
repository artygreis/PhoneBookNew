using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class CityControl : UserControl
    {
        public event Action<int>? CityChanged;

        public CityControl()
        {
            InitializeComponent();

            autoCompleteControlCity.AutoCompleteItemSelected += AutoCompleteControlCity_AutoCompleteItemSelected;
        }

        private void AutoCompleteControlCity_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
        {
            var cityId = autoCompleteControlCity.AutoComplete.GetItemArray(args.SelectedValue)[0];
            CityChanged?.Invoke(Convert.ToInt32(cityId));
        }

        public void LoadCity(int countryId)
        {
            var cities = CityCollection.GetCityCollections(countryId);

            autoCompleteControlCity.AutoComplete.Columns.Clear();
            autoCompleteControlCity.AutoComplete.DataSource = null;

            autoCompleteControlCity.AutoComplete.ParentForm = this;
            autoCompleteControlCity.AutoComplete.DataSource = cities;
            autoCompleteControlCity.AutoComplete.RefreshColumns();
            autoCompleteControlCity.AutoComplete.Columns[1].MatchingColumn = true;
            autoCompleteControlCity.AutoComplete.Columns[0].Visible = false;

            if (cities.Count == 1)
            {
                autoCompleteControlCity.AutoComplete.ActiveFocusControl = autoCompleteControlCity.TextBox;
                autoCompleteControlCity.AutoComplete.SelectedValue = $"{cities.FirstOrDefault()?.CityData}";
                autoCompleteControlCity.AutoComplete.ActiveFocusControl = null;
            }
        }

        public void ClearDataCity()
        {
            autoCompleteControlCity.TextBox.Text = "";
            autoCompleteControlCity.AutoComplete.DataSource = null;
            autoCompleteControlCity.AutoComplete.ResetHistory();
        }

        public string GetTextCity()
        {
            return autoCompleteControlCity.TextBox.Text;
        }

        public int GetCityId()
        {
            return Convert.ToInt32(autoCompleteControlCity.AutoComplete.GetItemArray(autoCompleteControlCity.TextBox.Text)[0]);
        }

        public void SelectCity(int cityId)
        {
            autoCompleteControlCity.AutoComplete.ActiveFocusControl = autoCompleteControlCity.TextBox;
            autoCompleteControlCity.AutoComplete.SelectedValue = autoCompleteControlCity.TextBox.Text;
            autoCompleteControlCity.AutoComplete.ActiveFocusControl = null;
            CityChanged?.Invoke(Convert.ToInt32(cityId));
        }

        public void ChangeWidthTextBox(int width)
        {
            if (width > 0)
                autoCompleteControlCity.Width += width;
        }
    }
}
