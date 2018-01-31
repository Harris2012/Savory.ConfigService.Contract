using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savory.ConfigService.Contract.GetConfig;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Savory.ConfigService.Contract
{
    [DebuggerStepThrough]
    public class ConfigServiceClient : ClientBase<IConfigService>, IConfigService
    {
        public ConfigServiceClient() :
            base(new ServiceEndpoint(ContractDescription.GetContract(typeof(IConfigService)), new BasicHttpBinding(), new EndpointAddress("http://localhost:8899/")))
        {
        }

        #region IConfigService Members
        public GetAppConfigResponse GetAppConfig(GetAppConfigRequest request)
        {
            return base.Channel.GetAppConfig(request);
        }
        #endregion
    }
}
