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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pridavaci_formular_obrazku obr = new Pridavaci_formular_obrazku();

            obr.ShowDialog();
        }

        private void Add_pony_Click(object sender, EventArgs e)
        {
            Pridavaci_formular_pony pon = new Pridavaci_formular_pony();

            pon.ShowDialog();

            this.poniesDataSet1.Pony.Clear();
            this.ponyTableAdapter1.Fill(this.poniesDataSet1.Pony);
        }
        private void refresh_info()
        {
            if ((pony_list.SelectedItem as DataRowView) != null)
            {
                int pony_id = (int)((pony_list.SelectedItem as DataRowView)["Id"]);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["xPDA_LS_2019.Properties.Settings.poniesConnectionString"].ConnectionString);
                conn.Open();

                SqlCommand command = new SqlCommand("Select p.name, p.gender, r.race from Pony AS p JOIN Race AS r ON r.Id = p.race where p.Id=@pony_id", conn);
                command.Parameters.AddWithValue("@pony_id", pony_id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        info_name.Text = reader["name"].ToString();
                        info_race.Text = reader["race"].ToString();
                        info_gender.Text = reader["gender"].ToString();
                    }
                }

                conn.Close();
            }
        }
        private void refreshGallery()
        {
            if ((pony_list.SelectedItem as DataRowView) != null)
            {
                int pony_id = (int)((pony_list.SelectedItem as DataRowView)["Id"]);
                this.images.imagesview.Clear();
                this.imagesviewTableAdapter.Fill(this.images.imagesview);
                listView1.BeginUpdate();
                listView1.Clear();
                imageList1.Images.Clear();
                foreach (DataRow dr in this.images.imagesview.Select(String.Format("pony_fk = {0}", pony_id)))
                {
                    imageList1.Images.Add(Image.FromFile(String.Format("./img/{0}", dr["filename"])));
                }
                for (int j = 0; j < this.imageList1.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = j;
                    this.listView1.Items.Add(item);
                }
                listView1.EndUpdate();
                //listView1.Update();

            }
            
        }
        private void Pony_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_info();
            refreshGallery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'images.imagesview'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.imagesviewTableAdapter.Fill(this.images.imagesview);
            // TODO: Tento řádek načte data do tabulky 'poniesDataSet1.Pony'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.ponyTableAdapter1.Fill(this.poniesDataSet1.Pony);
            // TODO: Tento řádek načte data do tabulky 'poniesNames.Pony'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.ponyTableAdapter.Fill(this.poniesNames.Pony);
            refresh_info();
            refreshGallery();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
