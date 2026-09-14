/* =============================================================================
 * Niji Calculator
 * =============================================================================
 * 
 * presented by:
 *     Niji System
 *         Satoki Nijikawa
 *         Wamo
 *         Kiyoi
 *         Vihreääketty
 *         Hsiao Lyuhsien
 *         Antiainehunt Õudus
 *         Rinith
 *         Q'aemil
 *         SAW-01-2548 "Mlikam Klichesh"
 */

using System;

namespace NijiCalculator
{
    class NijiConvenience
    {
        private string _notImplemented = "This is not implemented yet!";
        public string NotImplemented => _notImplemented;
        // Read in specific input types
        public bool ReadBooleanInput()
        {
            bool boolean = Convert.ToBoolean(Console.ReadLine());
            return boolean;
        }
        public char ReadCharacterInput()
        {
            char character = Convert.ToChar(Console.ReadLine());
            return character;
        }
        public double ReadFloatingPointNumberInput()
        {
            double floatingPointNumber = Convert.ToDouble(Console.ReadLine());
            return floatingPointNumber;
        }
        public int Read32BitNumberInput()
        {
            int integer32Bit = Convert.ToInt32(Console.ReadLine());
            return integer32Bit;
        }
        public uint ReadUnsigned32BitNumberInput()
        {
            uint unsignedInteger32Bit = (uint)Convert.ToInt32(Console.ReadLine());
            return unsignedInteger32Bit;
        }
        public long Read64BitNumberInput()
        {
            long integer64Bit = Convert.ToInt64(Console.ReadLine());
            return integer64Bit;
        }
        public ulong ReadUnsigned64BitNumberInput()
        {
            ulong unsignedInteger64Bit = (ulong)Convert.ToInt64(Console.ReadLine());
            return unsignedInteger64Bit;
        }
    }
}
