using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pb_Animation.Visible = false;
            Btn_Go.Visible = false;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool Pn_H;
        Point ClientCoord;

        private void Pnl_Header_MouseDown(object sender, MouseEventArgs e)
        {
            Pn_H = true;
            ClientCoord = PointToClient(Cursor.Position);
        }

        private void Pnl_Header_MouseUp(object sender, MouseEventArgs e)
        {
            Pn_H = false;
        }

        private void Pnl_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (Pn_H)
            {
                this.SetDesktopLocation(MousePosition.X - ClientCoord.X, MousePosition.Y - ClientCoord.Y);
            }
        }


        /*
         * POST
         *url: 'http://steamworkshop.download/online/steamonline.php',
         *              modid          oyun id
         *data: {item: 445589127, app: 255710},          
         **/

        public void verilericek()
        {
            var web = new HtmlAgilityPack.HtmlWeb();
            var doc = web.Load(Txt_SteamURL.Text);

            var modid = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[7]/div[5]/div[1]/div[4]/div[6]/a[1]").Attributes["href"].Value.Replace("https://steamcommunity.com/sharedfiles/filedetails/?id=",string.Empty);
            var oyunid = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[7]/div[5]/div[1]/div[3]/a[1]").Attributes["href"].Value.Replace("https://steamcommunity.com/app/", string.Empty);

            

            var modadi = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[7]/div[5]/div[1]/div[4]/div[5]/div[2]").InnerText;
            var oyunadi = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[7]/div[5]/div[1]/div[3]/a[1]").InnerText.ToLower();
            
            if(modid != string.Empty || oyunid != string.Empty || modadi != string.Empty || oyunadi != string.Empty){
                indir(modid, oyunid, modadi, oyunadi);
            }
        }

        string yol;

        public async void indir(string modid, string oyunid, string modadi, string oyunadi)
        {
            using (var client = new HttpClient())
            {
                var PostData = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("item",modid),
                    new KeyValuePair<string,string>("app",oyunid)
                });
                var gonder = await client.PostAsync("http://steamworkshop.download/online/steamonline.php", PostData);
                string sonuc = await gonder.Content.ReadAsStringAsync();

                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(sonuc);

                string downloadurl = doc.DocumentNode.SelectSingleNode("//a").Attributes["href"].Value;

                Regex regex = new Regex(":");
                yol = "mods/" + regex.Replace(oyunadi,string.Empty) + "/";
                System.IO.Directory.CreateDirectory(yol);

                using (var webclient = new WebClient())
                {
                    webclient.DownloadFile(downloadurl, yol+ regex.Replace(modadi,string.Empty).ToLower() + ".zip");
                    Lbl_info.Text = "indirildi";
                    Lbl_ModName.Text = modadi;
                    Pb_Animation.Visible = false;
                    Btn_Go.Visible = true;
                }

                

            }

            
        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if(Txt_SteamURL.Text != string.Empty)
            {
                Lbl_info.Text = "-";
                Lbl_ModName.Text = "-";
                Btn_Go.Visible = false;
                Pb_Animation.Visible = true;
                verilericek();
                Txt_SteamURL.Text = "";
            }
            else
            {
                MessageBox.Show("URL kısmı boş bırakılamaz!");
            }
        }

        private void Btn_Go_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory()+"/"+yol;
            Process.Start(path);
        }
    }
}
