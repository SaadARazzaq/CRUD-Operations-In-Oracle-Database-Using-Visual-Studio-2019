using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CRUDoperation2._0
{
    public partial class Form1 : Form
    {
        OracleConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=SAAD;PASSWORD=saad";
            con = new OracleConnection(conStr);
            Select();
        }


        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------INSERT BUTTON------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void INSERT_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please Enter valid ID");
                ID.Focus();
            }
            else if(NAME.Text == "")
            {
                MessageBox.Show("Please Enter valid NAME");
                NAME.Focus();
            }
            else if (GENDER.Text == "")
            {
                MessageBox.Show("Please Enter valid GENDER");
                GENDER.Focus();
            }
            else if (AGE.Text == "")
            {
                MessageBox.Show("Please Enter valid AGE");
                AGE.Focus();
            }
            else
            {
                con.Open();
                OracleCommand insertCRUD = con.CreateCommand();
                insertCRUD.CommandText = "INSERT INTO crudtable VALUES(\'" +
               ID.Text.ToString() + "\',\'" + NAME.Text.ToString() + "\',\'" +
               GENDER.Text.ToString() + "\',\'" + AGE.Text.ToString() + "\')";
                insertCRUD.CommandType = CommandType.Text;
                int rows = insertCRUD.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!");
                }
                con.Close();
            }
        }


        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------DELETE BUTTON------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please Enter a Valid ID!");
                ID.Focus();
            }
            else if (NAME.Text != "")
            {
                MessageBox.Show("Other text boxes must be empty except ID. Name textbox seems to have data!!!");
                NAME.Focus();
            }
            else if (GENDER.Text != "")
            {
                MessageBox.Show("Other text boxes must be empty except ID. Gender textbox seems to have data!!!");
                GENDER.Focus();
            }
            else if (AGE.Text != "")
            {
                MessageBox.Show("Other text boxes must be empty except ID. Age textbox seems to have data!!!");
                AGE.Focus();
            }
            else
            {
                con.Open();
                OracleCommand deleteCRUD = con.CreateCommand();
                deleteCRUD.CommandText = "DELETE FROM CRUDTABLE WHERE ID = " +
        ID.Text.ToString();
                deleteCRUD.CommandType = CommandType.Text;
                int rows = deleteCRUD.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data DELETED Successfully!");
                }
                else
                {
                    MessageBox.Show("Data Not Found to Delete");
                }
                con.Close();
            }
        }


        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------UPDATE BUTTON------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please Enter valid ID");
                ID.Focus();
            }
            else if (NAME.Text == "")
            {
                MessageBox.Show("Please Enter valid NAME");
                NAME.Focus();
            }
            else if (GENDER.Text == "")
            {
                MessageBox.Show("Please Enter valid GENDER");
                GENDER.Focus();
            }
            else if (AGE.Text == "")
            {
                MessageBox.Show("Please Enter valid AGE");
                AGE.Focus();
            }
            else
            {
                con.Open();
                OracleCommand updateCRUD = con.CreateCommand();
                updateCRUD.CommandText = "UPDATE CRUDTABLE SET ID = " +
               ID.Text.ToString() +
                ",NAME = \'" + NAME.Text.ToString() + "\',GENDER =\'" +
               GENDER.Text.ToString() + "\',AGE =\'" + AGE.Text.ToString() + "\'WHERE ID = " + ID.Text.ToString();
                updateCRUD.CommandType = CommandType.Text;
                int rows = updateCRUD.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data UPDATED Successfully!");
                }
                else
                {
                    MessageBox.Show("Data Not Found to update");
                }
                con.Close();
            }
        }


        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------SELECT BUTTON------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void SELECTION_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand selectCRUD = con.CreateCommand();
            selectCRUD.CommandText = "SELECT * FROM CRUDTABLE";
            selectCRUD.CommandType = CommandType.Text;
            OracleDataReader empDR = selectCRUD.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }




        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------TEXTBOXES----------------------------------------------
        //---------------------------------------------------------------------------------------------------


        private void ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void GENDER_TextChanged(object sender, EventArgs e)
        {

        }

        private void AGE_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        //---------------------------------------------------------------------------------------------------
        //--------------------------------------------DATAGRIDVIEW-------------------------------------------
        //---------------------------------------------------------------------------------------------------

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
