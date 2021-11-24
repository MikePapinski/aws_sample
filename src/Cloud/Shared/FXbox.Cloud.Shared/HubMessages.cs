namespace FXbox.Cloud.Shared
{

    /// <summary>
    /// Stores shared names used in both client and hub
    /// </summary>
    public static class HubMessages
    {
        /// <summary>
        /// Name of the Hub method to send a message
        /// </summary>
        public const string SEND = "SendMessage";
        
        /// <summary>
        /// Event name when a message is received
        /// </summary>
        public const string RECEIVE = "ReceiveMessage";

        /// <summary>
        /// Name of the Hub method to register a new user
        /// </summary>
        public const string REGISTER_USER = "RegisterUser";
        
        /// <summary>
        /// Name of the Hub method to register a new node
        /// </summary>
        public const string REGISTER_NODE = "RegisterNode";
        
        /// <summary>
        /// Name of the Hub method to register a new node
        /// </summary>
        public const string CONNECT_BROKER_TO_NODE = "ConnectBroker";
        
        /// <summary>
        /// Name of the Hub method to register a new node
        /// </summary>
        public const string DISCONNECT_BROKER_FROM_NODE = "DisconnectBroker";
        
        /// <summary>
        /// Name of the Hub method to register a new node
        /// </summary>
        public const string SUBSCRIBE_BROKER_SYMBOL_ON_NODE = "SubscribeBrokerSymbol";
        
        /// <summary>
        /// Name of the Hub method to register a new node
        /// </summary>
        public const string UNSUBSCRIBE_BROKER_SYMBOL_ON_NODE = "UnsubscribeBrokerSymbol";

        

    }
}