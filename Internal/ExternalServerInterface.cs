using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal
{
    public class ExternalServerInterface : MarshalByRefObject
    {
        public static InternalServerInterface _inServer;
        public static event Action<InternalServerInterface> ConnectedToInternalServer;

        public void IsInstalled(int clientPID)
        {
            Console.WriteLine("SCP-Stealth has injected the dll {0}.\r\n", clientPID);
        }

        public void ReportMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ReportException(Exception e)
        {
            Console.WriteLine("The target process has reported an error: \r\n" + e.ToString());
        }

        public void StartIpcClient(string channelName)
        {
            _inServer = EasyHook.RemoteHooking.IpcConnectClient<InternalServerInterface>(channelName);
            _inServer.Ping();
            ConnectedToInternalServer?.Invoke(_inServer);
        }

        public void Ping() { }
    }
}
