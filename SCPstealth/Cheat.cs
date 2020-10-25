using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPstealth
{
    class Cheat
    {
        public event Action Injected;

        public bool IsInjected { get; private set; }
        public bool RecoilHooked { get; private set; }

        Internal.InternalServerInterface _inServer = null;
        private String channelName = null;

        public void Inject(int id)
        {
            Internal.ExternalServerInterface.ConnectedToInternalServer += (Internal.InternalServerInterface inServerInterface) => { _inServer = inServerInterface; _inServer.Test(); };


            string injectionLibrary = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Internal.dll"); 
            Console.WriteLine(injectionLibrary);
            EasyHook.RemoteHooking.IpcCreateServer<Internal.ExternalServerInterface>(ref channelName, System.Runtime.Remoting.WellKnownObjectMode.Singleton);

            try
            {
                EasyHook.RemoteHooking.Inject(id, injectionLibrary, injectionLibrary, channelName);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There was an error while injecting into target:");
                Console.ResetColor();
                Console.WriteLine(e.ToString());
            }

            Injected?.Invoke();
            IsInjected = true;

        }

        public void UnhookEverything()
        {

        }

        public void HookRecoil(int multiplier)
        {
            if (!IsInjected || RecoilHooked || _inServer == null) return;

            _inServer.HookRecoil(true, multiplier);
        }

        public void UnhookRecoil()
        {
            if (!IsInjected || !RecoilHooked || _inServer == null) return;
            _inServer.HookRecoil(false, 0);
        }

    }

    class Offests
    {
        public static uint recoilFunc = 0xbadf00d;
    }
}
