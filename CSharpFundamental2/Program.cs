using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamental2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "An",
                    LastName = "Duong",
                    Gender = "Male",
                    DateOfBirth =DateTime.Parse("07/06/2000"),
                    BirthPlace = "Thai Nguyen"
                },
                new Member{
                    FirstName = "An",
                    LastName = "Dang",
                    Gender = "Male",
                    DateOfBirth =DateTime.Parse("07/06/2000"),
                    BirthPlace = "Ha Noi"
                },
                new Member{
                    FirstName = "Ha",
                    LastName = "Hoang",
                    Gender = "Female",
                    DateOfBirth =DateTime.Parse("07/06/1999"),
                    BirthPlace = "Ha Noi"
                },
                new Member{
                    FirstName = "Linh",
                    LastName = "Nguyen",
                    Gender = "Female",
                    DateOfBirth =DateTime.Parse("07/06/2003"),
                    BirthPlace = "Nam Dinh"
                }
            };
            //Cau 1
            Console.WriteLine("Cau 1");
            var maleMembers =  members.Where(m => m.Gender == "Male").ToList();
            maleMembers.ForEach(m => Console.WriteLine(m.MemberInFo()));

            //Cau 2
            Console.WriteLine("Cau 2");
            var maxAge =  members.Max(m => m.Age);
            
            //Cach 1
            Member oldestMember = members.First(x => x.Age == maxAge);

            /*
            //Cach 2
            Member oldestMember1 = members.FirstOrDefault(x => x.Age == maxAge);

            //Cach 3
            var oldestMember2 = members.Where(x => x.Age == maxAge).Take(1);
            */

            //output cach 1
            //Console.WriteLine("Cach 1:");
            Console.WriteLine(oldestMember.MemberInFo());
            
            /*
            //output cach 2
            Console.WriteLine("Cach 2:");
            if(oldestMember1!=null)
                Console.WriteLine(oldestMember1.MemberInFo());

            //output cach 3
            Console.WriteLine("Cach 3:");
            if(oldestMember2.Any())
            {
                foreach (var item in members)
                {
                    Console.WriteLine(item.MemberInFo());
                }
            }
            */

            //Cau 3
            Console.WriteLine("Cau 3");
            List<string> fullNames = members.Select(m => m.FirstName + " "+ m.LastName).ToList();
            fullNames.ForEach(m=>Console.WriteLine(m));

            //Cau 4
            Console.WriteLine("Cau 4");
            //Year of birth = 2000
            Console.WriteLine("List of members who has birth year is 2000");
            var yearEqual2000s =  members.Where(m => m.DateOfBirth.Year == 2000).ToList();
            yearEqual2000s.ForEach(m => Console.WriteLine(m.MemberInFo()));
            //Year of birth > 2000
            Console.WriteLine("List of members who has birth year is greater than 2000");
            var yearGreater2000s =  members.Where(m => m.DateOfBirth.Year > 2000).ToList();
            yearGreater2000s.ForEach(m => Console.WriteLine(m.MemberInFo()));
            //Year of birth < 2000
            Console.WriteLine("List of members who has birth year is less than 2000");
            var yearLess2000s =  members.Where(m => m.DateOfBirth.Year < 2000).ToList();
            yearLess2000s.ForEach(m => Console.WriteLine(m.MemberInFo()));

            //Cau 5
            Console.WriteLine("Cau 5");
            var firstBornHaNoi =  members.First(m => m.BirthPlace.CompareTo("Ha Noi") == 0);
            Console.WriteLine(firstBornHaNoi.MemberInFo());
            
            //Note: Linq query
            //var/ClassName queryName = listName.functionNames(m => Conditions)
            //Console.WriteLine(queryName.outputMethod());
        }
    }
}
