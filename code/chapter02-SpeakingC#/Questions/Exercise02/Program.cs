using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"|----------|------|-----------------------|-----------------------|");
            WriteLine($"| {"Type", 8} | {"size", 4} | {"max value", 21} | {"min value", 21} |");
            WriteLine($"|----------|------|-----------------------|-----------------------|");
            WriteLine($"| {"sbyte", 8} | {sizeof(sbyte), 4} | {sbyte.MinValue, 22}| {sbyte.MaxValue, 21} |");
            WriteLine($"| {"byte", 8} | {sizeof(byte), 4} | {byte.MinValue, 22}| {byte.MaxValue, 21} |");
            WriteLine($"| {"short", 8} | {sizeof(short), 4} | {short.MinValue, 22}| {short.MaxValue, 21} |");
            WriteLine($"| {"ushort", 8} | {sizeof(ushort), 4} | {ushort.MinValue, 22}| {ushort.MaxValue, 21} |");
            WriteLine($"| {"int", 8} | {sizeof(int), 4} | {int.MinValue, 22}| {int.MaxValue, 21} |");
            WriteLine($"| {"uint", 8} | {sizeof(uint), 4} | {uint.MinValue, 22}| {uint.MaxValue, 21} |");
            WriteLine($"| {"long", 8} | {sizeof(long), 4} | {long.MinValue, 22}| {long.MaxValue, 21} |");
            WriteLine($"| {"ulong", 8} | {sizeof(ulong), 4} | {ulong.MinValue, 22}| {ulong.MaxValue, 21} |");
            WriteLine($"| {"float", 8} | {sizeof(float), 4} | {float.MinValue, 22}| {float.MaxValue, 21} |");
            WriteLine($"| {"double", 8} | {sizeof(double), 4} | {double.MinValue, 22}| {double.MaxValue, 21} |");
            WriteLine($"| {"decimal", 8} | {sizeof(decimal), 4} | {decimal.MinValue, 22}| {decimal.MaxValue, 21} |");
            
            /*WriteLine($"byte uses {sizeof(byte)} bytes and the smallest value it can hold is {byte.MinValue:N0}, while the largest value it can hold is {byte.MaxValue:N0}");
            WriteLine($"short uses {sizeof(short)} bytes and the smallest value it can hold is {short.MinValue:N0}, while the largest value it can hold is {short.MaxValue:N0}");            
            WriteLine($"ushort uses {sizeof(ushort)} bytes and the smallest value it can hold is {ushort.MinValue:N0}, while the largest value it can hold is {ushort.MaxValue:N0}");
            WriteLine($"int uses {sizeof(int)} bytes and the smallest value it can hold is {int.MinValue:N0}, while the largest value it can hold is {int.MaxValue:N0}");
            WriteLine($"uint uses {sizeof(uint)} bytes and the smallest value it can hold is {uint.MinValue:N0}, while the largest value it can hold is {uint.MaxValue:N0}");
            WriteLine($"long uses {sizeof(long)} bytes and the smallest value it can hold is {long.MinValue:N0}, while the largest value it can hold is {long.MaxValue:N0}");
            WriteLine($"ulong uses {sizeof(ulong)} bytes and the smallest value it can hold is {ulong.MinValue:N0}, while the largest value it can hold is {ulong.MaxValue:N0}");
            WriteLine($"float uses {sizeof(float)} bytes and the smallest value it can hold is {float.MinValue:N0}, while the largest value it can hold is {float.MaxValue:N0}");
            WriteLine($"double uses {sizeof(double)} bytes and the smallest value it can hold is {double.MinValue:N0}, while the largest value it can hold is {double.MaxValue:N0}");
            WriteLine($"decimal uses {sizeof(decimal)} bytes and the smallest value it can hold is {decimal.MinValue:N0}, while the largest value it can hold is {decimal.MaxValue:N0}");*/
            WriteLine("|----------|------|-----------------------|-----------------------|");
        }
    }
}
