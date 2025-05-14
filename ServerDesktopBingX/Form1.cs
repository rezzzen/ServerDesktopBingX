
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using System.IO.Compression;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Linq.Expressions;
using ServerDesktopBingX.Controls;
using MongoDB.Driver;
using MongoDB.Bson;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO.Compression;
using static System.Collections.Specialized.BitVector32;
using MongoDB.Driver.Core.Configuration;
using System.Text;
using System.Reflection;




namespace ServerDesktopBingX
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            InitializeBackupSystem();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            UpdateDateTimeAsync();
            //TB_KEY.Text = "w1RI3Q6HD5Q5Xu2bphWC6G1YnKRl6xR6pZvlbbWhGIxc68yhHg8B6pIwoWd8nrxyYPxpLydOPrsDWz0KAVHBw";
            //TB_SECRET.Text = "O7bPmfWDsIrEn5NO4mE0kNSjVQMj7P66NzJPrI1TjN1HoA9hDLCrtgBKleU5KGwt5XhwH9z8coLUz6vSg";
            //TB_DBNAME.Text = "CDA";
            //TB_LOCALHOST.Text = "27017";


            L_VERSION.Text = "14.05.2025";
            string API_KEY = TB_KEY.Text;
            string API_SECRET = TB_SECRET.Text;
            string HOST = "open-api.bingx.com";


            LogTelegramBot.Initialize(L_LOG_TELEGRAM);
            NotificationTelegramBot.Initialize(L_LOG_TELEGRAM);


            async Task UpdateDateTimeAsync()
            {
                while (true) // Безопасный цикл благодаря await
                {
                    // Обновление UI через Invoke (если метод вызывается из другого потока)
                    if (L_DATE.InvokeRequired)
                    {
                        L_DATE.Invoke((Action)(() =>
                            L_DATE.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")));
                    }
                    else
                    {
                        L_DATE.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                    }

                    await Task.Delay(1000); // Не блокирует поток
                }
            }

            SW_LANGUAGE.Checked = Properties.Settings.Default.SW_LANGUAGE;

            if (SW_LANGUAGE.Checked)
            {
                L_BINGX_STATUS.Text = "Stopped";
                L_STATUS_LCO.Text = "Stopped";
                L_STATUS_G.Text = "Stopped";
                L_STATUS_S.Text = "Stopped";
                L_STATUS_ADD1.Text = "Stopped";
                L_STATUS_ADD2.Text = "Stopped";
            }
            else
            {
                L_BINGX_STATUS.Text = "Остановлено";
                L_STATUS_LCO.Text = "Остановлено";
                L_STATUS_G.Text = "Остановлено";
                L_STATUS_S.Text = "Остановлено";
                L_STATUS_ADD1.Text = "Остановлено";
                L_STATUS_ADD2.Text = "Остановлено";
            }


            if (true)
            {
                SW_MAIN.Checked = Properties.Settings.Default.SW_MAIN;
                
                if (SW_MAIN.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_BINGX_STATUS.Text = "Connecting...";
                    }
                    else
                    {
                        L_BINGX_STATUS.Text = "Подключение...";
                    }
                    L_BINGX_STATUS.ForeColor = System.Drawing.Color.DarkOrange;
                }

                SW_LCO.Checked = Properties.Settings.Default.SW_LCO;
                if (SW_LCO.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_LCO.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_LCO.Text = "Подключение...";
                    }
                    L_STATUS_LCO.ForeColor = System.Drawing.Color.DarkOrange;
                }
                SW_DB_LCO.Checked = Properties.Settings.Default.SW_DB_LCO;

                SW_G.Checked = Properties.Settings.Default.SW_G;
                if (SW_G.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_G.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_G.Text = "Подключение...";
                    }
                    L_STATUS_G.ForeColor = System.Drawing.Color.DarkOrange;
                }
                SW_DB_G.Checked = Properties.Settings.Default.SW_DB_G;

                SW_S.Checked = Properties.Settings.Default.SW_S;
                if (SW_S.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_S.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_S.Text = "Подключение...";
                    }
                    L_STATUS_S.ForeColor = System.Drawing.Color.DarkOrange;
                }
                SW_DB_S.Checked = Properties.Settings.Default.SW_DB_S;

                if (Properties.Settings.Default.TB_NAME_ADD1 != "")
                {
                    TB_NAME_ADD1.Text = Properties.Settings.Default.TB_NAME_ADD1;
                    SW_ADD1.Checked = Properties.Settings.Default.SW_ADD1;
                    if (SW_ADD1.Checked == true)
                    {
                        if (SW_LANGUAGE.Checked)
                        {
                            L_STATUS_ADD1.Text = "Connecting...";
                        }
                        else
                        {
                            L_STATUS_ADD1.Text = "Подключение...";
                        }
                        L_STATUS_ADD1.ForeColor = System.Drawing.Color.DarkOrange;
                    }
                    SW_DB_ADD1.Checked = Properties.Settings.Default.SW_DB_ADD1;
                }

                if (Properties.Settings.Default.TB_NAME_ADD2 != "")
                {
                    TB_NAME_ADD2.Text = Properties.Settings.Default.TB_NAME_ADD2;
                    SW_ADD2.Checked = Properties.Settings.Default.SW_ADD2;
                    if (SW_ADD1.Checked == true)
                    {
                        if (SW_LANGUAGE.Checked)
                        {
                            L_STATUS_ADD2.Text = "Connecting...";
                        }
                        else
                        {
                            L_STATUS_ADD2.Text = "Подключение...";
                        }
                        L_STATUS_ADD2.ForeColor = System.Drawing.Color.DarkOrange;
                    }
                    SW_DB_ADD2.Checked = Properties.Settings.Default.SW_DB_ADD2;
                }

                if (Properties.Settings.Default.TB_KEY != "")
                    TB_KEY.Text = Properties.Settings.Default.TB_KEY;
                if (Properties.Settings.Default.TB_SECRET != "")
                    TB_SECRET.Text = Properties.Settings.Default.TB_SECRET;
                if (Properties.Settings.Default.TB_DBNAME != "")
                    TB_DBNAME.Text = Properties.Settings.Default.TB_DBNAME;
                else
                    TB_DBNAME.Text = "CDA";
                if (Properties.Settings.Default.TB_LOCALHOST != "")
                    TB_LOCALHOST.Text = Properties.Settings.Default.TB_LOCALHOST;
                else
                    TB_LOCALHOST.Text = "27017";

                if (Properties.Settings.Default.TB_NOT_BOT_TELEGRAM_TOKEN != "")
                    TB_NOT_BOT_TELEGRAM_TOKEN.Text = Properties.Settings.Default.TB_NOT_BOT_TELEGRAM_TOKEN;

                if (Properties.Settings.Default.TB_LOG_BOT_TELEGRAM_TOKEN != "")
                    TB_LOG_BOT_TELEGRAM_TOKEN.Text = Properties.Settings.Default.TB_LOG_BOT_TELEGRAM_TOKEN;

                SW_NOT_BOT_TELEGRAM.Checked = Properties.Settings.Default.SW_NOT_BOT_TELEGRAM;
                SW_LOG_BOT_TELEGRAM.Checked = Properties.Settings.Default.SW_LOG_BOT_TELEGRAM;

                SW_NOT_CHANGE_LCO.Checked = Properties.Settings.Default.SW_NOT_CHANGE_LCO;
                SW_NOT_CHANGE_G.Checked = Properties.Settings.Default.SW_NOT_CHANGE_G;
                SW_NOT_CHANGE_S.Checked = Properties.Settings.Default.SW_NOT_CHANGE_S;
                SW_NOT_CHANGE_ADD1.Checked = Properties.Settings.Default.SW_NOT_CHANGE_ADD1;
                SW_NOT_CHANGE_ADD2.Checked = Properties.Settings.Default.SW_NOT_CHANGE_ADD2;


                SW_LOG_LCO.Checked = Properties.Settings.Default.SW_LOG_LCO;
                SW_LOG_G.Checked = Properties.Settings.Default.SW_LOG_G;
                SW_LOG_S.Checked = Properties.Settings.Default.SW_LOG_S;
                SW_LOG_ADD1.Checked = Properties.Settings.Default.SW_LOG_ADD1;
                SW_LOG_ADD2.Checked = Properties.Settings.Default.SW_LOG_ADD2;


                UD_NOT_CHANGE_LCO.Value = Properties.Settings.Default.UD_NOT_CHANGE_LCO;
                UD_NOT_CHANGE_G.Value = Properties.Settings.Default.UD_NOT_CHANGE_G;
                UD_NOT_CHANGE_S.Value = Properties.Settings.Default.UD_NOT_CHANGE_S;
                UD_NOT_CHANGE_ADD1.Value = Properties.Settings.Default.UD_NOT_CHANGE_ADD1;
                UD_NOT_CHANGE_ADD2.Value = Properties.Settings.Default.UD_NOT_CHANGE_ADD2;

                SW_BACKUP.Checked = Properties.Settings.Default.SW_BACKUP;
                SW_BACKUP_TELEGRAM.Checked = Properties.Settings.Default.SW_BACKUP_TELEGRAM;

                


                SW_DAILYREPORT.Checked = Properties.Settings.Default.SW_DAILYREPORT;

                if (Properties.Settings.Default.DTP_BACKUP == "")
                {
                    DTP_BACKUP.Value = DateTime.Parse("1:00");
                }
                else
                {
                    DTP_BACKUP.Value = DateTime.Parse(Properties.Settings.Default.DTP_BACKUP);
                }



                try
                {
                    if (TB_NOT_BOT_TELEGRAM_TOKEN.Text != "" && SW_NOT_BOT_TELEGRAM.Checked)
                    {
                        NotificationTelegramBot.Init(TB_NOT_BOT_TELEGRAM_TOKEN.Text);
                    }
                }
                catch (Exception ex)
                {
                    string message = "Произошла ошибка при запуске Notification Telegram бота, проверьте введенный TOKEN";
                    MessageBox.Show(message);
                    LogTelegramBot.Send(message).ConfigureAwait(false);
                }

                try
                {
                    if (TB_LOG_BOT_TELEGRAM_TOKEN.Text != "" && SW_LOG_BOT_TELEGRAM.Checked)
                    {
                        LogTelegramBot.Init(TB_LOG_BOT_TELEGRAM_TOKEN.Text);
                    }
                }
                catch (Exception ex)
                {
                    string message = "Произошла ошибка при запуске Log Telegram бота, проверьте введенный TOKEN";
                    MessageBox.Show(message);
                    LogTelegramBot.Send(message).ConfigureAwait(false);
                }



                if (TB_NAME_ADD1.Text == "")
                {
                    TB_NAME_ADD1.Visible = false;
                    BT_CHECK_ADD1.Visible = false;
                    BT_CHECK_ADD1.Enabled = false;
                    BT_EDIT_ADD1.Visible = false;
                    BT_EDIT_ADD1.Enabled = false;
                    BT_DELETE_ADD1.Enabled = false;
                    TB_OPEN_ADD1.Visible = false;
                    TB_CLOSE_ADD1.Visible = false;
                    TB_MAX_ADD1.Visible = false;
                    TB_MIN_ADD1.Visible = false;
                    L_CHANGE_ADD1.Visible = false;
                    L_STATUS_ADD1.Visible = false;
                    L_LOG_ADD1.Visible = false;
                    SW_ADD1.Visible = false;
                    SW_DB_ADD1.Visible = false;
                    UD_NOT_CHANGE_ADD1.Visible = false;
                    SW_NOT_CHANGE_ADD1.Visible = false;
                    SW_LOG_ADD1.Visible = false;
                    BT_ADD_ADD2.Visible = false;
                    BT_ADD_ADD2.Enabled = false;
                    GB_TELEGRAM_SETTINGS.Location = new Point(13, 290);
                    GB_BACKUP_SETTINGS.Location = new Point(728, 290);
                    GB_LANGUAGE.Location = new Point(1182, 375);
                    L_DATE.Location = new Point(1185, 445);
                    GB_NOT_SETTINGS.Size = new Size(198, 267);
                    GB_DB_SETTINGS.Size = new Size(204, 268);
                    this.Size = new Size(1404, 521);
                }
                else
                {
                    BT_ADD_ADD1.Visible = false;
                    BT_ADD_ADD1.Enabled = false;
                    BT_DELETE_ADD1.Visible = true;
                    BT_DELETE_ADD1.Enabled = true;

                }


                if (TB_NAME_ADD2.Text == "")
                {


                    TB_NAME_ADD2.Visible = false;
                    BT_CHECK_ADD2.Visible = false;
                    BT_CHECK_ADD2.Enabled = false;
                    BT_EDIT_ADD2.Visible = false;
                    BT_EDIT_ADD2.Enabled = false;
                    BT_DELETE_ADD2.Enabled = false;
                    TB_OPEN_ADD2.Visible = false;
                    TB_CLOSE_ADD2.Visible = false;
                    TB_MAX_ADD2.Visible = false;
                    TB_MIN_ADD2.Visible = false;
                    L_CHANGE_ADD2.Visible = false;
                    L_STATUS_ADD2.Visible = false;
                    L_LOG_ADD2.Visible = false;
                    SW_ADD2.Visible = false;
                    SW_DB_ADD2.Visible = false;
                    UD_NOT_CHANGE_ADD2.Visible = false;
                    SW_NOT_CHANGE_ADD2.Visible = false;
                    SW_LOG_ADD2.Visible = false;

                }
                else
                {
                    BT_ADD_ADD2.Visible = false;
                    BT_ADD_ADD2.Enabled = false;
                    BT_DELETE_ADD1.Visible = false;
                    BT_DELETE_ADD1.Enabled = false;
                    BT_DELETE_ADD2.Visible = true;
                    BT_DELETE_ADD2.Enabled = true;
                }

                BT_CHECK_KEY.Visible = false;
                BT_CHECK_KEY.Enabled = false;
                BT_CHECK_SECRET.Visible = false;
                BT_CHECK_SECRET.Enabled = false;
                BT_CHECK_DBNAME.Visible = false;
                BT_CHECK_DBNAME.Enabled = false;
                BT_CHECK_LOCALHOST.Visible = false;
                BT_CHECK_LOCALHOST.Enabled = false;
            }



        }




        // В классе формы
        private System.Timers.Timer dailyReportTimer;
        private readonly TimeSpan reportTime = new TimeSpan(0, 5, 0); // 01:00 ночи

        private void InitializeDailyReport()
        {
            if (!SW_DAILYREPORT.Checked || !SW_NOT_BOT_TELEGRAM.Checked) return;

            dailyReportTimer = new System.Timers.Timer
            {
                Interval = CalculateIntervalToNextReport(reportTime),
                AutoReset = false // Ручной перезапуск после обработки
            };

            dailyReportTimer.Elapsed += async (s, e) =>
            {
                try
                {
                    await SendDailyReport();
                }
                finally
                {
                    dailyReportTimer.Interval = CalculateIntervalToNextReport(reportTime);
                    dailyReportTimer.Start();
                }
            };
            dailyReportTimer.Start();
        }

        private double CalculateIntervalToNextReport(TimeSpan targetTime)
        {
            var now = DateTime.Now;
            var targetDate = now.Date.Add(targetTime);
            if (targetDate < now) targetDate = targetDate.AddDays(1);
            return (targetDate - now).TotalMilliseconds;
        }

        public async Task SendDailyReport()
        {
            try
            {
                var today = DateTime.Today.AddDays(-1);
                var instruments = await GetAvailableInstruments();
                var reportData = new Dictionary<string, double>();

                foreach (var instrument in instruments)
                {
                    var actualBars = await GetActualBarsCount(instrument, today);
                    if (actualBars == 0) continue;

                    var expectedBars = GetTradingHours(instrument) / 5;
                    reportData[GetDisplayName(instrument)] = (expectedBars - actualBars) * 100.0 / expectedBars;
                }

                await SendReport(reportData, today);
            }
            catch (Exception ex)
            {
                await NotificationTelegramBot.Send($"Ошибка: {ex.Message}");
            }
        }

        private async Task<List<string>> GetAvailableInstruments()
        {
            var client = new MongoClient($"mongodb://localhost:{TB_LOCALHOST.Text}");
            var collections = await client.GetDatabase(TB_DBNAME.Text)
                .ListCollectionNamesAsync(new ListCollectionNamesOptions
                {
                    Filter = new BsonDocument("name", new BsonDocument("$regex", "_5M$"))
                });

            return collections.ToList().Select(x => x[..^3]).ToList();
        }

        private string GetDisplayName(string instrument) => instrument switch
        {
            "ADD1" => TB_NAME_ADD1.Text.Trim(),
            "ADD2" => TB_NAME_ADD2.Text.Trim(),
            _ => instrument
        };

        private async Task SendReport(Dictionary<string, double> data, DateTime date)
        {
            if (data.Count == 0)
            {
                await NotificationTelegramBot.Send("Нет данных для отчёта");
                return;
            }

            var message = new StringBuilder()
                .AppendLine($"Отчёт по потерям данных за {date:dd.MM.yyyy}")
                .AppendLine("============================")
                .AppendJoin("\n", data.Select(x => $"{x.Key} - {x.Value:F1}%"))
                .AppendLine("\n---------------------------")
                .AppendLine($"Среднее: {data.Values.Average():F1}%")
                .ToString();

            await NotificationTelegramBot.Send(message);
        }

        private int GetTradingHours(string instrument) => instrument switch
        {
            "S" or "G" or "P" => 22 * 60,    // 22 часа
            "LCO" or "NG" => 20 * 60,        // 20 часов
            _ => 24 * 60                     // 24 часа
        };

        private async Task<int> GetActualBarsCount(string instrument, DateTime date)
        {
            var collection = new MongoClient($"mongodb://localhost:{TB_LOCALHOST.Text}")
                .GetDatabase(TB_DBNAME.Text)
                .GetCollection<BsonDocument>($"{instrument}_5M");

            var filter = Builders<BsonDocument>.Filter
                .Regex("Date", new BsonRegularExpression($"^{date:yyyy-MM-dd}"));

            return (int)await collection.CountDocumentsAsync(filter);
        }












        private System.Timers.Timer backupTimer;
        private BackupManager backupManager;
        // В классе BackupManager:
        private readonly string backupDirectory = "DB_Backups"; // Путь по умолчанию







        private void InitializeBackupSystem()
        {
            // Инициализация таймера
            backupTimer = new System.Timers.Timer(CalculateInterval());
            backupTimer.Elapsed += BackupTimerElapsed;
            backupTimer.AutoReset = true;
            backupTimer.Start();

            // Загрузка сохраненных настроек
            LoadBackupSettings();
        }

        private void LoadBackupSettings()
        {
            TB_DIRECTORY_BACKUP.Text = Properties.Settings.Default.TB_DIRECTORY_BACKUP;
            UD_DAYS_BACKUP.Value = Properties.Settings.Default.UD_DAYS_BACKUP;
            UD_STORE_BACKUP.Value = Properties.Settings.Default.UD_STORE_BACKUP;
        }

        private void SaveBackupSettings()
        {
            Properties.Settings.Default.TB_DIRECTORY_BACKUP = TB_DIRECTORY_BACKUP.Text;
            Properties.Settings.Default.UD_DAYS_BACKUP = (int)UD_DAYS_BACKUP.Value;
            Properties.Settings.Default.UD_STORE_BACKUP = (int)UD_STORE_BACKUP.Value;
            Properties.Settings.Default.Save();
        }

        private async void BackupTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            backupTimer.Interval = CalculateInterval();

            if (DateTime.Now.TimeOfDay >= DTP_BACKUP.Value.TimeOfDay &&
                DateTime.Now.TimeOfDay < DTP_BACKUP.Value.TimeOfDay.Add(TimeSpan.FromMinutes(1)))
            {
                await SendDailyReport();
                await PerformScheduledBackup(1);
            }
        }

        private async Task PerformScheduledBackup(int a)
        {
            if (SW_BACKUP.Checked && SW_LOG_BOT_TELEGRAM.Checked)
            {
                try
                {
                    // Уничтожаем предыдущий экземпляр
                    if (backupManager != null)
                    {
                        backupManager.Dispose();
                        backupManager = null;
                    }
                    if (a == 1)
                    {
                        // Создаем новый экземпляр
                        backupManager = new BackupManager(
                            TB_DIRECTORY_BACKUP.Text,
                            (int)UD_DAYS_BACKUP.Value,
                            (int)UD_STORE_BACKUP.Value,
                            SW_BACKUP_TELEGRAM.Checked && SW_LOG_BOT_TELEGRAM.Checked,
                            statusLabel: L_LOG_BACKUP

                        );

                        var result = await backupManager.PerformBackup(
                            TB_LOCALHOST.Text,
                            TB_DBNAME.Text
                        );

                        // Освобождаем ресурсы после выполнения
                        backupManager.Dispose();
                        backupManager = null;
                    }
                }
                catch (Exception ex)
                {
                    // Освобождаем ресурсы даже при ошибке
                    backupManager?.Dispose();
                    backupManager = null;

                    if (SW_LOG_BOT_TELEGRAM.Checked == true)
                    {
                        await NotificationTelegramBot.Send($"Ошибка бэкапа: {ex.Message}");
                        L_LOG_BACKUP.Text = "Ошибка бэкапа";
                    }
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private class BackupManager : IDisposable
        {

            private readonly Label _statusLabel; // Добавляем поле для Label
            private readonly string backupDirectory;
            private readonly int backupFrequency;
            private readonly int backupsToKeep;
            private readonly bool backupsTg;

            public Action<string> OnError;




            public bool IsDisposed { get; private set; }

            public BackupManager(string directory, int frequency, int keep, bool tg, Label statusLabel)
            {
                backupDirectory = directory;
                backupFrequency = frequency;
                backupsToKeep = keep;
                backupsTg = tg;
                _statusLabel = statusLabel; // Сохраняем ссылку на Label
            }


            private void UpdateStatus(string message)
            {
                if (_statusLabel != null && !_statusLabel.IsDisposed)
                {
                    if (_statusLabel.InvokeRequired)
                    {
                        _statusLabel.Invoke(new Action(() =>
                        {
                            _statusLabel.Text = message;
                        }));
                    }
                    else
                    {
                        _statusLabel.Text = message;
                    }
                }
            }



            public async Task<bool> PerformBackup(string port, string dbName)
            {
                if (DateTime.Now.Day % backupFrequency != 0)
                    return false;

                var backupPath = Path.Combine(
                    backupDirectory,
                    $"{dbName}_{DateTime.Now:yyyyMMdd_HHmmss}"
                );

                Directory.CreateDirectory(backupPath);
                string zipPath = null;

                try
                {
                    UpdateStatus($"{DateTime.Now:HH:mm} Начало создания бэкапа...");

                    var processInfo = new ProcessStartInfo
                    {
                        FileName = @"C:\Program Files\MongoDB\Tools\100\bin\mongodump.exe",
                        Arguments = $"--host localhost --port {port} --db {dbName} --out \"{backupPath}\"",
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                    };

                    using (var process = Process.Start(processInfo))
                    {
                        string error = await process.StandardError.ReadToEndAsync();
                        await process.WaitForExitAsync();

                        if (process.ExitCode != 0)
                            throw new Exception($"Mongodump error: {error}");

                        CleanOldBackups();
                        Task.Delay(5000);
                        UpdateStatus($"Бэкап создан: {DateTime.Now:HH:mm}");
                    }

                    if (backupsTg)
                    {
                        zipPath = $"{backupPath}.zip";
                        ZipFile.CreateFromDirectory(backupPath, zipPath);
                        await SendBackupToTelegram(zipPath);
                        Task.Delay(5000);
                        UpdateStatus($"{DateTime.Now:HH:mm} Архив отправлен в Telegram");
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    UpdateStatus($"{DateTime.Now:HH:mm} Ошибка: {ex.Message}");

                    if (Directory.Exists(backupPath))
                        Directory.Delete(backupPath, true);

                    if (File.Exists(zipPath))
                        File.Delete(zipPath);

                    return false;
                }
            }


            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!IsDisposed)
                {
                    if (disposing)
                    {
                        // Освобождение управляемых ресурсов (если есть)
                    }

                    IsDisposed = true;
                }
            }

            ~BackupManager()
            {
                Dispose(false);
            }




            private async Task SendBackupToTelegram(string filePath)
            {

                try
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        await LogTelegramBot.SendDocument(
                            document: new InputFileStream(stream, Path.GetFileName(filePath)),
                            caption: $"Бэкап {DateTime.Now:yyyy-MM-dd HH:mm}"
                        );
                    }

                    File.Delete(filePath); // Удаляем архив после отправки
                }
                catch (Exception ex)
                {
                    await LogTelegramBot.Send($"Ошибка отправки архива: {ex.Message}");
                    throw;
                }
            }

            private void CleanOldBackups()
            {
                try
                {
                    UpdateStatus("Очистка старых бэкапов...");

                    var backups = Directory.GetDirectories(backupDirectory)
                        .Select(d => new { Path = d, Name = Path.GetFileName(d) })
                        .Where(d => IsValidBackupName(d.Name))
                        .OrderByDescending(d => d.Name)
                        .ToList();

                    var backupsToDelete = backups.Skip(backupsToKeep).ToList();

                    foreach (var dir in backupsToDelete)
                    {
                        Directory.Delete(dir.Path, true);
                    }

                    UpdateStatus($"Удалено бэкапов: {backupsToDelete.Count}");
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Ошибка очистки: {ex.Message}");
                }
            }

            private bool IsValidBackupName(string name)
            {
                // Регулярное выражение для проверки формата имени (пример: CDA_20231201_120000)
                return Regex.IsMatch(name, @"^[a-zA-Z0-9]+_\d{8}_\d{6}$");
            }


        }





        private double CalculateInterval()
        {
            var now = DateTime.Now;
            var targetTime = DTP_BACKUP.Value.TimeOfDay; // Берём время из DateTimePicker
            var nextRun = now.Date.Add(targetTime);

            if (now > nextRun)
                nextRun = nextRun.AddDays(1);

            return (nextRun - now).TotalMilliseconds;
        }




        private CancellationTokenSource _cts = new CancellationTokenSource();

        private async void Form1_Load(object sender, EventArgs e)
        {
            StartMonitoring();
        }

        async void StartMonitoring()
        {
            try
            {
                var tasks = new List<Task> { };
                if (TB_NAME_ADD1.Text != "" && TB_NAME_ADD2.Text == "")
                {
                    tasks = new List<Task>
                {
                RunAssetUpdate("Oil - Brent Crude", "LCO", _cts.Token),
                RunAssetUpdate("Silver", "S", _cts.Token),
                RunAssetUpdate("Gold", "G", _cts.Token),
                RunAssetUpdate(TB_NAME_ADD1.Text, "ADD1", _cts.Token)
                };
                }
                else if (TB_NAME_ADD1.Text != "" && TB_NAME_ADD2.Text != "")
                {
                    tasks = new List<Task>
                {
                RunAssetUpdate("Oil - Brent Crude", "LCO", _cts.Token),
                RunAssetUpdate("Silver", "S", _cts.Token),
                RunAssetUpdate("Gold", "G", _cts.Token),
                RunAssetUpdate(TB_NAME_ADD1.Text, "ADD1", _cts.Token),
                RunAssetUpdate(TB_NAME_ADD2.Text, "ADD2", _cts.Token)
                };
                }
                else
                {
                    tasks = new List<Task>
                {
                RunAssetUpdate("Oil - Brent Crude", "LCO", _cts.Token),
                RunAssetUpdate("Silver", "S", _cts.Token),
                RunAssetUpdate("Gold", "G", _cts.Token),
                };
                }
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                string message = $"Произошла ошибка: {ex.Message}";
                MessageBox.Show(
                   message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                await LogTelegramBot.Send(message).ConfigureAwait(false);
            }
        }
        async Task RunAssetUpdate(string symbol, string suffix, CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                await DoRequest(
                    "https",
                    "open-api.bingx.com",
                    "/openApi/contract/v1/allPosition",
                    "GET",
                    TB_KEY.Text,
                    TB_SECRET.Text,
                    new { symbol, recvWindow = 0 },
                    suffix
                );

                await Task.Delay(1000, ct); // Обновление каждые 5 секунд
            }
        }

        async Task DoRequest(string protocol, string host, string api, string method,
                            string API_KEY, string API_SECRET, dynamic payload, string suffix)
        {
            var sw = Controls.Find($"SW_{suffix}", true).FirstOrDefault() as ToggleSwitch;

            while (SW_MAIN.Checked == true && sw.Checked == true)
            {
                long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                string parameters = $"timestamp={timestamp}";

                if (payload != null)
                {
                    foreach (var property in payload.GetType().GetProperties())
                    {
                        parameters += $"&{property.Name}={property.GetValue(payload)}";
                    }
                }

                string sign = CalculateHmacSha256(parameters, API_SECRET);
                string url = $"{protocol}://{host}{api}?{parameters}&signature={sign}";

                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

                    try
                    {


                        using (HttpClient client = new HttpClient(handler))
                        {
                            client.DefaultRequestHeaders.Add("X-BX-APIKEY", API_KEY);
                            HttpResponseMessage response;

                            if (method.ToUpper() == "GET")
                            {
                                response = await client.GetAsync(url);
                            }
                            else if (method.ToUpper() == "POST")
                            {
                                response = await client.PostAsync(url, null);
                            }
                            else if (method.ToUpper() == "DELETE")
                            {
                                response = await client.DeleteAsync(url);
                            }
                            else if (method.ToUpper() == "PUT")
                            {
                                response = await client.PutAsync(url, null);
                            }
                            else
                            {
                                throw new NotSupportedException("Unsupported HTTP method: " + method);
                            }
                            response.EnsureSuccessStatusCode();
                            var json = await response.Content.ReadAsStringAsync();
                            dynamic data = JsonConvert.DeserializeObject(json);

                            try
                            {
                                foreach (dynamic item in data.data)
                                {
                                    if (item.symbol == payload.symbol) // Используем symbol из payload
                                    {
                                        UpdateUIElements(suffix, item);
                                        break;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                    }
                    catch
                    {
                        foreach (Control control in Controls)
                        {
                            // Если это Label - проверяем и обновляем текст
                            if (control is Label label)
                            {
                                if (label.Text == "Connected")
                                {
                                    label.Text = "Disconnected";
                                    label.ForeColor = System.Drawing.Color.Red;
                                }
                                if (label.Text == "Подключено")
                                {
                                    label.Text = "Отключено";
                                    label.ForeColor = System.Drawing.Color.Red;
                                }
                            }
                        }
                    }
                }
                await Task.Delay(1000); // Задержка между запросами
            }
        }

        private bool IsTradingTimeResources(DateTime moscowTime)
        {
            // Проверка выходных
            if (moscowTime.DayOfWeek == DayOfWeek.Saturday ||
                moscowTime.DayOfWeek == DayOfWeek.Sunday)
                return false;

            TimeSpan time = moscowTime.TimeOfDay;
            DayOfWeek day = moscowTime.DayOfWeek;
            return time >= new TimeSpan(4, 0, 0) || time < new TimeSpan(0, 0, 0);

        }

        private bool IsTradingTimeMetal(DateTime moscowTime)
        {
            // Проверка выходных
            if (moscowTime.DayOfWeek == DayOfWeek.Saturday ||
                moscowTime.DayOfWeek == DayOfWeek.Sunday)
                return false;

            TimeSpan time = moscowTime.TimeOfDay;
            DayOfWeek day = moscowTime.DayOfWeek;
            return time >= new TimeSpan(2, 0, 0) || time < new TimeSpan(0, 0, 0);

        }


        private static readonly object _lock = new object();
        private static Dictionary<string, DateTime> _lastSavedBarTimes = new Dictionary<string, DateTime>();



        async void UpdateUIElements(string suffix, dynamic item)
        {

            var moscowTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscowTimeZone);

            var currentPrice = item.currentPrice.ToString();
            // Вычисляем начало текущего пятиминутного бара
            int minutes = now.Minute - (now.Minute % 5);
            DateTime currentBarStart = now.Date.AddHours(now.Hour).AddMinutes(minutes - now.Minute % 5);

            // Блокируем для потокобезопасности
            lock (_lock)
            {
                if (!_lastSavedBarTimes.ContainsKey(suffix))
                {
                    _lastSavedBarTimes[suffix] = currentBarStart;
                    return;
                }
            }

            DateTime lastSaved;
            lock (_lock)
            {
                lastSaved = _lastSavedBarTimes[suffix];
            }



            if (currentBarStart > lastSaved)
            {
                if (suffix == "S" || suffix == "G" || suffix == "P")
                {
                    if (!IsTradingTimeMetal(lastSaved) && IsTradingTimeMetal(now))
                    {
                        lock (_lock)
                        {
                            _lastSavedBarTimes[suffix] = currentBarStart;
                        }
                        return;
                    }
                }
                else if (suffix == "LCO" || suffix == "NG")
                {
                    if (!IsTradingTimeResources(lastSaved) && IsTradingTimeResources(now))
                    {
                        lock (_lock)
                        {
                            _lastSavedBarTimes[suffix] = currentBarStart;
                        }
                        return;
                    }
                }

                // Основная логика сохранения
                var previousOpen = GetTextBoxValue("OPEN");
                var previousClose = GetTextBoxValue("CLOSE");
                var previousMax = GetTextBoxValue("MAX");
                var previousMin = GetTextBoxValue("MIN");

                if (previousMax != previousMin)
                {
                    var log = Controls.Find($"L_LOG_{suffix}", true).FirstOrDefault();
                    var sw_db = Controls.Find($"SW_DB_{suffix}", true).FirstOrDefault() as ToggleSwitch;
                    var sw_not = Controls.Find($"SW_NOT_CHANGE_{suffix}", true).FirstOrDefault() as ToggleSwitch;

                    var ud = Controls.Find($"UD_NOT_CHANGE_{suffix}", true).FirstOrDefault() as NumericUpDown;

                    var sw_log = Controls.Find($"SW_LOG_{suffix}", true).FirstOrDefault() as ToggleSwitch;

                    bool Session = true;
                    if (suffix == "S" || suffix == "G" || suffix == "P")
                    {
                        Session = IsTradingTimeMetal(lastSaved); // Используем начало предыдущего бара
                    }
                    else if (suffix == "LCO" || suffix == "NG")
                    {
                        Session = IsTradingTimeResources(lastSaved);
                    }

                    if (Session)
                    {
                        if (!string.IsNullOrEmpty(previousOpen) &&
                            !string.IsNullOrEmpty(previousClose) &&
                            !string.IsNullOrEmpty(previousMax) &&
                            !string.IsNullOrEmpty(previousMin))
                        {
                            try
                            {
                                var document = new BsonDocument
                        {
                            { "Date", lastSaved.ToString("yyyy-MM-dd") },
                            { "Time", lastSaved.ToString("HH:mm") },
                            { "Open", Convert.ToDouble(previousOpen) },
                            { "Close", Convert.ToDouble(previousClose) },
                            { "High", Convert.ToDouble(previousMax) },
                            { "Low", Convert.ToDouble(previousMin) },
                            { "Change", Math.Round(
                                (Convert.ToDouble(previousClose) - Convert.ToDouble(previousOpen)) /
                                Convert.ToDouble(previousOpen) * 100, 2) }
                        };

                                var mongoClient = new MongoClient($"mongodb://localhost:{TB_LOCALHOST.Text}");
                                var database = mongoClient.GetDatabase($"{TB_DBNAME.Text}");
                                var collection = database.GetCollection<BsonDocument>($"{suffix}_5M");
                                if (suffix == "ADD1")
                                {
                                    collection = database.GetCollection<BsonDocument>($"{TB_NAME_ADD1.Text}_5M");
                                }
                                else if (suffix == "ADD2")
                                {
                                    collection = database.GetCollection<BsonDocument>($"{TB_NAME_ADD2.Text}_5M");
                                }
                                else
                                {
                                    collection = database.GetCollection<BsonDocument>($"{suffix}_5M");
                                }

                                if (sw_db.Checked)
                                {
                                    await collection.InsertOneAsync(document);
                                    log.Text = $"Бар {lastSaved:HH:mm} сохранён";
                                }
                                if (sw_log.Checked)
                                {
                                    var instrumentNames = new Dictionary<string, string>
                                    {
                                        { "ADD1", TB_NAME_ADD1?.Text ?? "ADD1" },
                                        { "ADD2", TB_NAME_ADD2?.Text ?? "ADD2" }
                                    };

                                    var instrumentName = instrumentNames.TryGetValue(suffix, out var name)
                                        ? name
                                        : suffix;

                                    await LogTelegramBot.Send($"Бар по инструменту {instrumentName} в {lastSaved:HH:mm} сохранён")
                                        .ConfigureAwait(false);

                                }


                            }
                            catch (Exception ex)
                            {
                                log.Text = "Ошибка MongoDB";
                                if (sw_log.Checked)
                                {
                                    var instrumentNames = new Dictionary<string, string>
                                    {
                                        { "ADD1", TB_NAME_ADD1?.Text ?? "ADD1" },
                                        { "ADD2", TB_NAME_ADD2?.Text ?? "ADD2" }
                                    };

                                    var instrumentName = instrumentNames.TryGetValue(suffix, out var name)
                                        ? name
                                        : suffix;

                                    await LogTelegramBot.Send($"Произошла ошибка при сохранении бара в {lastSaved:HH:mm} по инструменту {instrumentName}")
                                        .ConfigureAwait(false);
                                }

                            }
                            decimal change = Convert.ToDecimal(Math.Round(
                                (Convert.ToDouble(previousClose) - Convert.ToDouble(previousOpen)) /
                                Convert.ToDouble(previousOpen) * 100, 2));
                            if (ud.Value <= Math.Abs(change) && sw_not.Checked)
                            {
                                var instrumentNames = new Dictionary<string, string>
                                {
                                    { "ADD1", TB_NAME_ADD1.Text },
                                    { "ADD2", TB_NAME_ADD2.Text }
                                };

                                var sign = change > 0 ? "+" : "-";
                                var instrumentName = instrumentNames.TryGetValue(suffix, out var name)
                                    ? name
                                    : suffix;

                                var message = $"Там капец! {instrumentName} изменился на {sign}{Math.Abs(change):0.00}%!";
                                await NotificationTelegramBot.Send(message).ConfigureAwait(false);
                            }


                        }

                        // Обновляем время последнего сохранения
                        lock (_lock)
                        {
                            _lastSavedBarTimes[suffix] = currentBarStart;
                        }

                        // Сброс значений для нового бара
                        SafeSetTextBox("OPEN", item.currentPrice.ToString());
                        SafeSetTextBox("CLOSE", item.currentPrice.ToString());
                        SafeSetTextBox("MAX", item.currentPrice.ToString());
                        SafeSetTextBox("MIN", item.currentPrice.ToString());
                    }


                }
            }
            else
            {
                SafeSetTextBox("CLOSE", currentPrice);
            }
            string GetTextBoxValue(string type)
            {
                var tb = Controls.Find($"TB_{type}_{suffix}", true).FirstOrDefault() as TextBox;
                return tb?.Text ?? "";
            }

            void SafeSetTextBox(string type, string value)
            {
                var tb = Controls.Find($"TB_{type}_{suffix}", true).FirstOrDefault() as TextBox;
                if (tb != null)
                {
                    if (tb.InvokeRequired)
                        tb.Invoke((Action)(() => tb.Text = value));
                    else
                        tb.Text = value;
                }
            }

            void SetColorForAll(System.Drawing.Color color)
            {
                string[] types = { "OPEN", "CLOSE", "MAX", "MIN" };
                foreach (var type in types)
                {
                    var control = Controls.Find($"TB_{type}_{suffix}", true).FirstOrDefault();
                    if (control != null)
                    {
                        if (control.InvokeRequired)
                            control.Invoke((Action)(() => control.BackColor = color));
                        else
                            control.BackColor = color;
                    }
                }
            }

            void SetColorForChange(System.Drawing.Color color)
            {
                var change = Controls.Find($"L_CHANGE_{suffix}", true).FirstOrDefault();
                change.ForeColor = color;
            }






            // Основная логика



            // Обновление MAX и MIN
            try
            {
                var currentPriceValue = Convert.ToDouble(currentPrice);

                if (string.IsNullOrEmpty(GetTextBoxValue("CLOSE")))
                    SafeSetTextBox("CLOSE", currentPrice);

                if (string.IsNullOrEmpty(GetTextBoxValue("OPEN")))
                    SafeSetTextBox("OPEN", currentPrice);

                // Обновление MAX
                if (string.IsNullOrEmpty(GetTextBoxValue("MAX")))
                {
                    SafeSetTextBox("MAX", currentPrice);
                }
                else if (Convert.ToDouble(GetTextBoxValue("MAX")) < currentPriceValue)
                {
                    SafeSetTextBox("MAX", currentPrice);
                }

                // Обновление MIN
                if (string.IsNullOrEmpty(GetTextBoxValue("MIN")))
                {
                    SafeSetTextBox("MIN", currentPrice);
                }
                else if (Convert.ToDouble(GetTextBoxValue("MIN")) > currentPriceValue)
                {
                    SafeSetTextBox("MIN", currentPrice);
                }

                // Определение цвета
                var openValue = Convert.ToDouble(GetTextBoxValue("OPEN"));
                var closeValue = Convert.ToDouble(GetTextBoxValue("CLOSE"));

                if (openValue == closeValue)
                {
                    SetColorForAll(System.Drawing.Color.White);
                }
                else if (openValue > closeValue)
                {
                    SetColorForAll(System.Drawing.Color.LightPink);
                }
                else
                {
                    SetColorForAll(System.Drawing.Color.LightGreen);
                }
                if (SW_LANGUAGE.Checked)
                {
                    L_BINGX_STATUS.Text = "Connected";
                }
                else
                {
                    L_BINGX_STATUS.Text = "Подключено";
                }
                L_BINGX_STATUS.ForeColor = System.Drawing.Color.Green;
                var l = Controls.Find($"L_STATUS_{suffix}", true).FirstOrDefault() as Label;
                if (SW_LANGUAGE.Checked)
                {
                    l.Text = "Connected";
                }
                else
                {
                    l.Text = "Подключено";
                }
                
                l.ForeColor = System.Drawing.Color.Green;


                if (openValue == closeValue)
                {
                    SetColorForChange(System.Drawing.Color.Black);
                }
                else if (openValue > closeValue)
                {
                    SetColorForChange(System.Drawing.Color.Red);
                }
                else
                {
                    SetColorForChange(System.Drawing.Color.Green);
                }

                // Добавленный код: расчет изменения цены
                double percentageChange = (closeValue - openValue) / openValue * 100;
                string changeText = percentageChange >= 0
                    ? $"+{percentageChange:0.00}%"
                    : $"{percentageChange:0.00}%";

                // Обновление метки изменения
                var changeLabel = Controls.Find($"L_CHANGE_{suffix}", true).FirstOrDefault() as Label;
                if (changeLabel != null)
                {
                    if (changeLabel.InvokeRequired)
                        changeLabel.Invoke((Action)(() => changeLabel.Text = changeText));
                    else
                        changeLabel.Text = changeText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обновлении UI: {ex.Message}");
            }
        }

        void UpdateTextBox(string controlName, string value)
        {
            var textBox = Controls.Find(controlName, true).FirstOrDefault() as TextBox;
            textBox.Text = value;
        }


        static string CalculateHmacSha256(string input, string key)
        {
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (HMACSHA256 hmac = new HMACSHA256(keyBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        private void SW_MAIN_Click(object sender, EventArgs e)
        {
            if (SW_MAIN.Checked == false)
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_BINGX_STATUS.Text = "Stopped";
                    L_STATUS_LCO.Text = "Stopped";
                    L_STATUS_G.Text = "Stopped";
                    L_STATUS_S.Text = "Stopped";
                    L_STATUS_ADD1.Text = "Stopped";
                    L_STATUS_ADD2.Text = "Stopped";
                }
                else
                {
                    L_BINGX_STATUS.Text = "Остановлено";
                    L_STATUS_LCO.Text = "Остановлено";
                    L_STATUS_G.Text = "Остановлено";
                    L_STATUS_S.Text = "Остановлено";
                    L_STATUS_ADD1.Text = "Остановлено";
                    L_STATUS_ADD2.Text = "Остановлено";
                }
                L_BINGX_STATUS.ForeColor = System.Drawing.Color.Red;
                L_STATUS_LCO.ForeColor = System.Drawing.Color.Red;
                L_STATUS_G.ForeColor = System.Drawing.Color.Red;
                L_STATUS_S.ForeColor = System.Drawing.Color.Red;
                L_STATUS_ADD1.ForeColor = System.Drawing.Color.Red;
                L_STATUS_ADD2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_BINGX_STATUS.Text = "Connecting...";
                }
                else
                {
                    L_BINGX_STATUS.Text = "Подключение...";
                }
                L_BINGX_STATUS.ForeColor = System.Drawing.Color.DarkOrange;
                if (SW_LCO.Checked == true)
                {
                    if (SW_LANGUAGE.Checked) 
                    {
                        L_STATUS_LCO.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_LCO.Text = "Подключение...";
                    }
                    L_STATUS_LCO.ForeColor = System.Drawing.Color.DarkOrange;
                }
                if (SW_G.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_G.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_G.Text = "Подключение...";
                    }
                    L_STATUS_G.ForeColor = System.Drawing.Color.DarkOrange;
                }
                if (SW_S.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_S.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_S.Text = "Подключение...";
                    }
                    L_STATUS_S.ForeColor = System.Drawing.Color.DarkOrange;
                }
                if (SW_ADD1.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_ADD1.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_ADD1.Text = "Подключение...";
                    }
                    L_STATUS_ADD1.ForeColor = System.Drawing.Color.DarkOrange;
                }
                if (SW_ADD2.Checked == true)
                {
                    if (SW_LANGUAGE.Checked)
                    {
                        L_STATUS_ADD2.Text = "Connecting...";
                    }
                    else
                    {
                        L_STATUS_ADD2.Text = "Подключение...";
                    }
                    L_STATUS_ADD2.ForeColor = System.Drawing.Color.DarkOrange;
                }
            }
        }

        private void BT_ADD_ADD1_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD1.Visible = true;
            BT_CHECK_ADD1.Visible = true;
            BT_CHECK_ADD1.Enabled = true;
            BT_EDIT_ADD1.Visible = true;
            BT_EDIT_ADD1.Enabled = true;
            BT_DELETE_ADD1.Visible = true;
            BT_DELETE_ADD1.Enabled = true;
            TB_OPEN_ADD1.Visible = true;
            TB_CLOSE_ADD1.Visible = true;
            TB_MAX_ADD1.Visible = true;
            TB_MIN_ADD1.Visible = true;
            L_STATUS_ADD1.Visible = true;
            L_LOG_ADD1.Visible = true;
            L_CHANGE_ADD1.Visible = true;
            SW_ADD1.Visible = true;
            SW_DB_ADD1.Visible = true;
            UD_NOT_CHANGE_ADD1.Visible = true;
            SW_NOT_CHANGE_ADD1.Visible = true;
            SW_LOG_ADD1.Visible = true;
            BT_ADD_ADD1.Visible = false;
            BT_ADD_ADD1.Enabled = false;
            BT_ADD_ADD2.Visible = true;
            BT_ADD_ADD2.Enabled = true;
            GB_TELEGRAM_SETTINGS.Location = new Point(13, 320);
            GB_BACKUP_SETTINGS.Location = new Point(728, 320);
            GB_LANGUAGE.Location = new Point(1182, 405);
            L_DATE.Location = new Point(1185, 475);
            GB_NOT_SETTINGS.Size = new Size(198, 297);
            GB_DB_SETTINGS.Size = new Size(204, 298);
            this.Size = new Size(1404, 551);
        }

        private void BT_ADD_ADD2_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD2.Visible = true;
            BT_CHECK_ADD2.Visible = true;
            BT_CHECK_ADD2.Enabled = true;
            BT_EDIT_ADD2.Visible = true;
            BT_EDIT_ADD2.Enabled = true;
            BT_DELETE_ADD2.Visible = true;
            BT_DELETE_ADD2.Enabled = true;
            TB_OPEN_ADD2.Visible = true;
            TB_CLOSE_ADD2.Visible = true;
            TB_MAX_ADD2.Visible = true;
            TB_MIN_ADD2.Visible = true;
            L_STATUS_ADD2.Visible = true;
            L_LOG_ADD2.Visible = true;
            L_CHANGE_ADD2.Visible = true;
            SW_ADD2.Visible = true;
            SW_DB_ADD2.Visible = true;
            UD_NOT_CHANGE_ADD2.Visible = true;
            SW_NOT_CHANGE_ADD2.Visible = true;
            SW_LOG_ADD2.Visible = true;
            BT_ADD_ADD2.Visible = false;
            BT_ADD_ADD2.Enabled = false;
            BT_DELETE_ADD1.Visible = false;
            BT_DELETE_ADD1.Enabled = false;
        }

        private void BT_EDIT_KEY_Click(object sender, EventArgs e)
        {
            TB_KEY.ReadOnly = false;
            TB_KEY.Enabled = true;
            TB_KEY.UseSystemPasswordChar = false;
            BT_EDIT_KEY.Visible = false;
            BT_EDIT_KEY.Enabled = false;
            BT_CHECK_KEY.Visible = true;
            BT_CHECK_KEY.Enabled = true;
        }

        private void BT_CHECK_KEY_Click(object sender, EventArgs e)
        {
            TB_KEY.ReadOnly = true;
            TB_KEY.Enabled = false;
            TB_KEY.UseSystemPasswordChar = true;
            BT_EDIT_KEY.Visible = true;
            BT_EDIT_KEY.Enabled = true;
            BT_CHECK_KEY.Visible = false;
            BT_CHECK_KEY.Enabled = false;
        }

        private void BT_EDIT_SECRET_Click(object sender, EventArgs e)
        {
            TB_SECRET.ReadOnly = false;
            TB_SECRET.Enabled = true;
            TB_SECRET.UseSystemPasswordChar = false;
            BT_EDIT_SECRET.Visible = false;
            BT_EDIT_SECRET.Enabled = false;
            BT_CHECK_SECRET.Visible = true;
            BT_CHECK_SECRET.Enabled = true;
        }

        private void BT_CHECK_SECRET_Click(object sender, EventArgs e)
        {
            TB_SECRET.ReadOnly = true;
            TB_SECRET.Enabled = false;
            TB_SECRET.UseSystemPasswordChar = true;
            BT_EDIT_SECRET.Visible = true;
            BT_EDIT_SECRET.Enabled = true;
            BT_CHECK_SECRET.Visible = false;
            BT_CHECK_SECRET.Enabled = false;
        }

        private void BT_CHECK_ADD1_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD1.ReadOnly = true;
            TB_NAME_ADD1.Enabled = false;
            BT_EDIT_ADD1.Visible = true;
            BT_EDIT_ADD1.Enabled = true;
            BT_CHECK_ADD1.Visible = false;
            BT_CHECK_ADD1.Enabled = false;
            StartMonitoring();
        }

        private void BT_CHECK_ADD2_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD2.ReadOnly = true;
            TB_NAME_ADD2.Enabled = false;
            BT_EDIT_ADD2.Visible = true;
            BT_EDIT_ADD2.Enabled = true;
            BT_CHECK_ADD2.Visible = false;
            BT_CHECK_ADD2.Enabled = false;
            StartMonitoring();
        }

        private void BT_EDIT_ADD1_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD1.ReadOnly = false;
            TB_NAME_ADD1.Enabled = true;
            BT_EDIT_ADD1.Visible = false;
            BT_EDIT_ADD1.Enabled = false;
            BT_CHECK_ADD1.Visible = true;
            BT_CHECK_ADD1.Enabled = true;
        }

        private void BT_EDIT_ADD2_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD2.ReadOnly = false;
            TB_NAME_ADD2.Enabled = true;
            BT_EDIT_ADD2.Visible = false;
            BT_EDIT_ADD2.Enabled = false;
            BT_CHECK_ADD2.Visible = true;
            BT_CHECK_ADD2.Enabled = true;
        }

        private void SW_LCO_Click(object sender, EventArgs e)
        {
            if ((SW_LCO.Checked == true) && (SW_MAIN.Checked == true))
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_LCO.Text = "Connecting...";
                }
                else
                {
                    L_STATUS_LCO.Text = "Подключение...";
                }
                L_STATUS_LCO.ForeColor = System.Drawing.Color.DarkOrange;

            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_LCO.Text = "Stopped";
                }
                else
                {
                    L_STATUS_LCO.Text = "Остановлено";
                }
                L_STATUS_LCO.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SW_NG_Click(object sender, EventArgs e)
        {
            if ((SW_G.Checked == true) && (SW_MAIN.Checked == true))
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_G.Text = "Connecting...";
                }
                else
                {
                    L_STATUS_G.Text = "Подключение...";
                }
                L_STATUS_G.ForeColor = System.Drawing.Color.DarkOrange;

            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_G.Text = "Stopped";
                }
                else
                {
                    L_STATUS_G.Text = "Остановлено";
                }
                L_STATUS_G.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SW_S_Click(object sender, EventArgs e)
        {
            if ((SW_S.Checked == true) && (SW_MAIN.Checked == true))
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_S.Text = "Connecting...";
                }
                else
                {
                    L_STATUS_S.Text = "Подключение...";
                }
                L_STATUS_S.ForeColor = System.Drawing.Color.DarkOrange;

            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_S.Text = "Stopped";
                }
                else
                {
                    L_STATUS_S.Text = "Остановлено";
                }
                L_STATUS_S.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SW_ADD1_Click(object sender, EventArgs e)
        {
            if ((SW_ADD1.Checked == true) && (SW_MAIN.Checked == true))
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_ADD1.Text = "Connecting...";
                }
                else
                {
                    L_STATUS_ADD1.Text = "Подключение...";
                }
                L_STATUS_ADD1.ForeColor = System.Drawing.Color.DarkOrange;

            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_ADD1.Text = "Stopped";
                }
                else
                {
                    L_STATUS_ADD1.Text = "Остановлено";
                }
                L_STATUS_ADD1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void SW_ADD2_Click(object sender, EventArgs e)
        {
            if ((SW_ADD2.Checked == true) && (SW_MAIN.Checked == true))
            {
                if (SW_LANGUAGE.Checked) 
                {
                    L_STATUS_ADD2.Text = "Connecting...";
                }
                else
                {
                    L_STATUS_ADD2.Text = "Подключение...";
                }
                
                L_STATUS_ADD2.ForeColor = System.Drawing.Color.DarkOrange;

            }
            else
            {
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_ADD2.Text = "Stopped";
                }
                else
                {
                    L_STATUS_ADD2.Text = "Остановлено";
                }
                L_STATUS_ADD2.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BT_DELETE_ADD1_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD1.Text = "";
            TB_OPEN_ADD1.Text = "";
            TB_OPEN_ADD1.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_CLOSE_ADD1.Text = "";
            TB_CLOSE_ADD1.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_MAX_ADD1.Text = "";
            TB_MAX_ADD1.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_MIN_ADD1.Text = "";
            TB_MIN_ADD1.BackColor = System.Drawing.Color.WhiteSmoke;
            L_CHANGE_ADD1.Text = "";
            if (SW_LANGUAGE.Checked)
            {
                L_STATUS_ADD1.Text = "Stopped";
            }
            else
            {
                L_STATUS_ADD1.Text = "Остановлено";
            }
            L_STATUS_ADD1.ForeColor = System.Drawing.Color.Red;
            L_LOG_ADD1.Text = "";
            SW_ADD1.Checked = false;
            SW_DB_ADD1.Checked = false;
            UD_NOT_CHANGE_ADD1.Value = 0;
            SW_NOT_CHANGE_ADD1.Checked = false;
            SW_LOG_ADD1.Checked = false;

            if (TB_NAME_ADD2.Visible == true)
            {
                TB_NAME_ADD1.Text = TB_NAME_ADD2.Text;
                SW_ADD1.Checked = SW_ADD2.Checked;
                L_STATUS_ADD1.Text = L_STATUS_ADD2.Text;
                TB_NAME_ADD2.Visible = false;
                BT_CHECK_ADD2.Visible = false;
                BT_CHECK_ADD2.Enabled = false;
                BT_EDIT_ADD2.Visible = false;
                BT_EDIT_ADD2.Enabled = false;
                BT_DELETE_ADD2.Visible = false;
                BT_DELETE_ADD2.Enabled = false;
                TB_OPEN_ADD2.Visible = false;
                TB_CLOSE_ADD2.Visible = false;
                TB_MAX_ADD2.Visible = false;
                TB_MIN_ADD2.Visible = false;
                L_STATUS_ADD2.Visible = false;
                L_LOG_ADD2.Visible = false;
                L_CHANGE_ADD2.Visible = false;
                SW_ADD2.Visible = false;
                SW_DB_ADD2.Visible = false;
                UD_NOT_CHANGE_ADD2.Visible = false;
                SW_NOT_CHANGE_ADD2.Visible = false;
                SW_LOG_ADD2.Visible = false;
                BT_ADD_ADD2.Visible = true;
                BT_ADD_ADD2.Enabled = true;
            }
            else
            {
                TB_NAME_ADD1.Text = null;
                SW_ADD1.Checked = false;
                if (SW_LANGUAGE.Checked)
                {
                    L_STATUS_ADD1.Text = "Stopped";
                }
                else
                {
                    L_STATUS_ADD1.Text = "Остановлено";
                }
                L_STATUS_ADD1.ForeColor = System.Drawing.Color.Red;
                TB_NAME_ADD1.Visible = false;
                BT_CHECK_ADD1.Visible = false;
                BT_CHECK_ADD1.Enabled = false;
                BT_EDIT_ADD1.Visible = false;
                BT_EDIT_ADD1.Enabled = false;
                BT_DELETE_ADD1.Visible = false;
                BT_DELETE_ADD1.Enabled = false;
                TB_OPEN_ADD1.Visible = false;
                TB_CLOSE_ADD1.Visible = false;
                TB_MAX_ADD1.Visible = false;
                TB_MIN_ADD1.Visible = false;
                L_STATUS_ADD1.Visible = false;
                L_CHANGE_ADD1.Visible = false;
                L_LOG_ADD1.Visible = false;
                SW_ADD1.Visible = false;
                SW_DB_ADD1.Visible = false;
                UD_NOT_CHANGE_ADD1.Visible = false;
                SW_NOT_CHANGE_ADD1.Visible = false;
                SW_LOG_ADD1.Visible = false;
                BT_ADD_ADD1.Visible = true;
                BT_ADD_ADD1.Enabled = true;
                BT_ADD_ADD2.Visible = false;
                BT_ADD_ADD2.Enabled = false;
            }
            GB_TELEGRAM_SETTINGS.Location = new Point(13, 290);
            GB_BACKUP_SETTINGS.Location = new Point(728, 290);
            GB_LANGUAGE.Location = new Point(1182, 375);
            L_DATE.Location = new Point(1185, 445);
            GB_NOT_SETTINGS.Size = new Size(198, 267);
            GB_DB_SETTINGS.Size = new Size(204, 268);
            this.Size = new Size(1404, 521);
        }

        private void BT_DELETE_ADD2_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD2.Text = "";
            TB_OPEN_ADD2.Text = "";
            TB_OPEN_ADD2.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_CLOSE_ADD2.Text = "";
            TB_CLOSE_ADD2.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_MAX_ADD2.Text = "";
            TB_MAX_ADD2.BackColor = System.Drawing.Color.WhiteSmoke;
            TB_MIN_ADD2.Text = "";
            TB_MIN_ADD2.BackColor = System.Drawing.Color.WhiteSmoke;
            L_CHANGE_ADD2.Text = "";
            L_LOG_ADD2.Text = "";
            SW_ADD2.Checked = false;
            SW_DB_ADD2.Checked = false;
            UD_NOT_CHANGE_ADD2.Value = 0;
            SW_NOT_CHANGE_ADD2.Checked = false;
            SW_LOG_ADD2.Checked = false;
            if (SW_LANGUAGE.Checked)
            {
                L_STATUS_ADD2.Text = "Stopped";
            }
            else
            {
                L_STATUS_ADD2.Text = "Остановлено";
            }
            L_STATUS_ADD2.ForeColor = System.Drawing.Color.Red;
            TB_NAME_ADD2.Visible = false;
            BT_CHECK_ADD2.Visible = false;
            BT_CHECK_ADD2.Enabled = false;
            BT_EDIT_ADD2.Visible = false;
            BT_EDIT_ADD2.Enabled = false;
            BT_DELETE_ADD2.Visible = false;
            BT_DELETE_ADD2.Enabled = false;
            TB_OPEN_ADD2.Visible = false;
            TB_CLOSE_ADD2.Visible = false;
            TB_MAX_ADD2.Visible = false;
            TB_MIN_ADD2.Visible = false;
            L_STATUS_ADD2.Visible = false;
            L_LOG_ADD2.Visible = false;
            L_CHANGE_ADD2.Visible = false;
            SW_ADD2.Visible = false;
            SW_DB_ADD2.Visible = false;
            UD_NOT_CHANGE_ADD2.Visible = false;
            SW_NOT_CHANGE_ADD2.Visible = false;
            SW_LOG_ADD2.Visible = false;
            BT_ADD_ADD2.Visible = true;
            BT_ADD_ADD2.Enabled = true;
            BT_DELETE_ADD1.Visible = true;
            BT_DELETE_ADD1.Enabled = true;

            

        }

        private void BT_EDIT_DBNAME_Click(object sender, EventArgs e)
        {
            TB_DBNAME.ReadOnly = false;
            TB_DBNAME.Enabled = true;
            BT_EDIT_DBNAME.Visible = false;
            BT_EDIT_DBNAME.Enabled = false;
            BT_CHECK_DBNAME.Visible = true;
            BT_CHECK_DBNAME.Enabled = true;
        }

        private void BT_CHECK_DBNAME_Click(object sender, EventArgs e)
        {
            TB_DBNAME.ReadOnly = true;
            TB_DBNAME.Enabled = false;
            BT_EDIT_DBNAME.Visible = true;
            BT_EDIT_DBNAME.Enabled = true;
            BT_CHECK_DBNAME.Visible = false;
            BT_CHECK_DBNAME.Enabled = false;
        }

        private void BT_EDIT_LOCALHOST_Click(object sender, EventArgs e)
        {
            TB_LOCALHOST.ReadOnly = false;
            TB_LOCALHOST.Enabled = true;
            BT_EDIT_LOCALHOST.Visible = false;
            BT_EDIT_LOCALHOST.Enabled = false;
            BT_CHECK_LOCALHOST.Visible = true;
            BT_CHECK_LOCALHOST.Enabled = true;
        }

        private void BT_CHECK_LOCALHOST_Click(object sender, EventArgs e)
        {
            TB_LOCALHOST.ReadOnly = true;
            TB_LOCALHOST.Enabled = false;
            BT_EDIT_LOCALHOST.Visible = true;
            BT_EDIT_LOCALHOST.Enabled = true;
            BT_CHECK_LOCALHOST.Visible = false;
            BT_CHECK_LOCALHOST.Enabled = false;
        }

        private void BT_EDIT_NOT_BOT_TELEGRAM_TOKEN_Click(object sender, EventArgs e)
        {
            TB_NOT_BOT_TELEGRAM_TOKEN.ReadOnly = false;
            TB_NOT_BOT_TELEGRAM_TOKEN.Enabled = true;
            BT_EDIT_NOT_BOT_TELEGRAM_TOKEN.Visible = false;
            BT_EDIT_NOT_BOT_TELEGRAM_TOKEN.Enabled = false;
            BT_CHECK_NOT_BOT_TELEGRAM_TOKEN.Visible = true;
            BT_CHECK_NOT_BOT_TELEGRAM_TOKEN.Enabled = true;
            TB_NOT_BOT_TELEGRAM_TOKEN.UseSystemPasswordChar = false;
        }

        private void BT_CHECK_NOT_BOT_TELEGRAM_TOKEN_Click(object sender, EventArgs e)
        {
            TB_NOT_BOT_TELEGRAM_TOKEN.ReadOnly = true;
            TB_NOT_BOT_TELEGRAM_TOKEN.Enabled = false;
            BT_EDIT_NOT_BOT_TELEGRAM_TOKEN.Visible = true;
            BT_EDIT_NOT_BOT_TELEGRAM_TOKEN.Enabled = true;
            BT_CHECK_NOT_BOT_TELEGRAM_TOKEN.Visible = false;
            BT_CHECK_NOT_BOT_TELEGRAM_TOKEN.Enabled = false;
            TB_NOT_BOT_TELEGRAM_TOKEN.UseSystemPasswordChar = true;

            try
            {
                if (TB_NOT_BOT_TELEGRAM_TOKEN.Text != "" && SW_NOT_BOT_TELEGRAM.Checked)
                {
                    NotificationTelegramBot.Init(TB_NOT_BOT_TELEGRAM_TOKEN.Text);
                }
                else
                {
                    NotificationTelegramBot.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при проверке токена, проверьте введенный TOKEN");
                LogTelegramBot.Send("Произошла ошибка при проверке токена Notification Bot, проверьте введенный TOKEN").ConfigureAwait(false);
            }
        }


        private void TB_EDIT_LOG_BOT_TELEGRAM_Click(object sender, EventArgs e)
        {
            TB_LOG_BOT_TELEGRAM_TOKEN.ReadOnly = false;
            TB_LOG_BOT_TELEGRAM_TOKEN.Enabled = true;
            BT_EDIT_LOG_BOT_TELEGRAM_TOKEN.Visible = false;
            BT_EDIT_LOG_BOT_TELEGRAM_TOKEN.Enabled = false;
            BT_CHECK_LOG_BOT_TELEGRAM_TOKEN.Visible = true;
            BT_CHECK_LOG_BOT_TELEGRAM_TOKEN.Enabled = true;
            TB_LOG_BOT_TELEGRAM_TOKEN.UseSystemPasswordChar = false;
        }

        private void BT_CHECK_LOG_BOT_TELEGRAM_TOKEN_Click(object sender, EventArgs e)
        {
            TB_LOG_BOT_TELEGRAM_TOKEN.ReadOnly = true;
            TB_LOG_BOT_TELEGRAM_TOKEN.Enabled = false;
            BT_EDIT_LOG_BOT_TELEGRAM_TOKEN.Visible = true;
            BT_EDIT_LOG_BOT_TELEGRAM_TOKEN.Enabled = true;
            BT_CHECK_LOG_BOT_TELEGRAM_TOKEN.Visible = false;
            BT_CHECK_LOG_BOT_TELEGRAM_TOKEN.Enabled = false;
            TB_LOG_BOT_TELEGRAM_TOKEN.UseSystemPasswordChar = true;
            try
            {
                if (TB_LOG_BOT_TELEGRAM_TOKEN.Text != "" && SW_LOG_BOT_TELEGRAM.Checked)
                {
                    LogTelegramBot.Init(TB_NOT_BOT_TELEGRAM_TOKEN.Text);
                }
                else
                {
                    LogTelegramBot.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при проверке токена, проверьте введенный TOKEN");

            }
        }


        private void BT_EDIT_BACKUP_Click(object sender, EventArgs e)
        {
            TB_DIRECTORY_BACKUP.ReadOnly = false;
            TB_DIRECTORY_BACKUP.Enabled = true;
            BT_EDIT_BACKUP.Visible = false;
            BT_EDIT_BACKUP.Enabled = false;
            BT_CHECK_BACKUP.Visible = true;
            BT_CHECK_BACKUP.Enabled = true;
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TB_DIRECTORY_BACKUP.Text = fbd.SelectedPath;
                    SaveBackupSettings();
                }
            }
        }

        private void BT_CHECK_BACKUP_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Directory.Exists(TB_DIRECTORY_BACKUP.Text))
                {
                    TB_DIRECTORY_BACKUP.ReadOnly = true;
                    TB_DIRECTORY_BACKUP.Enabled = false;
                    BT_EDIT_BACKUP.Visible = true;
                    BT_EDIT_BACKUP.Enabled = true;
                    BT_CHECK_BACKUP.Visible = false;
                    BT_CHECK_BACKUP.Enabled = false;
                    Directory.CreateDirectory(TB_DIRECTORY_BACKUP.Text);
                    MessageBox.Show("Директория успешно создана!");
                }
                TB_DIRECTORY_BACKUP.ReadOnly = true;
                TB_DIRECTORY_BACKUP.Enabled = false;
                BT_EDIT_BACKUP.Visible = true;
                BT_EDIT_BACKUP.Enabled = true;
                BT_CHECK_BACKUP.Visible = false;
                BT_CHECK_BACKUP.Enabled = false;
                SaveBackupSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания директории: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SW_MAIN = SW_MAIN.Checked;
            Properties.Settings.Default.SW_LCO = SW_LCO.Checked;
            Properties.Settings.Default.SW_DB_LCO = SW_DB_LCO.Checked;
            Properties.Settings.Default.SW_G = SW_G.Checked;
            Properties.Settings.Default.SW_DB_G = SW_DB_G.Checked;
            Properties.Settings.Default.SW_S = SW_S.Checked;
            Properties.Settings.Default.SW_DB_S = SW_DB_S.Checked;
            Properties.Settings.Default.TB_KEY = TB_KEY.Text;
            Properties.Settings.Default.TB_SECRET = TB_SECRET.Text;
            Properties.Settings.Default.TB_DBNAME = TB_DBNAME.Text;
            Properties.Settings.Default.TB_LOCALHOST = TB_LOCALHOST.Text;
            Properties.Settings.Default.TB_NAME_ADD1 = TB_NAME_ADD1.Text;
            Properties.Settings.Default.TB_NAME_ADD2 = TB_NAME_ADD2.Text;
            Properties.Settings.Default.SW_ADD1 = SW_ADD1.Checked;
            Properties.Settings.Default.SW_ADD2 = SW_ADD2.Checked;
            Properties.Settings.Default.SW_DB_ADD1 = SW_DB_ADD1.Checked;
            Properties.Settings.Default.SW_DB_ADD2 = SW_DB_ADD2.Checked;


            //Телега и уведомления
            Properties.Settings.Default.SW_NOT_BOT_TELEGRAM = SW_NOT_BOT_TELEGRAM.Checked;
            Properties.Settings.Default.SW_LOG_BOT_TELEGRAM = SW_LOG_BOT_TELEGRAM.Checked;
            Properties.Settings.Default.TB_NOT_BOT_TELEGRAM_TOKEN = TB_NOT_BOT_TELEGRAM_TOKEN.Text;
            Properties.Settings.Default.TB_LOG_BOT_TELEGRAM_TOKEN = TB_LOG_BOT_TELEGRAM_TOKEN.Text;
            Properties.Settings.Default.SW_NOT_CHANGE_LCO = SW_NOT_CHANGE_LCO.Checked;
            Properties.Settings.Default.SW_NOT_CHANGE_G = SW_NOT_CHANGE_G.Checked;
            Properties.Settings.Default.SW_NOT_CHANGE_S = SW_NOT_CHANGE_S.Checked;
            Properties.Settings.Default.SW_NOT_CHANGE_ADD1 = SW_NOT_CHANGE_ADD1.Checked;
            Properties.Settings.Default.SW_NOT_CHANGE_ADD2 = SW_NOT_CHANGE_ADD2.Checked;
            Properties.Settings.Default.SW_LOG_LCO = SW_LOG_LCO.Checked;
            Properties.Settings.Default.SW_LOG_G = SW_LOG_G.Checked;
            Properties.Settings.Default.SW_LOG_S = SW_LOG_S.Checked;
            Properties.Settings.Default.SW_LOG_ADD1 = SW_LOG_ADD1.Checked;
            Properties.Settings.Default.SW_LOG_ADD2 = SW_LOG_ADD2.Checked;
            Properties.Settings.Default.UD_NOT_CHANGE_LCO = UD_NOT_CHANGE_LCO.Value;
            Properties.Settings.Default.UD_NOT_CHANGE_G = UD_NOT_CHANGE_G.Value;
            Properties.Settings.Default.UD_NOT_CHANGE_S = UD_NOT_CHANGE_S.Value;
            Properties.Settings.Default.UD_NOT_CHANGE_ADD1 = UD_NOT_CHANGE_ADD1.Value;
            Properties.Settings.Default.UD_NOT_CHANGE_ADD2 = UD_NOT_CHANGE_ADD2.Value;


            Properties.Settings.Default.SW_BACKUP = SW_BACKUP.Checked;
            Properties.Settings.Default.SW_BACKUP_TELEGRAM = SW_BACKUP_TELEGRAM.Checked;

            Properties.Settings.Default.SW_DAILYREPORT = SW_DAILYREPORT.Checked;

            Properties.Settings.Default.DTP_BACKUP = (DTP_BACKUP.Value).ToString();

            Properties.Settings.Default.SW_LANGUAGE = SW_LANGUAGE.Checked;

            Properties.Settings.Default.Save();
        }

        private void BT_TELEGRAM_Click(object sender, EventArgs e)
        {
            NotificationTelegramBot.Send("Тестовое сообщение");
        }

        private void UD_DAYS_BACKUP_ValueChanged(object sender, EventArgs e)
        {
            if (SW_LANGUAGE.Checked)
            {
                if (UD_DAYS_BACKUP.Value == 1)
                {
                    label26.Text = "day in";
                }
                else
                {
                    label26.Text = "days in";
                }
            }
            else
            {
                if (UD_DAYS_BACKUP.Value == 1)
                {
                    label26.Text = "день в";
                }
                else
                {
                    label26.Text = "дней в";
                }
            }
            Properties.Settings.Default.UD_DAYS_BACKUP = (int)UD_DAYS_BACKUP.Value;
            Properties.Settings.Default.Save();
        }
        private void UD_STORE_BACKUP_ValueChanged(object sender, EventArgs e)
        {
            if (SW_LANGUAGE.Checked)
            {
                if (UD_STORE_BACKUP.Value == 1)
                {
                    label28.Text = "backup";
                }
                else
                {
                    label28.Text = "backups";
                }
            }
            else
            {
                if (UD_STORE_BACKUP.Value == 1)
                {
                    label28.Text = "бэкапа";
                }
                else
                {
                    label28.Text = "бэкапов";
                }
            }
            
            Properties.Settings.Default.UD_STORE_BACKUP = (int)UD_STORE_BACKUP.Value;
            Properties.Settings.Default.Save();
            PerformScheduledBackup(0);


        }

        private void DTP_BACKUP_ValueChanged(object sender, EventArgs e)
        {
            backupTimer.Interval = CalculateInterval();
            backupTimer.Start(); // Перезапускаем таймер
        }

        private void SW_BACKUP_TELEGRAM_EnabledChanged(object sender, EventArgs e)
        {
            PerformScheduledBackup(0);
        }

        private void SW_LANGUAGE_CheckedChanged(object sender)
        {
            if (SW_LANGUAGE.Checked == false)
            {
                L_BX_STATUS.Text = "Статус подключения к бирже:";
                L_BX_STATUS.Location = new System.Drawing.Point(140, 15);
                label16.Text = "Версия от";
                label16.Location = new System.Drawing.Point(705, 15);
                GB_DB_SETTINGS.Text = "Настройки БД";
                label19.Text = "Имя БД";
                label18.Text = "Порт";
                GB_NOT_SETTINGS.Text = "Настройки уведомлений";
                label30.Text = "Ежедневный отчет о работе приложения";
                label3.Text = "Открытие";
                label3.Location = new System.Drawing.Point(155, 134);
                label4.Text = "Закрытие";
                label4.Location = new System.Drawing.Point(234, 134);
                label5.Text = "Макс";
                label5.Location = new System.Drawing.Point(324, 134);
                label6.Text = "Мин";
                label6.Location = new System.Drawing.Point(398, 134);
                label17.Text = "Изменение";
                label17.Location = new System.Drawing.Point(447, 134);
                label11.Text = "Статус";
                label11.Location = new System.Drawing.Point(560, 134);
                label12.Text = "Лог";
                label20.Text = "Состояние";
                label20.Location = new System.Drawing.Point(885, 134);
                label21.Text = "Сохранение в БД";
                label21.Location = new System.Drawing.Point(1008, 134);
                label22.Text = "Изменение (%)";
                label23.Text = "Лог";
                GB_TELEGRAM_SETTINGS.Text = "Настройки Telegram";
                label8.Text = "Бот для уведомлений";
                label10.Text = "Бот для лога";
                label7.Text = "Токен";
                label9.Text = "Токен";
                label31.Text = "Лог";
                GB_BACKUP_SETTINGS.Text = "Настройки бэкапа";
                label29.Text = "Отправлять в TG";
                label24.Text = "Директория";
                TB_DIRECTORY_BACKUP.Size = new Size(296, 27);
                TB_DIRECTORY_BACKUP.Location = new Point(109,57);
                label25.Text = "Сохранять каждые";
                UD_DAYS_BACKUP.Location = new Point(156, 88);
                label26.Text = "дней в";
                label26.Location = new Point(209, 91);
                DTP_BACKUP.Location = new Point(263, 88);
                label27.Text = "Хранить не более";
                label28.Text = "бэкапов";
                label32.Text = "Лог";
                GB_LANGUAGE.Text = "Язык интерфейса";
                if (L_BINGX_STATUS.Text == "Stopped")
                    L_BINGX_STATUS.Text = "Остановлено";

                if (L_STATUS_LCO.Text == "Stopped")
                    L_STATUS_LCO.Text = "Остановлено";

                if (L_STATUS_G.Text == "Stopped")
                    L_STATUS_G.Text = "Остановлено";

                if (L_STATUS_S.Text == "Stopped")
                    L_STATUS_S.Text = "Остановлено";

                if (L_STATUS_ADD1.Text == "Stopped")
                    L_STATUS_ADD1.Text = "Остановлено";

                if (L_STATUS_ADD2.Text == "Stopped")
                    L_STATUS_ADD2.Text = "Остановлено";

            }
            else
            {
                L_BX_STATUS.Text = "BINGX CONNECTION STATUS";
                label16.Text = "Version from";
                label16.Location = new Point(695, 16);
                GB_DB_SETTINGS.Text = "Database settings";
                label19.Text = "DB Name";
                label18.Text = "Port";
                GB_NOT_SETTINGS.Text = "Notifications settings";
                label30.Text = "Daily report to Telegram on the application's operation";
                label3.Text = "OPEN";
                label3.Location = new Point(171, 134);
                label4.Text = "CLOSE";
                label4.Location = new Point(245, 134);
                label5.Text = "MAX";
                label5.Location = new Point(323, 134);
                label6.Text = "MIN";
                label6.Location = new Point(402, 134);
                label17.Text = "CHANGE";
                label17.Location = new Point(456, 134);
                label11.Text = "STATUS";
                label11.Location = new Point(556, 134);
                label12.Text = "LOG";
                label20.Text = "STATE";
                label20.Location = new Point(902, 134);
                label21.Text = "SAVE TO DB";
                label21.Location = new Point(1031, 134);
                label22.Text = "CHANGE (%)";
                label22.Location = new Point(14, 118);
                label23.Text = "LOG";
                GB_TELEGRAM_SETTINGS.Text = "Telegram settings";
                label8.Text = "NOTIFICATIONS BOT";
                label10.Text = "LOG BOT";
                label7.Text = "TOKEN";
                label9.Text = "TOKEN";
                label31.Text = "LOG";
                GB_BACKUP_SETTINGS.Text = "Backup settings";
                label29.Text = "Send to TG";
                label24.Text = "Directory";
                TB_DIRECTORY_BACKUP.Size = new Size(308, 27);
                TB_DIRECTORY_BACKUP.Location = new Point(98, 57);
                label25.Text = "Save every";
                UD_DAYS_BACKUP.Location = new Point(98, 88);
                label26.Text = "days in";
                label26.Location = new Point(154, 91);
                DTP_BACKUP.Location = new Point(215, 88);
                label27.Text = "Store no more than";
                label28.Text = "backups";
                label32.Text = "LOG";
                GB_LANGUAGE.Text = "Language UI";
                if (L_BINGX_STATUS.Text == "Остановлено")
                    L_BINGX_STATUS.Text = "Stopped";

                if (L_STATUS_LCO.Text == "Остановлено")
                    L_STATUS_LCO.Text = "Stopped";

                if (L_STATUS_G.Text == "Остановлено")
                    L_STATUS_G.Text = "Stopped";

                if (L_STATUS_S.Text == "Остановлено")
                    L_STATUS_S.Text = "Stopped";

                if (L_STATUS_ADD1.Text == "Остановлено")
                    L_STATUS_ADD1.Text = "Stopped";

                if (L_STATUS_ADD2.Text == "Остановлено")
                    L_STATUS_ADD2.Text = "Stopped";
            }
        }
    }
    // Класс для управления ботом
    public static class NotificationTelegramBot
    {
        private static Label _statusLabel;
        private static CancellationTokenSource _cts;
        private static TelegramBotClient _bot;
        private static long? _chatId;
        private static readonly string ConfigFile = "telegram.cfg";
        private static readonly object LockObject = new object();

        // Инициализация бота
        public static void Init(string token)
        {
            LoadConfig();

            _bot = new TelegramBotClient(token);
            _cts = new CancellationTokenSource(); // Инициализируем токен

            _bot.StartReceiving(
                HandleUpdate,
                HandleError,
                cancellationToken: _cts.Token // Передаем токен
            );
        }

        public static void Initialize(Label statusLabel)
        {
            _statusLabel = statusLabel;
        }



        public static void Stop()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _cts = null;
            _bot = null;
            _chatId = null;
        }

        // Загрузка сохраненного chat ID
        private static void LoadConfig()
        {
            if (File.Exists(ConfigFile))
            {
                var content = File.ReadAllText(ConfigFile);
                if (long.TryParse(content, out long savedId))
                {
                    _chatId = savedId;
                }
            }
        }

        // Сохранение chat ID
        private static void SaveChatId(long id)
        {
            lock (LockObject)
            {
                _chatId = id;
                File.WriteAllText(ConfigFile, id.ToString());
            }
        }

        // Отправка сообщения
        public static async Task Send(string message)
        {
            if (_chatId.HasValue && _bot != null)
            {
                try
                {
                    await _bot.SendMessage(
                        chatId: _chatId.Value,
                        text: message
                    );
                    UpdateUI($"NOT_BOT {DateTime.Now:HH:mm} Сообщение отправлено");
                }
                catch (Exception ex)
                {
                    UpdateUI($"NOT_BOT {DateTime.Now:HH:mm} Ошибка отправки сообщения");
                }
            }
        }

        // Обработка входящих сообщений
        private static async Task HandleUpdate(ITelegramBotClient bot, Update update, CancellationToken ct)
        {
            if (update.Message?.Text == "/start" && !_chatId.HasValue)
            {
                var newChatId = update.Message.Chat.Id;
                SaveChatId(newChatId);
                await bot.SendMessage(
                    chatId: newChatId,
                    text: "Вы стали получателем уведомлений!"
                );
            }
        }

        // Обработка ошибок
        private static Task HandleError(ITelegramBotClient bot, Exception ex, CancellationToken ct)
        {
            Console.WriteLine($"Ошибка бота: {ex.Message}");
            return Task.CompletedTask;
        }


        private static void UpdateUI(string message)
        {
            if (_statusLabel != null && !_statusLabel.IsDisposed)
            {
                if (_statusLabel.InvokeRequired)
                {
                    _statusLabel.BeginInvoke(new Action(() =>
                    {
                        _statusLabel.Text = message;
                    }));
                }
                else
                {
                    _statusLabel.Text = message;
                }
            }
        }
    }



    public static class LogTelegramBot
    {
        private static Label _statusLabel;
        private static CancellationTokenSource _cts;
        private static TelegramBotClient _bot;
        private static long? _chatId;
        private static readonly string ConfigFile = "log_telegram.cfg";
        private static readonly object LockObject = new object();

        // Инициализация бота
        public static void Init(string token)
        {
            LoadConfig();

            _bot = new TelegramBotClient(token);
            _cts = new CancellationTokenSource(); // Инициализируем токен

            _bot.StartReceiving(
                HandleUpdate,
                HandleError,
                cancellationToken: _cts.Token // Передаем токен
            );
        }

        public static void Initialize(Label statusLabel)
        {
            _statusLabel = statusLabel;
        }


        public static void Stop()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _cts = null;
            _bot = null;
            _chatId = null;
        }

        // Загрузка сохраненного chat ID
        private static void LoadConfig()
        {
            if (File.Exists(ConfigFile))
            {
                var content = File.ReadAllText(ConfigFile);
                if (long.TryParse(content, out long savedId))
                {
                    _chatId = savedId;
                }
            }
        }

        // Сохранение chat ID
        private static void SaveChatId(long id)
        {
            lock (LockObject)
            {
                _chatId = id;
                File.WriteAllText(ConfigFile, id.ToString());
            }
        }

        // Отправка сообщения
        public static async Task Send(string message)
        {
            if (_chatId.HasValue && _bot != null)
            {
                try
                {
                    await _bot.SendMessage(
                        chatId: _chatId.Value,
                        text: message
                    );
                    UpdateUI($"LOG_BOT {DateTime.Now:HH:mm} Сообщение отправлено");
                }
                catch (Exception ex)
                {
                    UpdateUI($"LOG_BOT {DateTime.Now:HH:mm} Ошибка: {ex.Message}");
                }
            }
        }


        public static async Task SendDocument(InputFileStream document, string caption = "")
        {
            if (_chatId.HasValue && _bot != null)
            {
                try
                {
                    await _bot.SendDocument(
                        chatId: _chatId.Value,
                        document: document,
                        caption: caption
                    );
                    UpdateUI($"LOG_BOT {DateTime.Now:HH:mm} Документ отправлен");
                }
                catch (Exception ex)
                {
                    UpdateUI($"LOG_BOT {DateTime.Now:HH:mm} Ошибка: {ex.Message}");
                }
            }
        }

        // Обработка входящих сообщений
        private static async Task HandleUpdate(ITelegramBotClient bot, Update update, CancellationToken ct)
        {
            if (update.Message?.Text == "/start" && !_chatId.HasValue)
            {
                var newChatId = update.Message.Chat.Id;
                SaveChatId(newChatId);
                await bot.SendMessage(
                    chatId: newChatId,
                    text: "Вы стали получателем уведомлений!"
                );
            }
        }

        // Обработка ошибок
        private static Task HandleError(ITelegramBotClient bot, Exception ex, CancellationToken ct)
        {
            Console.WriteLine($"Ошибка бота: {ex.Message}");
            return Task.CompletedTask;
        }



        private static void UpdateUI(string message)
        {
            if (_statusLabel != null && !_statusLabel.IsDisposed)
            {
                if (_statusLabel.InvokeRequired)
                {
                    _statusLabel.BeginInvoke(new Action(() =>
                    {
                        _statusLabel.Text = message;
                    }));
                }
                else
                {
                    _statusLabel.Text = message;
                }
            }
        }


    }
}
