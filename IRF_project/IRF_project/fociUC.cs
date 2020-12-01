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

namespace IRF_project
{
    public partial class fociUC : UserControl
    {
        XDocument xdoc = XDocument.Load("results_PREM.xml");
        BindingList<Meccsek> merkozes = new BindingList<Meccsek>();
        public fociUC()
        {
            InitializeComponent();

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

                foreach (XmlElement homegoalElement in hgElement.GetElementsByTagName("stat"))
                {
                    if (homegoalElement.GetAttribute("type").Equals("goals"))
                    {
                        mccs.Home_goals = int.Parse(homegoalElement.InnerText);
                    }


                }
                var agElement = (XmlElement)element.GetElementsByTagName("away-team-content")[0];

                foreach (XmlElement awaygoalElement in agElement.GetElementsByTagName("name"))
                {

                    mccs.Away_team = awaygoalElement.InnerText;


                }

                

                merkozes.Add(mccs);

            }

        }
    }
}
