using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.ConfigService.Contract.GetConfig
{
    [DataContract]
    public class GetAppConfigRequest
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
    }
}
