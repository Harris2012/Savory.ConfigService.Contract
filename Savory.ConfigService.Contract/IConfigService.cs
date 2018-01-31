using Savory.ConfigService.Contract.GetConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Savory.ConfigService.Contract
{
    /// <summary>
    /// Savory配置服务契约
    /// </summary>
    [ServiceContract]
    public interface IConfigService
    {
        /// <summary>
        /// 获取配置列表
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        GetAppConfigResponse GetAppConfig(GetAppConfigRequest request);
    }
}
