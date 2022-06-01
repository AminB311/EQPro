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

namespace EQProDXApp
{
    
    public partial class frmUsers : Form
    {  

        string sSql = "";
        //int iCount= 0;
        //Class_PublicDataAccessLayer objDALCls;
        Class_PublicMethods objPubClass = new Class_PublicMethods();
        SqlConnection SqlConn = new SqlConnection();
        DataSet sqlDtSet = new DataSet();
        DataTable sqlDtTbl = new DataTable();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmEnvironment_Load(object sender, EventArgs e)
        {
            sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
            objPubClass.Load_CmbBoxValues(sSql, cmbBoxUserID);
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            try
            {
                if (btnAdd.Text == "Add")
                {
                    cmbBoxUserID.Text = "";
                    tBoxPwdVerify.Text = "";
                    tBoxNewPwd.Text = "";
                    tBoxPrefix.Text = "";
                    btnAdd.Text = "Save";
                }
                else if (btnAdd.Text == "Save")
                {
                    stxtPlant = stxtPlanRev = stxtZoneID = stxtPlantSearched = "";
                    btnAdd.Enabled = false;
                    //sSql = "SELECT txtPlant, txtPlanRev, txtZoneID, txtPlantSearched FROM tblEnviParameterCurrentInfo where txtPlant = " + "'" + stxtPlant + "'";
                    //sSql = "SELECT Plant,EquipmentID,Equip_Revision,ZoneID,ZoneRev  FROM TblEquipmentAssignment where StationName = " + sStName + " ";
                    if (String.IsNullOrEmpty(cmbBoxUserID.Text) == false)
                    {
                        stxtPlanRev = "";
                        stxtPlant = cmbBoxUserID.Text;
                        sSql = "SELECT txtPlanRev FROM tblEnviParameterCurrentInfo where txtPlant = '" + stxtPlant + "'";
                        stxtPlanRev = objPubClass.Get_ValueStrfromTable(sSql);
                        if (String.IsNullOrEmpty(stxtPlanRev) == false)
                        {
                            MessageBox.Show("Plant already exists, please enter a new Plant", "Existing Field");
                            btnAdd.Enabled = true;
                        }
                        else
                        {
                            stxtPlant = cmbBoxUserID.Text;
                            stxtPlanRev = tBoxPwdVerify.Text;
                            stxtZoneID = tBoxNewPwd.Text;
                            stxtPlantSearched = tBoxPrefix.Text;

                            sSql = "Insert into tblEnviParameterCurrentInfo(txtPlant, txtPlanRev, txtZoneID,txtPlantSearched) " +
                                       "Values('" + stxtPlant + "','" + stxtPlanRev + "','" + stxtZoneID + "', '" + stxtPlantSearched + "')";

                            if (objPubClass.AddNew_Values(sSql) == 1)
                            {
                                cmbBoxUserID.Text = "";
                                MessageBox.Show("Plant added successfully", "Transacntion");
                                sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                                objPubClass.Load_CmbBoxValues(sSql, cmbBoxUserID);
                            }
                            else
                            {
                                MessageBox.Show("Error Plant was not added", "Transacntion");
                            }

                            btnAdd.Text = "Add";
                            btnAdd.Enabled = true;
                            cmbBoxUserID.Text = "";
                            tBoxPwdVerify.Text = "";
                            tBoxNewPwd.Text = "";
                            tBoxPrefix.Text = "";
                            btnAdd.Text = "Save";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Plant can't be empty", "Empty Field");
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in btnAdd_Click", ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string stxtPlant = "";
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete the Plant", "Please Confirm", MessageBoxButtons.YesNoCancel);

                if (String.IsNullOrEmpty(cmbBoxUserID.Text) == false)
                {
                    stxtPlant = cmbBoxUserID.Text;
                }
                else
                {
                    MessageBox.Show("Plant can't be empty", "Empty Field");
                }

                if ((result == DialogResult.Yes) && (String.IsNullOrEmpty(cmbBoxUserID.Text) == false))
                {
                    stxtPlant = cmbBoxUserID.Text;
                    //sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                    sSql = "Delete FROM tblEnviParameterCurrentInfo where txtPlant = '" + stxtPlant + "'";
                    objPubClass.Delete_SelectedValues(sSql);

                    cmbBoxUserID.Text = "";
                    sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                    objPubClass.Load_CmbBoxValues(sSql, cmbBoxUserID);
                }
                else if (result == DialogResult.No)
                {
                    //do what you want!!
                }
                else
                {
                    //do what you want!!
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in btnDelete_Click", ex);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";

        }

        private void cmbBoxtxtPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSql, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dtTbl = new DataTable();
            int iCount;
            try
            {
                stxtPlanRev = stxtZoneID = stxtPlantSearched = "";
                stxtPlant = cmbBoxUserID.Text;
                sSql = "SELECT txtPlant, txtPlanRev, txtZoneID, txtPlantSearched FROM tblEnviParameterCurrentInfo where txtPlant = " + "'" + stxtPlant + "'";
                //sSql = "SELECT Plant,EquipmentID,Equip_Revision,ZoneID,ZoneRev  FROM TblEquipmentAssignment where StationName = " + sStName + " ";
                dtTbl = objPubClass.Get_DataTable(sSql);
                if (dtTbl.Rows.Count > 0)
                {
                    iCount = 0;
                    foreach (DataRow dr_Row in dtTbl.Rows)
                    {
                        stxtPlanRev = dtTbl.Rows[iCount][1].ToString().TrimEnd();
                        stxtZoneID = dtTbl.Rows[iCount][2].ToString().TrimEnd();
                        stxtPlantSearched = dtTbl.Rows[iCount][3].ToString().TrimEnd();
                    }
                }
                tBoxPwdVerify.Text = stxtPlanRev;
                tBoxNewPwd.Text = stxtZoneID;
                tBoxPrefix.Text = stxtPlantSearched;
            }

            catch (Exception ex)
            {
                new Exception("Error in cmbBoxStatioName_SelectedIndexChanged", ex);
            }

        }

        private void btnMianPg_Click(object sender, EventArgs e)
        {
            //frmEnvironment objFrmEnvirt = new frmEnvironment();
            //objFrmEnvirt.Hide();
            //this.Hide();

           // this.Close ();
            this.Hide();

            frmMain objFrmMain1 = new frmMain();
            objFrmMain1.Show();

        }

        private void cmbBoxEQAppRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxEQRepRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
