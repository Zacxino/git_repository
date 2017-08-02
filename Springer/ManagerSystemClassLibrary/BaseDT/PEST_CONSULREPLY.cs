﻿using DataBaseClassLibrary;
using ManagerSystemModel;
using ManagerSystemSearchWhereModel;
using PublicClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSystemClassLibrary.BaseDT
{
    /// <summary>
    /// 有害生物_专家会诊回复表
    /// </summary>
    public class PEST_CONSULREPLY
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Add(PEST_CONSULREPLY_Model m)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO  PEST_CONSULREPLY( PEST_CONSULTATIONID, REPLYUID, REPLYTIME, REPLYCONTENT)");
            sb.AppendFormat(" OUTPUT INSERTED.PEST_CONSULREPLYID");
            sb.AppendFormat(" VALUES(");
            sb.AppendFormat(" {0}", ClsSql.saveNullField(m.PEST_CONSULTATIONID));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.REPLYUID));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.REPLYTIME));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.REPLYCONTENT));
            sb.AppendFormat(")");
            try
            {
                string sId = DataBaseClass.ReturnSqlField(sb.ToString());
                if (sId != "")
                    return new Message(true, "添加成功!", sId);
                else
                    return new Message(false, "添加失败!", "");
            }
            catch
            {
                return new Message(false, "添加失败!", "");
            }
        }

        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Mdy(PEST_CONSULREPLY_Model m)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE PEST_CONSULREPLY SET ");
            sb.AppendFormat(" PEST_CONSULTATIONID={0}", ClsSql.saveNullField(m.PEST_CONSULTATIONID));
            sb.AppendFormat(",REPLYUID={0}", ClsSql.saveNullField(m.REPLYUID));
            sb.AppendFormat(",REPLYTIME={0}", ClsSql.saveNullField(m.REPLYTIME));
            sb.AppendFormat(",REPLYCONTENT={0}", ClsSql.saveNullField(m.REPLYCONTENT));
            sb.AppendFormat(" WHERE PEST_CONSULREPLYID= '{0}'", ClsSql.EncodeSql(m.PEST_CONSULREPLYID));
            bool bln = DataBaseClass.ExeSql(sb.ToString());
            if (bln == true)
                return new Message(true, "修改成功!", m.PEST_CONSULREPLYID);
            else
                return new Message(false, "修改失败!", "");
        }

        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Del(PEST_CONSULREPLY_Model m)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("delete PEST_CONSULREPLY");
            sb.AppendFormat(" where PEST_CONSULREPLYID= '{0}'", ClsSql.EncodeSql(m.PEST_CONSULREPLYID));
            bool bln = DataBaseClass.ExeSql(sb.ToString());
            if (bln == true)
                return new Message(true, "删除成功!", "");
            else
                return new Message(false, "删除失败!", "");
        }

        #endregion

        #region 判断记录是否存在
        /// <summary>
        /// 判断记录是否存在
        /// </summary>
        /// <param name="sw">参见模型</param>
        /// <returns>true存在 false不存在</returns>
        public static bool isExists(PEST_CONSULREPLY_SW sw)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select 1 from PEST_CONSULREPLY where 1=1");
            if (string.IsNullOrEmpty(sw.PEST_CONSULREPLYID) == false)
                sb.AppendFormat(" where PEST_CONSULREPLYID= '{0}'", ClsSql.EncodeSql(sw.PEST_CONSULREPLYID));
            return DataBaseClass.JudgeRecordExists(sb.ToString());
        }

        #endregion

        #region 获取记录
        /// <summary>
        /// 获取记录
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        public static DataTable getDT(PEST_CONSULREPLY_SW sw)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" FROM  PEST_CONSULREPLY WHERE  1=1");
            if (string.IsNullOrEmpty(sw.PEST_CONSULREPLYID) == false)
                sb.AppendFormat(" AND PEST_CONSULTATIONID = '{0}'", ClsSql.EncodeSql(sw.PEST_CONSULTATIONID));
            if (string.IsNullOrEmpty(sw.PEST_CONSULTATIONID) == false)
                sb.AppendFormat(" AND PEST_CONSULTATIONID = '{0}'", ClsSql.EncodeSql(sw.PEST_CONSULTATIONID));
            if (string.IsNullOrEmpty(sw.REPLYUID) == false)
                sb.AppendFormat(" AND REPLYUID = '{0}'", ClsSql.EncodeSql(sw.REPLYUID));
            if (string.IsNullOrEmpty(sw.REPLYTIME) == false)
            {
                sb.AppendFormat(" AND REPLYTIME = '{0}'", ClsSql.EncodeSql(DateTime.Parse(sw.REPLYTIME).ToString()));
                sb.AppendFormat(" AND REPLYTIME = '{0}'", ClsSql.EncodeSql(DateTime.Parse(sw.REPLYTIME).AddDays(1).AddSeconds(-1).ToString()));
            }
            string sql = "SELECT PEST_CONSULREPLYID, PEST_CONSULTATIONID, REPLYUID, REPLYTIME, REPLYCONTENT" + sb.ToString() + " ORDER BY REPLYTIME ";
            DataSet ds = DataBaseClass.FullDataSet(sql);
            return ds.Tables[0];
        }

        #endregion

        #region 获取分页列表
        /// <summary>
        /// 获取分页列表
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static DataTable getDT(PEST_CONSULREPLY_SW sw, out int total)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" FROM  PEST_CONSULREPLY WHERE  1=1");
            if (string.IsNullOrEmpty(sw.PEST_CONSULREPLYID) == false)
                sb.AppendFormat(" AND PEST_CONSULTATIONID = '{0}'", ClsSql.EncodeSql(sw.PEST_CONSULTATIONID));
            if (string.IsNullOrEmpty(sw.PEST_CONSULTATIONID) == false)
                sb.AppendFormat(" AND PEST_CONSULTATIONID = '{0}'", ClsSql.EncodeSql(sw.PEST_CONSULTATIONID));
            if (string.IsNullOrEmpty(sw.REPLYUID) == false)
                sb.AppendFormat(" AND REPLYUID = '{0}'", ClsSql.EncodeSql(sw.REPLYUID));
            if (string.IsNullOrEmpty(sw.REPLYTIME) == false)
            {
                sb.AppendFormat(" AND REPLYTIME = '{0}'", ClsSql.EncodeSql(DateTime.Parse(sw.REPLYTIME).ToString()));
                sb.AppendFormat(" AND REPLYTIME = '{0}'", ClsSql.EncodeSql(DateTime.Parse(sw.REPLYTIME).AddDays(1).AddSeconds(-1).ToString()));
            }
            string sql = "SELECT PEST_CONSULREPLYID, PEST_CONSULTATIONID, REPLYUID, REPLYTIME, REPLYCONTENT" + sb.ToString() + " ORDER BY REPLYTIME ";
            string sqlC = "select count(1) " + sb.ToString();
            total = int.Parse(DataBaseClass.ReturnSqlField(sqlC));
            sw.CurPage = PagerCls.getCurPage(new PagerSW { curPage = sw.CurPage, pageSize = sw.PageSize, rowCount = total });
            DataSet ds = DataBaseClass.FullDataSet(sql, (sw.CurPage - 1) * sw.PageSize, sw.PageSize, "a");
            return ds.Tables[0];
        }
        #endregion
    }
}
