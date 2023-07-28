using PhoneBook.Types;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneBook.UserControls
{
    public partial class TypeStreetControl : UserControl
    {
        public TextBox TypeStreetTextBox => autoCompleteControlTypeStreet.TextBox;

        public TypeStreetControl()
        {
            InitializeComponent();
            autoCompleteControlTypeStreet.TextBox.CharacterCasing = CharacterCasing.Lower;
        }

        public void LoadTypeStreet()
        {
            using (var db = new ApplicationContext())
            {
                var typeStreets = db.TypeStreet.ToList();

                autoCompleteControlTypeStreet.AutoComplete.Columns.Clear();
                autoCompleteControlTypeStreet.AutoComplete.DataSource = null;

                autoCompleteControlTypeStreet.AutoComplete.ParentForm = this;
                autoCompleteControlTypeStreet.AutoComplete.DataSource = typeStreets;
                autoCompleteControlTypeStreet.AutoComplete.RefreshColumns();
                autoCompleteControlTypeStreet.AutoComplete.Columns[1].MatchingColumn = true;
                autoCompleteControlTypeStreet.AutoComplete.Columns[0].Visible = false;
                autoCompleteControlTypeStreet.AutoComplete.Columns[2].Visible = false;
            }  
        }

        public void SetTypeStreetInTextBox(string typeStreet)
        {
            autoCompleteControlTypeStreet.AutoComplete.ActiveFocusControl = autoCompleteControlTypeStreet.TextBox;
            autoCompleteControlTypeStreet.AutoComplete.SelectedValue = $"{typeStreet}";
            autoCompleteControlTypeStreet.AutoComplete.ActiveFocusControl = null;
        }

        public int GetTypeStreetIdFromAutoComplete()
        {
            return Convert.ToInt32(autoCompleteControlTypeStreet.AutoComplete.GetItemArray(autoCompleteControlTypeStreet.TextBox.Text)[0]);
        }

        public object GetAutoCompleteTypeStreet()
        {
            return autoCompleteControlTypeStreet.AutoComplete.GetItemArray(autoCompleteControlTypeStreet.TextBox.Text);
        }

        public void SelectTypeStreet(string typeStreet)
        {
            autoCompleteControlTypeStreet.AutoComplete.SelectedValue = typeStreet;
        }
    }
}
