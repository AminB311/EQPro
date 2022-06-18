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
                sSql = "SELECT PlantNumber,PlantName,Location,Building,RoomNumber,Description,Zone,DocketNumber, Parameter," +
                   "LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation";
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
                                    //if (MessageBoxButtons.OKCancel == DialogResult.Cancel )
                                    //{
                                    //}
                                    //if (vResult == Cancel )
                                    //{
                                    //}
                                    //MUST be exactly as you wish it to appear in printedEQ Binders, as
                                    //the station name cannot be changed after creation.
                                    //The station name MUST be exactly as you wish it to appear in printedEQ Binders, as
                                    //the station name cannot be changed after creation
                                    //Yes and then OK button to the message box displayed by EQPro and proceed to
                                    //enter the Plant Docket Number(s) and Plant Licensing Criteria respectively.Note clicking
                                    //cancel button suspends Station creation process
                                    //If the user clicks “OK” button after providing the Docket Number(s), EQPro displays the
                                    //following message with Plant Licensing Criteria expected values.
                                    //Station creation has been cancelled
                                    //sSql = "Insert into tblEnviParameterCurrentInfo(txtPlant, txtPlanRev, txtZoneID,txtPlantSearched) " +
                                    //       "Values('" + sStationName + "','" + sRoomNo + "','" + sDescription + "')";
                                    //if (objPubClass.AddNew_Values(sSql) == 1)
                                    //{
                                    //    cmbboxStation.Text = "";
                                    //    MessageBox.Show("Plant added successfully", "Transacntion");
                                    //    sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                                    //    objPubClass.Load_CmbBoxValues(sSql, cmbboxStation);
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("Error Plant was not added", "Transacntion");
                                    //}
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
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    string stxtPlant = "";
        //    try
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to Delete the Plant", "Please Confirm", MessageBoxButtons.YesNoCancel);

        //        if (String.IsNullOrEmpty(cmbboxStation.Text) == false)
        //        {
        //            stxtPlant = cmbboxStation.Text;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Plant can't be empty", "Empty Field");
        //        }

        //        if ((result == DialogResult.Yes) && (String.IsNullOrEmpty(cmbboxStation.Text) == false))
        //        {
        //            stxtPlant = cmbboxStation.Text;
        //            //sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
        //            sSql = "Delete FROM tblEnviParameterCurrentInfo where txtPlant = '" + stxtPlant + "'";
        //            objPubClass.Delete_SelectedValues(sSql);

        //            cmbboxStation.Text = "";
        //            sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
        //            objPubClass.Load_CmbBoxValues(sSql, cmbboxStation);
        //        }
        //        else if (result == DialogResult.No)
        //        {
        //            //do what you want!!
        //        }
        //        else
        //        {
        //            //do what you want!!
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        new Exception("Error in btnDelete_Click", ex);
        //    }
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form objOpenFrm = Application.OpenForms["frmRoom"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
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
        private void lblEnv_Click(object sender, EventArgs e)
        {

        }

        private void tBoxPlanRev_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tBoxRoomNo_EditValueChanged(object sender, EventArgs e)
        {

        }
        
        private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dataTable = new DataTable();
            string sSql;
            //int iCount;
            try
            {
                sSql = "SELECT PlantName, RoomNumber, Description FROM RoomStation where PlantNumber = " + int.Parse(cmbboxStation.Text);
                dataTable = objClssMethods.Get_DataTable(sSql);
                //userID = int.Parse(dataTable.Rows[0][0].ToString());
                txtBoxRoomNo.Text = dataTable.Rows[0][1].ToString();
                txtBoxDescription.Text = dataTable.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
            }
        }
    }
}
