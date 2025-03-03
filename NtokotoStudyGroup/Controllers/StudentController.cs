using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NtokotoStudyGroup.Models;

namespace NtokotoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<StudentTable> newStudent = new List<StudentTable>
            {
                new StudentTable
                {
                    Student_Number = "u23671922",
                    Student_Name = "Tshami",
                    Student_Surname = "Mongwe",
                    Student_Email = "u23671922@tuks.co.za"
                },
                new StudentTable
                {
                    Student_Number = "u23345931",
                    Student_Name = "Ayanda",
                    Student_Surname = "Zulu",
                    Student_Email = "u23345931@tuks.co.za"
                },
                new StudentTable
                {
                    Student_Number = "u22671988",
                    Student_Name = "Zinhle",
                    Student_Surname = "Mthembu",
                    Student_Email = "u22671988@tuks.co.za"
                },
                new StudentTable
                {
                    Student_Number = "u25671900",
                    Student_Name = "Natasha",
                    Student_Surname = "Ndlovu",
                    Student_Email = "u25671900@tuks.co.za"
                },
new StudentTable
                {
                    Student_Number = "u23678762",
                    Student_Name = "Hlangi",
                    Student_Surname = "Ngobeni",
                    Student_Email = "u23678762@tuks.co.za"
                },


            };

            return View(newStudent);
        }
    }
}