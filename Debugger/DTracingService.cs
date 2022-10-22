using Microsoft.Xrm.Sdk;

namespace Debugger
{
    public class DTracingService : ITracingService
    {
        public void Trace(string format, params object[] args)
        {
            if (args.Length == 0)
            {
                System.Diagnostics.Debug.WriteLine(format);
                System.Console.WriteLine(format);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(format, args);
                System.Console.WriteLine(format, args);
            }
        }
    }
}