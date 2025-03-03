using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NtokotoStudyGroup.Models
{
    public class StudentTable
    {
        [DisplayName("STUDENT NUMBER")]
        public string Student_Number { get; set; }

        [DisplayName("NAME")]
        public string Student_Name { get; set; }

        [DisplayName("SURNAME")]
        public string Student_Surname { get; set; }

        [DisplayName("EMAIL ADDRESS")]
        public string Student_Email { get; set; }
    }
}