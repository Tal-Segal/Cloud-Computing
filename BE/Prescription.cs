﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        [DisplayName ("Doctor First Name")]
        public string DoctorFirstName { get; set; }
        [DisplayName("Doctor Last Name")]
        public string DoctorLastName { get; set; }
        public Medicine medicine { get; set; }
        [DisplayName("Begin Time")]
        public DateTime BeginTime { get; set; }
        [DisplayName("Finish Time")]
        public DateTime FinishTime { get; set; }
        public Prescription() { }
        public Prescription(int patientId, string doctorFirstName, string doctorLastName, Medicine medicine1, DateTime beginTime, DateTime finishTime)
        {
            PatientId = patientId;
            DoctorFirstName =doctorFirstName;
            DoctorLastName = doctorLastName;
            medicine = medicine1;
            BeginTime = beginTime;
            FinishTime = finishTime;

        }
        public Prescription(Prescription prescription)
        {
            PatientId = prescription.PatientId;
            DoctorFirstName = prescription.DoctorFirstName;
            DoctorLastName = prescription.DoctorLastName;
            medicine = prescription.medicine;
            BeginTime = prescription.BeginTime;
            FinishTime = prescription.FinishTime;
        }

    }
}
