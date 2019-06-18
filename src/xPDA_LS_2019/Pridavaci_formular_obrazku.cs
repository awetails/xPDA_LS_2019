using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xPDA_LS_2019
{
    public partial class Pridavaci_formular_obrazku : Form
    {
        public Pridavaci_formular_obrazku()
        {
            InitializeComponent();
        }

        private void Pridavaci_formular_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'poniesDataSet.Pony'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.ponyTableAdapter1.Fill(this.poniesDataSet.Pony);
            // TODO: Tento řádek načte data do tabulky 'poniesDataSet.Pony'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.ponyTableAdapter1.Fill(this.poniesDataSet.Pony);
            // TODO: Tento řádek načte data do tabulky 'poniesNames.Pony'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.ponyTableAdapter.Fill(this.poniesNames.Pony);

        }

        private String _file;

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    this._file = file;
                    preview.Image = Image.FromFile(this._file);
                }
            }
            check_input();
        }

        private void check_input()
        {
            if (((ponyselect.SelectedItem as DataRowView) != null) && preview.Image != null)
            {
                Upload.Enabled = true;
            }
            if ((ponyselect.SelectedItem as DataRowView) == null)
            {
                Upload.Enabled = false;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            string imgpath = @"./img/";

            FileInfo fi = new FileInfo(this._file);
            if (fi.Exists)
            {
                if (!Directory.Exists(imgpath))
                {
                    Directory.CreateDirectory(imgpath);
                }
                try
                {
                    fi.CopyTo(string.Format("{0}{1}", imgpath, fi.Name));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured, try again");
                    this.Close();
                }
                //add img to db
                String connectionString = ConfigurationManager.ConnectionStrings["xPDA_LS_2019.Properties.Settings.poniesConnectionString"].ConnectionString;
                String imgquery = "INSERT INTO Image(filename) output INSERTED.ID VALUES (@path)";
                int ? new_id = null;

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(imgquery, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@path", fi.Name);
                        conn.Open();
                        new_id = (int)cmd.ExecuteScalar();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        File.Delete(string.Format("{0}{1}", imgpath, fi.Name));
                        MessageBox.Show("An error occured, try again");
                        this.Close();
                    }
                }
                
                foreach (DataRowView pony in ponyselect.SelectedItems)
                {
                    String ponyimgquery = "INSERT INTO rel_PonyImage(pony_fk,image_fk) VALUES (@pony_id, @image_id)";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(ponyimgquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@pony_id", pony["Id"]);
                        cmd.Parameters.AddWithValue("@image_id", new_id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }           
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occured, try again");
                this.Close();
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {

        }

        private void Preview_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            check_input();
        }

        private void Ponyselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_input();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
