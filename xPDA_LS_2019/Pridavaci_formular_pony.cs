using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            string rasa;

                 if (radioButton4.Checked == true)
            {
                rasa = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                rasa = "Unicorn";
            }
            else if (radioButton3.Checked == true)
            {
                rasa = "Pegasus";
            }

            string pohlavi;
            {
                if (radioButton4.Checked == true)
                {
                    rasa = "M";
                }
                else if (radioButton5.Checked == true)
                {
                    rasa = "F";

                    
            

                using (SqlConnection openCon = new SqlConnection("your_connection_String"))
                {
                    string savePony = "INSERT INTO Pony (name, gender, race) VALUES (@name,(SELECT Id FROM Race WHERE race LIKE @race),@gender)";

                    using (SqlCommand querySavePony = new SqlCommand(savePony))
                    {
                        querySavePony.Connection = openCon;
                        querySavePony.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = jmeno;
                        querySavePony.Parameters.Add("@gender", SqlDbType.VarChar, 2).Value = pohlavi;
                        querySavePony.Parameters.Add("@race", SqlDbType.VarChar, 30).Value = rasa;

                        openCon.Open();








                    }
                }
}
