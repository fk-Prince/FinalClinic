using System;
using System.Collections.Generic;

namespace ClinicSystem
{
    public class Operation
    {
        private string operationCode;
        private string operationName;
        private DateTime dateAdded;
        private string description;
        private double price;
        private TimeSpan duration;
        private List<Doctor> doctor= new List<Doctor>();

        public Operation(string operationCode, string operationName, DateTime dateAdded, string description, double price, TimeSpan duration)
        {
            this.operationCode = operationCode;
            this.operationName = operationName;
            this.dateAdded = dateAdded.Date;
            this.description = description;
            this.price = price;
            this.duration = duration;
        }
      
        public string OperationCode { get => operationCode;}
        public string OperationName { get => operationName; }
        public DateTime DateAdded { get => dateAdded; }
        public string Description { get => description;  }
        public double Price { get => price;  }
        public TimeSpan Duration { get => duration;}

        public List<Doctor> Doctor { get => doctor; set => doctor = value; }
    }
}