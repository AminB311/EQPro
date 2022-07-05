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

namespace EQProDXApp
{    
    public partial class frmCreateRoom : Form
    { 
        string sSql = "";
        Class_PublicDataAccessLayer objDALCls = new Class_PublicDataAccessLayer();
        Class_PublicMethods objClssMethods = new Class_PublicMethods();
        //int iCount= 0;
        //Class_PublicDataAccessLayer objDALCls;
        Class_PublicMethods objPubClass = new Class_PublicMethods();
        SqlConnection SqlConn = new SqlConnection();
        DataSet sqlDtSet = new DataSet();
        DataTable sqlDtTbl = new DataTable();
        public frmCreateRoom()
        {
            InitializeComponent();
        }

        private void frmCreateRoom_Load(object sender, EventArgs e)
        {
            try
            {
                //sSql = "Select PlantID,PlantName,Location,Building,RoomNumber,Description,Zone,DocketNumber,"+
                //       "Parameter,LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation";
                sSql = "Select PlantName FROM RoomStation";//Station Name
                if (objPubClass.Load_CmbBoxValues(sSql, cmbboxStation) == true)
                {
                    objPubClass.Load_CmbBoxValues(sSql, cmbboxStation);
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
            string sPlantNumber, sPlantName, sLocation, sBuilding, sRoomNumber, sDescription, sZone, sDocketNumber, sParameter;
            string sLicensingCriteria, sStatus, sDescriptionChange, sRevisionNumber;
            try
            {
                if (ValidateForm())
                {
                    if (btnAdd.Text == "Add Room")
                    {
                        sPlantNumber = sPlantName = sLocation = sBuilding = sRoomNumber = sDescription = sZone = sDocketNumber = sParameter = "";
                        sLicensingCriteria = sStatus = sDescriptionChange = sRevisionNumber = "";
                        btnAdd.Enabled = false;
                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                        if (String.IsNullOrEmpty(cmbboxStation.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            string sStationNameExist = "";
                            sPlantName = cmbboxStation.Text;
                            sSql = "SELECT PlantNumber FROM RoomStation where PlantName = '" + sPlantName + "'";
                            sStationNameExist = objPubClass.Get_ValueStrfromTable(sSql);

                            //The station name MUST be exactly as you wish it to appear in printedEQ Binders, as
                            //the station name cannot be changed after creation.
                            if (String.IsNullOrEmpty(sStationNameExist) == false)
                            {
                                MessageBox.Show("Plant already exists, please enter a new Plant", "Existing Field");
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                DialogResult drResult = MessageBox.Show("Plant name currently not in EQPro. Do you wish to add this Plant to EQPro?", "Unknown Plant", MessageBoxButtons.YesNo);
                                var vDocketResult = "";
                                if (drResult == DialogResult.Yes)
                                {
                                    vDocketResult = XtraInputBox.Show("Please fill in the Plant Docket Number(s)", "Required Docket Number(s) Needed ", "", MessageBoxButtons.OKCancel);
                                    if (String.IsNullOrEmpty(vDocketResult) == false)
                                    {
                                        var vLicensing = "";
                                        vLicensing = XtraInputBox.Show("Please in the Plant Licensing Criterea", "Required Plant Licensing Criterea Needed", "", MessageBoxButtons.OKCancel);
                                        if (String.IsNullOrEmpty(vLicensing) == false)
                                        {
                                            sPlantName = cmbboxStation.Text;
                                            sRoomNumber = txtBoxRoomNo.Text;
                                            sDescription = txtBoxDescription.Text;
                                            sDocketNumber = vDocketResult;
                                            sLicensingCriteria = vLicensing;
                                            //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                                            //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                                            sSql = "Insert into RoomStation(PlantName, Location, Building, RoomNumber, Description, Zone," +
                                                   "DocketNumber, Parameter,LicensingCriteria,Status,DescriptionChange,RevisionNumber) " +
                                                    "Values('" + sPlantName + "','" + sLocation + "','" + sBuilding + "','" + sRoomNumber + "',"+
                                                    "'" + sDescription + "','" + sZone + "','" + sDocketNumber + "','" + sParameter + "'," +
                                                   "'" + sLicensingCriteria + "','" + sStatus + "','" + sDescriptionChange + "', '" + sRevisionNumber + "')";
                                            objClssMethods.AddNew_Values(sSql);
                                        }
                                    }
                                    else
                                    {

                                    }
                                    ResetRoomValues();
                                    
                                }
                            }
                        }
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
                if (cmbboxStation.Text == "")
                {
                    MessageBox.Show("Station Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(cmbboxStation, "Empty Field");
                    return false;
                }
                if (txtBoxRoomNo.Text == "")
                {
                    MessageBox.Show("Room Number Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(txtBoxRoomNo, "Empty Field");
                    return false;
                }
                if (txtBoxDescription.Text == "")
                {
                    MessageBox.Show("Description Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(txtBoxDescription, "Empty Field");
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
                cmbboxStation.Text = "";
                txtBoxRoomNo.Text = "";
                txtBoxDescription.Text = "";
                cmbboxStation.Visible = true;
                btnAdd.Text = "Add";
                btnAdd.Enabled = true;
            }

            catch (Exception ex)
            {
                new Exception("Error in ResetRoomValues", ex);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form objOpenFrm = Application.OpenForms["frmRoom"];
            //if (objOpenFrm != null)
            //{
            //    objOpenFrm.Close();
            //}           
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
            string sSql, sStatName;
            //int iCount;
            try
            {
                sStatName = cmbboxStation.Text;
                sSql = "SELECT RoomNumber, Description FROM RoomStation where PlantName =  '" + sStatName + "'";
                dataTable = objClssMethods.Get_DataTable(sSql);
                //userID = int.Parse(dataTable.Rows[0][0].ToString());
                txtBoxRoomNo.Text = dataTable.Rows[0][0].ToString();
                txtBoxDescription.Text = dataTable.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ResetRoomValues();
            }
            catch (Exception ex)
            {
                new Exception("Error in btnClear_Click", ex);
            }
        }
    }
}
