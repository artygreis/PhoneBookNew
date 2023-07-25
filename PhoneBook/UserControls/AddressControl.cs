using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        public void LoadAddress(int cityId, bool privatehouse)
        {
            var addresses = AddressCollection.GetAddressCollections(cityId, privatehouse);

            autoCompleteControlAddress.AutoComplete.Columns.Clear();
            autoCompleteControlAddress.AutoComplete.DataSource = null;
            autoCompleteControlAddress.AutoComplete.ParentForm = this;

            autoCompleteControlAddress.AutoComplete.DataSource = addresses;
            autoCompleteControlAddress.AutoComplete.RefreshColumns();
            autoCompleteControlAddress.AutoComplete.Columns[1].MatchingColumn = true;
            autoCompleteControlAddress.AutoComplete.Columns[0].Visible = false;
            autoCompleteControlAddress.AutoComplete.Columns[2].Visible = false;
        }

        public void ClearDataAddress()
        {
            autoCompleteControlAddress.TextBox.Text = "";
            autoCompleteControlAddress.AutoComplete.DataSource = null;
            autoCompleteControlAddress.AutoComplete.ResetHistory();
        }
    }
}
