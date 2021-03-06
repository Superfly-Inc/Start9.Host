//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Host.Adapters
{
    
    public class IHostContractToViewHostAdapter : Start9.Host.Views.IHost
    {
        private Start9.Api.Contracts.IHostContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IHostContractToViewHostAdapter()
        {
        }
        public IHostContractToViewHostAdapter(Start9.Api.Contracts.IHostContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public void SendMessage(Start9.Host.Views.IMessage message)
        {
            _contract.SendMessage(Start9.Host.Adapters.IMessageHostAdapter.ViewToContractAdapter(message));
        }
        public void SaveConfiguration(Start9.Host.Views.IModule module)
        {
            _contract.SaveConfiguration(Start9.Host.Adapters.IModuleHostAdapter.ViewToContractAdapter(module));
        }
        public System.Collections.Generic.IList<Start9.Host.Views.IModule> GetModules()
        {
            return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IModuleContract, Start9.Host.Views.IModule>(_contract.GetModules(), Start9.Host.Adapters.IModuleHostAdapter.ContractToViewAdapter, Start9.Host.Adapters.IModuleHostAdapter.ViewToContractAdapter);
        }
        public Start9.Host.Views.IConfiguration GetGlobalConfiguration()
        {
            return Start9.Host.Adapters.IConfigurationHostAdapter.ContractToViewAdapter(_contract.GetGlobalConfiguration());
        }
        internal Start9.Api.Contracts.IHostContract GetSourceContract()
        {
            return _contract;
        }
    }
}

