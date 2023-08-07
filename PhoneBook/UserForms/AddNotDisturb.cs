using PhoneBook.Types;

namespace PhoneBook.UserForms
{
    public partial class AddNotDisturb : Form
    {
        public NotDisturb NotDisturb { get; set; } = new NotDisturb();

        string _address = "";

        public AddNotDisturb(string address)
        {
            InitializeComponent();

            _address = address;
        }

        private void AddNotDisturb_Load(object sender, EventArgs e)
        {
            lblAddress.Text = $"{_address}";

            if (NotDisturb.Id != 0)
            {
                chkNotCall.Checked = NotDisturb.NotCall;
                chkNotEnter.Checked = NotDisturb.NotEnter;
                txtNote.Text = NotDisturb.Notes;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkNotCall.Checked && !chkNotEnter.Checked)
            {
                MessageBox.Show("Вы не указали \"Не звонить\" или \"Не заходить\".", "Добавить \"Не беспокоить\"",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NotDisturb.NotCall = chkNotCall.Checked;
                NotDisturb.NotEnter = chkNotEnter.Checked;
                NotDisturb.Notes = txtNote.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
