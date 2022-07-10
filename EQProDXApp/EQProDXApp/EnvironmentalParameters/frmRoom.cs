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
        Class_PublicMethods objMethods = new Class_PublicMethods();

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
                sSql = "Select PlantName FROM Plant";//Station Name
                if (objPubClass.Load_CmbBoxValues(sSql, cmbboxStation) == true)
                {
                    objPubClass.Load_CmbBoxValues(sSql, cmbboxStation);
                }
                else
                {
                    MessageBox.Show("Error in connection string opening the DB");
                    new Exception("Error in connection string opening the DB");
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in frmCreateRoom_Load", ex);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iVal = 0;
            string sPlantNumber, sPlantName, sLocation, sBuilding, sRoomNumber, sDescription, sZone, sDocketNumber, sParameter;
            string sLicensingCriteria, sStatus, sDescriptionChange, sRevisionNumber, sReference;
            string sRevision, sDateAssig, sDateDel, sDateRevised, sDeletedBy, sPlantID, sRoomID;
            int iPlantID, iRoomID;
            try
            {
                if (ValidateForm())
                {
                    if (btnAdd.Text == "Add Room")
                    {
                        sPlantNumber = sPlantName = sLocation = sBuilding = sRoomNumber = sDescription = sZone = sDocketNumber = sParameter = "";
                        sLicensingCriteria = sStatus = sDescriptionChange = sRevisionNumber = sReference = sDeletedBy = "";
                        sRevision = sDateAssig = sDateDel = sDateRevised = "";
                        //btnAdd.Enabled = false;
                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                        if (String.IsNullOrEmpty(cmbboxStation.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            string sStationNameExist = "";
                            sPlantName = cmbboxStation.Text;
                            sPlantName = cmbboxStation.Text;
                            sRoomNumber = txtBoxRoomNo.Text;
                            sDescription = txtBoxDescription.Text;
                            sRevisionNumber = "0";
                            sLocation = "Test";
                            sStatus = "Revision In Progress";
                            sRevision = "0";
                            sDateAssig = DateTime.Today.ToString();
                            sDateDel = "";
                            sDateRevised = "";
                            sDeletedBy = "";
                            sPlantID = "";

                            sSql = "SELECT PlantID FROM Plant where PlantName = '" + sPlantName + "'";
                            sStationNameExist = objPubClass.Get_ValueStrfromTable(sSql);
                            //07/08/2022 If Plant Exists, then only add Rooms
                            if (String.IsNullOrEmpty(sStationNameExist) == false)
                            {
                                sPlantID = sStationNameExist;                               
                                sSql = "Insert into Room(Name,Location,Description) " +
                                         "Values('" + sRoomNumber + "','" + sLocation + "','" + sDescription + "')";
                                iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert
                                if (iVal == 0)
                                {
                                    MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                }
                                iRoomID = objClssMethods.Get_MaxIDfromTable("RoomID", "Room");//Get MAX LinkDateID from Target, it returns MAX+1 
                                iRoomID--;
                                sRoomID = iRoomID.ToString();
                                sSql = "Insert into PlantRoomAssignment(Status,PlantID,RoomID,Revision,DateAssigned,DateRevised,DateDeleted,DeletedBy) " +
                                      "Values('" + sStatus + "','" + sPlantID + "','" + sRoomID + "','" + sRevision + "','" + sDateAssig + "','" + sDateRevised + "','" + sDateDel + "'," +
                                      "'" + sDeletedBy + "')";
                                iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert                                                                                   
                                if (iVal == 1)
                                {
                                    MessageBox.Show("Room added successfully.", "Room Added", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                }
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
                                            sDocketNumber = vDocketResult;
                                            sLicensingCriteria = vLicensing;
                                            //Insert into Plant(PlantName, Location, Description, Zone, DocketNumber, Parameter, LicensingCriteria, Status, DescriptionChange, RevisionNumber, Reference)
                                            //Values('New Test Station', '505', 'Created on July 05', '', 'Docket No 505', '', 'Lic Crit 505', 'Revision In Progress', '', '1', '')
                                            sSql = "Insert into Plant(PlantName, Location, Description, Zone," +
                                                   "DocketNumber, Parameter,LicensingCriteria,Status,DescriptionChange,RevisionNumber, Reference) " +
                                                    "Values('" + sPlantName + "','" + sLocation + "','" + sDescription + "','" + sZone + "','" + sDocketNumber + "','" + sParameter + "'," +
                                                   "'" + sLicensingCriteria + "','" + sStatus + "','" + sDescriptionChange + "', '" + sRevisionNumber + "','" + sReference + "') " +
                                                   //"set @trgPlantID = SCOPE_IDENTITY() "+
                                                   "Insert into Room(Name,Location,Description) " +
                                                   "Values('" + sRoomNumber + "','" + sLocation + "','" + sDescription + "')";
                                            iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert
                                            if (iVal == 1)
                                            {
                                                //Get recently added values 
                                                //Plant ID
                                                iPlantID = objClssMethods.Get_MaxIDfromTable("PlantID", "Plant");//Get MAX LinkDateID from Target, it returns MAX+1 
                                                iPlantID--;
                                                sPlantID = iPlantID.ToString();
                                                //Room ID
                                                iRoomID = objClssMethods.Get_MaxIDfromTable("RoomID", "Room");//Get MAX LinkDateID from Target, it returns MAX+1 
                                                iRoomID--;
                                                sRoomID = iRoomID.ToString();
                                                sSql = "Insert into PlantRoomAssignment(Status,PlantID,RoomID,Revision,DateAssigned,DateRevised,DateDeleted,DeletedBy) " +
                                                      "Values('" + sStatus + "','" + sPlantID + "','" + sRoomID + "','" + sRevision + "','" + sDateAssig + "','" + sDateRevised + "','" + sDateDel + "'," +
                                                      "'" + sDeletedBy + "')";
                                                iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert                                                                                    
                                                if (iVal == 1)
                                                {
                                                    MessageBox.Show("Room added successfully.", "Room Added", MessageBoxButtons.OK);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                            }
                                        }
                                    }                                   
                                    ResetRoomValues();
                                }
                            }
                        }
                    }                                      
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in adding a New Room", ex);
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
                    errorProvider.SetError(cmbboxStation, "Station can't be Empty");
                    return false;
                }
                if (txtBoxRoomNo.Text == "")
                {
                    MessageBox.Show("Room Number Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(txtBoxRoomNo, "Room Number can't be Empty");
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
                cmbboxStation.Enabled  = true;
                btnAdd.Text = "Add Room";
                btnAdd.Enabled = true;
                objMethods.Load_CmbBoxValues("SELECT PlantName from Plant", cmbboxStation);
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
        
        //private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
        //    DataTable dataTable = new DataTable();
        //    string sSql, sStatName;
        //    //int iCount;
        //    try
        //    {
        //        sStatName = cmbboxStation.Text;
        //        //sSql = "SELECT RoomNumber, Description FROM Plant where PlantName =  '" + sStatName + "'";

        //        sSql = "SELECT R.Name, R.Description  from Plant P " +
        //              "INNER JOIN PlantRoomAssignment PA " +
        //              "ON PA.PlantID = P.PlantID " +
        //              "INNER JOIN Room R " +
        //              "ON R.RoomID = PA.RoomID " +
        //              "where P.PlantName = '" + sStatName + "'";
        //        dataTable = objClssMethods.Get_DataTable(sSql);
        //        //userID = int.Parse(dataTable.Rows[0][0].ToString());
        //        txtBoxRoomNo.Text = dataTable.Rows[0][0].ToString();
        //        txtBoxDescription.Text = dataTable.Rows[0][1].ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        new Exception("Error in cmbboxStation_SelectedIndexChanged", ex);
        //    }
        //}

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

        private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dataTable = new DataTable();
            string sSql, sStatName;
            //int iCount;
            try
            {
                sStatName = cmbboxStation.Text;
                //sSql = "SELECT RoomNumber, Description FROM Plant where PlantName =  '" + sStatName + "'";

                sSql = "SELECT R.Name, R.Description  from Plant P " +
                      "INNER JOIN PlantRoomAssignment PA " +
                      "ON PA.PlantID = P.PlantID " +
                      "INNER JOIN Room R " +
                      "ON R.RoomID = PA.RoomID " +
                      "where P.PlantName = '" + sStatName + "'";
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
    }
}
