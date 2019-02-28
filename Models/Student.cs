using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Myproject.Models
{
    public class Student
    {
        [Required(ErrorMessage="cant be empty")]
        [Display(Name="Student name")]
        //[RegularExpression()]
        public string Sname { get; set; }
        [Required(ErrorMessage = "cant be empty")]
        [Display(Name = "Student Adress")]
        [DataType(DataType.MultilineText)]
        public string Saddress { get; set; }
        [Required(ErrorMessage = "cant be empty")]
        [Display(Name = "email")]
        [DataType(DataType.EmailAddress)]
        public string Semail{ get; set; }
        public Gender Sgender { get; set; }
    }
        public enum Gender
        {
            Male,
            Female
        }


    }
