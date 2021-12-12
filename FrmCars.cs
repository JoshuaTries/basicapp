using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarsDatabase
{

    public partial class FrmCars : Form

    {
        // CONNECTION STRING 
        String myConnection = @"Data Source=(local);Initial Catalog=Hire;Integrated Security=True";

        DataTable dt = new DataTable();
        int R = 0;
        


        public FrmCars()
        {
            InitializeComponent();
        }
        //TABLE POPULATION METHOD 
        private void GetData(int index)
        {
            txtVehicleRegNo.Text = dt.Rows[index][0].ToString();
            txtMake.Text = dt.Rows[index][1].ToString();
            txtEngineSize.Text = dt.Rows[index][2].ToString();
            txtDateRegistered.Text = dt.Rows[index][3].ToString();
            txtRental.Text = dt.Rows[index][4].ToString();
            chkbxAvailable.Checked = (bool)dt.Rows[index][5];



        }
        //SQL METHOD

        private void FrmCars_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(myConnection))
                {
                    if (sqlConn.State == ConnectionState.Closed)
                        sqlConn.Open();



                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT * FROM tblCar";
                    sqlCommand.Connection = sqlConn;

                    var adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);



                    if (dt.Rows.Count > 0)
                    {
                        GetData(R);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        

        //EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        //UPDATE BUTTON 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string VehicleRegNo = txtVehicleRegNo.Text;
            string Make = txtMake.Text;
            string EngineSize = txtEngineSize.Text;
            string DateRegistered = txtDateRegistered.Text;
            string RentalPerDay = txtRental.Text;
            string Available = chkbxAvailable.Text;
            string sqlquery;
            SqlConnection sqlcn = new SqlConnection("Data Source=(local);Initial Catalog=Hire;Integrated Security=True");
            sqlcn.Open();
            sqlquery = "UPDATE tblCar SET  Make = @Make, EngineSize = @EngineSize, DateRegistered = @DateRegistered, RentalPerDay = @RentalPerDay, Available = @Available Where VehicleRegNo = @VehicleRegNo";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlquery, sqlcn);
                cmd.Parameters.AddWithValue("@VehicleRegNo", VehicleRegNo);
                cmd.Parameters.AddWithValue("@Make", Make);
                cmd.Parameters.AddWithValue("@EngineSize", EngineSize);
                cmd.Parameters.AddWithValue("@DateRegistered", DateRegistered);
                cmd.Parameters.AddWithValue("@RentalPerDay", RentalPerDay);
                cmd.Parameters.AddWithValue("@Available", Available);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                sqlcn.Close();

            }
        }

        //ADD BUTTON 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string VehicleRegNo = txtVehicleRegNo.Text;
            string Make = txtMake.Text;
            string EngineSize = txtEngineSize.Text;
            string DateRegistered = txtDateRegistered.Text;
            string RentalPerDay = txtRental.Text;
            string Available = chkbxAvailable.Text;
            string sqlquery;
            SqlConnection sqlcn = new SqlConnection("Data Source=(local);Initial Catalog=Hire;Integrated Security=True");
            sqlcn.Open();
            sqlquery = "INSERT INTO tblCar( VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES ('" + VehicleRegNo + "', '" + Make + "', '" + EngineSize + "', '" + DateRegistered + "', '" + RentalPerDay + "', '" + Available + "')";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlquery, sqlcn);
                cmd.Parameters.AddWithValue("@VehicleRegNo", VehicleRegNo);
                cmd.Parameters.AddWithValue("@Make", Make);
                cmd.Parameters.AddWithValue("@EngineSize", EngineSize);
                cmd.Parameters.AddWithValue("@DateRegistered", DateRegistered);
                cmd.Parameters.AddWithValue("@RentalPerDay", RentalPerDay);
                cmd.Parameters.AddWithValue("@Available", Available);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Succesfully Added");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                sqlcn.Close();

            }
        }

        //DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string VehicleRegNo = txtVehicleRegNo.Text;
            string Make = txtMake.Text;
            string EngineSize = txtEngineSize.Text;
            string DateRegistered = txtDateRegistered.Text;
            string RentalPerDay = txtRental.Text;
            string Available = chkbxAvailable.Text;
            string sqlquery;
            SqlConnection sqlcn = new SqlConnection("Data Source=(local);Initial Catalog=Hire;Integrated Security=True");
            sqlcn.Open();
            sqlquery = "Delete From tblCar WHERE VehicleRegNo like @VehicleRegNo";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlquery, sqlcn);
                cmd.Parameters.AddWithValue("@VehicleRegNo", VehicleRegNo);
                cmd.Parameters.AddWithValue("@Make", Make);
                cmd.Parameters.AddWithValue("@EngineSize", EngineSize);
                cmd.Parameters.AddWithValue("@DateRegistered", DateRegistered);
                cmd.Parameters.AddWithValue("@RentalPerDay", RentalPerDay);
                cmd.Parameters.AddWithValue("@Available", Available);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                sqlcn.Close();

            }
        }

        //CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVehicleRegNo.Text = "";
            txtMake.Text = "";
            txtEngineSize.Text = "";
            txtDateRegistered.Text = "";
            txtRental.Text = "";
            chkbxAvailable.Checked = false;

        }

        //SEARCH FROM BUTTON 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmCars.ActiveForm.Hide();
            FrmSearch fs = new FrmSearch();

            fs.Show();
        }

        //Display Records
        private void txtRecord_TextChanged(object sender, EventArgs e)
        {
            

        }

        //FIRST RECORD BUTTON 

        private void btnFirst_Click(object sender, EventArgs e)
        {
            R = 0;
            GetData(R);
        }

        //Previous Button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            R--;
            if (R >= 0)
            {
                GetData(R);
            }
            else
            {
                MessageBox.Show("No more Previous Records");
            }
        }

        //Next Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            R++;
            if (R < dt.Rows.Count)
            {

                GetData(R);
            }
            else
            {
                MessageBox.Show("Last Record");
                R = dt.Rows.Count - 1;
            }

        }

        //Last Button
        private void btnLast_Click(object sender, EventArgs e)
        {
            R = dt.Rows.Count - 1;
            GetData(R);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Closes Application", btnExit);
        }

        private void txtVehicleRegNo_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Enter Car Registration Number", txtVehicleRegNo);
        }

        private void txtMake_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Vehicle Make ", txtMake);
        }

        private void txtEngineSize_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Engine Size .eg 1.8L ", txtEngineSize);
        }
    }
}



