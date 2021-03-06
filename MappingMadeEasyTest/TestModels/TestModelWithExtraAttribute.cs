﻿using System.Collections.Generic;
using MappingMadeEasy.Standard.Nuget.CustomDataAttributes;

namespace MappingMadeEasyTest.TestModels
{
    public class TestModelWithExtraAttribute
    {
        [MapToName("Name")]
        public string PersonName { get; set; }
        [MapToName("Age")]
        public int CurrentAge { get; set; }
        [MapToName("RandomData")]
        public List<string> RandomData { get; set; }
        [MapToName("Salary")]
        public double CurrentSalary { get; set; }
        [MapToName("HoursWorked")]
        public int HoursWorked { get; set; }
    }
}