using System;
using System.Collections.Generic;

//using Core.Math.Intervals;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.MotoriAbilities
{
    /// <summary>
    /// Approximation for 1RM (1 repetitio/rep maximum, one repetition max) AKA Max Load
    /// 
    /// <a href="http://www.sportsscience.co/tools/1-rep-max-1rm-calculator/"/>
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class
                                        MaxLoad1RMApproximation
    {
        public
            double?
                                        CalculateEpley_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            double? max_load = mass * (1 + 0.0333d * number_of_repetitions);

            return max_load;
        }

        public
            double?
                                        CalculateLander_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = (100 x W) / (101.3 – 2.67123 x R)
            double? max_load =
                                (100.00 * mass)
                                /
                                (
                                    101.3d
                                    -
                                    2.67123d * number_of_repetitions
                                );

            return max_load;
        }

        public
            double?
                                        CalculateWathan_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = (100 x W) / (48.8 + (53.8 x e-0.075 x R))
            double? max_load = 
                                (100.0 * mass) 
                                / 
                                (
                                    48.8
                                    +
                                    53.8
                                    *
                                    System.Math.Pow
                                                (
                                                    System.Math.E,
                                                    -0.075 * number_of_repetitions.Value
                                                )
                                );

            return max_load;
        }

        public
            double?
                                        CalculateLombardi_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = W x R^0.1
            double? max_load =
                                mass
                                *
                                System.Math.Pow
                                            (
                                                number_of_repetitions.Value,
                                                0.1
                                            );

            return max_load;
        }

        public
            double?
                                        CalculateMayhewEtAl_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = (100 x W) / (52.2 + 41.9 x e(-0.055 x R)))
            double? max_load =
                                100.0 * mass
                                /
                                (
                                    52.2
                                    +
                                    41.9
                                    *
                                    System.Math.Pow
                                                (
                                                    System.Math.E,
                                                    -0.055 * number_of_repetitions.Value
                                                )
                                );

            return max_load;
        }

        public
            double?
                                        CalculateOConnerEtAl_SportScience
                                        (
                                            double? mass,
                                            ulong? number_of_repetitions
                                        )
        {
            // 1RM = W x (1 + 0.025 x R)
            double? max_load =
                                mass
                                *
                                (
                                    1.0
                                    +
                                    (
                                        double_0_025_1_over_40_OConner * number_of_repetitions
                                    )
                                );

            return max_load;
        }

    }
}
