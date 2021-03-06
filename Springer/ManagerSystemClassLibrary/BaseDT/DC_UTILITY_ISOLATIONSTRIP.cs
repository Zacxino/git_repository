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
    /// 数据中心_设施_隔离带
    /// </summary>
    public class DC_UTILITY_ISOLATIONSTRIP
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Add(DC_UTILITY_ISOLATIONSTRIP_Model m)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat("INSERT INTO  DC_UTILITY_ISOLATIONSTRIP(ISOLATIONTYPE, NUMBER, NAME, BYORGNO, BUILDDATE, USESTATE,MANAGERSTATE, WIDTH, LENGTH, JDBEGIN, WDBEGIN, JDEND, WDEND,JWDLIST)");
            sb.AppendFormat("INSERT INTO  DC_UTILITY_ISOLATIONSTRIP( ISOLATIONTYPE, NUMBER, NAME, BYORGNO, BUILDDATE, USESTATE,MANAGERSTATE, WIDTH, LENGTH, JDBEGIN, WDBEGIN, JDEND, WDEND,JWDLIST,PLANAREA,REALAREA,WORTH,KINDTYPE,POSITION,PRICE,ALLEYWAYWIDETH,TREETYPE,ENTRYTIME,BUILDDATEBEGIN,BUILDDATEEND) output inserted.DC_UTILITY_ISOLATIONSTRIP_ID");
            sb.AppendFormat(" VALUES(");
            sb.AppendFormat("{0}", ClsSql.saveNullField(m.ISOLATIONTYPE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.NUMBER));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.NAME));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.BYORGNO));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.BUILDDATE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.USESTATE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.MANAGERSTATE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.WIDTH));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.LENGTH));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.JDBEGIN));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.WDBEGIN));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.JDEND));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.WDEND));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.JWDLIST));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.PLANAREA));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.REALAREA));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.WORTH));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.KINDTYPE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.Position));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.Price));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.AlleywayWideth));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.TREETYPE));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.ENTRYTIME));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.BUILDDATEBEGIN));
            sb.AppendFormat(",{0}", ClsSql.saveNullField(m.BUILDDATEEND));
            sb.AppendFormat(")");
            try
            {
                string strid = DataBaseClass.ReturnSqlField(sb.ToString());
                if (string.IsNullOrEmpty(strid) == false)
                {
                    return new Message(true, "添加成功！", strid);
                }
                else
                {
                    return new Message(false, "添加失败！请检查输入框是否正确！", strid);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Mdy(DC_UTILITY_ISOLATIONSTRIP_Model m)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE DC_UTILITY_ISOLATIONSTRIP");
            sb.AppendFormat(" set ");
            sb.AppendFormat("ISOLATIONTYPE={0}", ClsSql.saveNullField(m.ISOLATIONTYPE));
            sb.AppendFormat(",NUMBER={0}", ClsSql.saveNullField(m.NUMBER));
            sb.AppendFormat(",NAME={0}", ClsSql.saveNullField(m.NAME));
            sb.AppendFormat(",BYORGNO={0}", ClsSql.saveNullField(m.BYORGNO));
            sb.AppendFormat(",BUILDDATE={0}", ClsSql.saveNullField(m.BUILDDATE));
            sb.AppendFormat(",USESTATE={0}", ClsSql.saveNullField(m.USESTATE));
            sb.AppendFormat(",MANAGERSTATE={0}", ClsSql.saveNullField(m.MANAGERSTATE));
            sb.AppendFormat(",WIDTH={0}", ClsSql.saveNullField(m.WIDTH));
            sb.AppendFormat(",LENGTH={0}", ClsSql.saveNullField(m.LENGTH));
            sb.AppendFormat(",JDBEGIN={0}", ClsSql.saveNullField(m.JDBEGIN));
            sb.AppendFormat(",WDBEGIN={0}", ClsSql.saveNullField(m.WDBEGIN));
            sb.AppendFormat(",JDEND={0}", ClsSql.saveNullField(m.JDEND));
            sb.AppendFormat(",WDEND={0}", ClsSql.saveNullField(m.WDEND));
            sb.AppendFormat(",JWDLIST={0}", ClsSql.saveNullField(m.JWDLIST));
            sb.AppendFormat(",PLANAREA={0}", ClsSql.saveNullField(m.PLANAREA));
            sb.AppendFormat(",REALAREA={0}", ClsSql.saveNullField(m.REALAREA));
            sb.AppendFormat(",WORTH={0}", ClsSql.saveNullField(m.WORTH));
            sb.AppendFormat(",KINDTYPE={0}", ClsSql.saveNullField(m.KINDTYPE));
            sb.AppendFormat(",POSITION={0}", ClsSql.saveNullField(m.Position));
            sb.AppendFormat(",PRICE={0}", ClsSql.saveNullField(m.Price));
            sb.AppendFormat(",ALLEYWAYWIDETH={0}", ClsSql.saveNullField(m.AlleywayWideth));
            sb.AppendFormat(",TREETYPE={0}", ClsSql.saveNullField(m.TREETYPE));
            sb.AppendFormat(",ENTRYTIME={0}", ClsSql.saveNullField(m.ENTRYTIME));
            sb.AppendFormat(",BUILDDATEBEGIN={0}", ClsSql.saveNullField(m.BUILDDATEBEGIN));
            sb.AppendFormat(",BUILDDATEEND={0}", ClsSql.saveNullField(m.BUILDDATEEND));
            sb.AppendFormat(" where DC_UTILITY_ISOLATIONSTRIP_ID= '{0}'", ClsSql.EncodeSql(m.DC_UTILITY_ISOLATIONSTRIP_ID));
            bool bln = DataBaseClass.ExeSql(sb.ToString());
            if (bln == true)
                return new Message(true, "修改成功！", m.DC_UTILITY_ISOLATIONSTRIP_ID);
            else
                return new Message(false, "修改失败，请检查各输入框是否正确！", "");
        }

        #endregion

        #region 修改经纬度
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message MdyJWD(DC_UTILITY_ISOLATIONSTRIP_Model m)
        {
            StringBuilder sb = new StringBuilder();
            //HID, HNAME, SN, PHONE, SEX, BIRTH, ONSTATE, BYORGNO
            sb.AppendFormat("UPDATE DC_UTILITY_ISOLATIONSTRIP");
            sb.AppendFormat(" set ");
            sb.AppendFormat("JDBEGIN={0}", ClsSql.saveNullField(m.JDBEGIN));
            sb.AppendFormat(",WDBEGIN={0}", ClsSql.saveNullField(m.WDBEGIN));
            sb.AppendFormat(",JDEND={0}", ClsSql.saveNullField(m.JDEND));
            sb.AppendFormat(",WDEND={0}", ClsSql.saveNullField(m.WDEND));
            sb.AppendFormat(" where DC_UTILITY_ISOLATIONSTRIP_ID= '{0}'", ClsSql.EncodeSql(m.DC_UTILITY_ISOLATIONSTRIP_ID));
            bool bln = DataBaseClass.ExeSql(sb.ToString());
            if (bln == true)
                return new Message(true, "修改成功！", m.DC_UTILITY_ISOLATIONSTRIP_ID);
            else
                return new Message(false, "修改失败，请检查各输入框是否正确！", "");
        }

        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="m">参见模型</param>
        /// <returns>参见模型</returns>
        public static Message Del(DC_UTILITY_ISOLATIONSTRIP_Model m)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("delete DC_UTILITY_ISOLATIONSTRIP");
            sb.AppendFormat(" where DC_UTILITY_ISOLATIONSTRIP_ID= '{0}'", ClsSql.EncodeSql(m.DC_UTILITY_ISOLATIONSTRIP_ID));
            bool bln = DataBaseClass.ExeSql(sb.ToString());
            if (bln == true)
                return new Message(true, "删除成功！", "");
            else
                return new Message(false, "删除失败，请检查各输入框是否正确！", "");
        }

        #endregion

        #region 判断记录是否存在
        /// <summary>
        /// 判断记录是否存在
        /// </summary>
        /// <param name="sw">参见模型</param>
        /// <returns>true存在 false不存在</returns>
        public static bool isExists(DC_UTILITY_ISOLATIONSTRIP_SW sw)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select 1 from DC_UTILITY_ISOLATIONSTRIP where 1=1");
            if (string.IsNullOrEmpty(sw.DC_UTILITY_ISOLATIONSTRIP_ID) == false)
                sb.AppendFormat(" where DC_UTILITY_ISOLATIONSTRIP_ID= '{0}'", ClsSql.EncodeSql(sw.DC_UTILITY_ISOLATIONSTRIP_ID));
            return DataBaseClass.JudgeRecordExists(sb.ToString());
        }

        #endregion

        #region 获取记录
        /// <summary>
        /// 获取记录
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        public static DataTable getDT(DC_UTILITY_ISOLATIONSTRIP_SW sw)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(" FROM      DC_UTILITY_ISOLATIONSTRIP");
            sb.AppendFormat(" WHERE   1=1");
            if (string.IsNullOrEmpty(sw.DC_UTILITY_ISOLATIONSTRIP_ID) == false)
                sb.AppendFormat(" AND DC_UTILITY_ISOLATIONSTRIP_ID = '{0}'", ClsSql.EncodeSql(sw.DC_UTILITY_ISOLATIONSTRIP_ID));
            if (string.IsNullOrEmpty(sw.NUMBER) == false)
                sb.AppendFormat(" AND NUMBER like '%{0}%'", ClsSql.EncodeSql(sw.NUMBER));
            if (string.IsNullOrEmpty(sw.NAME) == false)
                sb.AppendFormat(" AND NAME like '%{0}%'", ClsSql.EncodeSql(sw.NAME));
            if (string.IsNullOrEmpty(sw.ISOLATIONTYPE) == false)
                sb.AppendFormat(" AND ISOLATIONTYPE = '{0}'", ClsSql.EncodeSql(sw.ISOLATIONTYPE));
            if (string.IsNullOrEmpty(sw.USESTATE) == false)
                sb.AppendFormat(" AND USESTATE = '{0}'", ClsSql.EncodeSql(sw.USESTATE));
            if (string.IsNullOrEmpty(sw.MANAGERSTATE) == false)
                sb.AppendFormat(" AND MANAGERSTATE = '{0}'", ClsSql.EncodeSql(sw.MANAGERSTATE));

            if (!string.IsNullOrEmpty(sw.BYORGNO))
            {
                if (sw.ORGNOSXZ != "1")
                {
                    if (sw.BYORGNO.Substring(4, 11) == "00000000000")//获取所有市的
                        sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,4) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 4)));
                    else if (sw.BYORGNO.Substring(6, 9) == "000000000")//获取所有县的
                        sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,6) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 6)));
                    else if (sw.BYORGNO.Substring(9, 6) == "000000")//获取说有乡镇的
                        sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,9) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 9)));
                    else if (sw.BYORGNO.Substring(12, 3) == "000")//获取说有村的
                        sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,12) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 12)));
                    else
                        sb.AppendFormat(" AND BYORGNO = '{0}'", ClsSql.EncodeSql(sw.BYORGNO));
                }
                else 
                {
                    sb.AppendFormat(" AND BYORGNO = '{0}'", ClsSql.EncodeSql(sw.BYORGNO));
                }
            }
            string sql = "SELECT DC_UTILITY_ISOLATIONSTRIP_ID, ISOLATIONTYPE, NUMBER, NAME, BYORGNO, BUILDDATE, USESTATE,MANAGERSTATE, WIDTH, LENGTH, JDBEGIN, WDBEGIN, JDEND, WDEND,JWDLIST,PLANAREA,REALAREA,WORTH,KINDTYPE,POSITION,PRICE,ALLEYWAYWIDETH,TREETYPE,ENTRYTIME,BUILDDATEBEGIN,BUILDDATEEND"
                + sb.ToString()
                + " order by DC_UTILITY_ISOLATIONSTRIP_ID desc";

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
        public static DataTable getDT(DC_UTILITY_ISOLATIONSTRIP_SW sw, out int total)
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat(" FROM      DC_UTILITY_ISOLATIONSTRIP");
            sb.AppendFormat(" WHERE   1=1");
            if (string.IsNullOrEmpty(sw.DC_UTILITY_ISOLATIONSTRIP_ID) == false)
                sb.AppendFormat(" AND DC_UTILITY_ISOLATIONSTRIP_ID = '{0}'", ClsSql.EncodeSql(sw.DC_UTILITY_ISOLATIONSTRIP_ID));
            if (string.IsNullOrEmpty(sw.NUMBER) == false)
                sb.AppendFormat(" AND NUMBER like '%{0}%'", ClsSql.EncodeSql(sw.NUMBER));
            if (string.IsNullOrEmpty(sw.NAME) == false)
                sb.AppendFormat(" AND NAME like '%{0}%'", ClsSql.EncodeSql(sw.NAME));
            if (string.IsNullOrEmpty(sw.ISOLATIONTYPE) == false)
                sb.AppendFormat(" AND ISOLATIONTYPE = '{0}'", ClsSql.EncodeSql(sw.ISOLATIONTYPE));
            if (string.IsNullOrEmpty(sw.USESTATE) == false)
                sb.AppendFormat(" AND USESTATE = '{0}'", ClsSql.EncodeSql(sw.USESTATE));
            if (string.IsNullOrEmpty(sw.MANAGERSTATE) == false)
                sb.AppendFormat(" AND MANAGERSTATE = '{0}'", ClsSql.EncodeSql(sw.MANAGERSTATE));

            if (!string.IsNullOrEmpty(sw.BYORGNO))
            {
                if (sw.BYORGNO.Substring(4, 11) == "00000000000")//获取所有市的
                    sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,4) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 4)));
                else if (sw.BYORGNO.Substring(4, 11) == "xxxxxxxxxxx")//单独市
                    sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,15) = '{0}')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 4) + "00000000000"));
                else if (sw.BYORGNO.Substring(6, 9) == "xxxxxxxxx")//获取所有县的
                    sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,6) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 6)));
                else if (sw.BYORGNO.Substring(9, 6) == "000000")//获取说有乡镇的
                    sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,9) = '{0}'or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 9)));
                else if (sw.BYORGNO.Substring(12, 3) == "000")//获取说有村的
                    sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,12) = '{0}'or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 12)));
                else
                    sb.AppendFormat(" AND BYORGNO = '{0}'", ClsSql.EncodeSql(sw.BYORGNO));
            }
            string sql = "SELECT DC_UTILITY_ISOLATIONSTRIP_ID, ISOLATIONTYPE, NUMBER, NAME, BYORGNO, BUILDDATE, USESTATE,MANAGERSTATE, WIDTH, LENGTH, JDBEGIN, WDBEGIN, JDEND, WDEND,JWDLIST,PLANAREA,REALAREA,WORTH,KINDTYPE,POSITION,PRICE,ALLEYWAYWIDETH,TREETYPE,ENTRYTIME,BUILDDATEBEGIN,BUILDDATEEND"
                + sb.ToString()
                + " order by BYORGNO,DC_UTILITY_ISOLATIONSTRIP_ID desc";
            string sqlC = "select count(1) " + sb.ToString();
            total = int.Parse(DataBaseClass.ReturnSqlField(sqlC));
            sw.curPage = PagerCls.getCurPage(new PagerSW { curPage = sw.curPage, pageSize = sw.pageSize, rowCount = total });
            DataSet ds = DataBaseClass.FullDataSet(sql, (sw.curPage - 1) * sw.pageSize, sw.pageSize, "a");
            return ds.Tables[0];
        }

        #endregion

        #region 根据DataTable和OrgNo和隔离带的各个类型判断记录个数
        /// <summary>
        /// 根据DataTable和OrgNo和隔离带的各个类型判断记录个数
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="orgNo">组织机构码</param>
        /// <param name="DICTVALUE">隔离带的各个类型值</param>
        /// <param name="TYPE">确定统计那个隔离带的类型</param>
        /// <returns>记录个数</returns>
        public static string getCountISOLATIONSTRIPByOrgNo(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE == "1")//统计使用现状类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计维护管理现状
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//隔离带类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";
        }
        #endregion

        #region 根据DataTable和OrgNo和隔离带的各个县市类型判断记录个数
        /// <summary>
        /// 根据DataTable和OrgNo和隔离带的各个县市类型判断记录个数
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="orgNo">组织机构码</param>
        /// <param name="DICTVALUE">隔离带的各个类型值</param>
        /// <param name="TYPE">确定统计那个隔离带的类型</param>
        /// <returns>记录个数</returns>
        public static string getCountXSByOrgNo(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE == "1")//统计使用现状类型
            {
                 if (PublicCls.OrgIsZhen(orgNo)==false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计维护管理现状
            {
                if (PublicCls.OrgIsZhen(orgNo)==false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//隔离带类型
            {
                if (PublicCls.OrgIsZhen(orgNo)==false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("count(DC_UTILITY_ISOLATIONSTRIP_ID)", "BYORGNO='" + orgNo + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";
        }
        #endregion

        #region 根据DataTable和OrgNo获取各个县市单独长度统计
        /// <summary>
        /// 统计长度
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="orgNo"></param>
        /// <param name="DICTVALUE"></param>
        /// <param name="TYPE"></param>
        /// <returns></returns>
        public static string getLENGTHXSCount(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE=="1")
            {
               if (PublicCls.OrgIsZhen(orgNo) == false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计维护管理现状
            {
                if (PublicCls.OrgIsZhen(orgNo)==false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//隔离带类型
            {
                if (PublicCls.OrgIsZhen(orgNo)==false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "BYORGNO='" + orgNo + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";
            }

        #endregion

        #region 根据DataTable和OrgNo各个县市单独面积统计
        /// <summary>
        /// 统计面积
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="orgNo"></param>
        /// <param name="DICTVALUE"></param>
        /// <param name="TYPE"></param>
        /// <returns></returns>
        public static string getAREAXSCount(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE == "1")//使用现状
            {
                if (PublicCls.OrgIsZhen(orgNo) == false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计维护管理现状
            {
                if (PublicCls.OrgIsZhen(orgNo) == false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//隔离带类型
            {
                if (PublicCls.OrgIsZhen(orgNo) == false)
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "BYORGNO='" + orgNo + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";
        }

        #endregion

        #region 根据DataTable和OrgNo获取面积统计
        /// <summary>
        /// 统计面积
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="orgNo"></param>
        /// <param name="DICTVALUE"></param>
        /// <param name="TYPE"></param>
        /// <returns></returns>
        public static string getAREACount(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE == "1")//统计资源类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计林龄类别
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//统计起源类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(AREA)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";

        }
        #endregion

        #region 根据DataTable和OrgNo获取长度统计
        /// <summary>
        /// 统计长度
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="orgNo"></param>
        /// <param name="DICTVALUE"></param>
        /// <param name="TYPE"></param>
        /// <returns></returns>
        public static string getLENGTHCount(DataTable dt, string orgNo, string DICTVALUE, string TYPE)
        {
            if (string.IsNullOrEmpty(orgNo))//返回所有记录个数
                return dt.Rows.Count.ToString();
            if (TYPE == "1")//统计资源类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and USESTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "2")//统计林龄类别
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and MANAGERSTATE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            if (TYPE == "3")//统计起源类型
            {
                if (PublicCls.OrgIsShi(orgNo))//市
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,4)='" + PublicCls.getShiIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsXian(orgNo))//县
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,6)='" + PublicCls.getXianIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else if (PublicCls.OrgIsZhen(orgNo))
                {
                    if (string.IsNullOrEmpty(DICTVALUE))
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "'").ToString();
                    else
                        return dt.Compute("Sum(LENGTH)", "substring(BYORGNO,1,9)='" + PublicCls.getZhenIncOrgNo(orgNo) + "' and ISOLATIONTYPE='" + DICTVALUE + "'").ToString();
                }
                else //机构编码可能不正确
                    return "";
            }
            else
                return "";

        }
        #endregion

        #region 统计当前用户下隔离带的数量
        /// <summary>
        /// 统计当前用户下防火通道的记录数量
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        public static string getNum(DC_UTILITY_ISOLATIONSTRIP_SW sw)
        {
            string total = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("    from   DC_UTILITY_ISOLATIONSTRIP a ");
            sb.AppendFormat("where 1 = 1 ");
            if (sw.BYORGNO.Substring(4, 11) == "00000000000")  //获取所有市的
                sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,4) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 4)));
            else if (sw.BYORGNO.Substring(6, 9) == "000000000" && sw.BYORGNO.Substring(4, 11) != "00000000000") //获取所有县的
                sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,6) = '{0}' or BYORGNO is null or BYORGNO='')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 6)));
            else
                sb.AppendFormat(" AND (SUBSTRING(BYORGNO,1,9) = '{0}')", ClsSql.EncodeSql(sw.BYORGNO.Substring(0, 9)));
            string sqlC = "select count(1) " + sb.ToString();
            total = (DataBaseClass.ReturnSqlField(sqlC)).ToString();
            return total;
        }
        #endregion
    }
}