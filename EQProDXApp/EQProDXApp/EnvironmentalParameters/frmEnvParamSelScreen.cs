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
                sSql = "Select Concat(Name,' , ',Description) FROM Room";//Room

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

        private void btnFilter_Click(object sender, EventArgs e)
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
                        if (String.IsNullOrEmpty(cmbBoxStation.Text) == false)
                        {
                            //sStationName, sRoomNo, sDescription
                            //string sPlantID = "";
                            sRoomNo = cmbBoxStation.Text;
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

        private void dataGridStation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidateForm()
        {
            try
            {
                ErrorProvider errorProvider = new ErrorProvider();
                //var phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
                if (cmbBoxStation.Text == "")
                {
                    MessageBox.Show("Station Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(cmbBoxStation, "Empty Field");
                    return false;
                }               
            }
            catch (Exception ex)
            {
                new Exception("Error in ValidateForm", ex);
            }
            
            return true;
        }             

        private void cmBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSql,sTmp;
            try
            {
                sTmp = cmbBoxStation.Text;
                string[] sWordArr = sTmp.Split(',');
                sRoomNo = sWordArr[0];
                sDescrip = sWordArr[1];
                //001 Plant is loked
                sRoomNo = sRoomNo;

                //sSql = "SELECT RevisionNumber, Status FROM RoomStation where RoomNumber = " + sRoomNo + " " +
                //       "AND Description = " + sDescrip;

                sSql = "SELECT P.PlantName as Station  , P.RevisionNumber as Revision, P.Status " +
                       "from Plant P " +
                       "INNER JOIN PlantRoomAssignment PA " +
                       "ON PA.PlantID = P.PlantID " +
                       "INNER JOIN Room R " +
                       "ON R.RoomID = PA.RoomID " +
                       "where R.Name = '" + sRoomNo + "'";
                dtTblEnvParam = objClssMethods.Get_DataTable(sSql);
                dataGridStation.DataSource = dtTblEnvParam;
                
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
