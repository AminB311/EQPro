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
        string sEnvAsgID, sPlantID, sRevisionNumber, sStatus, sDateEnvSel;
        string sRoomNo, sDescrip, sStatName;
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
                //sSql = "SELECT Concat(RoomNumber,',',Description) FROM RoomStation";
                sSql = "Select PlantName FROM Plant";//Station Name

                if (objPubClass.Load_CmbBoxValues(sSql, cmbBoxStationName) == true)
                {
                    objPubClass.Load_CmbBoxValues(sSql, cmbBoxStationName);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (btnFilter.Text == "Add Room")
                    {
                        sEnvAsgID = sPlantID = sRoomNo  = sRevisionNumber = sStatus = sDateEnvSel = "";
                        btnFilter.Enabled = false;
                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                        if (String.IsNullOrEmpty(cmbBoxStationName.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            //string sPlantID = "";
                            sRoomNo = cmbBoxStationName.Text;
                            sSql = "SELECT RoomNumber FROM EnvParamAssignment where PlantID = '" + sPlantID + "'";
                            sRoomNo = objPubClass.Get_ValueStrfromTable(sSql);

                            sSql = "Insert into EnvParamAssignment(PlantNumber, PlantName, Location, Building, RoomNumber, Description)" +
                                   "Values('" + sPlantID + "','" + sRoomNo + "','" + sRevisionNumber + "'," +
                                   "'" + sStatus + "','" + sDateEnvSel + ")";
                            objClssMethods.AddNew_Values(sSql);
                        }
                        ResetRoomValues();
                    }
                    else
                    {
                        //Edit Update SQL
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in btnAdd_Click", ex);
            }
        }

        private bool ValidateForm()
        {
            try
            {
                ErrorProvider errorProvider = new ErrorProvider();
                //var phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
                if (cmbBoxStationName.Text == "")
                {
                    MessageBox.Show("Station Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(cmbBoxStationName, "Empty Field");
                    return false;
                }
               
            }

            catch (Exception ex)
            {
                new Exception("Error in ValidateForm", ex);
            }


            return true;
        }

        private void cmbboxRevStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


            }


            catch (Exception ex)
            {
                new Exception("Error in cmbboxRevStation_SelectedIndexChanged", ex);
            }

        }

        private void cmBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSql,sTmp;
            try
            {
                sTmp = cmbBoxStationName.Text;
                //string[] sWordArr = sTmp.Split(',');
                //sRoomNo = sWordArr[0];
                //sDescrip = sWordArr[1];
                //001 Plant is loked
                sStatName = cmbBoxStationName.Text;

                //sSql = "SELECT RevisionNumber, Status FROM RoomStation where RoomNumber = " + sRoomNo + " " +
                //       "AND Description = " + sDescrip;

                sSql = "SELECT R.Name as RoomName, P.Description, P.DescriptionChange as ChangeDescription, " +
                       "P.Reference from Plant P " +
                        "INNER JOIN PlantRoomAssignment PA " +
                        "ON PA.PlantID = P.PlantID " +
                        "INNER JOIN Room R " +
                        "ON R.RoomID = PA.RoomID " +
                        "where P.PlantName = '" + sStatName + "'";
                dtTblEnvParam = objClssMethods.Get_DataTable(sSql);
                dataGridRoom.DataSource = dtTblEnvParam;
                if (dtTblEnvParam.Rows.Count > 1)
                {         
                    //Station Name
                    txtBoxRevBy.Text = dtTblEnvParam.Rows[0][0].ToString();                   
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in cmBoxRoomNo_SelectedIndexChanged", ex);
            }

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridRoom_Click(object sender, EventArgs e)
        {

        }

        private void ResetRoomValues()
        {
            try
            {
                //cmbboxStation.Text = "";
           
                btnFilter.Text = "Add";
                btnFilter.Enabled = true;
            }

            catch (Exception ex)
            {
                new Exception("Error in ResetRoomValues", ex);
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMianPg_Click(object sender, EventArgs e)
        {
            Form objOpenFrm = Application.OpenForms["frmEnvironment"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
                frmMain objFrmMain = new frmMain();
                objFrmMain.Show();
            }
        }       
             
        private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dataTable = new DataTable();
            string sSql;
            //int iCount;
            try
            {
                sSql = "SELECT PlantName, RoomNumber, Description FROM RoomStation where PlantNumber = " + int.Parse(cmbBoxStationName.Text);
                dataTable = objClssMethods.Get_DataTable(sSql);
                //userID = int.Parse(dataTable.Rows[0][0].ToString());
             
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }

        private void btnRoleAsg_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmRoleAssignment objfrmRoleAssg = new frmRoleAssignment();
            //objfrmRoleAssg.TopLevel = false;
            //this.centerPanel.Controls.Add(objfrmRoleAssg);
            //objfrmRoleAssg.Dock = DockStyle.Fill;
            objfrmRoleAssg.Show();


            //frmEnvParamSelScreen objEnvParamSel = new frmEnvParamSelScreen();
            //objEnvParamSel.TopLevel = false;
            //this.centerPanel.Controls.Add(objEnvParamSel);
            //objEnvParamSel.Dock = DockStyle.Fill;
            //objEnvParamSel.Show();

        }


    }
}
