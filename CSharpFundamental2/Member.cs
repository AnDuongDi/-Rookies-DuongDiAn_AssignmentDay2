using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamental2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
            set { Age = value; }
        }
        public bool IsGraduated { get; set; }
        //Khoi tao khong doi
        public Member()
        {
               
        }
        //Khoi tao co doi
        public Member(string firstName
            , string lastName
            , string gender
            , DateTime dateOfBirth
            , string phoneNumber
            , string birthPlace
            , bool isGraduated)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.PhoneNumber = phoneNumber;
            this.BirthPlace = birthPlace;
            this.IsGraduated = isGraduated;
        }
        
        public string MemberInFo()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-20}{4,-15}{5,-12}{6,-10}"
                , FirstName, LastName, Gender, DateOfBirth, PhoneNumber, BirthPlace, IsGraduated);
        }
    }
}