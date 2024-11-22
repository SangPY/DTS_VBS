using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NamedPipeWrapper;
using dts_shared.Model;
using dts_logger.Logger;
using Newtonsoft.Json;
using dts_shared.DataModel;

namespace dts_agent.NamedPipe
{
    public class NamedPipeClientModel
    {
        protected const string TECHNICIAN = "TECHNICIAN";
        protected const string SUPER_ADMIN = "SUPER ADMIN";

        private NamedPipeClient<NamedPipeMessageModel> client;
        private bool isServerRunning = false;
        private bool isUserDataReady = false;
        private AccountDataModel userData;

        public static NamedPipeClientModel Instance { get; } = new NamedPipeClientModel();

        public void StartNamedPipeClient(string pipeName)
        {
            client = new NamedPipeClient<NamedPipeMessageModel>(pipeName);
            //client.ServerMessage += OnServerMessage;
            //client.Error += OnError;
            //client.Disconnected += OnDisconnected;
            client.Start();
        }

        private void OnError(Exception exception)
        {
            System.Environment.Exit(0);
        }

        public void SendToServer(Guid messageID, string message, object data)
        {
            string messageData = string.Empty;

            if (data != null)
            {
                messageData = JsonConvert.SerializeObject(data);
            }
            if (client != null)
            {
                client.PushMessage(new NamedPipeMessageModel { MessageID = messageID, Message = message, Data = messageData });
            }
            else
            {
                CodedLogger.LogClearText("[Agent] SendToServer : client = null - exit app");
                //System.Environment.Exit(0);
            }
        }
    }
}