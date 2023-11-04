
using System;

namespace HolisticWare.Ph4ct3x.Utilities.PseudoScience
{
    /// <summary>
    /// BioRythm Calculations
    /// </summary>
    public partial class 
                                        BioRythm
    {
        /// <summary>
        /// Physical
        /// </summary>
        /// <param name="date_of_birth"></param>
        /// <returns></returns>
        public
            double 
                                        Physical 
                                        (
                                            DateTime date_of_birth
                                        )
        {
            TimeSpan ts = DateTime.Now.Subtract(date_of_birth);
            double age = ts.TotalDays;

            return Math.Sin( 2.0 * Math.PI * age / this.CycleDurationInDaysPhysical );
        }

        /// <summary>
        /// CycleDurationInDaysPhysical
        /// </summary>
        public 
            double 
                                        CycleDurationInDaysPhysical
        {
            get;
            set;
        } = 23.0;

        /// <summary>
        /// Emotional
        /// </summary>
        /// <param name="date_of_birth"></param>
        /// <returns></returns>
        public 
            double 
                                        Emotional 
                                        (
                                            DateTime date_of_birth
                                        )
        {
            TimeSpan ts = DateTime.Now.Subtract(date_of_birth);
            double age = ts.TotalDays;

            return Math.Sin(2 * Math.PI * age / this.CycleDurationInDaysEmotional);
        }

        /// <summary>
        /// CycleDurationInDaysEmotional
        /// </summary>
        public 
            double
                                        CycleDurationInDaysEmotional
        {
            get;
            set;
        } = 28.0;

        /// <summary>
        /// Intellectual
        /// </summary>
        /// <param name="date_of_birth"></param>
        /// <returns></returns>
        public
            double 
                                        Intellectual 
                                        (
                                            DateTime date_of_birth
                                        )
        {
            TimeSpan ts = DateTime.Now.Subtract(date_of_birth);
            double age = ts.TotalDays;

            return Math.Sin(2 * Math.PI * age / this.CycleDurationInDaysIntellectual);
        }

        /// <summary>
        /// CycleDurationInDaysIntellectual
        /// </summary>
        public 
            double
                                        CycleDurationInDaysIntellectual
        {
            get;
            set;
        } = 33.0;
    }
}
