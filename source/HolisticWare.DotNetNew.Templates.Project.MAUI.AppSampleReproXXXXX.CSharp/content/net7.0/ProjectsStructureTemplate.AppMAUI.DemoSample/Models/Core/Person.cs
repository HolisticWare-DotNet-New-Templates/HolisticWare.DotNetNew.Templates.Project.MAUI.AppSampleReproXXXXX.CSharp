namespace HolisticWare.Ph4ct3x.Core
{
    using System;

    /// <summary>
    /// Person abstraction
    /// </summary>
    public partial class
                                        Person
    {
        /// <summary>
        /// NameLast - Family/Last Name
        /// </summary>
        public
            string?
                                        NameLast
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// </summary>
        public
            string?
                                        NameFirst
        {
            get;
            set;
        }

        /// <summary>
        /// Sex (biological not sociological) 
        /// XX and XY chromosomes 
        /// </summary>
        public
            Sex?
                                        Sex
        {
            get;
            set;
        }

        public
            DateTime
                                        DateOfBirth
        {
            get;
            set;
        }

        public
            double?
                                        AgeNumeric
                                        (
                                            DateTime? date = null
                                        )
        {
            TimeSpan? time_span = AgeAsTimeSpan(date);

            double? a = time_span?.Days / 365.25;

            return a;
        }

        public
            TimeSpan?
                                        AgeAsTimeSpan
                                        (
                                            DateTime? date = null
                                        )
        {
            DateTime date_calculated = date ?? DateTime.Now;
            TimeSpan? timeSpan = date_calculated - this.DateOfBirth;

            return timeSpan;
        }

        public
            Age
                                        AgeAsAgeAtDate
                                        (
                                            DateTime? date = null
                                        )
        {
            DateTime date_calculated = date ?? DateTime.Now;

            Age a = new Age(this.DateOfBirth, date_calculated);

            return a;
        }
    }
}
