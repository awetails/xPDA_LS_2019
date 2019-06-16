using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xPDA_LS_2019
{
    public partial class Pridavaci_formular_pony : Form
    {
        public Pridavaci_formular_pony()
        {
            InitializeComponent();
        }

        private void Pridavaci_formular_pony_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;

            string rasa = "";

            if (rb_earth.Checked == true)
            {
                rasa = "Earth Pony";
            }
            if (rb_uni.Checked == true)
            {
                rasa = "Unicorn";
            }
            if (rb_pega.Checked == true)
            {
                rasa = "Pegasus";
            }

            string pohlavi="";

            if (rb_M.Checked == true)
            {
                pohlavi = "M";
            }
            if (rb_F.Checked == true)
            {
                pohlavi = "F";
            }



            using (SqlConnection openCon = new SqlConnection(ConfigurationManager.ConnectionStrings["xPDA_LS_2019.Properties.Settings.poniesConnectionString"].ConnectionString))
            {
                string savePony = "INSERT INTO Pony (name, race, gender) VALUES (@name,(SELECT Id FROM Race WHERE race = @race),@gender)";

                using (SqlCommand querySavePony = new SqlCommand(savePony))
                {
                    querySavePony.Connection = openCon;
                    querySavePony.Parameters.AddWithValue("@name", jmeno);
                    querySavePony.Parameters.AddWithValue("@gender", pohlavi);
                    querySavePony.Parameters.AddWithValue("@race", rasa);

                    openCon.Open();
                    querySavePony.ExecuteNonQuery();
                    openCon.Close();
                }
            }
            this.Close();
        }

        private void Rb_M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
