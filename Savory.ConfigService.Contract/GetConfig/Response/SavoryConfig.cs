using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.ConfigService.Contract.GetConfig.Resonse
{
    /// <summary>
    /// 配置组
    /// </summary>
    [DataContract]
    public class SavoryConfig
    {
        /// <summary>
        /// 应用程序Id
        /// </summary>
        [DataMember]
        public int AppId { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// 发布的key
        /// </summary>
        [DataMember]
        public string ReleaseKey { get; set; }

        /// <summary>
        /// 配置值
        /// </summary>
        [DataMember]
        public Dictionary<string, string> Properties { get; set; }
    }
}
