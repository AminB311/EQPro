using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        public void Load_CmbBoxValues(string sSql, DevExpress.XtraEditors.ComboBoxEdit objCmbBoxName)
        {
            string sVal = "";
            try
            {
                objCmbBoxName.Properties.Items.Clear();
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
            }
            catch (Exception ex)
            {
                new Exception("Error in Load_CmbBoxValues, filling Combo Box", ex);
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


        public void NewMethod()
        {
            try
            {
                string sVal = "Test";
            }

            catch (Exception ex)
            {
                new Exception("Error in NewMethod", ex);
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

    }
}
