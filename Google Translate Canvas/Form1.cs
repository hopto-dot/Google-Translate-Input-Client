using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Translate_Canvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class line
        {
            public List<int> xCoords = new List<int>();
            public List<int> yCoords = new List<int>();
        }
        public static List<line> lines = new List<line>();

        public void addLine()
        {
            line newLine = new line();
            lines.Add(newLine);
        }

        public void addXCoordinate(int X)
        {
            try
            {
                lines[lines.Count - 1].xCoords.Add(X);
            }
            catch { }
        }
        public void addYCoordinate(int Y)
        {
            lines[lines.Count - 1].yCoords.Add(Y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvas1.clearCanvas();
        }

        public void googleRequest()
        {
            string strokesString = createCoordinateString();
            var handler = new HttpClientHandler();

            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://inputtools.google.com/request?itc=und-t-i0-handwrit&app=hwtcharpicker"))
                {
                    request.Headers.TryAddWithoutValidation("authority", "inputtools.google.com");
                    request.Headers.TryAddWithoutValidation("sec-ch-ua", "^^");
                    request.Headers.TryAddWithoutValidation("dnt", "1");
                    request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
                    request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
                    request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "^^");
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    request.Headers.TryAddWithoutValidation("origin", "https://www.google.com");
                    request.Headers.TryAddWithoutValidation("x-client-data", "CJC2yQEIo7bJAQjBtskBCKmdygEI5f3KAQjr8ssBCJ75ywEI1/zLAQjmhMwBCJqPzAEI5ZXMAQiElswBCNWWzAEIopfMARiOnssB");
                    request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-site");
                    request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
                    request.Headers.TryAddWithoutValidation("sec-fetch-dest", "empty");
                    request.Headers.TryAddWithoutValidation("referer", "https://www.google.com/");
                    request.Headers.TryAddWithoutValidation("accept-language", "ja,en-GB;q=0.9,en;q=0.8");
                    request.Headers.TryAddWithoutValidation("cookie", "CONSENT=YES+GB.en+20151207-13-0; HSID=Atn9ujhPHvPG4gkw3; SSID=AST-MQETwhKugUcRk; APISID=HvHwylBK8NbpLVo7/AaIkst7gDlb-EaSnH; SAPISID=-pRMcytaSZ6b19n-/AE9Yo7qalB8CEAulN; __Secure-1PAPISID=-pRMcytaSZ6b19n-/AE9Yo7qalB8CEAulN; __Secure-3PAPISID=-pRMcytaSZ6b19n-/AE9Yo7qalB8CEAulN; SID=Ggg2HOPlWhOlWWDaTCZCWW1Qkky3PZSp88DTtctO3-cerffc2_cE2quitFXdIc48WyQ1sQ.; __Secure-1PSID=Ggg2HOPlWhOlWWDaTCZCWW1Qkky3PZSp88DTtctO3-cerffcD4kRvlV9CGZ_7011A0S33Q.; __Secure-3PSID=Ggg2HOPlWhOlWWDaTCZCWW1Qkky3PZSp88DTtctO3-cerffcTLSdKI90KQJE3SDG7y0YjA.; 1P_JAR=2022-02-02-13; NID=511=UnCJpWt6rIvWV_o63Zn7PvO0cAmj7_9XWwX7Rb3PagsbwJvxWEJBDzXbCmslrj5whS_CGGazisWzcX-JXE1YHta1P79ByMlKake2mTkfxSTv3hW-0AX-NJAPrP90CAWDS-qToBnqdfuVwcAK_klmEZfUwBLhRoegAR6dW4uGhCmQVNVB2ZmW_0txM14_gLH01pxjbnrb686IioO8540Ljkukom5qrbt0cIfTdvETWABKZiIFBnQVlz-Y0gniuAu63UqoDyCf0hhiPfMJjDELLjX2G81DGZt1N5wVHqXLBFEUzeAV-gc3ti76rPdY_-CNxWkKCG577-og_2M; SIDCC=AJi4QfEYU4LKcD0H5vntqLHeIqDb_LUiDOc4t5lGuMhRh5peotz9DtpjhnkmS4iX4qXyjA2QnQ; __Secure-3PSIDCC=AJi4QfGFpJIr1YajQlsJnc6jPpclj6JGWAaYMdVWfe44qhq9CDE_2yHakcEw-owdLTcR7lRm4g");

                    request.Content = new StringContent("{\"itc\":\"und-t-i0-handwrit\",\"app_version\":0.4,\"api_level\":\"537.36\",\"device\":\"5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36\",\"input_type\":\"0\",\"options\":\"enable_pre_space\",\"requests\":[{\"writing_guide\":{\"writing_area_width\":260,\"writing_area_height\":260},\"pre_context\":\"\",\"max_num_results\":100,\"max_completions\":0,\"language\":\"universal\",\"ink\":" + strokesString + "}]}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=UTF-8");

                    HttpResponseMessage response = null;
                    try
                    {
                        response = httpClient.SendAsync(request).Result;
                    }
                    catch { try { response = httpClient.SendAsync(request).Result; } catch { return; } }

                    var content = response.Content.ReadAsStringAsync();

                    string[] suggestions = getSuggestionsList(content.Result);
                    if (suggestions == null) { flpSuggestions.Invoke(new MethodInvoker(delegate { tbxInput.Text += " "; return; })); }

                    flpSuggestions.Invoke(new MethodInvoker(delegate { flpSuggestions.Controls.Clear(); }));
                    if (suggestions == null) { return; }

                    foreach (string suggestion in suggestions)
                    {
                        Button newButton = new Button();
                        newButton.Click += selectButton;
                        newButton.Text = suggestion.Replace("\"", "");
                        newButton.Font = new Font("Microsoft Sans Serif", 19);

                        newButton.Width = 49;
                        newButton.Height = 49;

                        flpSuggestions.Invoke(new MethodInvoker(delegate { flpSuggestions.Controls.Add(newButton); }));
                    }
                }
            }

            void selectButton(object sender, EventArgs e)
            {
                tbxInput.Text += sender.ToString().Substring(sender.ToString().Length - 1, 1);
            }

            string[] getSuggestionsList(string response)
            {
                int snipString = -1;
                snipString = response.IndexOf("[") + 1;
                response = response.Substring(snipString);
                snipString = response.IndexOf("[") + 1;
                response = response.Substring(snipString);
                snipString = response.IndexOf("[") + 1;
                response = response.Substring(snipString);
                snipString = response.IndexOf("[") + 1;
                response = response.Substring(snipString);

                snipString = response.IndexOf("]") - 1;
                try
                {
                    response = response.Substring(1, snipString);
                }
                catch { return null; }

                string[] suggestions = response.Split(',');

                return suggestions;

            }

            string createCoordinateString()
            {
                string strokeString = string.Empty;
                string newstrokeString = string.Empty;
                int i = 1;

                foreach (line stroke in lines)
                {
                    string xString = "[";
                    string yString = "[";
                    string zString = "[";

                    foreach (int xcoord in stroke.xCoords)
                    {
                        xString += xcoord + ", ";
                        zString += i + ", ";
                        i += 50;
                    }
                    xString += "]";
                    xString = xString.Replace(", ]", "]");
                    zString += "]";
                    zString = zString.Replace(", ]", "]");

                    foreach (int ycoord in stroke.yCoords)
                    {
                        yString += ycoord + ", ";
                    }
                    yString += "]";
                    yString = yString.Replace(", ]", "]");

                    newstrokeString = $"{xString},{yString},{zString}";
                    //newstrokeString = $"[X],[Y],[Z]";
                    strokeString += "[" + newstrokeString + "],";
                }
                strokeString = "[" + strokeString + "]";
                strokeString = strokeString.Replace(",]", "]");
                

                return strokeString;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas1.undoLastLine();
        }
    }
}
