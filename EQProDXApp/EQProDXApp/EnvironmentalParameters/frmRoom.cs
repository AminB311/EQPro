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
                cmbboxStation.Enabled = true;

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
            string sPlantNumber, sPlantName, sLocation, sBuilding, sRoomName, sDescription, sZone, sDocketNumber, sParameter;
            string sLicensingCriteria, sStatus, sDescriptionChange, sRevisionNumber, sReference;
            string sRevision, sDateAssig, sDateDel, sDateRevised, sDeletedBy, sPlantID, sRoomID;
            int iPlantID, iRoomID;
            double dPlantlife;
            try
            {
                if (ValidateForm())
                {
                    //if (btnAdd.Text == "Add Room")
                    //{
                        sPlantNumber = sPlantName = sLocation = sBuilding = sRoomName = sDescription = sZone = sDocketNumber = sParameter = "";
                        sLicensingCriteria = sStatus = sDescriptionChange = sRevisionNumber = sReference = sDeletedBy = "";
                        sRevision = sDateAssig = sDateDel = sDateRevised = "";
                        //btnAdd.Enabled = false;
                        //SELECT PlantNumber, PlantName, Location, Building, RoomNumber, Description, Zone, DocketNumber, Parameter,"+
                        //LicensingCriteria,Status,DescriptionChange,RevisionNumber FROM RoomStation
                        if (String.IsNullOrEmpty(cmbboxStation.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            string sNameExist = "";
                            sPlantName = cmbboxStation.Text;
                            sPlantName = cmbboxStation.Text;
                            sRoomName = txtBoxRoomName.Text;
                            sDescription = txtBoxDescription.Text;
                            sRevisionNumber = "0";
                            sLocation = "Test";
                            sStatus = "Revision In Progress";
                            dPlantlife = 0;
                            sRevision = "0";
                            sDateAssig = DateTime.Today.ToString();
                            sDateDel = "";
                            sDateRevised = "";
                            sDeletedBy = "";
                            sPlantID = "";

                            sSql = "SELECT PlantID FROM Plant where PlantName = '" + sPlantName + "'";
                            sPlantID = objPubClass.Get_ValueStrfromTable(sSql);
                            //07/08/2022 If Plant Exists, then only add Rooms
                            if (String.IsNullOrEmpty(sPlantID) == false)
                            {
                                sSql = "SELECT RoomID FROM Room where Name = '" + sRoomName + "'";
                                sNameExist = objPubClass.Get_ValueStrfromTable(sSql);
                                //07/08/2022 If Plant Exists, then only add Rooms
                                if (String.IsNullOrEmpty(sNameExist) == true)
                                {
                                    //sPlantID = sNameExist;
                                    sSql = "Insert into Room(Name,Location,Description) " +
                                             "Values('" + sRoomName + "','" + sLocation + "','" + sDescription + "')";
                                    iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert
                                    if (iVal == 0)
                                    {
                                        MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                    }
                                    iRoomID = objClssMethods.Get_MaxIDfromTable("RoomID", "Room");//Get MAX LinkDateID from Target, it returns MAX+1 
                                    iRoomID--;
                                    sRoomID = iRoomID.ToString();
                                    sSql = "Insert into PlantRoomAssignment(Status,PlantID,RoomID,Revision,DateAssigned,DateRevised,DateDeleted,DeletedBy) " +
                                          "Values('" + sStatus + "','" + sPlantID + "','" + sRoomID + "','" + sRevision + "','" + sDateAssig + "',"+
                                          "'" + sDateRevised + "','" + sDateDel + "'," +"'" + sDeletedBy + "')";
                                    iVal = objClssMethods.AddNew_Values(sSql);// 1 Big Sql for Insert                                                                                   
                                    if (iVal == 1)
                                    {
                                        MessageBox.Show("Room added to the existing Station.", "Room added successfully", MessageBoxButtons.OK);
                                        ResetRoomValues();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Room was not added.", "Error", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Room alreay exists, please enter a different name.", "Error", MessageBoxButtons.OK);
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
                                        vLicensing = XtraInputBox.Show("Please fill in the Plant Licensing Criterea", "Required Plant Licensing Criterea Needed", "", MessageBoxButtons.OKCancel);
                                        if (String.IsNullOrEmpty(vLicensing) == false)
                                        {
                                            var vPlantLife = "";
                                            vPlantLife = XtraInputBox.Show("Please fill in the Plant Life Period", "Required Plant Life Period Needed", "", MessageBoxButtons.OKCancel);
                                            if (String.IsNullOrEmpty(vPlantLife) == false)
                                            {
                                                sDocketNumber = vDocketResult;
                                                sLicensingCriteria = vLicensing;
                                                dPlantlife = Convert.ToDouble(vPlantLife);
                                                //Insert into Plant(PlantName, Location, Description, Zone, DocketNumber, Parameter, LicensingCriteria, Status, DescriptionChange, RevisionNumber, Reference)
                                                //Values('New Test Station', '505', 'Created on July 05', '', 'Docket No 505', '', 'Lic Crit 505', 'Revision In Progress', '', '1', '')
                                                sSql = "Insert into Plant(PlantName, Location, Description, Zone," +
                                                       "DocketNumber, Parameter,LicensingCriteria,Plantlife,Status,DescriptionChange,RevisionNumber, Reference) " +
                                                        "Values('" + sPlantName + "','" + sLocation + "','" + sDescription + "','" + sZone + "','" + sDocketNumber + "','" + sParameter + "'," +
                                                       "'" + sLicensingCriteria + "','" + dPlantlife + "','" + sStatus + "','" + sDescriptionChange + "', '" + sRevisionNumber + "','" + sReference + "') " +
                                                       //"set @trgPlantID = SCOPE_IDENTITY() "+
                                                       "Insert into Room(Name,Location,Description) " +
                                                       "Values('" + sRoomName + "','" + sLocation + "','" + sDescription + "')";
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
                                                        MessageBox.Show("Station creation was successful.", "Plant Creation Confirmed", MessageBoxButtons.OK);
                                                        ResetRoomValues();

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Station was not added.", "Error", MessageBoxButtons.OK);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Station was not added.", "Error", MessageBoxButtons.OK);
                                                }
                                            }
                                        }
                                    }                                   
                                    ResetRoomValues();
                                }
                            }
                        }
                    //}                                      
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
                if (txtBoxRoomName.Text == "")
                {
                    MessageBox.Show("Room Number Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(txtBoxRoomName, "Room Number can't be Empty");
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
                //cmbboxStation.Text = "";
                txtBoxRoomName.Text = "";
                txtBoxDescription.Text = "";
                
              
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

        private void cmbboxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                string sPlantName = "";
                sPlantName = cmbboxStation.Text;
                DataTable dataTable = new DataTable();

                if (String.IsNullOrEmpty(sPlantName) == true)
                {
                    //cmbboxStation.Enabled = true;
                    sSql = "Select PlantName, Status, RevisionNumber FROM Plant " +
                           "where PlantName = '" + sPlantName + "'" +
                           "Order By RevisionNumber Desc";

                    dataTable = objClssMethods.Get_DataTable(sSql);


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
            }
            catch (Exception ex)
            {
                new Exception("Error in frmCreateRoom_Load", ex);
            }
        }


    }
}
