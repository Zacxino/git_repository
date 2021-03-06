﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSystemSearchWhereModel
{
    /// <summary>
    /// 数据采集
    /// </summary>
    public class T_IPSCOL_COLLECT_SW
    {
        /// <summary>
        /// 采集ID
        /// </summary>
        public string COLLECTID { get; set; }
        /// <summary>
        /// 护林员ID
        /// </summary>
        public string HID { get; set; }
        /// <summary>
        /// 类型值
        /// </summary>
        public string SYSTYPEVALUE { get; set; }
        /// <summary>
        /// 采集时间
        /// </summary>
        public string COLLECTTIME { get; set; }
        /// <summary>
        /// 反馈结果 是否处理
        /// </summary>
        public string MANSTATE { get; set; }
        /// <summary>
        /// 数据采集明细ID
        /// </summary>

        public string COLLECTDETAILID { get; set; }
        /// <summary>
        /// 数据采集上报ID
        /// </summary>

        public string COLLECTUPLOADID { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        public string orgNo { get; set; }
        /// <summary>
        /// 顶级单位编码，用于获取该单位下所有的信息
        /// </summary>
        public string TopORGNO { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string DateBegin { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public string DateEnd { get; set; }
        /// <summary>
        /// 地图类型
        /// </summary>
        public string MapType { get; set; }


        /// <summary>
        /// 是否关联护林员表
        /// </summary>
        public bool UnionHUser { get; set; }

        /// <summary>
        /// 护林员姓名
        /// </summary>
        public string HUserName { get; set; }
    }
}
