using PhoneBook.Types;
using System.Security.Cryptography.X509Certificates;

namespace PhoneBook.UserControls
{
    public partial class StreetNameControl : UserControl
    {
        public TextBox StreetNameTextBox => autoCompleteControlStreetName.TextBox;

        public StreetNameControl()
        {
            InitializeComponent();
        }

        public void LoadStreetName(List<AddressEdit> addresses)
        {
            autoCompleteControlStreetName.AutoComplete.Columns.Clear();
            autoCompleteControlStreetName.AutoComplete.DataSource = null;

            autoCompleteControlStreetName.AutoComplete.ParentForm = this;
            autoCompleteControlStreetName.AutoComplete.DataSource = addresses.Select(a => a.StreetName).Distinct().ToList();
            autoCompleteControlStreetName.AutoComplete.RefreshColumns();
            autoCompleteControlStreetName.AutoComplete.Columns[0].MatchingColumn = true;
        }

        public void SetStreetNameInTextBox(string streetName)
        {
            autoCompleteControlStreetName.AutoComplete.ActiveFocusControl = autoCompleteControlStreetName.TextBox;
            autoCompleteControlStreetName.AutoComplete.SelectedValue = $"{streetName}";
            autoCompleteControlStreetName.AutoComplete.ActiveFocusControl = null;
        }
    }
}
