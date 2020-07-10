using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var roomID = 1;
            var dayOfWeek = DayOfWeek.Monday;
            var startTime = DateTime.Parse("13:59");
            var endTime = DateTime.Parse("13:00");
            var schedules = MockData.Generate();
            // Filter schedules on selected room and selected day
            var roomSchedulesForDay = schedules.Where((r) => r.Room.RoomID == roomID && r.DayOfWeek == dayOfWeek);
            foreach (var item in roomSchedulesForDay)
            {
                Console.WriteLine(item.ScheduleID + " " + item.Faculty.Name + " " + item.Room.Name + " " + item.DayOfWeek.ToString() + " " + item.TimeStart.ToShortTimeString() + "-" + item.TimeEnd.ToShortTimeString());
            }
            /**
             * Find conflict schedules on selected room
             * */
            if (roomSchedulesForDay.Count() > 0)
            {
                
                var conflicts = roomSchedulesForDay.Where(r => r.TimeStart.TimeOfDay < endTime.TimeOfDay && startTime.TimeOfDay < r.TimeEnd.TimeOfDay );
                foreach (var item in conflicts)
                {
                    Console.WriteLine(item.ScheduleID + " " + item.Faculty.Name + " " + item.Room.Name + " " + item.DayOfWeek.ToString() + " " + item.TimeStart.ToShortTimeString() + "-" + item.TimeEnd.ToShortTimeString());
                }
            }
            
            
            Console.ReadKey();
        }


    }
    class Faculty
    {
        
        public int FacultyID { get; set; }
        public string Name { get; set; }
    }
    class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
    }
    class Section
    {
        public int SectionID { get; set; }
        public string Name { get; set; }
    }
    class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
    }
    class Schedule
    {
        public int ScheduleID { get; set; }
        public string Code { get; set; }
        public Faculty Faculty { get; set; }
        public Room Room { get; set; }
        public Section Section { get; set; }
        public Subject Subject { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }

    static class MockData
    {
        public static List<Schedule> Generate()
        {
            return new List<Schedule>(){
                new Schedule() {
                    ScheduleID= 1,
                    Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 1),
                    Room =GenerateRooms().First((r) => r.RoomID == 1),
                    Section = GenerateSections().First((r) => r.SectionID == 1),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 1),
                    DayOfWeek = DayOfWeek.Monday,
                    TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 2,
                    Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 2),
                    Room =GenerateRooms().First((r) => r.RoomID == 1),
                    Section = GenerateSections().First((r) => r.SectionID == 2),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 2),
                    DayOfWeek = DayOfWeek.Monday,
                    TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 3,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 3),
                    Room =GenerateRooms().First((r) => r.RoomID == 3),
                    Section = GenerateSections().First((r) => r.SectionID == 3),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 3),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 4,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 4),
                    Room =GenerateRooms().First((r) => r.RoomID == 4),
                    Section = GenerateSections().First((r) => r.SectionID == 4),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 4),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 5,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 5),
                    Room =GenerateRooms().First((r) => r.RoomID == 5),
                    Section = GenerateSections().First((r) => r.SectionID == 5),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 5),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 6,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 6),
                    Room =GenerateRooms().First((r) => r.RoomID == 6),
                    Section = GenerateSections().First((r) => r.SectionID == 6),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 6),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 7,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 7),
                    Room =GenerateRooms().First((r) => r.RoomID == 7),
                    Section = GenerateSections().First((r) => r.SectionID == 7),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 7),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 8,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 8),
                    Room =GenerateRooms().First((r) => r.RoomID == 8),
                    Section = GenerateSections().First((r) => r.SectionID == 8),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 8),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
                new Schedule() {
                    ScheduleID= 9,
                     Code = "monday_7-3",
                    Faculty = GenerateFaculties().First((r) => r.FacultyID == 9),
                    Room =GenerateRooms().First((r) => r.RoomID == 9),
                    Section = GenerateSections().First((r) => r.SectionID == 9),
                    Subject =GenerateSubjects().First((r) => r.SubjectID == 9),
                    DayOfWeek = DayOfWeek.Monday,
                     TimeStart = DateTime.Parse("07:00"),
                    TimeEnd = DateTime.Parse("13:00")
                    },
            };
        }
        public static List<Faculty> GenerateFaculties()
        {
            return new List<Faculty>()
            {
                new Faculty(){FacultyID= 1, Name="Faculty1"},
                new Faculty(){FacultyID= 2, Name="Faculty2"},
                new Faculty(){FacultyID= 3, Name="Faculty3"},
                new Faculty(){FacultyID= 4, Name="Faculty4"},
                new Faculty(){FacultyID= 5, Name="Faculty5"},
                new Faculty(){FacultyID= 6, Name="Faculty6"},
                new Faculty(){FacultyID= 7, Name="Faculty7"},
                new Faculty(){FacultyID= 8, Name="Faculty8"},
                new Faculty(){FacultyID= 9, Name="Faculty9"},
                new Faculty(){FacultyID= 10, Name="Faculty10"},
            };
        }
        public static List<Room> GenerateRooms()
        {
            return new List<Room>()
            {
                new Room(){RoomID= 1, Name="Room1"},
                new Room(){RoomID= 2, Name="Room2"},
                new Room(){RoomID= 3, Name="Room3"},
                new Room(){RoomID= 4, Name="Room4"},
                new Room(){RoomID= 5, Name="Room5"},
                new Room(){RoomID= 6, Name="Room6"},
                new Room(){RoomID= 7, Name="Room7"},
                new Room(){RoomID= 8, Name="Room8"},
                new Room(){RoomID= 9, Name="Room9"},
                new Room(){RoomID= 10, Name="Room10"},
            };
        }
        public static List<Section> GenerateSections()
        {
            return new List<Section>()
            {
                new Section(){SectionID= 1, Name="Section1"},
                new Section(){SectionID= 2, Name="Section2"},
                new Section(){SectionID= 3, Name="Section3"},
                new Section(){SectionID= 4, Name="Section4"},
                new Section(){SectionID= 5, Name="Section5"},
                new Section(){SectionID= 6, Name="Section6"},
                new Section(){SectionID= 7, Name="Section7"},
                new Section(){SectionID= 8, Name="Section8"},
                new Section(){SectionID= 9, Name="Section9"},
                new Section(){SectionID= 10, Name="Section10"},
            };
        }
        public static List<Subject> GenerateSubjects()
        {
            return new List<Subject>()
            {
                new Subject(){SubjectID= 1, Name="Subject1"},
                new Subject(){SubjectID= 2, Name="Subject2"},
                new Subject(){SubjectID= 3, Name="Subject3"},
                new Subject(){SubjectID= 4, Name="Subject4"},
                new Subject(){SubjectID= 5, Name="Subject5"},
                new Subject(){SubjectID= 6, Name="Subject6"},
                new Subject(){SubjectID= 7, Name="Subject7"},
                new Subject(){SubjectID= 8, Name="Subject8"},
                new Subject(){SubjectID= 9, Name="Subject9"},
                new Subject(){SubjectID= 10, Name="Subject10"},
            };
        }
    }
}
