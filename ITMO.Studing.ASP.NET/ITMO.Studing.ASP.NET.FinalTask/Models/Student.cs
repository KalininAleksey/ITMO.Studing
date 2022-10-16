using ITMO.Studing.ASP.NET.FinalTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace ITMO.Studing.ASP.NET.FinalTask
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не указана фамилия")]
        [MaxLength(30)]
        public string LastName { get; set; }
        public int scoreSum { get; set; }
        public virtual List<StudentPerfomance> studentPerfomance { get; set; }
        public Student()
        {
            studentPerfomance = new List<StudentPerfomance>();
        }
        public override string ToString()
        {
            string s ="N"+StudentId+" "+FirstName + " " + LastName;
            return s;
        }
        public string ToStrScores()
        {
            string s = "сумма баллов = " + scoreSum;
            return s;
        }
        public void scoresum(StudentPerfomance perf)
        {
            scoreSum = scoreSum+perf.score;
        }
    }
}