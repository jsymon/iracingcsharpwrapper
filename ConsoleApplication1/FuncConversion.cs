using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRSDKSharp;
namespace ConsoleApplication1
{
    public static class FuncConversion
    {
        public static string GetNativeType(int varType)
        {
            return GetNativeType((CVarHeader.VarType)varType);
        }
        public static string GetNativeType(CVarHeader.VarType varType)
        {
            switch (varType)
            {
                case CVarHeader.VarType.irChar: return "string";
                case CVarHeader.VarType.irBool: return "bool";
                case CVarHeader.VarType.irInt: return "int";
                case CVarHeader.VarType.irBitField: return "bitfield";//this case will throw a compiler error (good)
                case CVarHeader.VarType.irFloat: return "float";
                case CVarHeader.VarType.irDouble: return "double";
                default: return "unknown";
            }
        }
    }
}
