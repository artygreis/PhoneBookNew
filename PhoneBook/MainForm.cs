using PhoneBook.Controls;
using PhoneBook.Types.Settings;
using PhoneBook.UserForms;
using Squirrel;
using System.Reflection;

namespace PhoneBook
{
    public partial class MainForm : Form
    {

        private bool availableUpdate = false;

        public MainForm()
        {
            InitializeComponent();

            AddVersionNumber();
            btnSearch.GotFocus += Button_GotFocus;
            btnAdd.GotFocus += Button_GotFocus;
            btnSettings.GotFocus += Button_GotFocus;

            if (!CheckExistDb())
            {
                var settingsForm = new DataBaseSettings();
                settingsForm.ShowDialog();
            }

#if (!DEBUG)
            UpdateMyApp();
#endif

            btnSearch_Click(btnSearch, new EventArgs());
        }

        /// <summary>
        /// Проверка существования БД
        /// </summary>
        /// <returns></returns>
        private bool CheckExistDb()
        {
            var settings = Settings.Load();

            if (settings == null || string.IsNullOrEmpty(settings?.UserSourceDb ?? "") || !File.Exists(settings?.UserSourceDb))
                return false;

            return true;
        }

        private async Task UpdateMyApp()
        {
            using var mgr = new UpdateManager("https://github.com/artygreis/PhoneBookNew/releases/latest");
            var newVersion = await mgr.UpdateApp();
            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                SettingsPicture.AddTextToPicture(btnSettings);
                availableUpdate = true;
            }
        }

        /// <summary>
        /// Обработка события для снятия фокуса с кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GotFocus(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.NotifyDefault(false);
            }
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleSettings.ReleaseCapture();
            TitleSettings.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Получение версии программы
        /// </summary>
        private void AddVersionNumber()
        {
            lblCaption.Text += $" v.{Assembly.GetEntryAssembly()?.GetName().Version?.ToString().Substring(0, 5) ?? "?"}";
        }

        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(c);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSearch);
            if (CheckExistDb())
                AddControlToPanel(new SearchControl());
            else
                AddControlToPanel(new ErrorConnectControl());
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btnAdd);
            if (CheckExistDb())
                AddControlToPanel(new AddControl());
            else
                AddControlToPanel(new ErrorConnectControl());
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(btnSettings);
                AddControlToPanel(new SettingsControl(btnSettings, availableUpdate));
        }
    }
}