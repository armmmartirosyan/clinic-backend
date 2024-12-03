namespace Clinic.Models
{
    public enum WeekDays
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7,
    }

    [Table("week_day_schedule")]
    public class WeekDaySchedule
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("start_time", TypeName = "TIME")]
        public required TimeSpan StartTime { get; set; }

        [Column("end_time", TypeName = "TIME")]
        public required TimeSpan EndTime { get; set; }

        [Column("break_start_time", TypeName = "TIME")]
        public required TimeSpan BreakStartTime { get; set; }

        [Column("break_end_time", TypeName = "TIME")]
        public required TimeSpan BreakEndTime { get; set; }

        [Column("day_of_week", TypeName = "TINYINT")]
        public required WeekDays DayOfWeek { get; set; }

        //	dentist_id(INT, Foreign Key, relates to Dentists.id)
    }
}
