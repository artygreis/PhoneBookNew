using Microsoft.EntityFrameworkCore;
using PhoneBook.Types.Settings;
using System.Configuration;

namespace PhoneBook.UserForms
{
    public partial class DataBaseSettings : Form
    {
        readonly string DefaultPath = Path.GetFullPath(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", @".."));

        public DataBaseSettings()
        {
            InitializeComponent();
            openFileDialog.Filter = "DB files(*.db)|*.db";
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleSettings.ReleaseCapture();
            TitleSettings.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var settings = Settings.Load();

            if (settings == null || string.IsNullOrEmpty(settings.UserSourceDb))
            {
                var dialog = MessageBox.Show($"Прекратить первоначальную настройку справочника?\n" +
                $"Дальнейшая работа с программой будет некорректной.", "Предупреждение",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                    DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Выбор папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            errorValidating.Clear();
            textBoxSourceDb.Text = folderBrowserDialog.SelectedPath;
        }

        /// <summary>
        /// Поиск файла справочника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            errorValidating.Clear();
            textBoxSourceFile.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Обработка переключателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDefault.Enabled = false;
            btnChangeFolder.Enabled = false;
            textBoxSourceDb.Enabled = false;
            textBoxSourceFile.Enabled = false;
            btnSearchFile.Enabled = false;
            errorValidating.Clear();
            var radioButton = (RadioButton)sender;
            if (radioButton.Name == "rdbNew")
            {
                textBoxSourceDb.Enabled = true;
                checkBoxDefault.Enabled = true;
                checkBoxDefault_CheckedChanged(checkBoxDefault, new EventArgs());
            }
            if (radioButton.Name == "rdbExist")
            {
                textBoxSourceFile.Enabled = true;
                btnSearchFile.Enabled = true;
            }
        }

        /// <summary>
        /// Установка пути по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
        {
            btnChangeFolder.Enabled = false;
            if (!checkBoxDefault.Checked)
            {
                btnChangeFolder.Enabled = true;
            }
            if (checkBoxDefault.Checked)
                textBoxSourceDb.Text = DefaultPath;
        }

        /// <summary>
        /// Проврека информации для настройки
        /// </summary>
        /// <returns></returns>
        private bool ValidatingData()
        {
            errorValidating.Clear();
            if (rdbNew.Checked && checkBoxDefault.Checked)
            {
                var dialog = MessageBox.Show($"При использовании пути к базе данных по умолчанию, при удалении приложения " +
                    $"будет удалена и сама база данных (телефонный справочник). Продолжить?", "Предупреждение",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Cancel)
                    return false;
            }
            return CheckSourceData();
        }
        /// <summary>
        /// Проверка путей к папке или файлу
        /// </summary>
        /// <returns></returns>
        private bool CheckSourceData()
        {
            if (!Directory.Exists(textBoxSourceDb.Text))
            {
                errorValidating.SetError(textBoxSourceDb, "Проверьте указанный путь.");
                errorValidating.SetIconAlignment(textBoxSourceDb, ErrorIconAlignment.MiddleLeft);
                errorValidating.SetIconPadding(textBoxSourceDb, 4);
                return false;
            }
            if (rdbExist.Checked)
            {
                if (!File.Exists(textBoxSourceFile.Text))
                {
                    errorValidating.SetError(textBoxSourceFile, "Не найден файл.");
                    errorValidating.SetIconAlignment(textBoxSourceFile, ErrorIconAlignment.MiddleLeft);
                    errorValidating.SetIconPadding(textBoxSourceFile, 4);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Сохранение пользовательских настроек
        /// </summary>
        private bool SaveUserSettings()
        {
            var settings = Settings.Load();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (rdbExist.Checked)
                settings.UserSourceDb = $"{textBoxSourceFile.Text}";
            if (rdbNew.Checked)
                settings.UserSourceDb = $"{textBoxSourceDb.Text}\\{GetNameFile(config.AppSettings.Settings["DefaultFileNameDb"].Value)}";

            if (string.IsNullOrEmpty(settings.ColorNotCall))
            {
                settings.ColorNotCall = ColorSettings.GetDefaultColorNotCall.ToKnownColor().ToString();
            }
            if (string.IsNullOrEmpty(settings.ColorNotDoor))
            {
                settings.ColorNotDoor = ColorSettings.GetDefaultColorNotDoor.ToKnownColor().ToString();
            }
            if (string.IsNullOrEmpty(settings.ColorNotFull))
            {
                settings.ColorNotFull = ColorSettings.GetDefaultColorNotFull.ToKnownColor().ToString();
            }
            settings.Save();
            using (var db = new ApplicationContext())
            {
                try
                {
                    DbInitializer.InitializeDb();
                    db.Database.OpenConnection();
                    db.Database.CloseConnection();
                    return true;
                }
                catch
                {
                    Settings.DeleteFileSettings();
                    MessageBox.Show("Возникла непредвиденная ошибка! Файл с настройками не был сохранен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        /// Формирование имению файла БД (справочника)
        /// </summary>
        /// <param name="defaultName"></param>
        /// <returns></returns>
        private string GetNameFile(string defaultName)
        {
            var listFiles = Directory.GetFiles(textBoxSourceDb.Text).Select(f => Path.GetFileName(f)).ToList();
            int count = 1;
            while (true)
            {
                if (listFiles.Contains(defaultName))
                {
                    defaultName = defaultName.Substring(0, defaultName.LastIndexOf('.')) + count + ".db";
                    count++;
                }
                else
                {
                    return defaultName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidatingData()) return;

            if (!SaveUserSettings()) return;

            DialogResult = DialogResult.OK;
        }

        private void DataBaseSettings_Load(object sender, EventArgs e)
        {
            //textBoxSourceDb.Text = DefaultPath;
            radioButton_CheckedChanged(rdbNew, new EventArgs());
        }
    }
}
