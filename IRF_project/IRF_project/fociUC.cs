using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace IRF_project
{
    public partial class fociUC : UserControl
    {
        XDocument xdoc = XDocument.Load("results_PREM.xml");
        BindingList<Meccsek> merkozes = new BindingList<Meccsek>();


        public bool filtered_triggered = false;

        public fociUC()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(Results));
            

            dataGridView1.DataSource = merkozes;
        }

        private void load_data_btn_Click(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load("results_PREM.xml");

            var football_content = (XmlElement)xml.DocumentElement.GetElementsByTagName("team-sport-content")[0];
            var league_content = (XmlElement)football_content.GetElementsByTagName("league-content")[0];
            var season_content = (XmlElement)league_content.GetElementsByTagName("season-content")[0];

            foreach (XmlElement element in season_content.GetElementsByTagName("competition"))
            {

                var mccs = new Meccsek();

                var homeElement = (XmlElement)element.GetElementsByTagName("home-team-content")[0];

                foreach (XmlElement name1Element in homeElement.GetElementsByTagName("name"))
                {

                    mccs.Home_team = name1Element.InnerText;


                }
                var awayElement = (XmlElement)element.GetElementsByTagName("away-team-content")[0];

                foreach (XmlElement name2Element in awayElement.GetElementsByTagName("name"))
                {

                    mccs.Away_team = name2Element.InnerText;


                }
                var hgElement = (XmlElement)element.GetElementsByTagName("home-team-content")[0];

                foreach (XmlElement homestatElement in hgElement.GetElementsByTagName("stat"))
                {
                    var homegoalelement = homestatElement.GetAttribute("num");
                    mccs.Home_goals = int.Parse(homegoalelement);
                    
                }
                var agElement = (XmlElement)element.GetElementsByTagName("away-team-content")[0];

                foreach (XmlElement awaystatElement in agElement.GetElementsByTagName("stat"))
                {

                    var awaygoalelement = awaystatElement.GetAttribute("num");
                    mccs.Away_goals = int.Parse(awaygoalelement);


                }
             
                
                if (mccs.Home_goals > mccs.Away_goals)
                {
                    mccs.Result = Results.home_win;
                }
                else if (mccs.Home_goals < mccs.Away_goals)
                {
                    mccs.Result = Results.away_win;
                }
                else
                {
                    mccs.Result = Results.draw;
                }
                



                merkozes.Add(mccs);

            }

        }
   
        public void load_btn_Click(object sender, EventArgs e)
        {
            filter(); //filterezés triggerelése azért ilyen módon, hogy később el tudjuk érni a függvény által generált listát
        }
        private List<Meccsek> filter()
        {
            List<Meccsek> filtered_merkozes = new List<Meccsek>(merkozes);

            foreach (var a in filtered_merkozes.ToList())
            {
                Results filter = (Results)Enum.Parse(typeof(Results), comboBox1.SelectedItem.ToString());
                if (a.Result != filter)
                {
                    filtered_merkozes.Remove(a);
                }
            }
            dataGridView1.DataSource = filtered_merkozes;

            filtered_triggered = true;

            return filtered_merkozes; //kapunk egy listát, amit később fel tudunk használni
        }

        public void export_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                if (filtered_triggered == true)
                {
                    foreach (var b in filter()) // a lista elérése érdekében hívtuk meg itt
                    {
                        sw.Write(b.Home_team);
                        sw.Write(",");
                        sw.Write(b.Away_team);
                        sw.Write(",");
                        sw.Write(b.Home_goals.ToString());
                        sw.Write(",");
                        sw.Write(b.Away_goals.ToString());
                        sw.Write(",");
                        sw.Write(b.Result.ToString());
                        sw.WriteLine();
                    }
                }
                else
                {
                    foreach (var b in merkozes)
                    {
                        sw.Write(b.Home_team);
                        sw.Write(",");
                        sw.Write(b.Away_team);
                        sw.Write(",");
                        sw.Write(b.Home_goals.ToString());
                        sw.Write(",");
                        sw.Write(b.Away_goals.ToString());
                        sw.Write(",");
                        sw.Write(b.Result.ToString());
                        sw.WriteLine();
                    }
                }
                
            }
            
        }
    }
}
