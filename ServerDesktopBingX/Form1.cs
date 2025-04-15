
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Linq.Expressions;
using ServerDesktopBingX.Controls;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ServerDesktopBingX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            UpdateDateTimeAsync();
            //TB_KEY.Text = "w1RI3Q6HD5Q5Xu2bphWC6G1YnKRl6xR6pZvlbbWhGIxc68yhHg8B6pIwoWd8nrxyYPxpLydOPrsDWz0KAVHBw";
            //TB_SECRET.Text = "O7bPmfWDsIrEn5NO4mE0kNSjVQMj7P66NzJPrI1TjN1HoA9hDLCrtgBKleU5KGwt5XhwH9z8coLUz6vSg";
            //TB_DBNAME.Text = "CDA";
            //TB_LOCALHOST.Text = "27017";
            L_VERSION.Text = "15.04.2025";
            string API_KEY = TB_KEY.Text;
            string API_SECRET = TB_SECRET.Text;
            string HOST = "open-api.bingx.com";


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


            if (true)
            {
                SW_MAIN.Checked = Properties.Settings.Default.SW_MAIN;
                if (SW_MAIN.Checked == true)
                {
                    L_BINGX_STATUS.Text = "Connecting...";
                    L_BINGX_STATUS.ForeColor = Color.DarkOrange;
                }

                SW_LCO.Checked = Properties.Settings.Default.SW_LCO;
                if (SW_LCO.Checked == true)
                {
                    L_STATUS_LCO.Text = "Connecting...";
                    L_STATUS_LCO.ForeColor = Color.DarkOrange;
                }
                SW_DB_LCO.Checked = Properties.Settings.Default.SW_DB_LCO;

                SW_NG.Checked = Properties.Settings.Default.SW_NG;
                if (SW_NG.Checked == true)
                {
                    L_STATUS_NG.Text = "Connecting...";
                    L_STATUS_NG.ForeColor = Color.DarkOrange;
                }
                SW_DB_NG.Checked = Properties.Settings.Default.SW_DB_NG;

                SW_S.Checked = Properties.Settings.Default.SW_S;
                if (SW_S.Checked == true)
                {
                    L_STATUS_S.Text = "Connecting...";
                    L_STATUS_S.ForeColor = Color.DarkOrange;
                }
                SW_DB_S.Checked = Properties.Settings.Default.SW_DB_S;

                if (Properties.Settings.Default.TB_NAME_ADD1 != "")
                {
                    TB_NAME_ADD1.Text = Properties.Settings.Default.TB_NAME_ADD1;
                    SW_ADD1.Checked = Properties.Settings.Default.SW_ADD1;
                    if (SW_ADD1.Checked == true)
                    {
                        L_STATUS_ADD1.Text = "Connecting...";
                        L_STATUS_ADD1.ForeColor = Color.DarkOrange;
                    }
                    SW_DB_ADD1.Checked = Properties.Settings.Default.SW_DB_ADD1;
                }

                if (Properties.Settings.Default.TB_NAME_ADD2 != "")
                {
                    TB_NAME_ADD2.Text = Properties.Settings.Default.TB_NAME_ADD2;
                    SW_ADD2.Checked = Properties.Settings.Default.SW_ADD2;
                    if (SW_ADD1.Checked == true)
                    {
                        L_STATUS_ADD2.Text = "Connecting...";
                        L_STATUS_ADD2.ForeColor = Color.DarkOrange;
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
                    D1_ADD1.Visible = false;
                    H4_ADD1.Visible = false;
                    H1_ADD1.Visible = false;
                    M5_ADD1.Visible = false;
                    L_STATUS_ADD1.Visible = false;
                    L_LOG_ADD1.Visible = false;
                    SW_ADD1.Visible = false;
                    SW_DB_ADD1.Visible = false;
                    this.Size = new System.Drawing.Size(1206, 325);
                }
                else
                {
                    BT_ADD_ADD1.Visible = false;
                    BT_ADD_ADD1.Enabled = false;
                    this.Size = new System.Drawing.Size(1206, 359);
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
                    D1_ADD2.Visible = false;
                    H4_ADD2.Visible = false;
                    H1_ADD2.Visible = false;
                    M5_ADD2.Visible = false;
                    L_STATUS_ADD2.Visible = false;
                    L_LOG_ADD2.Visible = false;
                    SW_ADD2.Visible = false;
                    SW_DB_ADD2.Visible = false;
                    BT_ADD_ADD2.Visible = true;
                    BT_ADD_ADD2.Enabled = true;
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
                RunAssetUpdate(TB_NAME_ADD1.Text, "ADD1", _cts.Token)
                };
                }
                else if (TB_NAME_ADD1.Text != "" && TB_NAME_ADD2.Text != "")
                {
                    tasks = new List<Task>
                {
                RunAssetUpdate("Oil - Brent Crude", "LCO", _cts.Token),
                RunAssetUpdate("Silver", "S", _cts.Token),
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
                };
                }
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Произошла ошибка: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
                                    label.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
                await Task.Delay(700); // Задержка между запросами
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
            return time >= new TimeSpan(4, 0, 0) && time < new TimeSpan(24, 0, 0);
            
        }

        private bool IsTradingTimeMetal(DateTime moscowTime)
        {
            // Проверка выходных
            if (moscowTime.DayOfWeek == DayOfWeek.Saturday ||
                moscowTime.DayOfWeek == DayOfWeek.Sunday)
                return false;

            TimeSpan time = moscowTime.TimeOfDay;
            DayOfWeek day = moscowTime.DayOfWeek;
            return time >= new TimeSpan(2, 0, 0) && time < new TimeSpan(24, 0, 0);

        }

        void UpdateUIElements(string suffix, dynamic item)
        {
            var moscowTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time"); // Для Linux используйте "Europe/Moscow"
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscowTimeZone);

            // MongoDB
            var mongoClient = new MongoClient($"mongodb://localhost:{TB_LOCALHOST.Text}");
            var database = mongoClient.GetDatabase($"{TB_DBNAME.Text}");
            // Вспомогательные функции для работы с элементами UI
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

            void SetColorForAll(Color color)
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

            void SetColorForChange(Color color)
            {
                var change = Controls.Find($"L_CHANGE_{suffix}", true).FirstOrDefault();
                change.ForeColor = color;
            }






            // Основная логика
            var currentPrice = item.currentPrice.ToString();

            if (now.Minute % 5 == 0 && now.Second == 0)
            {
                DateTime barStart = now.AddMinutes(-5);
                // Сбор данных предыдущего бара
                var previousOpen = GetTextBoxValue("OPEN");
                var previousClose = GetTextBoxValue("CLOSE");
                var previousMax = GetTextBoxValue("MAX");
                var previousMin = GetTextBoxValue("MIN");
                var log = Controls.Find($"L_LOG_{suffix}", true).FirstOrDefault();
                var sw_db = Controls.Find($"SW_DB_{suffix}", true).FirstOrDefault() as ToggleSwitch;
                bool Session = true;
                if (suffix == "S" || suffix == "G" || suffix == "P")
                {
                    Session = IsTradingTimeMetal(barStart);
                }
                else if (suffix == "LCO" || suffix == "NG")
                {
                    Session = IsTradingTimeResources(barStart);
                }
                else
                {
                    Session = true;
                }
                if ((Session == true) && (sw_db.Checked == true))
                {
                    if (!string.IsNullOrEmpty(previousOpen)
                    && !string.IsNullOrEmpty(previousClose)
                    && !string.IsNullOrEmpty(previousMax)
                    && !string.IsNullOrEmpty(previousMin))
                    {
                        try
                        {
                            // Вычисление времени начала предыдущего бара (5 минут назад)


                            // Формируем документ
                            var document = new BsonDocument
                {
                    { "Date", barStart.ToString("yyyy-MM-dd") },
                    { "Time", barStart.ToString("HH:mm") },
                    { "Open", Convert.ToDouble(previousOpen) },
                    { "Close", Convert.ToDouble(previousClose) },
                    { "High", Convert.ToDouble(previousMax) },
                    { "Low", Convert.ToDouble(previousMin) },
                    { "Change", Math.Round(
                        (Convert.ToDouble(previousClose) - Convert.ToDouble(previousOpen))
                        / Convert.ToDouble(previousOpen) * 100,
                        2 // Округление до 2 знаков
                        )  }
                };

                            // Имя коллекции: "NG_5M" (пример для suffix = "NG")
                            var collection = database.GetCollection<BsonDocument>($"{suffix}_5M");

                            // Асинхронная вставка
                            var _ = collection.InsertOneAsync(document);
                            log.Text = $"Бар {barStart.ToString("HH:mm")} сохранён";
                        }

                        catch (Exception ex)
                        {

                            log.Text = "Ошибка MongoDB";
                        }
                    }

                    // Сброс значений для нового бара
                    SafeSetTextBox("OPEN", currentPrice);
                    SafeSetTextBox("CLOSE", currentPrice);
                    SafeSetTextBox("MAX", currentPrice);
                    SafeSetTextBox("MIN", currentPrice);
                }
            }
            else
            {
                SafeSetTextBox("CLOSE", currentPrice);
            }


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
                    SetColorForAll(Color.White);
                }
                else if (openValue > closeValue)
                {
                    SetColorForAll(Color.LightPink);
                }
                else
                {
                    SetColorForAll(Color.LightGreen);
                }
                L_BINGX_STATUS.Text = "Connected";
                L_BINGX_STATUS.ForeColor = Color.Green;
                var l = Controls.Find($"L_STATUS_{suffix}", true).FirstOrDefault() as Label;
                l.Text = "Connected";
                l.ForeColor = Color.Green;


                if (openValue == closeValue)
                {
                    SetColorForChange(Color.Black);
                }
                else if (openValue > closeValue)
                {
                    SetColorForChange(Color.Red);
                }
                else
                {
                    SetColorForChange(Color.Green);
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
                L_BINGX_STATUS.Text = "Stopped";
                L_BINGX_STATUS.ForeColor = Color.Red;
                L_STATUS_LCO.Text = "Stopped";
                L_STATUS_LCO.ForeColor = Color.Red;
                L_STATUS_NG.Text = "Stopped";
                L_STATUS_NG.ForeColor = Color.Red;
                L_STATUS_S.Text = "Stopped";
                L_STATUS_S.ForeColor = Color.Red;
                L_STATUS_ADD1.Text = "Stopped";
                L_STATUS_ADD1.ForeColor = Color.Red;
                L_STATUS_ADD2.Text = "Stopped";
                L_STATUS_ADD2.ForeColor = Color.Red;

            }
            else
            {
                L_BINGX_STATUS.Text = "Connecting...";
                L_BINGX_STATUS.ForeColor = Color.DarkOrange;
                if (SW_LCO.Checked == true)
                {
                    L_STATUS_LCO.Text = "Connecting...";
                    L_STATUS_LCO.ForeColor = Color.DarkOrange;
                }
                if (SW_NG.Checked == true)
                {
                    L_STATUS_NG.Text = "Connecting...";
                    L_STATUS_NG.ForeColor = Color.DarkOrange;
                }
                if (SW_S.Checked == true)
                {
                    L_STATUS_S.Text = "Connecting...";
                    L_STATUS_S.ForeColor = Color.DarkOrange;
                }
                if (SW_ADD1.Checked == true)
                {
                    L_STATUS_ADD1.Text = "Connecting...";
                    L_STATUS_ADD1.ForeColor = Color.DarkOrange;
                }
                if (SW_ADD2.Checked == true)
                {
                    L_STATUS_ADD2.Text = "Connecting...";
                    L_STATUS_ADD2.ForeColor = Color.DarkOrange;
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
            D1_ADD1.Visible = true;
            H4_ADD1.Visible = true;
            H1_ADD1.Visible = true;
            M5_ADD1.Visible = true;
            L_STATUS_ADD1.Visible = true;
            L_LOG_ADD1.Visible = true;
            L_CHANGE_ADD1.Visible = true;
            SW_ADD1.Visible = true;
            SW_DB_ADD1.Visible = true;
            BT_ADD_ADD1.Visible = false;
            BT_ADD_ADD1.Enabled = false;
            BT_ADD_ADD2.Visible = true;
            BT_ADD_ADD2.Enabled = true;
            this.Size = new System.Drawing.Size(1206, 359);
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
            D1_ADD2.Visible = true;
            H4_ADD2.Visible = true;
            H1_ADD2.Visible = true;
            M5_ADD2.Visible = true;
            L_STATUS_ADD2.Visible = true;
            L_LOG_ADD2.Visible = true;
            L_CHANGE_ADD2.Visible = true;
            SW_ADD2.Visible = true;
            SW_DB_ADD2.Visible = true; 
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
                L_STATUS_LCO.Text = "Connecting...";
                L_STATUS_LCO.ForeColor = Color.DarkOrange;

            }
            else
            {
                L_STATUS_LCO.Text = "Stopped";
                L_STATUS_LCO.ForeColor = Color.Red;
            }
        }

        private void SW_NG_Click(object sender, EventArgs e)
        {
            if ((SW_NG.Checked == true) && (SW_MAIN.Checked == true))
            {
                L_STATUS_NG.Text = "Connecting...";
                L_STATUS_NG.ForeColor = Color.DarkOrange;

            }
            else
            {
                L_STATUS_NG.Text = "Stopped";
                L_STATUS_NG.ForeColor = Color.Red;
            }
        }

        private void SW_S_Click(object sender, EventArgs e)
        {
            if ((SW_S.Checked == true) && (SW_MAIN.Checked == true))
            {
                L_STATUS_S.Text = "Connecting...";
                L_STATUS_S.ForeColor = Color.DarkOrange;

            }
            else
            {
                L_STATUS_S.Text = "Stopped";
                L_STATUS_S.ForeColor = Color.Red;
            }
        }

        private void SW_ADD1_Click(object sender, EventArgs e)
        {
            if ((SW_ADD1.Checked == true) && (SW_MAIN.Checked == true))
            {
                L_STATUS_ADD1.Text = "Connecting...";
                L_STATUS_ADD1.ForeColor = Color.DarkOrange;

            }
            else
            {
                L_STATUS_ADD1.Text = "Stopped";
                L_STATUS_ADD1.ForeColor = Color.Red;
            }
        }

        private void SW_ADD2_Click(object sender, EventArgs e)
        {
            if ((SW_ADD2.Checked == true) && (SW_MAIN.Checked == true))
            {
                L_STATUS_ADD2.Text = "Connecting...";
                L_STATUS_ADD2.ForeColor = Color.DarkOrange;

            }
            else
            {
                L_STATUS_ADD2.Text = "Stopped";
                L_STATUS_ADD2.ForeColor = Color.Red;
            }
        }

        private void BT_DELETE_ADD1_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD1.Text = "";
            TB_OPEN_ADD1.Text = "";
            TB_OPEN_ADD1.BackColor = Color.WhiteSmoke;
            TB_CLOSE_ADD1.Text = "";
            TB_CLOSE_ADD1.BackColor = Color.WhiteSmoke;
            TB_MAX_ADD1.Text = "";
            TB_MAX_ADD1.BackColor = Color.WhiteSmoke;
            TB_MIN_ADD1.Text = "";
            TB_MIN_ADD1.BackColor = Color.WhiteSmoke;
            L_CHANGE_ADD1.Text = "";
            L_STATUS_ADD1.Text = "Stopped";
            L_STATUS_ADD1.ForeColor = Color.Red;
            L_LOG_ADD1.Text = "";
            SW_ADD1.Checked = false;
            SW_DB_ADD1.Checked = false;
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
                D1_ADD2.Visible = false;
                H4_ADD2.Visible = false;
                H1_ADD2.Visible = false;
                M5_ADD2.Visible = false;
                L_STATUS_ADD2.Visible = false;
                L_LOG_ADD2.Visible = false;
                SW_ADD2.Visible = false;
                SW_DB_ADD2.Visible = false;
                BT_ADD_ADD2.Visible = true;
                BT_ADD_ADD2.Enabled = true;
            }
            else
            {
                TB_NAME_ADD1.Text = null;
                SW_ADD1.Checked = false;
                L_STATUS_ADD1.Text = "Stopped";
                L_STATUS_ADD1.ForeColor = Color.Red;
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
                D1_ADD1.Visible = false;
                H4_ADD1.Visible = false;
                H1_ADD1.Visible = false;
                M5_ADD1.Visible = false;
                L_STATUS_ADD1.Visible = false;
                L_LOG_ADD1.Visible = false;
                SW_ADD1.Visible = false;
                SW_DB_ADD1.Visible = false;
                BT_ADD_ADD1.Visible = true;
                BT_ADD_ADD1.Enabled = true;
                BT_ADD_ADD2.Visible = false;
                BT_ADD_ADD2.Enabled = false;
                this.Size = new System.Drawing.Size(1206, 325);
            }
        }

        private void BT_DELETE_ADD2_Click(object sender, EventArgs e)
        {
            TB_NAME_ADD2.Text = "";
            TB_OPEN_ADD2.Text = "";
            TB_OPEN_ADD2.BackColor = Color.WhiteSmoke;
            TB_CLOSE_ADD2.Text = "";
            TB_CLOSE_ADD2.BackColor = Color.WhiteSmoke;
            TB_MAX_ADD2.Text = "";
            TB_MAX_ADD2.BackColor = Color.WhiteSmoke;
            TB_MIN_ADD2.Text = "";
            TB_MIN_ADD2.BackColor = Color.WhiteSmoke;
            L_CHANGE_ADD2.Text = "";
            L_LOG_ADD2.Text = "";
            SW_ADD2.Checked = false;
            SW_DB_ADD2.Checked = false;
            L_STATUS_ADD2.Text = "Stopped";
            L_STATUS_ADD2.ForeColor = Color.Red;
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
            D1_ADD2.Visible = false;
            H4_ADD2.Visible = false;
            H1_ADD2.Visible = false;
            M5_ADD2.Visible = false;
            L_STATUS_ADD2.Visible = false;
            L_LOG_ADD2.Visible = false;
            SW_ADD2.Visible = false;
            SW_DB_ADD2.Visible = false;
            BT_ADD_ADD2.Visible = true;
            BT_ADD_ADD2.Enabled = true;

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SW_MAIN = SW_MAIN.Checked;
            Properties.Settings.Default.SW_LCO = SW_LCO.Checked;
            Properties.Settings.Default.SW_DB_LCO = SW_DB_LCO.Checked;
            Properties.Settings.Default.SW_NG = SW_NG.Checked;
            Properties.Settings.Default.SW_DB_NG = SW_DB_NG.Checked;
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
            Properties.Settings.Default.Save();
        }
    }
}
