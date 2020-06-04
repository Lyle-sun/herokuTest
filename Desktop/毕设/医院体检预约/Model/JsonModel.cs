using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conris.DBA.Model
{
    public class JsonModel
    {
        public JsonModel()
        {
            nocheck = false;
        }
        /// <summary>
        /// 用于设置节点id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用于设置节点guid
        /// </summary>
        public string guid { get; set; }

        /// <summary>
        /// 用于设置父节点ID
        /// </summary>
        public string pId { get; set; }

        /// <summary>
        /// 用于设置节点名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 设置节点的 展开 / 折叠 状态
        /// </summary>
        public bool open { get; set; }

        /// <summary>
        /// 记录节点是否为父节点
        /// </summary>
        public bool isParent { get; set; }

        /// <summary>
        /// 节点自定义图标的 URL 路径
        /// </summary>
        public bool nocheck { get; set; }

        public bool @checked { get; set; }
    }
}
