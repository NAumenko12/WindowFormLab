using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
        }
        public void DisplayPerson(Person person)
        {
            IDtxt.Text = person.ID;
            Famtxt.Text = person.Fam;
            Nametxt.Text = person.Name;
            Otchestvotxt.Text = person.Otchesctvo;

        }
    }
}
