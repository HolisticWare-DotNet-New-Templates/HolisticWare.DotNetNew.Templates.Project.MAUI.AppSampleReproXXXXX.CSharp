namespace HolisticWare.Ph4ct3x.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Age abstraction
    /// Thanks to Faisal Alman
    /// </summary>
    /// <a href="https://gist.github.com/faisalman"/>
    /// <a href="https://gist.github.com/faisalman/1724253"/>
    public partial class
                                        Age
    {
        public
            int
                                        Years
        {
            get;
            set;
        }

        public
            int
                                        Months
        {
            get;
            set;
        }

        public
            int
                                        Days
        {
            get;
            set;
        }

        public
                                        Age
                                        (
                                            DateTime date_of_birth
                                        )
        {
            Age a = this.Calculate(date_of_birth);

            return;
        }

        public
                                        Age
                                        (
                                            DateTime date_of_birth,
                                            DateTime date_current
                                        )
        {
            Age a = this.Calculate(date_of_birth, date_current);

            return;
        }

        public
            Age
                                        Calculate
                                        (
                                            DateTime date_of_birth
                                        )
        {
            Age a = this.Calculate(date_of_birth, DateTime.Today);

            return a;
        }

        public
            Age
                                        Calculate
                                        (
                                            DateTime date_of_birth,
                                            DateTime date_current
                                        )
        {
            if 
                (
                    (date_current.Year - date_of_birth.Year) > 0 
                    ||
                    (
                        (
                            (date_current.Year - date_of_birth.Year) == 0
                        ) 
                        && 
                        (
                            (date_of_birth.Month < date_current.Month) 
                            ||
                            (
                                (date_of_birth.Month == date_current.Month) 
                                && 
                                (date_of_birth.Day <= date_current.Day)
                            )
                        )
                    )
                )
            {
                int days_in_dob = DateTime.DaysInMonth(date_of_birth.Year, date_of_birth.Month);
                int DaysRemain = date_current.Day + (days_in_dob - date_of_birth.Day);

                if (date_current.Month > date_of_birth.Month)
                {
                    this.Years = date_current.Year - date_of_birth.Year;
                    this.Months =
                                    date_current.Month
                                    -
                                    (date_of_birth.Month + 1)
                                    +
                                    Math.Abs(DaysRemain / days_in_dob)
                                    ;
                    this.Days = (DaysRemain % days_in_dob + days_in_dob) % days_in_dob;
                }
                else if (date_current.Month == date_of_birth.Month)
                {
                    if (date_current.Day >= date_of_birth.Day)
                    {
                        this.Years = date_current.Year - date_of_birth.Year;
                        this.Months = 0;
                        this.Days = date_current.Day - date_of_birth.Day;
                    }
                    else
                    {
                        this.Years = (date_current.Year - 1) - date_of_birth.Year;
                        this.Months = 11;
                        this.Days =
                                    DateTime.DaysInMonth(date_of_birth.Year, date_of_birth.Month)
                                    -
                                    (date_of_birth.Day - date_current.Day);
                    }
                }
                else
                {
                    this.Years = (date_current.Year - 1) - date_of_birth.Year;
                    this.Months =
                                    date_current.Month
                                    +
                                    (11 - date_of_birth.Month)
                                    +
                                    Math.Abs(DaysRemain / days_in_dob)
                                    ;
                    this.Days = (DaysRemain % days_in_dob + days_in_dob) % days_in_dob;
                }
            }
            else
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }

            return this;
        }

        public 
            TimeSpan 
                                        AgeAsTimeSpan
        {
            get
            {
                return new TimeSpan(this.Years, this.Months, this.Days);
            }
        }

    }
}
