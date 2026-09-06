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
 */

using System;

namespace NijiCalculator
{
    class NijiConvenience
    {
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
        public long Read64BitNumberInput()
        {
            long integer64Bit = Convert.ToInt64(Console.ReadLine());
            return integer64Bit;
        }
    }
}
