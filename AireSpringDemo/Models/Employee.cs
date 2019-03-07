using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace AireSpringDemo.Models
{
    
    [Table("Employees")]
    public class Employee
    {

        
        private Guid employeeId;
        [Required]
        private string firstName;
        [Required]
        private string lastName;
        [Phone]
        private string phoneNumber;
        private int zip;
        [Required, MaxLength(2), MinLength(2), Range(1,31)]
        private int hireDay;
        [Required, MaxLength(2), MinLength(2), Range(1,12)]
        private int hireMonth;
        [Required, MinLength(4), MaxLength(4), Range(2000, 2019)]
        private int hireYear;
        private DateTime hireDate;


        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int phoneNumber, int zip, int hireDay, int hireMonth, int hireYear)
        {
            employeeId = new Guid();
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = string.Format("{0:(###) ###-####}", phoneNumber);;
            this.zip = zip;
            this.hireDay = hireDay;
            this.hireMonth = hireMonth;
            this.hireYear = hireYear;
            
            this.hireDate = new DateTime(hireYear, hireMonth, hireDay);
         

        }

        public Guid EmployeeId
        {
            set => employeeId = value;
            get => employeeId;
           
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