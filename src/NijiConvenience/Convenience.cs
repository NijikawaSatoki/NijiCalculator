/* =============================================================================
 * Class file `Convenience'
 * =============================================================================
 * 
 * Class author: Niji System
 * 
 */

using System;
using System.IO;

namespace NijiConvenience {
    class Convenience {
        public bool InputBoolean() {
            bool booleanState = Convert.ToBoolean(Console.ReadLine());
            return booleanState;
        }
        
        public char InputCharacter() {
            char character = Convert.ToChar(Console.ReadLine());
            return character;
        }
        
        public double InputDouble() {
            double doubleFloat = Convert.ToDouble(Console.ReadLine());
            return doubleFloat;
        }
        
        public int Input32BitInteger() {
            int int32 = Convert.ToInt32(Console.ReadLine());
            return int32;
        }
        
        public long Input64BitInteger() {
            long int64 = Convert.ToInt64(Console.ReadLine());
            return int64;
        }
        
        public void CreateOutput() {
            // Path parts
            string appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string outputFile = @"Calculator_Output.txt";
            string dataDirectory = @"NijiCalculator";
            // Full path
            string path = $@"{appDataDirectory}/{dataDirectory}/{outputFile}";
            // Output file header
            string output = "";
            Directory.CreateDirectory($@"{appDataDirectory}/{dataDirectory}/");
            File.AppendAllText(path, output);
        }
    }
}
