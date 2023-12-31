﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CourseEnrollment : BaseEntity
    {
        public CourseEnrollment()
        {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int CourseEnrollmentID { get; set; }

        [MaxLength(10)] // Max Length 10 karakter
        public string Grade { get; set; }

        [MaxLength(20)] // Max Length 20 karakter
        public string RegistrationStatus { get; set; }

        [MaxLength(20)] // Max Length 20 karakter
        public string CompletionStatus { get; set; }

        [MaxLength(200)] // Max Length 200 karakter
        public string Remark { get; set; }


        [ForeignKey("Student")] // Foreign Key
        public int? StudentID { get; set; }
        public virtual User Student { get; set; }

        [ForeignKey("Course")] // Foreign Key
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}
