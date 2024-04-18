﻿using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Data;


namespace Quan_Ly_Kho_Sys
{
    public class CSys_Thanh_Vien_Controller
    {
        public List<CSys_Thanh_Vien> FQ_531_TV_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_Thanh_Vien> FQ_531_TV_sp_sel_List_For_Cache()
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CSys_Thanh_Vien FQ_531_TV_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Thanh_Vien v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_dt.Rows[0]);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public CSys_Thanh_Vien FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap(string  p_strMa_Dang_Nhap)
        {
            CSys_Thanh_Vien v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap", p_strMa_Dang_Nhap);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_dt.Rows[0]);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }


        public long FQ_531_TV_sp_ins_Insert(CSys_Thanh_Vien p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_ins_Insert",
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.SDT,
                    p_objData.Gioi_Tinh, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_531_TV_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Thanh_Vien p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_ins_Insert",
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.SDT,
                    p_objData.Gioi_Tinh, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_531_TV_sp_upd_Update(CSys_Thanh_Vien p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.SDT,
                    p_objData.Gioi_Tinh, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_531_TV_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Thanh_Vien p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.SDT,
                    p_objData.Gioi_Tinh, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_531_TV_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Sys_Conn_String, "FQ_531_TV_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
