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
    public partial class frmMainEnvironmParameters : Form
    {
        public frmMainEnvironmParameters()
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

        private void cmbBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dataTable = new DataTable();
            string sSql;
            //int iCount;
            try
            {
                sSql = "SELECT PlantName, RoomNumber, Description FROM RoomStation where PlantNumber = " + int.Parse(cmbBoxRoomNo.Text);
                dataTable = objClssMethods.Get_DataTable(sSql);
                //** Check if Status is Revision In Progress for MAX RevisionNumber
                //Else display Message
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //sRole = dataTable.Rows[i][4].ToString();

                    //if (sRole == "Preparer")
                    //{
                    //    txtBoxPrpBy.Text = dataTable.Rows[i][3].ToString();
                    //    txtBoxDatePrp.Text = dataTable.Rows[i][4].ToString();
                    //}                    
                }

                sSql = "Select PlantName FROM Plant";//Station Name
                //if ()
                //{
                //    if (objPubClass.Load_CmbBoxValues(sSql, cmbboxStation) == true)
                //    {
                //        objPubClass.Load_CmbBoxValues(sSql, cmbboxStation);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Error in connection string opening the DB");
                //        new Exception("Error in connection string opening the DB");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("To add a Room to the selected Station, the Station's Environmemntal Patarmeters" +
                //        "module must be in 'Revision In Progress'Status(Unlocked) ", "Status Revision Not Present" +
                //        "", MessageBoxButtons.OK);
                //}
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }

        DataTable sqlDtTbl = new DataTable();
        private void frmMainEnvironmParameters_Load(object sender, EventArgs e)
        {
            try
            {
                //sSql = "SELECT Concat(RoomNumber,',',Description) FROM RoomStation";
                sSql = "Select Concat(Name,' , ',Description) FROM Room";//Room

                if (objPubClass.Load_CmbBoxValues(sSql, cmbBoxRoomNo) == true)
                {
                    objPubClass.Load_CmbBoxValues(sSql, cmbBoxRoomNo);
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (btnFilter.Text == "Add Room")
                    {
                        sEnvAsgID = sPlantID = sRoomNo = sRevisionNumber = sStatus = sDateEnvSel = "";
                        btnFilter.Enabled = false;
                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                        if (String.IsNullOrEmpty(cmbBoxRoomNo.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            //string sPlantID = "";
                            sRoomNo = cmbBoxRoomNo.Text;
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
                if (cmbBoxRoomNo.Text == "")
                {
                    MessageBox.Show("Station Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(cmbBoxRoomNo, "Empty Field");
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in ValidateForm", ex);
            }

            return true;
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
        private void btnRoleAsg_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmRoleAssignment objfrmRoleAssg = new frmRoleAssignment();
            //objfrmRoleAssg.TopLevel = false;
            //this.centerPanel.Controls.Add(objfrmRoleAssg);
            //objfrmRoleAssg.Dock = DockStyle.Fill;
            objfrmRoleAssg.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
