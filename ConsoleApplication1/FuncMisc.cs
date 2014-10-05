using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FuncMisc
    {
        public static string GetHeaderPropertyDeclarations(iRSDKSharp.CVarHeader[] headers)
        {
            var sb = new StringBuilder();
            foreach (var header in headers)
            {
                sb.AppendLine("/// <summary>");
                sb.AppendLine("/// "+header.Desc+".");
                sb.AppendLine("/// </summary>");
                sb.AppendLine(string.Format("public TelemetryValue<{0}> {1} {{ get {{ return GetUndefined<{0}>(\"{1}\"); }} }}", FuncConversion.GetNativeType(header.Type), header.Name));
            }
            return sb.ToString();
        }

        public static string GetHeaderPropertyNames(iRSDKSharp.CVarHeader[] headers)
        {
            var sb = new StringBuilder();
            foreach (var header in headers)
            {
                sb.AppendLine(header.Name);
            }
            return sb.ToString();
        }
    }
}
