using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class LocalityControl : UserControl
    {
        public TextBox LocalityTextBox => autoCompleteControlLocality.TextBox;
        public LocalityControl()
        {
            InitializeComponent();
        }

        public void LoadLocality(List<AddressEdit> addresses)
        {
            autoCompleteControlLocality.AutoComplete.Columns.Clear();
            autoCompleteControlLocality.AutoComplete.DataSource = null;

            autoCompleteControlLocality.AutoComplete.ParentForm = this;
            autoCompleteControlLocality.AutoComplete.DataSource = addresses.Where(a => !string.IsNullOrEmpty(a.Locality)).Select(a => a.Locality).Distinct().ToList();
            autoCompleteControlLocality.AutoComplete.RefreshColumns();
            autoCompleteControlLocality.AutoComplete.Columns[0].MatchingColumn = true;
        }

        public void SetLocalityInTextBox(string locality)
        {
            autoCompleteControlLocality.AutoComplete.ActiveFocusControl = autoCompleteControlLocality.TextBox;
            autoCompleteControlLocality.AutoComplete.SelectedValue = $"{locality}";
            autoCompleteControlLocality.AutoComplete.ActiveFocusControl = null;
        }
    }
}
