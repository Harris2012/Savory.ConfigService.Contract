using Savory.ConfigService.Contract.GetConfig.Resonse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.ConfigService.Contract.GetConfig
{
    [DataContract]
    public class GetAppConfigResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [DataMember]
        public int Status { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        [DataMember]
        public SavoryConfig SavoryConfig { get; set; }
    }
}
