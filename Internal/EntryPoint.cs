using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;



namespace Internal
{

    //function prototypes
    [UnmanagedFunctionPointer(CallingConvention.FastCall, SetLastError = true)]
    delegate void DoRecoilDelegate(RecoilProperties properties, int multiplier);


    class EntryPoint : EasyHook.IEntryPoint
    {
        string channelName;
        IntPtr funcAddr = new IntPtr(0);
        IntPtr baseAddr = IntPtr.Zero;
        Dictionary<String, EasyHook.LocalHook> hooks;

        static DoRecoilDelegate oDoRecoil;


        ExternalServerInterface _exServer = null;

        public EntryPoint(EasyHook.RemoteHooking.IContext ctx, string externalServerChannelName)
        {
            baseAddr = Process.GetCurrentProcess().MainModule.BaseAddress;

            //Start Internal Server 
            EasyHook.RemoteHooking.IpcCreateServer<InternalServerInterface>(ref channelName, System.Runtime.Remoting.WellKnownObjectMode.Singleton); 


            //Connect to External Server
            _exServer = EasyHook.RemoteHooking.IpcConnectClient<ExternalServerInterface>(externalServerChannelName);
            _exServer.Ping();        
        }

        public void Run(EasyHook.RemoteHooking.IContext ctx)
        {
            
            _exServer.IsInstalled(EasyHook.RemoteHooking.GetCurrentProcessId());
            _exServer.StartIpcClient(channelName);

            ////Hook functions
            //oDoRecoil = Marshal.GetDelegateForFunctionPointer<DoRecoilDelegate>(funcAddr); //create delegate to original function (function pointer in c#)
           

            var createRecoilHook = EasyHook.LocalHook.Create(funcAddr, new DoRecoilDelegate(hDoRecoil), this);
            //createRecoilHook.ThreadACL.SetExclusiveACL(new Int32[] { });
            //hooks.Add("recoil", createRecoilHook);

            _exServer.ReportMessage("Hooks placed");

            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    _exServer.Ping();
                }
            }
            catch {}

            //cleanup
            foreach (var h in hooks)
            {
                h.Value.Dispose();
            }
            EasyHook.LocalHook.Release();
            
        }


        //hook function
        static void hDoRecoil(RecoilProperties probs, int multi)
        {
            
            //TODO: If(activated)
            multi = 0;
            oDoRecoil(probs, multi);
        }
    }
}

public class RecoilProperties
{
    public float shockSize;
    public float upSize;
    public float lerpSpeed;
    public float backSpeed;
    public float fovKick;
}
