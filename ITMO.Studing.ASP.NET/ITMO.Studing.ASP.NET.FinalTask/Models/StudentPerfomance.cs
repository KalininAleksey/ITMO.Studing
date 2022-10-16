using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;

namespace ITMO.Studing.ASP.NET.FinalTask.Models
{
    public class StudentPerfomance
    {
        [Required]
        public int StudentPerfomanceId { get; set; }
        [Required(ErrorMessage = "Не указан студент")]
        public int studentId { get; set; }
        public Student student { get; set; }
        [Required(ErrorMessage = "Не указана дисциплина")]
        [MaxLength(30)]
        public string examName { get; set; }
        [Required(ErrorMessage = "Не указана оценка")]
        public byte score { get; set; }
        public DateTime TestDate { get; set; }
        public override string ToString()
        {
            student.ToString();
            string s =  TestDate+" получена оценка "+ score + " по дисциплине " + examName;
            return s;
        }

    }
}