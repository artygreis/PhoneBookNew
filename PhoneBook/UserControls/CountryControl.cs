using PhoneBook.Services;
using PhoneBook.Types;
using System.Data;
namespace PhoneBook.UserControls
{
    public partial class CountryControl : UserControl
    {

        public event Action<int>? CountryChanged;

        public CountryControl()
        {
            InitializeComponent();

            autoCompleteControlCountry.AutoCompleteItemSelected += AutoCompleteControlCountry_AutoCompleteItemSelected;
        }

        private void AutoCompleteControlCountry_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
        {
            var countryId = autoCompleteControlCountry.AutoComplete.GetItemArray(args.SelectedValue)[0];
            CountryChanged?.Invoke(Convert.ToInt32(countryId));
        }

        public void LoadCountry()
        {
            if (!DesignMode)
            {
                using (var db = new ApplicationContext())
                {
                    var countries = db.Country
                        .Select(c => new CountryCollection() { Id = c.Id, CountryData = $"{c.CountryName} ({c.CountryCode})" })
                        .ToList();

                    autoCompleteControlCountry.AutoComplete.Columns.Clear();
                    autoCompleteControlCountry.AutoComplete.DataSource = null;

                    autoCompleteControlCountry.AutoComplete.ParentForm = this;
                    autoCompleteControlCountry.AutoComplete.DataSource = countries;
                    autoCompleteControlCountry.AutoComplete.RefreshColumns();
                    autoCompleteControlCountry.AutoComplete.Columns[1].MatchingColumn = true;
                    autoCompleteControlCountry.AutoComplete.Columns[0].Visible = false;

                    if (countries.Count == 1)
                    {
                        autoCompleteControlCountry.AutoComplete.ActiveFocusControl = autoCompleteControlCountry.TextBox;
                        autoCompleteControlCountry.AutoComplete.SelectedValue = $"{countries?.FirstOrDefault()?.CountryData}";
                        autoCompleteControlCountry.AutoComplete.ActiveFocusControl = null;
                    }
                }
            }
        }

        public void ClearDataCountry()
        {
            autoCompleteControlCountry.TextBox.Text = "";
            autoCompleteControlCountry.AutoComplete.DataSource = null;
            autoCompleteControlCountry.AutoComplete.ResetHistory();
        }

        public int GetCountryId()
        {
            return Convert.ToInt32(autoCompleteControlCountry.AutoComplete.GetItemArray(autoCompleteControlCountry.TextBox.Text)[0]);
        }

        public string GetTextCountry()
        {
            return autoCompleteControlCountry.TextBox.Text;
        }

        public void ChangeWidthTextBox(int width)
        {
            if (width > 0)
                autoCompleteControlCountry.Width += width;
        }
    }
}
