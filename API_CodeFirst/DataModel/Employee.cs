﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public partial class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public long MobileNo { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long EmergencyContactNo { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string Designation { get; set; }
        public float Salary { get; set; }
        //public Guid DepartmentID { get; set; }
        //[ForeignKey("DepartmentID")]
        //public Department Department { get; set; }
    }
}
