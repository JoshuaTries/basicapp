using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class FrmSearch : Form
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=(local);Initial Catalog=Hire;Integrated Security=True");
        
        DataTable dt;
        SqlDataAdapter adapter;
        
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmSearch.ActiveForm.Hide();
            FrmCars fs = new FrmCars();

            fs.Show();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM tblCar", sqlConn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
       

        private void cbboxField_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void cbboxOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
