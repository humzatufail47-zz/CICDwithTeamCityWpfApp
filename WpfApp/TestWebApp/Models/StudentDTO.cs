using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    /// <summary>
    /// Class Contains the Student Data
    /// </summary>
    public class StudentDTO
    {
        /// <summary>
        /// Name Property of the Student
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Last name Property of the Student
        /// </summary>
        public String Lastname { get; set; }

        /// <summary>
        /// Gender of the Student
        /// </summary>
        public String  Gender { get; set; }

        /// <summary>
        /// CNIC of the Student
        /// </summary>
        public String CNIC { get; set; }

        /// <summary>
        /// This method init the students DTO
        /// </summary>
        public void Init()
        {
            Debug.WriteLine("Init Method");
        }
    }
}