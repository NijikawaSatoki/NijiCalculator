/* =============================================================================
 * Class file `Calculate'
 * =============================================================================
 * 
 * Class author: Niji System
 * 
 */

using System;

namespace NijiCalculator {
    class Calculate {
        // Basic functions
        public long Add(long x, long y) {
            long z = x + y;
            return z;
        }
        public long Subtract(long x, long y) {
            long z = x - y;
            return z;
        }
        public long Multiply(long x, long y) {
            long z = x * y;
            return z;
        }
        public double Divide(double x, double y) {
            double z = x / y;
            return z;
        }
        public long Modulo(long x, long y) {
            long z = x % y;
            return z;
        }
    }
}
