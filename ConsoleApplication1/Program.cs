using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sdk = new iRSDKSharp.iRacingSDK();
            sdk.defines.MemMapFileName = @"c:\code\test.ibt";
            sdk.Startup();

            var sessionInfo = sdk.GetSessionInfo();
            var info = new iRacingSdkWrapper.TelemetryInfoOffline(sdk);


            if (sdk.SubHeader.SessionLapCount >= 0)
                sdk.Header.LineNumberMax = sdk.SubHeader.SessionRecordCount;
            while (!sdk.Header.IsEOF)
            {
               Console.WriteLine(info.FrameRate);
                sdk.Header.LineNumber++;
            }
            Console.Read();
        }
    }
}
