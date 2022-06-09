﻿using System;
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
    
    public partial class frmCreateRoom : Form
    { 
        string sSql = "";
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

        private void frmEnvironment_Load(object sender, EventArgs e)
        {
            sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
            if (objPubClass.Load_CmbBoxValues(sSql, cmbStationName) == true)
            {
                objPubClass.Load_CmbBoxValues(sSql, cmbStationName);
            }
            else
            {
                MessageBox.Show("Error in connection string opening the DB ");
                new Exception("Error in connection string opening the DB ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sStationName, sRoomNo, sDescription;
            try
            {
                if (btnAdd.Text == "Add")
                {
                    cmbStationName.Text = "";
                    tBoxRoomNo.Text = "";
                    tBoxDescrip.Text = "";                  
                    btnAdd.Text = "Save";
                }
                else if (btnAdd.Text == "Save")
                {
                    sStationName =  sRoomNo = sDescription = "";
                    btnAdd.Enabled = false;
                    //sSql = "SELECT txtPlant, txtPlanRev, txtZoneID, txtPlantSearched FROM tblEnviParameterCurrentInfo where txtPlant = " + "'" + stxtPlant + "'";
                    if (String.IsNullOrEmpty(cmbStationName.Text) == false)
                    {
                        //sStationName, sRoomNo, sDescription
                        string sStationNameExist = "";
                        sStationName = cmbStationName.Text;
                        sSql = "SELECT txtPlanRev FROM tblEnviParameterCurrentInfo where txtPlant = '" + sStationName + "'";
                        sStationNameExist = objPubClass.Get_ValueStrfromTable(sSql);
                        if (String.IsNullOrEmpty(sStationNameExist) == false)
                        {
                            MessageBox.Show("Plant already exists, please enter a new Plant", "Existing Field");
                            btnAdd.Enabled = true;
                        }
                        else
                        {
                          DialogResult drResult =      MessageBox.Show("Plant name currently not in EQPro. Do you wish to add this Plant toEQPro?", "Unknown Plant",MessageBoxButtons.YesNo);

                            if (drResult == DialogResult.Yes)
                            {
                                sStationName = cmbStationName.Text;
                                sRoomNo = tBoxRoomNo.Text;
                                sDescription = tBoxDescrip.Text;


                                sSql = "Insert into tblEnviParameterCurrentInfo(txtPlant, txtPlanRev, txtZoneID,txtPlantSearched) " +
                                           "Values('" + sStationName + "','" + sRoomNo + "','" + sDescription + "')";

                                if (objPubClass.AddNew_Values(sSql) == 1)
                                {
                                    cmbStationName.Text = "";
                                    MessageBox.Show("Plant added successfully", "Transacntion");
                                    sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                                    objPubClass.Load_CmbBoxValues(sSql, cmbStationName);
                                }
                                else
                                {
                                    MessageBox.Show("Error Plant was not added", "Transacntion");
                                }
                            }

                            btnAdd.Text = "Add";
                            btnAdd.Enabled = true;
                            tBoxRoomNo.Text = "";
                            tBoxDescrip.Text = "";                           
                            //btnAdd.Text = "Save";
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

                if (String.IsNullOrEmpty(cmbStationName.Text) == false)
                {
                    stxtPlant = cmbStationName.Text;
                }
                else
                {
                    MessageBox.Show("Plant can't be empty", "Empty Field");
                }

                if ((result == DialogResult.Yes) && (String.IsNullOrEmpty(cmbStationName.Text) == false))
                {
                    stxtPlant = cmbStationName.Text;
                    //sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                    sSql = "Delete FROM tblEnviParameterCurrentInfo where txtPlant = '" + stxtPlant + "'";
                    objPubClass.Delete_SelectedValues(sSql);

                    cmbStationName.Text = "";
                    sSql = "SELECT txtPlant FROM tblEnviParameterCurrentInfo";
                    objPubClass.Load_CmbBoxValues(sSql, cmbStationName);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form objOpenFrm = Application.OpenForms["frmEnvironment"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
            }
        }

        private void cmbBoxtxtPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string  sSql, sStatName, stxtPlant, stxtPlanRev, stxtZoneID, stxtPlantSearched;
            DataTable dtTbl = new DataTable();
            int iCount;
            try
            {
                sStatName = stxtPlanRev = stxtZoneID = stxtPlantSearched = "";
                sStatName = cmbStationName.Text;
                sSql = "SELECT txtPlant, txtPlanRev, txtZoneID, txtPlantSearched FROM tblEnviParameterCurrentInfo where txtPlant = " + "'" + sStatName + "'";
                //sSql = "SELECT Plant,EquipmentID,Equip_Revision,ZoneID,ZoneRev  FROM TblEquipmentAssignment where StationName = " + sStName + " ";
                dtTbl = objPubClass.Get_DataTable(sSql);
                if (dtTbl.Rows.Count > 0)
                {
                    iCount = 0;
                    foreach (DataRow dr_Row in dtTbl.Rows)
                    {
                        sStatName = dtTbl.Rows[iCount][1].ToString().TrimEnd();
                        stxtZoneID = dtTbl.Rows[iCount][2].ToString().TrimEnd();
                        stxtPlantSearched = dtTbl.Rows[iCount][3].ToString().TrimEnd();
                    }
                }
                cmbStationName.Text = sStatName;
                //tBoxPlantSearched.Text = stxtPlantSearched;
                tBoxDescrip.Text = stxtPlanRev;
            }

            catch (Exception ex)
            {
                new Exception("Error in cmbBoxStatioName_SelectedIndexChanged", ex);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            cmbStationName.Text = "";
            cmbStationName.Text = "";
            //textBoxVerifyPass.Text = "";
            //textBoxFN.Text = "";
            //textBoxMN.Text = "";
            //textBoxLN.Text = "";
            //textBoxPrefix.Text = "";
            //textBoxSuffix.Text = "";
            //textBoxEmail.Text = "";
            //textBoxSignature.Text = "";
            //comboBoxEQRole.Text = "";
            //comboBoxEQUserRole.Text = "";
            //textBoxEQProUserID.Text = "Click Here";

            //textBoxUpdatedPassDate.Text = DateTime.Now.ToString();
            btnAdd.Text = "Add";
        }

        private void lblEnv_Click(object sender, EventArgs e)
        {

        }

        private void tBoxPlanRev_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
