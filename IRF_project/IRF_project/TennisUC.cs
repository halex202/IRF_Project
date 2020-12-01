using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace IRF_project
{

    
    public partial class TennisUC : UserControl
    {
        XDocument xdoc = XDocument.Load("rankings_ATP.xml");
        BindingList<Tennis_player> players = new BindingList<Tennis_player>();

        
        public TennisUC()
        {
            InitializeComponent();

            dataGridView1.DataSource = players;
            
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load("rankings_ATP.xml");

            var tennis_content = (XmlElement)xml.DocumentElement.GetElementsByTagName("tennis-content")[0];
            var league_content = (XmlElement)tennis_content.GetElementsByTagName("league-content")[0];
            var season_content = (XmlElement)league_content.GetElementsByTagName("season-content")[0];

            

                foreach (XmlElement element in season_content.GetElementsByTagName("player-content")) 
            {

                var plyr = new Tennis_player();

                var playerElement = (XmlElement)element.GetElementsByTagName("player")[0];

                foreach (XmlElement nameElement in playerElement.GetElementsByTagName("name"))
                {

                    if (nameElement.GetAttribute("type").Equals("first"))
                    {
                        plyr.Name = nameElement.InnerText + plyr.Name;
                    }
                    else
                    {
                        plyr.Name += " " + nameElement.InnerText;
                    }


                }

                var rankingElement = (XmlElement)element.GetElementsByTagName("ranking")[0];

                foreach (XmlElement rnkElement in rankingElement.GetElementsByTagName("rank"))
                {
                    plyr.Ranking = int.Parse(rnkElement.InnerText);
                }


                foreach (XmlElement pointElement in rankingElement.GetElementsByTagName("points"))
                {
                    plyr.Points = float.Parse(pointElement.InnerText);
                }

                players.Add(plyr);

            } 
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var b in players)
                {
                    sw.Write(b.Name);
                    sw.Write(",");
                    sw.Write(b.Ranking.ToString());
                    sw.Write(",");
                    sw.Write(b.Points.ToString());                    
                    sw.WriteLine();
                }
            }
        }
    }
}
