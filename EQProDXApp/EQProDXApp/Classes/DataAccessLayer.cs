using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace EQProDXApp
{
    public class Class_PublicDataAccessLayer
    {
        string sConnStr = "";
        //Amin 03/05/2022 Returns Sql Conn Obj
        public SqlConnection getSqlConn()
        {
            SqlConnection SqlConn = new SqlConnection();
            //EQPro_AcessDB_WthData
            sConnStr = "Data Source = AMINSPC\\SQLEXPRESS;Initial Catalog = KCI_EQPro; Integrated Security = true";
            //Data Source = AMINSPC\\SQLEXPRESS; Initial Catalog = KCIEqPro_Umair; Integrated Security = True
            try
            {
                //SqlConnection objSqlConn = new SqlConnection(sConnStr);
                SqlConn = new SqlConnection(sConnStr);
                SqlConn.Open();
                return SqlConn;
                //if (SqlConn != null && SqlConn.State == ConnectionState.Closed)
                //{
                //    return null;
                //}
                //else
                //{                    
                //    SqlConn.Open();
                //    return SqlConn;
                //}

                //return SqlConn;
            }
            catch (Exception ex)
            {
                new Exception("Error in getSqlConn, opening Sql Conn", ex);
                return SqlConn;
            }
        }

        //Amin 03/05/2022 Returns Set Table, sql qry is passed
        public DataSet getDataSet(string sSql, SqlConnection objSqlConn)
        {
            DataSet sqlDtSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            try
            {
                sqlDA = new SqlDataAdapter(sSql, objSqlConn);
                sqlDA.Fill(sqlDtSet);
                return sqlDtSet;
            }
            catch (Exception ex)
            {
                new Exception("Error in getDataSet, filling a data set using conn obj & query", ex);
                return sqlDtSet;
            }
        }

        //Amin 03/05/2022 Returns Table, sql qry is passed
        public DataTable getDataTable(string sSql, SqlConnection objSqlConn)
        {
            DataTable sqlDataTbl = new DataTable();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            try
            {
                sqlDA = new SqlDataAdapter(sSql, objSqlConn);
                sqlDA.Fill(sqlDataTbl);
                return sqlDataTbl;
            }
            catch (Exception ex)
            {
                new Exception("Error in getDataTable, filling a data table using conn obj & query", ex);
                return sqlDataTbl;
            }
        }


    }
}
