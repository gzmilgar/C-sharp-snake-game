using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class frmHighScore : Form
    {
        frmGame fg = new frmGame();
        public SqlConnection Bag = new SqlConnection("Data Source=.;Initial Catalog=c#yilan;Integrated Security=True");
        public frmHighScore()
        {
            InitializeComponent();
        }



        public static void GridNumaralandir(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    string sayi = (count + 1).ToString();
                    dataGridView.Rows[count].HeaderCell.Value = sayi;
                    dataGridView.RowHeadersWidth = 55;

                }
            }
        }
        
        private void frmHighScore_Load(object sender, EventArgs e)
        {
           
            try
            {
                Bag.Open();
                //veritabanındaki verileri listeliyoruz
                string listele = string.Format("select *from highscore");
                
                SqlDataAdapter da = new SqlDataAdapter(listele, Bag);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
          
                //0. kolon büyükten küçüğe sıralsı
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                //0. kolon genişliği 60 olarak ayarlandı
                dataGridView1.Columns[0].Width = 60;
                
            }
            catch (Exception el)
            {
                MessageBox.Show("Hata:" + el.Message);
            }
            finally
            {
                Bag.Close();
            }


        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridNumaralandir(dataGridView1);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i <= Convert.ToInt32(dataGridView1.Rows.Count) - 1; i++)
            {
                if (i % 2 == 0 || i == 0)
                { dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Beige; }
                else
                { dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Bisque; }

            }
        }
    }
}
