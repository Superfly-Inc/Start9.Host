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
    
    public class IReceiverContractViewToContractHostAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IReceiverContractContract
    {
        private Start9.Host.Views.IReceiverContract _view;
        public IReceiverContractViewToContractHostAdapter(Start9.Host.Views.IReceiverContract view)
        {
            _view = view;
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IReceiverEntryContract> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Start9.Host.Views.IReceiverEntry, Start9.Api.Contracts.IReceiverEntryContract>(_view.Entries, Start9.Host.Adapters.IReceiverEntryHostAdapter.ViewToContractAdapter, Start9.Host.Adapters.IReceiverEntryHostAdapter.ContractToViewAdapter);
            }
        }
        internal Start9.Host.Views.IReceiverContract GetSourceView()
        {
            return _view;
        }
    }
}

