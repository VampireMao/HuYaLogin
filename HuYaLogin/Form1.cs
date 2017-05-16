using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Security;
using System.Xml;
using System.Net.Http;

namespace HuYaLogin
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] objs = new object[1];
            objs[0] = "dfds156s";
            //webBrowser1.Navigate(Application.StartupPath + @"\1.html");
            webBrowser1.DocumentText = @"<script type='text / javascript'>
        function returnString()
            {
                return 'This is a test.';
            }
    </ script > ";
            webBrowser1.ObjectForScripting = this;
            string sd = webBrowser1.Document.InvokeScript("returnString").ToString();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "2015670083";
            dataGridView1.Rows[0].Cells[1].Value = "755bacc4a7f16c59caba852fbbae5fc65153a4ac28625cdf6c72fdc5bb9b1ec9518ada7d2ccb11792c865c7f218d27989005724bfa077770bb126c38a707e6fe8854e4e96c68cee44c81a065491c518fb7a77b183b4f13bd8f7ac79d114101728128d113be45e0c2e2d1885705d47e781f7ef720838722ea4f681126bdee9639";
            //755bacc4a7f16c59caba852fbbae5fc65153a4ac28625cdf6c72fdc5bb9b1ec9518ada7d2ccb11792c865c7f218d27989005724bfa077770bb126c38a707e6fe8854e4e96c68cee44c81a065491c518fb7a77b183b4f13bd8f7ac79d114101728128d113be45e0c2e2d1885705d47e781f7ef720838722ea4f681126bdee9639
            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "2015712182";
            dataGridView1.Rows[1].Cells[1].Value = "755bacc4a7f16c59caba852fbbae5fc65153a4ac28625cdf6c72fdc5bb9b1ec9518ada7d2ccb11792c865c7f218d27989005724bfa077770bb126c38a707e6fe8854e4e96c68cee44c81a065491c518fb7a77b183b4f13bd8f7ac79d114101728128d113be45e0c2e2d1885705d47e781f7ef720838722ea4f681126bdee9639";
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            //string path = null;
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "文本文档(txt) | *.txt";
            //DialogResult res = ofd.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    path = ofd.FileName;
            //}
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string[] items = sr.ReadLine().Split('#');
            //        dataGridView1.Rows.Add();
            //        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = items[0];
            //        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = items[1];
            //    }
            //}

        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            #region webclient
            //WebClient wc = new WebClient();
            //NameValueCollection post = new NameValueCollection();

            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    string tmp = RSA("dfds156s");
            //    wc.Headers.Add("Cookie", GetCookie("http://www.huya.com/udb_web/checkLogin.php"));
            //    wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0");
            //    wc.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            //    wc.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            //    //wc.Headers.Add("Referer", "https://lgn.yy.com/lgn/oauth/authorize.do?oauth_token=" + GetOauthToken() + "&denyCallbackURL=&regCallbackURL=http://www.huya.com/udb_web/udbport2.php?do=callback&UIStyle=xelogin&rdm=0.38588997092577465");
            //    wc.Headers.Add("X-Requested-With", "XMLHttpRequest");
            //    post.Clear();
            //    post.Add("username", dataGridView1.Rows[i].Cells[0].Value.ToString());
            //    post.Add("pwdencrypt", dataGridView1.Rows[i].Cells[1].Value.ToString());
            //    post.Add("oauth_token", GetOauthToken());
            //    post.Add("UIStyle", "xelogin");
            //    post.Add("appid", "5216");
            //    post.Add("isRemMe", "0");
            //    post.Add("hiido", "1");
            //    post.Add("denyCallbackURL", "");
            //    post.Add("mxc", "");
            //    post.Add("vk", "");
            //    post.Add("mmc", "");
            //    post.Add("vv", "");

            //    byte[] byRemoteInfo = wc.UploadValues("https://lgn.yy.com/lgn/oauth/x2/s/login_asyn.do", "POST", post);

            //    string s = Encoding.UTF8.GetString(byRemoteInfo);
            //    //wc.Headers.Clear();
            //    //WebHeaderCollection headers = wc.ResponseHeaders;
            //    //wc.Headers.Add("P3P", headers["P3P"]);
            //    //wc.Headers.Add("Cookie", headers["Set-Cookie"]);
            //    //wc.Headers.Add("Server", headers["Server"]);
            //    post.Clear();
            //    //JObject obj = (JObject)JsonConvert.DeserializeObject(s);  //序列化（也可使用JToken代替JObject）
            //    //post.Add("do", "callback");
            //    //post.Add("code", obj["code"].ToString());
            //    //post.Add("hdcode", obj["hdcode"].ToString());
            //    //obj = (JObject)JsonConvert.DeserializeObject(obj["obj"].ToString());
            //    string url = "http://i.huya.com/index.php?m=ProfileSetting";
            //    post.Add("m", "ProfileSetting");
            //    post.Add("do", "ajaxGetOpenRtmpAddr");
            //    post.Add("game_id", "411");
            //    post.Add("live_desc", "经典网游之一，你喜欢吗？");
            //    post.Add("game_name", "经典怀旧");
            //    post.Add("live_flag", "0");
            //    post.Add("read_only", "0");
            //    byRemoteInfo = wc.UploadValues(url, post);

            //    s = Encoding.UTF8.GetString(byRemoteInfo);
            //    StringBuilder sb = new StringBuilder();
            //    GZipStream g = new GZipStream((Stream)(new MemoryStream(byRemoteInfo)), CompressionMode.Decompress);
            //    byte[] d = new byte[20480];
            //    int l = g.Read(d, 0, 20480);
            //    while (l > 0)
            //    {
            //        sb.Append(Encoding.UTF8.GetString(d, 0, l));
            //        l = g.Read(d, 0, 20480);
            //    }
            //    s = sb.ToString();
            //}
            #endregion

            #region HttpClient
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
            handler.AllowAutoRedirect = true;
            using (var httpClient = new HttpClient(handler))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                        { "username", dataGridView1.Rows[i].Cells[0].Value.ToString() },
                        {"pwdencrypt", dataGridView1.Rows[i].Cells[1].Value.ToString() },
                        {"oauth_token", GetOauthToken() },
                        {"UIStyle", "xelogin" },
                        {"appid", "5216" },
                        {"isRemMe", "1" },
                        {"hiido", "1" },
                        {"denyCallbackURL", "" },
                        {"mxc", "" },
                        {"vk", "" },
                        {"mmc", "" },
                        {"vv", "" }
                });
                    var response = await httpClient.PostAsync("https://lgn.yy.com/lgn/oauth/x2/s/login_asyn.do", content);
                    string s = await response.Content.ReadAsStringAsync();

                    var en = response.Headers.GetValues("Set-Cookie");
                    response.Headers.Add("Cookie", en);
                    JObject obj = (JObject)JsonConvert.DeserializeObject(s);
                    obj = (JObject)JsonConvert.DeserializeObject(obj["obj"].ToString());
                    response = await httpClient.GetAsync(obj["callbackURL"].ToString());
                    s = await response.Content.ReadAsStringAsync();
                    en = response.Headers.GetValues("Set-Cookie");
                    response.Headers.Add("Cookie", en);

                    response = await httpClient.GetAsync("https://lgn.huya.com/lgn/oauth/wck_n.do?oauth_mckey4cookie=1bceaf76d5a1804a06f179a9112341898aab904ca458f4b7643a27cbe62c101fd4e12b4bb5b167cfc306f08708a9149d&oauth_signature=6tWQSMDYFntUznNrtacIhlnkNb0%3D&reqDomainList=lgn.yy.tv,lgn.yy.com,lgn.duowan.com&rdm=0.11976557167132512");
                    s = await response.Content.ReadAsStringAsync();
                    en = response.Headers.GetValues("Set-Cookie");
                }
            }
            #endregion
        }

        #region 获取Cookie
        private string GetCookie(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 20 * 1000; //连接超时
            request.Accept = "*/*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.CookieContainer = new CookieContainer();
            request.GetResponse().Close();

            string cookiesstr = request.CookieContainer.GetCookieHeader(request.RequestUri); //把cookies转换成字符串
            return cookiesstr;
        }
        #endregion

        #region 获取oauth_token
        private string GetOauthToken()
        {
            WebClient client = new WebClient();
            NameValueCollection post = new NameValueCollection();
            post.Add("callbackURL", "http://www.huya.com/udb_web/udbport2.php?do=callback");
            byte[] byRemoteInfo = client.UploadValues("http://www.huya.com/udb_web/authorizeURL.php?do=authorizeEmbedURL", "POST", post);
            string json = Encoding.UTF8.GetString(byRemoteInfo);
            return json.Substring(json.IndexOf('=') + 1, 96);
        }
        #endregion

        #region RSA加密
        private string RSA(string str)
        {
            string hexKey = "b5f53d3e7ab166d99b91bdee1414364e97a5569d9a4da971dcf241e9aec4ee4ee7a27b203f278be7cc695207d19b9209f0e50a3ea367100e06ad635e4ccde6f8a7179d84b7b9b7365a6a7533a9909695f79f3f531ea3c329b7ede2cd9bb9722104e95c0f234f1a72222b0210579f6582fcaa9d8fa62c431a37d88a4899ebce3d";
            Func<string, byte[]> hexToBytes = (s) =>
            {
                byte[] bytes = new byte[s.Length / 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(s[i * 2] + "" + s[i * 2 + 1], 16);
                }
                return bytes;
            };

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                RSAParameters rsaParams = new RSAParameters()
                {
                    Exponent = new byte[] { 1, 0, 1 },
                    Modulus = hexToBytes(hexKey),
                };
                rsa.ImportParameters(rsaParams);

                byte[] encrypted = rsa.Encrypt(Encoding.UTF8.GetBytes(str), false);
                return BitConverter.ToString(encrypted).Replace("-", "");
            }
        }

        private byte[] FromHex(string hex)
        {
            if (string.IsNullOrEmpty(hex) || hex.Length % 2 != 0) throw new ArgumentException("not a hexidecimal string");
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes.Add(Convert.ToByte(hex.Substring(i, 2), 16));
            }
            return bytes.ToArray();
        }
        #endregion
    }
}
