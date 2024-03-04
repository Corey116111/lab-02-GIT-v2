using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
    вариант 1 https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?pli=1

 */
namespace ClassLibrary
{
    public class Lesson
    {
        private string date;
        private string refDiscipline;
        private string refEmployee;
        private string refClassroom;
        private string refGroup;
        private string refPair;
        private string refTypeOfActivity; /// 14 варианта у нас нет

        public Lesson(string date, string refDiscipline, string refEmployee, string refClassroom, string refGroup, string refPair, string refTypeOfActivity)
        {
            this.date = DateTime.Today.ToString();
            this.refDiscipline = refDiscipline;
            this.refEmployee = refEmployee;
            this.refClassroom = refClassroom;
            this.refGroup = refGroup;
            this.refPair = refPair;
            this.refTypeOfActivity = refTypeOfActivity;
        }
    }
}
