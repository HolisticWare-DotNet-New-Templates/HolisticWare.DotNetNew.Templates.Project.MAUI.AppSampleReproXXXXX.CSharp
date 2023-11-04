using System;
using System.Collections.Generic;

//using Core.Math.Intervals;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.MotoriAbilities
{
    /// <summary>
    /// Approximation for 1RM (1 repetitio/rep maximum, one repetition max) AKA Max Load
    /// 
    /// <a href="https://en.wikipedia.org/wiki/One-repetition_maximum"/>
    /// <a href="https://www.brianmac.co.uk/maxload.htm"/>
    /// <a href="http://www.sportsscience.co/tools/1-rep-max-1rm-calculator/"/>
    /// <a href="https://www.thecalculator.co/health/1RM-Calculator-358.html"/>
    /// <a href="https://www.thecalculator.co/health/Bench-Press-Calculator-265.html"/>
    /// <a href=""/>
    /// <a href=""/>
    /// </summary>
    /// TODO: Func<> delegate + Dictionary
    public partial class
                                        MaxLoad1RMApproximation
    {
        public
            double?
                                        MaxLoad1RM
        {
            get
            {
                return max_load_1rm;
            }
        }

        //public Interval<double> MaxLoad1RMApproximationRange
        //{
        //    get;
        //    set;
        //}

        public
            double?
                                        Mass
        {
            get;
            set;
        }

        public
            ulong?
                                        NumberOfRepetitions
        {
            get;
            set;
        }

        protected const
            double
                                        double_0_033_AKA_1_over_30_Epley    = 0.033;
        protected const
            double
                                        double_0_025_1_over_40_OConner      = 0.025;

        public 
                                        MaxLoad1RMApproximation
                                        (
                                        )
        {
            return;
        }

        public 
                                        MaxLoad1RMApproximation
                                        (
                                            double? mass, 
                                            ulong? number_of_repetitions
                                        )
        {
            this.Mass = mass;
            this.NumberOfRepetitions = number_of_repetitions;

            return;
        }

        private
            double?
                                        max_load_1rm;


        public
            Dictionary<string, double?> 
                                        Calculate
                                        (
                                            double? mass, 
                                            ulong? number_of_repetitions
                                        )
        {
            Dictionary<string, double?> max_load_approximations = new()
            {
                {
                    "Epley (Wikipedia)",
                    this.CalculateBaechle_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "Brzycki (Wikipedia)",
                    this.CalculateBrzycki_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "McGlothin (Wikipedia)",
                    this.CalculateMcGlothin_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "Lombardi (Wikipedia)",
                    this.CalculateLombardi_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "Mayhew et al. (Wikipedia)",
                    this.CalculateMayhewEtAl_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "O'Conner et al. (Wikipedia)",
                    this.CalculateOConnerEtAl_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "Wathan (Wikipedia)",
                    this.CalculateWathan_Wikipedia(mass,number_of_repetitions)
                },
                {
                    "Beachle (BrianMac)", 
                    this.CalculateBaechle_BrianMac(mass,number_of_repetitions)
                },
                {
                    "Bryzicky (BrianMac)", 
                    this.CalculateBrzycki_BrianMac(mass,number_of_repetitions)},
                {
                    "Epley (BrianMac)", 
                    this.CalculateEpley_BrianMac(mass,number_of_repetitions)
                },
                {
                    "Epley (SportScience)", 
                    this.CalculateEpley_SportScience(mass,number_of_repetitions)
                },
                {
                    "Lander (SportScience)", 
                    this.CalculateLander_SportScience(mass,number_of_repetitions)
                },
                {
                    "Landers (BrianMac)",
                    this.CalculateLanders_BrianMac(mass,number_of_repetitions)
                },
                {
                    "Lombardi (SportScience)", 
                    this.CalculateLombardi_SportScience(mass,number_of_repetitions)
                },
                {
                    "Mayhew et. al. (SportScience)", 
                    this.CalculateMayhewEtAl_SportScience(mass,number_of_repetitions)
                },
                {
                    "OConner et. al. (SportScience)", 
                    this.CalculateOConnerEtAl_SportScience(mass,number_of_repetitions)
                },
                {
                    "Wathan (SportScience)", 
                    this.CalculateWathan_SportScience(mass,number_of_repetitions)
                },
            };

            double? sum = 0.0;
            double? min = double.MaxValue;
            double? max = double.MinValue;

            foreach(KeyValuePair<string, double?> kvp in max_load_approximations)
            {
                min = (kvp.Value < min) ? kvp.Value : min; 
                max = (kvp.Value > max) ? kvp.Value : max; 
                sum += kvp.Value;
            }

            max_load_1rm = sum / max_load_approximations.Count;
            max_load_approximations.Add("Max Load - average", this.MaxLoad1RM);

            //this.MaxLoad1RMApproximationRange = new Interval<double>()
            //{
            //    BoundLower = min,
            //    BoundUpper = max,
            //};

            return max_load_approximations;
        }

    }
}
