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

namespace IRF_project
{

    
    public partial class LabdarugasUC : UserControl
    {
        XDocument xdoc = XDocument.Load("rankings_ATP.xml");
        BindingList<Tennis_player> players = new BindingList<Tennis_player>();


        public LabdarugasUC()
        {
            InitializeComponent();

            dataGridView1.DataSource = players;
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load("rankings_ATP.xml");

           

            foreach (XmlElement element in xml.DocumentElement)
            {

                var plyr = new Tennis_player();
                players.Add(plyr);
                
                
                var childElement = (XmlElement)element.ChildNodes[0];
                plyr.Name = element.GetAttribute("name");

                
                

                
            
            } 
        }
    }
}
