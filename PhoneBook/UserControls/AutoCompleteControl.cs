using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.UserControls
{
    public partial class AutoCompleteControl : UserControl
    {
        //public List<AutoCompleteData> Datas { get; set; } = new List<AutoCompleteData>();
        public event AutoCompleteItemEventHandler? AutoCompleteItemSelected;
        public Font TextBoxFont 
        { 
            get => txtContent.Font; 
            set => txtContent.Font = value; 
        }
        public AutoComplete AutoComplete 
        { 
            get => autoComplete; 
        }
        public TextBox TextBox
        {
            get => txtContent;
        }
        public AutoCompleteControl()
        {
            InitializeComponent();
            autoComplete.SetAutoComplete(this.txtContent, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
            autoComplete.ShowColumnHeader = false;
            autoComplete.ShowCloseButton= false;
            autoComplete.ShowGripper= false;
            autoComplete.TextColor = Color.Black;
            autoComplete.ItemFont = new Font("Century Gothic", 10.25F);
        }

        private void AutoCompleteControl_Load(object sender, EventArgs e)
        {

        }

        private void AutoCompleteControl_Resize(object sender, EventArgs e)
        {
            this.Height = txtContent.Height;
        }

        private void txtContent_Resize(object sender, EventArgs e)
        {
            this.Height = txtContent.Height;
        }

        private void autoComplete_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            AutoCompleteItemSelected?.Invoke(sender, args);
        }
    }
}
