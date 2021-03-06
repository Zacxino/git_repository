﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSystemSearchWhereModel
{
    /// <summary>
    /// 野生动物_属性表
    /// </summary>
   public class WILD_ANIMALPROP_SW
    {
        /// <summary>
        /// 序号
        /// </summary>
       public string WILD_ANIMALPROPID { get; set; }
        /// <summary>
        /// 生物物种编码
        /// </summary>
       public string BIOLOGICALTYPECODE { get; set; }
        /// <summary>
       /// 保护级别编码
        /// </summary>
       public string PROTECTIONLEVELCODE { get; set; }
        /// <summary>
       /// 生存现状编码
        /// </summary>
       public string LIVINGSTATUSCODE { get; set; }
    }
}
