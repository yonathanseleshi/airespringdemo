using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace AireSpringDemo.Models
{
    public class Employee
    {

        private Guid userID;
        [Required]
        private string firstName;
        [Required]
        private string lastName;
        private string phoneNumber;
        private int zip;
        [Required, MaxLength(2), MinLength(2)]
        private int hireDay;
        [Required, MaxLength(2), MinLength(2)]
        private int hireMonth;
        [Required, MinLength(4), MaxLength(4)]
        private int hireYear;
        private DateTime hireDate;

     
        public Employee(string firstName, string lastName, int phoneNumber, int zip, int hireDay, int hireMonth, int hireYear)
        {
            userID = new Guid();
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = $"{phoneNumber:(###) ###-####}";;
            this.zip = zip;
            this.hireDay = hireDay;
            this.hireMonth = hireMonth;
            this.hireYear = hireYear;
            String dateString = $"{hireMonth}/{hireDay}/{hireYear}";
            string format = "MM/dd/yyyy";
            this.hireDate = DateTime.ParseExact(dateString, format, CultureInfo.CurrentCulture);
        }

        public Guid UserId
        {
            get => userID;
           
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public int Zip
        {
            get => zip;
            set => zip = value;
        }

        public DateTime HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }
        public int HireDay
        {
            get => hireDay;
            set => hireDay = value;
        }

        public int HireMonth
        {
            get => hireMonth;
            set => hireMonth = value;
        }

        public int HireYear
        {
            get => hireYear;
            set => hireYear = value;
        }





        
        
    }
}