﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSystemSearchWhereModel
{
    /// <summary>
    /// 数据中心_瞭望塔人员表
    /// </summary>
     public class DC_WATCHTOWERUSER_SW
    {
        /// <summary>
        /// 序号
        /// </summary>
        public string DC_WATCHTOWERUSERID { get; set; }
        /// <summary>
        /// 所属瞭望塔
        /// </summary>
        public string WATCHTOWERID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string FTNAME { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string BIRTH { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string SEX { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string NATION { get; set; }
        /// <summary>
        /// 用户职位
        /// </summary>
        public string USERJOB { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string LINKWAY { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string PHOTO { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public string ORDERBY { get; set; }
    }
}