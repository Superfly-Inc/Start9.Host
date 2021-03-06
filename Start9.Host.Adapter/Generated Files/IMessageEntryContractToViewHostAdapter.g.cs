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
    
    public class IMessageEntryContractToViewHostAdapter : Start9.Host.Views.IMessageEntry
    {
        private Start9.Api.Contracts.IMessageEntryContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        private Start9.Host.Adapters.IMessageEventHandlerViewToContractHostAdapter MessageSent_Handler;
        private static System.Reflection.MethodInfo s_MessageSentEventAddFire;
		public event System.EventHandler<Start9.Host.Views.MessageReceivedEventArgs>MessageSent{
			add{
				if (_MessageSent == null)
				{
					_contract.MessageSentEventAdd(MessageSent_Handler);
				}
				_MessageSent += value;
				}
			remove{
					_MessageSent -= value;
				if (_MessageSent == null)
				{
					_contract.MessageSentEventRemove(MessageSent_Handler);
				}
				}
		}
        static IMessageEntryContractToViewHostAdapter()
        {
            s_MessageSentEventAddFire = typeof(IMessageEntryContractToViewHostAdapter).GetMethod("Fire_MessageSent", ((System.Reflection.BindingFlags)(36)));
        }
        public IMessageEntryContractToViewHostAdapter(Start9.Api.Contracts.IMessageEntryContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
            MessageSent_Handler = new Start9.Host.Adapters.IMessageEventHandlerViewToContractHostAdapter(this, s_MessageSentEventAddFire);
        }
        public System.Type MessageObjectType
        {
            get
            {
                return _contract.MessageObjectType;
            }
        }
        public string FriendlyName
        {
            get
            {
                return _contract.FriendlyName;
            }
        }
        private event System.EventHandler<Start9.Host.Views.MessageReceivedEventArgs> _MessageSent;
        internal virtual void Fire_MessageSent(Start9.Host.Views.MessageReceivedEventArgs args)
        {
            if ((_MessageSent == null))
            {
            }
            else
            {
                _MessageSent.Invoke(this, args);
            }
        }
        internal Start9.Api.Contracts.IMessageEntryContract GetSourceContract()
        {
            return _contract;
        }
    }
}

