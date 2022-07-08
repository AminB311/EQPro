using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EQProDXApp
{
    public class Class_PublicMethods
    {
        string sSql = "";
        int iCount = 0;
        Class_PublicDataAccessLayer objDALCls = new Class_PublicDataAccessLayer();
        //DataAccessLayer.clsDataAccessLayer objDALCls = new DataAccessLayer.clsDataAccessLayer();
        SqlConnection SqlConn = new SqlConnection();
        DataSet sqlDtSet = new DataSet();
        DataTable sqlDtTbl = new DataTable();
        SqlDataAdapter objSqlDtAdap = new SqlDataAdapter();

        public bool Load_CmbBoxValues(string sSql, DevExpress.XtraEditors.ComboBoxEdit objCmbBoxName)
        {
            string sVal = "";
            try
            {
                objCmbBoxName.Properties.Items.Clear();
                if (objDALCls.getSqlConn() != null)
                {
                    SqlConn = objDALCls.getSqlConn();
                    sqlDtTbl = objDALCls.getDataTable(sSql, SqlConn);
                    if (sqlDtTbl.Rows.Count > 0)
                    {
                        iCount = 0;
                        foreach (DataRow dr_RowSel in sqlDtTbl.Rows)//Loop on Tbl
                        {
                            if (String.IsNullOrEmpty(sqlDtTbl.Rows[iCount][0].ToString()) == false)
                            {
                                sVal = sqlDtTbl.Rows[iCount][0].ToString();
                                sVal = sVal.TrimEnd();
                                objCmbBoxName.Properties.Items.Add(sVal);
                            }
                            iCount++;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in Load_CmbBoxValues, filling Combo Box", ex);
                return false;
            }
        }

        public bool Load_CmbTextBoxValues(string sSql, DevExpress.XtraEditors.ComboBoxEdit objCmbBoxName, DevExpress.XtraEditors.TextEdit objTextBoxName)
        {
            string sVal = "";
            try
            {
                //Create Temp Table 
                //sSql = "CREATE TABLE " + sTmpTblName + "(" + sTmpTblFieldNameSRC + " [int]," + sTmpTblFieldNameTRG + "[int], " + sBitColName + "[bit] NULL)";
                ////objPhdAdoTarget.ExecuteNonQuery(sSql);
                //sSql = "Drop Table " + sSchemaName + sDtTblName;
                //objPhdAdoTarget.ExecuteNonQuery(sSql);
                //sSql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('" + sCreateTmpTblName + "')";
                //iCount = objPhdAdoTarget.ExecuterScalar<int>(sSql);
                objCmbBoxName.Properties.Items.Clear();
                if (objDALCls.getSqlConn() != null)
                {
                    SqlConn = objDALCls.getSqlConn();
                    sqlDtTbl = objDALCls.getDataTable(sSql, SqlConn);
                    if (sqlDtTbl.Rows.Count > 0)
                    {
                        iCount = 0;
                        foreach (DataRow dr_RowSel in sqlDtTbl.Rows)//Loop on Tbl
                        {
                            if (String.IsNullOrEmpty(sqlDtTbl.Rows[iCount][0].ToString()) == false)
                            {
                                sVal = sqlDtTbl.Rows[iCount][0].ToString();
                                sVal = sVal.TrimEnd();
                                objCmbBoxName.Properties.Items.Add(sVal);
                                sVal = sqlDtTbl.Rows[iCount][1].ToString();//Load ID in txt Box
                                sVal = sVal.TrimEnd();
                                objTextBoxName.Text = sVal;
                            }
                            iCount++;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in Load_CmbTextBoxValues, filling Combo Box", ex);
                return false;
            }
        }

        public bool Load_CmbBoxValues(string sSql, ComboBox objCmbBoxName)
        {
            string sVal = "";
            try
            {
                objCmbBoxName.Items.Clear();
                if (objDALCls.getSqlConn() != null)
                {
                    SqlConn = objDALCls.getSqlConn();
                    sqlDtTbl = objDALCls.getDataTable(sSql, SqlConn);
                    if (sqlDtTbl.Rows.Count > 0)
                    {
                        iCount = 0;
                        foreach (DataRow dr_RowSel in sqlDtTbl.Rows)//Loop on Tbl
                        {
                            if (String.IsNullOrEmpty(sqlDtTbl.Rows[iCount][0].ToString()) == false)
                            {
                                sVal = sqlDtTbl.Rows[iCount][0].ToString();
                                sVal = sVal.TrimEnd();
                                objCmbBoxName.Items.Add(sVal);
                            }
                            iCount++;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Exception("Error in Load_CmbBoxValues, filling Combo Box", ex);
                return false;
            }
        }

        public void Delete_SelectedValues(string sSql)
        {
            try
            {
                SqlConn = objDALCls.getSqlConn();
                objSqlDtAdap.DeleteCommand = new SqlCommand(sSql, SqlConn);
                objSqlDtAdap.DeleteCommand.ExecuteNonQuery();
                //phdAdo.ExecuteNonQuery(sSql);


            }
            catch (Exception ex)
            {
                new Exception("Error in Delete_SelectedValues, filling Combo Box", ex);
            }
        }

        public int CheckForUniqueID(string sSql)
        {
            try
            {
                SqlConn = objDALCls.getSqlConn();
                SqlCommand cmd = new SqlCommand(sSql, SqlConn);
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Get_DataTable", ex);
            }
        }
        public int AddNew_Values(string sSql)
        {
            try
            {
                SqlConn = objDALCls.getSqlConn();
                objSqlDtAdap.InsertCommand = new SqlCommand(sSql, SqlConn);
                objSqlDtAdap.InsertCommand.ExecuteNonQuery();
                return 1;
                //if (dt_TrgCaseProdProjection.Rows.Count > 0)
                //{
                //    //Add new & Existing values into Case Product Projection
                //    phdAdo.bulkInsert("Cases.ProductProjection", dt_TrgCaseProdProjection, false);
                //    MergeCls.sMsg_CaseMerge = "Case Data Merged.";
                //}
                //sModelDeckIdTRG = MergeCorporateDataCls.Get_ValueStrfromTable(phdAdoTarget, sSql);
                //phdAdoTarget.ExecuteNonQuery(sSql);
                //sSql = "Delete FROM Cases.ProductProjection where CaseProjectionQualifierId in(" + sCaseProjQualIdTrgAll + ")";
                //phdAdo.ExecuteNonQuery(sSql);
            }
            catch (Exception ex)
            {
                new Exception("Error in AddNew_Values" + ", filling Combo Box", ex);
                return 0;
            }
        }

        //Get value from the table; check if value exists in the Table.Finally returns a string
        public string Get_ValueStrfromTable(string sSql)
        {
            string sVal = "";
            try
            {
                SqlConn = objDALCls.getSqlConn();
                //if(SqlConn= null)
                //{

                //}
                sqlDtTbl = objDALCls.getDataTable(sSql, SqlConn);
                //objDtTable = objPhdAdoTRG.LoadDataTable(sSql);
                if (sqlDtTbl.Rows.Count != 0)
                {
                    sVal = sqlDtTbl.Rows[0][0].ToString();
                }
                return sVal.TrimEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Get_ValuefromTable().", ex);
            }
        } // end     
       
        public DataTable Get_DataTable(string sSql)
        {
            try
            {
                SqlConn = objDALCls.getSqlConn();
                sqlDtTbl = objDALCls.getDataTable(sSql, SqlConn);
                return sqlDtTbl;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Get_DataTable", ex);
            }
        }

        public int Get_MaxIDfromTable(string sFieldName, string sTableName)
        {
            int iMaxID = 0;
            string sSql = "";
            try
            {              
                sSql = "SELECT ISNULL(max( " + sFieldName + "),0) FROM " + sTableName + "";
                //iMaxID = objDALCls.ExecuterScalar<int>(sSql);
                //SqlConn = objDALCls.getSqlConn();
                SqlCommand cmd = new SqlCommand(sSql, SqlConn);
                iMaxID = (int)cmd.ExecuteScalar();
                iMaxID = iMaxID + 1;
                return iMaxID;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Method Get_MaxIDfromTable().", ex);
                //return 0;
            }

        } // end 


    }
}
