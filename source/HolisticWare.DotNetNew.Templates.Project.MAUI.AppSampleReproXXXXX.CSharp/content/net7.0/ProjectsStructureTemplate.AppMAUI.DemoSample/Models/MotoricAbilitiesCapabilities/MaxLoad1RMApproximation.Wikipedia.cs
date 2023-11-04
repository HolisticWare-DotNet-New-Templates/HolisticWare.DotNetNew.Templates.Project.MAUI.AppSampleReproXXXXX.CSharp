using System;
using System.Collections.Generic;

//using Core.Math.Intervals;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.MotoriAbilities
{
    /// <summary>
    /// Approximation for 1RM (1 repetitio/rep maximum, one repetition max) AKA Max Load
    /// 
    /// <a href="https://en.wikipedia.org/wiki/One-repetition_maximum"/>
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class
                                        MaxLoad1RMApproximation
    {
        public
            double 
                                        CalculateWathan_Wikipedia
                                        (
                                            double? mass, 
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double 
                                        CalculateOConnerEtAl_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double 
                                        CalculateMayhewEtAl_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double 
                                        CalculateLombardi_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double? 
                                        CalculateBaechle_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double? 
                                        CalculateBrzycki_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            return double.NaN;
        }

        public 
            double? 
                                        CalculateMcGlothin_Wikipedia
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = W x (1 + 0.025 x R)
            double? max_load =
                                mass *
                                (
                                    1d
                                    +
                                    double_0_025_1_over_40_OConner * number_of_repetitions
                                );

            return max_load;
        }
    }
}
