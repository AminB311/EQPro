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
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace EQProDXApp.EnvironmentalParameters
{
    public partial class frmEnvParamSelScreen : Form
    {
        public frmEnvParamSelScreen()
        {
            InitializeComponent();
        }

        string sSql = "";
        //string sEnvAsgID, sPlantID, sRevisionNumber,  sDateEnvSel,sRoomNo;
        string sStatus,sDescrip, sStatName;
        DataTable dtTblEnvParam = new DataTable();

        Class_PublicDataAccessLayer objDALCls = new Class_PublicDataAccessLayer();
        Class_PublicMethods objClssMethods = new Class_PublicMethods();
        //int iCount= 0;
        //Class_PublicDataAccessLayer objDALCls;
        Class_PublicMethods objPubClass = new Class_PublicMethods();
        SqlConnection SqlConn = new SqlConnection();
        DataSet sqlDtSet = new DataSet();
        DataTable sqlDtTbl = new DataTable();

        private void frmEnvParamSelScreen_Load(object sender, EventArgs e)
        {
            try
            {
                sSql = "SELECT PlantName from Plant";

                if (objPubClass.Load_CmbBoxValues(sSql, cmbBoxStation) == true)
                {
                    objPubClass.Load_CmbBoxValues(sSql, cmbBoxStation);
                }
                else
                {
                    MessageBox.Show("Error in connection string opening the DB ");
                    new Exception("Error in connection string opening the DB ");
                }

            }
            catch (Exception ex)
            {
                new Exception("Error in frmCreateRoom_Load", ex);
            }
        }

        private void cmbBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRole;
            try
            {
                sStatus = cmbBoxStatus.Text;
                sStatName = cmbBoxStation.Text;

                sSql = "SELECT P.PlantName, P.RevisionNumber, P.Status, Concat(UM.FirstName,'', UM.LastName), " +
                       " PU.Role, PU.DateAccepted " +
                           "from Plant P " +
                           "INNER JOIN PlantRoomAssignment PA ON PA.PlantID = P.PlantID " +
                           "INNER JOIN Room R ON R.RoomID = PA.RoomID " +
                           "INNER JOIN PlantUserAssignment PU  ON PU.PlantID = P.PlantID " +
                           "INNER JOIN UserMain UM  ON UM.UserID = PU.UserID " +
                           "where P.PlantName = '" + sStatName + "'" +
                           "AND P.Status = '" + sStatus + "' AND PU.DateAccepted is not null";
                dtTblEnvParam = objClssMethods.Get_DataTable(sSql);

                if (dtTblEnvParam.Rows.Count > 1)
                {

                    //dataGridStation.DataSource = dtTblEnvParam;
                    dataGridStation.ColumnCount = 3;
                    dataGridStation.Columns[0].Name = "Station";
                    dataGridStation.Columns[0].Width = 500;
                    string sVal = dtTblEnvParam.Rows[0][0].ToString() + dtTblEnvParam.Rows[0][1].ToString() + dtTblEnvParam.Rows[0][2].ToString();
                    dataGridStation.Rows.Add(sVal);

                    dataGridStation.Columns[1].Name = "Revision";
                    dataGridStation.Columns[1].Width = 100;

                    //dtCurrentTable.Rows[i - 1]["Column1"] = box1.Text;
                    //(TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("TextBox1");
                    //dataGridStation.Rows.Add(dtTblEnvParam.Rows[0][1].ToString());
                    //GridView1.Controls[0].Controls.Add(row);

                    dataGridStation.Columns[2].Name = "Status";
                    dataGridStation.Columns[2].Width = 300;
                    //dataGridStation.Rows.Add(dtTblEnvParam.Rows[0][2].ToString());

                    for (int i = 0; i< dtTblEnvParam.Rows.Count;i++)
                    {
                        sRole = dtTblEnvParam.Rows[i][4].ToString();

                        if (sRole == "Preparer")
                        {
                            txtBoxPrpBy.Text = dtTblEnvParam.Rows[i][3].ToString();
                            txtBoxDatePrp.Text = dtTblEnvParam.Rows[i][4].ToString();
                        }
                        if (sRole == "Reviewer")
                        {
                            txtBoxRevBy.Text = dtTblEnvParam.Rows[i][3].ToString();
                            txtBoxDateRev.Text = dtTblEnvParam.Rows[i][4].ToString();
                        }
                        if (sRole == "Approver")
                        {
                            txtBoxAppBy.Text = dtTblEnvParam.Rows[i][3].ToString();
                            txtBoxDateApp.Text = dtTblEnvParam.Rows[i][4].ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                new Exception("Error in cmBoxRoomNo_SelectedIndexChanged", ex);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {               
            }
            catch (Exception ex)
            {
                new Exception("Error in btnAdd_Click", ex);
            }
        }

        private void dataGridStation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cmBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSql,sTmp;
            //try
            //{
            //    sTmp = cmbBoxStation.Text;
            //    string[] sWordArr = sTmp.Split(',');
            //    sRoomNo = sWordArr[0];
            //    sDescrip = sWordArr[1];
            //    //001 Plant is loked
            //    sRoomNo = sRoomNo;

            //    //sSql = "SELECT RevisionNumber, Status FROM RoomStation where RoomNumber = " + sRoomNo + " " +
            //    //       "AND Description = " + sDescrip;

            //    sSql = "SELECT P.PlantName as Station  , P.RevisionNumber as Revision, P.Status " +
            //           "from Plant P " +
            //           "INNER JOIN PlantRoomAssignment PA " +
            //           "ON PA.PlantID = P.PlantID " +
            //           "INNER JOIN Room R " +
            //           "ON R.RoomID = PA.RoomID " +
            //           "where R.Name = '" + sRoomNo + "'";
            //    dtTblEnvParam = objClssMethods.Get_DataTable(sSql);
            //    dataGridStation.DataSource = dtTblEnvParam;
                
            //    if (dtTblEnvParam.Rows.Count > 1)
            //    {         
            //        //Station Name
            //        txtBoxRevBy.Text = dtTblEnvParam.Rows[0][0].ToString();                   
            //    }
            //}
            //catch (Exception ex)
            //{
            //    new Exception("Error in cmBoxRoomNo_SelectedIndexChanged", ex);
            //}


        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                 
             
        private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dataTable = new DataTable();
            string sSql;
            //int iCount;
            try
            {
                sSql = "SELECT PlantName, RoomNumber, Description FROM RoomStation where PlantNumber = " + int.Parse(cmbBoxStation.Text);
                dataTable = objClssMethods.Get_DataTable(sSql);
                //userID = int.Parse(dataTable.Rows[0][0].ToString());
             
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }

        private void btnRadList_Click(object sender, EventArgs e)
        {
            

        }

    }
}
