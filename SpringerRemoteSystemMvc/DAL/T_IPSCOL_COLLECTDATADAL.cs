﻿using Springer.DBUtility;
using Springer.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Springer.DAL
{
    /// <summary>
    /// 数据访问类:T_IPSCOL_COLLECTDATA
    /// </summary>
    public partial class T_IPSCOL_COLLECTDATADAL
    {
        public T_IPSCOL_COLLECTDATADAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("HID", "T_IPSCOL_COLLECTDATA");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int HID, long COLLECTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_IPSCOL_COLLECTDATA");
            strSql.Append(" where HID=@HID and COLLECTID=@COLLECTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@HID", SqlDbType.Int,4),
					new SqlParameter("@COLLECTID", SqlDbType.BigInt,8)			};
            parameters[0].Value = HID;
            parameters[1].Value = COLLECTID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(T_IPSCOL_COLLECTDATAModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_IPSCOL_COLLECTDATA(");
            strSql.Append("HID,SYSTYPEVALUE,ADDRESS,COLLECTTIME,COLLECTNAME)");
            strSql.Append(" values (");
            strSql.Append("@HID,@SYSTYPEVALUE,@ADDRESS,@COLLECTTIME,@COLLECTNAME)");
            strSql.Append(";select SCOPE_IDENTITY()");
            SqlParameter[] parameters = {
					new SqlParameter("@HID", SqlDbType.Int,4),
					new SqlParameter("@SYSTYPEVALUE", SqlDbType.VarChar,10),
					new SqlParameter("@ADDRESS", SqlDbType.VarChar,20),
					new SqlParameter("@COLLECTTIME", SqlDbType.DateTime),
					new SqlParameter("@COLLECTNAME", SqlDbType.VarChar,20)};
            parameters[0].Value = model.HID;
            parameters[1].Value = model.SYSTYPEVALUE;
            parameters[2].Value = model.ADDRESS;
            parameters[3].Value = model.COLLECTTIME;
            parameters[4].Value = model.COLLECTNAME;


            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(T_IPSCOL_COLLECTDATAModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_IPSCOL_COLLECTDATA set ");
            strSql.Append("SYSTYPEVALUE=@SYSTYPEVALUE,");
            strSql.Append("ADDRESS=@ADDRESS,");
            strSql.Append("COLLECTTIME=@COLLECTTIME,");
            strSql.Append("COLLECTNAME=@COLLECTNAME,");
            strSql.Append("ISDEAL=@ISDEAL,");
            strSql.Append("NOTE=@NOTE");
            strSql.Append(" where COLLECTID=@COLLECTID");
            SqlParameter[] parameters = {
					new SqlParameter("@SYSTYPEVALUE", SqlDbType.VarChar,10),
					new SqlParameter("@ADDRESS", SqlDbType.VarChar,20),
					new SqlParameter("@COLLECTTIME", SqlDbType.DateTime),
					new SqlParameter("@COLLECTNAME", SqlDbType.VarChar,20),
					new SqlParameter("@ISDEAL", SqlDbType.SmallInt,2),
					new SqlParameter("@NOTE", SqlDbType.Text),
					new SqlParameter("@COLLECTID", SqlDbType.BigInt,8),
					new SqlParameter("@HID", SqlDbType.Int,4)};
            parameters[0].Value = model.SYSTYPEVALUE;
            parameters[1].Value = model.ADDRESS;
            parameters[2].Value = model.COLLECTTIME;
            parameters[3].Value = model.COLLECTNAME;
            parameters[4].Value = model.ISDEAL;
            parameters[5].Value = model.NOTE;
            parameters[6].Value = model.COLLECTID;
            parameters[7].Value = model.HID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long COLLECTID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_IPSCOL_COLLECTDATA ");
            strSql.Append(" where COLLECTID=@COLLECTID");
            SqlParameter[] parameters = {
					new SqlParameter("@COLLECTID", SqlDbType.BigInt)
			};
            parameters[0].Value = COLLECTID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int HID, long COLLECTID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_IPSCOL_COLLECTDATA ");
            strSql.Append(" where HID=@HID and COLLECTID=@COLLECTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@HID", SqlDbType.Int,4),
					new SqlParameter("@COLLECTID", SqlDbType.BigInt,8)			};
            parameters[0].Value = HID;
            parameters[1].Value = COLLECTID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string COLLECTIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_IPSCOL_COLLECTDATA ");
            strSql.Append(" where COLLECTID in (" + COLLECTIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T_IPSCOL_COLLECTDATAModel GetModel(long COLLECTID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COLLECTID,HID,SYSTYPEVALUE,ADDRESS,COLLECTTIME,COLLECTNAME,ISDEAL,NOTE from T_IPSCOL_COLLECTDATA ");
            strSql.Append(" where COLLECTID=@COLLECTID");
            SqlParameter[] parameters = {
					new SqlParameter("@COLLECTID", SqlDbType.BigInt)
			};
            parameters[0].Value = COLLECTID;

            T_IPSCOL_COLLECTDATAModel model = new T_IPSCOL_COLLECTDATAModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T_IPSCOL_COLLECTDATAModel DataRowToModel(DataRow row)
        {
            T_IPSCOL_COLLECTDATAModel model = new T_IPSCOL_COLLECTDATAModel();
            if (row != null)
            {
                if (row["COLLECTID"] != null && row["COLLECTID"].ToString() != "")
                {
                    model.COLLECTID = long.Parse(row["COLLECTID"].ToString());
                }
                if (row["HID"] != null && row["HID"].ToString() != "")
                {
                    model.HID = int.Parse(row["HID"].ToString());
                }
                if (row["SYSTYPEVALUE"] != null)
                {
                    model.SYSTYPEVALUE = row["SYSTYPEVALUE"].ToString();
                }
                if (row["ADDRESS"] != null)
                {
                    model.ADDRESS = row["ADDRESS"].ToString();
                }
                if (row["COLLECTTIME"] != null && row["COLLECTTIME"].ToString() != "")
                {
                    model.COLLECTTIME = DateTime.Parse(row["COLLECTTIME"].ToString());
                }
                if (row["COLLECTNAME"] != null)
                {
                    model.COLLECTNAME = row["COLLECTNAME"].ToString();
                }
                if (row["ISDEAL"] != null && row["ISDEAL"].ToString() != "")
                {
                    model.ISDEAL = int.Parse(row["ISDEAL"].ToString());
                }
                if (row["NOTE"] != null)
                {
                    model.NOTE = row["NOTE"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COLLECTID,HID,SYSTYPEVALUE,ADDRESS,COLLECTTIME,COLLECTNAME,ISDEAL,NOTE ");
            strSql.Append(" FROM T_IPSCOL_COLLECTDATA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" COLLECTID,HID,SYSTYPEVALUE,ADDRESS,COLLECTTIME,COLLECTNAME,ISDEAL,NOTE ");
            strSql.Append(" FROM T_IPSCOL_COLLECTDATA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_IPSCOL_COLLECTDATA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.COLLECTID desc");
            }
            strSql.Append(")AS Row, T.*  from T_IPSCOL_COLLECTDATA T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "T_IPSCOL_COLLECTDATA";
            parameters[1].Value = "COLLECTID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
