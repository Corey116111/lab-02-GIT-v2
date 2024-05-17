using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class TypeOfActivity
    {
        public char Letter { get; set; }
        public string Name { get; set; }

        public TypeOfActivity(char letter, string name)
        {
            Letter = letter;
            Name = name;
        }

        static TypeOfActivity()
        {
            Typesofactivities = new List<TypeOfActivity>
            {
                new TypeOfActivity('A', "Activity A"),
                new TypeOfActivity('B', "Activity B"),
                // Добавьте другие типы активности
            };
        }

        public static readonly List<TypeOfActivity> Typesofactivities;
    }
}