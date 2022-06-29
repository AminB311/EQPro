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

namespace EQProDXApp.EnvironmentalParameters
{
    public partial class frmRoleAssignment : Form
    {
        public frmRoleAssignment()
        {
            InitializeComponent();
        }

        string sSql = "";
        string sStr, sTmp, sLastName, sFirstName, sUserRoleAsgID, sUserID, sUserRole, sUserRoleAccepted, sDateAccepted;
        string sAssignedBy, sDateAssigned, sCancelledBy, sDateCancelled, sPlantID, sStatus;
        Class_PublicDataAccessLayer objDALCls = new Class_PublicDataAccessLayer();
        Class_PublicMethods objClssMethods = new Class_PublicMethods();
        //int iCount= 0;
        //Class_PublicDataAccessLayer objDALCls;
        Class_PublicMethods objPubClass = new Class_PublicMethods();
        SqlConnection SqlConn = new SqlConnection();

        private void cmbBoxPrepearer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string sSql;
            int iLen = 0;
            try
            {
                sTmp =  cmbBoxPrepearer.Text;
                //sStr = sTmp.Split(""); 
                //sFirstName = sStr.Substring(1,iLen)
                //sLastName = sStr;

                sSql = "SELECT UserID FROM UserMain where FirstName = " + sFirstName  + " AND LastName = " + sLastName ;
                dataTable = objClssMethods.Get_DataTable(sSql);
               
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }

        }


        DataSet sqlDtSet = new DataSet();
        DataTable sqlDtTbl = new DataTable();

        private void frmRoleAssignment_Load(object sender, EventArgs e)
        {
            try
            {
                //sSql = "SELECT LastName,FirstName, UserID FROM UserMain";
                sSql = "SELECT Concat(LastName,' ',FirstName,'   ', EQRole),  UserID FROM UserMain";
                if (objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxPrepearer,txtEditPrprID) == true)
                {
                    objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxPrepearer, txtEditPrprID);
                }
                else
                {
                    MessageBox.Show("Error in connection string opening the DB ");
                    new Exception("Error in connection string opening the DB ");
                }
                if (objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxReviewer,txtEditRvwrID) == true)
                {
                    objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxReviewer, txtEditRvwrID);
                }
                else
                {
                    MessageBox.Show("Error in connection string opening the DB ");
                    new Exception("Error in connection string opening the DB ");
                }
                if (objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxApprover,txtEditAppID) == true)
                {
                    objPubClass.Load_CmbTextBoxValues(sSql, cmbBoxApprover, txtEditAppID);
                }
                else
                {
                    MessageBox.Show("Error in connection string opening the DB ");
                    new Exception("Error in connection string opening the DB ");
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in frmRoleAssignment_Load", ex);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    //if (btnAssign.Text == "Add Room")
                    //{
                    //    btnAssign.Enabled = false;
                    //    //SELECT UserRoleAsgID, UserID, UserRole, UserRoleAccepted, DateAccepted,
                    //    //AssignedBy, DateAssigned, CancelledBy, DateCancelled, PlantID, Status FROM UserRoleAssignment
                    //    if (String.IsNullOrEmpty(cmbBoxPrepearer.Text) == false)
                    //    {
                    //        //sStationName, sRoomNo, sDescription
                    //        string sStationNameExist = "";
                    //        sPlantName = cmbBoxPrepearer.Text;
                    //        sSql = "SELECT PlantNumber FROM RoomStation where UserRoleAssignment = '" + sPlantName + "'";
                    //        sStationNameExist = objPubClass.Get_ValueStrfromTable(sSql);

                    //        //The station name MUST be exactly as you wish it to appear in printedEQ Binders, as
                    //        //the station name cannot be changed after creation.
                    //        if (String.IsNullOrEmpty(sStationNameExist) == false)
                    //        {
                    //            MessageBox.Show("Plant already exists, please enter a new Plant", "Existing Field");
                    //            btnAssign.Enabled = true;
                    //        }
                    //        else
                    //        {
                    //            DialogResult drResult = MessageBox.Show("Plant name currently not in EQPro. Do you wish to add this Plant to EQPro?", "Unknown Plant", MessageBoxButtons.YesNo);
                    //            var vDocketResult = "";
                    //            if (drResult == DialogResult.Yes)
                    //            {
                    //                vDocketResult = XtraInputBox.Show("Please fill in the Plant Docket Number(s)", "Required Docket Number(s) Needed ", "", MessageBoxButtons.OKCancel);
                    //                if (String.IsNullOrEmpty(vDocketResult) == false)
                    //                {
                    //                    var vLicensing = "";
                    //                    vLicensing = XtraInputBox.Show("Please in the Plant Licensing Criterea", "Required Plant Licensing Criterea Needed", "", MessageBoxButtons.OKCancel);
                    //                    if (String.IsNullOrEmpty(vLicensing) == false)
                    //                    {
                    //                        sPlantName = cmbBoxPrepearer.Text;

                    //                        sDocketNumber = vDocketResult;
                    //                        sLicensingCriteria = vLicensing;
                    //                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                    //                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                    //                        sSql = "Insert into RoomStation(PlantName, Location, Building, RoomNumber, Description, Zone," +
                    //                               "DocketNumber, Parameter,LicensingCriteria,Status,DescriptionChange,RevisionNumber) " +
                    //                                "Values('" + sPlantName + "','" + sLocation + "','" + sBuilding + "','" + sRoomNumber + "'," +
                    //                                "'" + sDescription + "','" + sZone + "','" + sDocketNumber + "','" + sParameter + "'," +
                    //                               "'" + sLicensingCriteria + "','" + sStatus + "','" + sDescriptionChange + "', '" + sRevisionNumber + "')";
                    //                        objClssMethods.AddNew_Values(sSql);
                    //                    }
                    //                }
                    //                else
                    //                {

                    //                }
                    //                ResetRoleAssigValues();
                    //            }
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    //Edit Update SQL
                    //}
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
                if (cmbBoxPrepearer.Text == "")
                {
                    MessageBox.Show("Station Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(cmbBoxPrepearer, "Empty Field");
                    return false;
                }
                //if (txtBoxStation.Text == "")
                //{
                //    MessageBox.Show("Room Number Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    errorProvider.SetError(txtBoxStation, "Empty Field");
                //    return false;
                //}
               
            }

            catch (Exception ex)
            {
                new Exception("Error in ValidateForm", ex);
            }


            return true;
        }
        private void ResetRoleAssigValues()
        {

            try
            {
                cmbBoxPrepearer.Text = "";
                cmbBoxPrepearer.Visible = true;
                btnAssign.Text = "Add";
                btnAssign.Enabled = true;
            }

            catch (Exception ex)
            {
                new Exception("Error in ResetRoleAssigValues", ex);
            }

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
                sSql = "SELECT LastName,FirstName, UserID FROM UserMain where LastName = " + int.Parse(cmbBoxPrepearer.Text);
                dataTable = objClssMethods.Get_DataTable(sSql);
                //userID = int.Parse(dataTable.Rows[0][0].ToString());
                //txtBoxStation.Text = dataTable.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnvParamSelScreen objEnvParamSel = new frmEnvParamSelScreen();
            objEnvParamSel.TopLevel = false;
            //this.centerPanel.Controls.Add(objEnvParamSel);
            objEnvParamSel.Dock = DockStyle.Fill;
            objEnvParamSel.Show();
        }
    }
}
