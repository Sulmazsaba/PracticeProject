using System;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Prototype
{
    public class Address :ICloneable
    {
        public string StreetName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}