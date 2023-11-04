using System;
using System.Collections.Generic;

//using Core.Math.Intervals;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.MotoriAbilities
{
    /// <summary>
    /// Approximation for 1RM (1 repetitio/rep maximum, one repetition max) AKA Max Load
    /// 
    /// <a href="https://www.brianmac.co.uk/maxload.htm"/>
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class
                                        MaxLoad1RMApproximation
    {
        /// <summary>
        /// </summary>
        /// <param name="mass">Mass (weight)</param>
        /// <param name="number_of_repetitions">Number of repetitions</param>
        /// <returns></returns>
        public
            double?
                                        CalculateBrzycki_BrianMac
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // original:    Weight ÷ ( 1.0278 - ( 0.0278 × Number of repetitions ) )
            double? max_load =
                                mass
                                /
                                (
                                    1.0278
                                    -
                                    (
                                        0.0278 * number_of_repetitions
                                    )
                                );

            return max_load;
        }

        public
            double?
                                        CalculateBaechle_BrianMac
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // original: Weight × ( 1 + ( 0.033 × Number of repetitions ) )
            double? max_load =
                                mass
                                *
                                (
                                    // 0.033 ???
                                    1.00 + (0.033 * number_of_repetitions)
                                );

            return max_load;
        }

        public 
            double?
                                        CalculateEpley_BrianMac
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            double? max_load =
                                mass
                                *
                                (
                                    1.00
                                    +
                                    double_0_033_AKA_1_over_30_Epley * number_of_repetitions
                                );

            return max_load;
        }

        public
            double?
                                        CalculateLanders_BrianMac
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            double? max_load =
                                (100.00 * mass)
                                /
                                (
                                    101.3
                                    -
                                    (
                                        2.67123 * number_of_repetitions
                                    )
                                );

            return max_load;
        }
    }
}
