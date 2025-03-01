using NtokotoStudyGroup.Models;
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
                    Student_Number = "u22671944",
                    Student_Name = "Ayanda",
                    Student_Surname = "Mosina",
                    Student_Email = "u22671944@tuks.co.za"

                },
                new StudentTable
                {
                    Student_Number = "u19676218",
                    Student_Name = "Natasha",
                    Student_Surname = "Mbele",
                    Student_Email = "u19676218@tuks.co.za"

                },
                new StudentTable
                {
                    Student_Number = "u24633629",
                    Student_Name = "Sindy",
                    Student_Surname = "Ndlovu",
                    Student_Email = "u24633629@tuks.co.za"

                },
                new StudentTable
                {
                    Student_Number = "u23671897",
                    Student_Name = "Leromo",
                    Student_Surname = "Nkosi",
                    Student_Email = "u23671897@tuks.co.za"

                },
                new StudentTable
                {
                    Student_Number = "u23543922",
                    Student_Name = "Lerato",
                    Student_Surname = "Nhlungwani",
                    Student_Email = "u23543922@tuks.co.za"

                }
            };
            return View(newStudent);
        }
    }
}