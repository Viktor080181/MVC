using System;
using System.Linq;
using ContosoUniversityHW.Models;  // замените на ваш namespace

namespace ContosoUniversityHW.Models  // или Data, в зависимости от структуры
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return; // База уже заполнена
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                // добавьте другие студенты
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            // Аналогично добавьте курсы и регистрации
        }
    }
}
