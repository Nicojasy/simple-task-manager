using SimpleTaskManager.Models;
using System;
using System.Linq;

namespace SimpleTaskManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TaskContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Tasks.Any())
            {
                return;   // DB has been seeded
            }

            DateTime now = DateTime.Now;

            var tasks = new UserTask[]
            {
                new UserTask{ name="task1", startDate=now.AddHours(-2), endDate=now.AddHours(3), status=StatusEnum.InProcess},
                new UserTask{ name="task2", startDate=now.AddHours(3), endDate=now.AddHours(6), status=StatusEnum.NotStarted},
                new UserTask{ name="task3", startDate=now.AddHours(-3), endDate=now.AddHours(1), status=StatusEnum.InProcess},
                new UserTask{ name="task4", startDate=now.AddHours(-1), endDate=now.AddHours(1), status=StatusEnum.InProcess},
                new UserTask{ name="task5", startDate=now.AddHours(-12), endDate=now.AddHours(-1), status=StatusEnum.Rejected},
                new UserTask{ name="task6", startDate=now.AddHours(12), endDate=now.AddHours(17), status=StatusEnum.NotStarted},
                new UserTask{ name="task7", startDate=now.AddHours(-10), endDate=now.AddHours(-2), status=StatusEnum.Expired},
                new UserTask{ name="task8", startDate=now.AddHours(-23), endDate=now.AddHours(-12), status=StatusEnum.Completed},
                new UserTask{ name="task9", startDate=now.AddHours(-5), endDate=now.AddHours(2), status=StatusEnum.InProcess},
                new UserTask{ name="task10", startDate=now.AddHours(-6), endDate=now.AddHours(2), status=StatusEnum.InProcess},
                new UserTask{ name="task11", startDate=now.AddHours(-3), endDate=now.AddHours(1), status=StatusEnum.InProcess},
                new UserTask{ name="task12", startDate=now.AddHours(-8), endDate=now.AddHours(-3), status=StatusEnum.Rejected},
                new UserTask{ name="task13", startDate=now.AddHours(-12), endDate=now.AddHours(-4), status=StatusEnum.Expired},
                new UserTask{ name="task14", startDate=now.AddHours(-7), endDate=now.AddHours(-2), status=StatusEnum.Completed},
                new UserTask{ name="task15", startDate=now.AddHours(20), endDate=now.AddHours(25), status=StatusEnum.NotStarted},
                new UserTask{ name="task16", startDate=now.AddHours(-4), endDate=now.AddHours(1), status=StatusEnum.InProcess},
            };
            foreach (UserTask t in tasks)
            {
                context.Tasks.Add(t);
            }
            context.SaveChanges();

        }
    }
}