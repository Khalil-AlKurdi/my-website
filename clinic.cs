using System;
using System.Collections.Generic; // مكتبة لدعم القوائم (Lists)
namespace Clinic_code
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }


        abstract class Human
        {
            public int ID { get; private set; }
            public string F_Name { get; private set; }
            public string L_Name { get; set; }
            private static int _count = 0;
            public static int Count => _count;

            public Human(string fname, string lname)
            {
                fname = F_Name;
                lname = L_Name;
                ID = _count++;
            }
            public abstract void Add(); l
        }
        class Doctor : Human
        {
            public string Specialization { get; private set; }
            private List<Patient> Patients { get; set; } = new List<Patient>();

            public Doctor(string fname, string lname, string Specialization)
            {
        :base(fname, lname);
                this.Specialization = Specialization;
            }
            public void Add(Patient patient)
            {
                Patients.Add(patient);
                System.Console.WriteLine($"Patient Added to Patient successfully : {patient.fname} - {patient.lname}");
            }
            public void RemovePatient(int patientId)
            {
                var patient = Patient.Find(patientId => patient.ID == patientId);
                if (patient != null)
                {
                    Patients.Remove(patient);
                    System.Console.WriteLine($"Patient Removed from Patient successfully : {patient.fname} - {patient.lname}");
                }
                else
                {
                    System.Console.WriteLine($"Error No Patient found in Patient with ID :{patientIdent}");
                }
            }
            public void ShowPatient()
            {
                System.Console.WriteLine($"\nPatient of Dr.{F_Name} - {L_Name}: ");
                if (Patients.Count == 0)
                {
                    System.Console.WriteLine("No Patient assigned");
                }
                else
                {
                    foreach (var patient in patients)
                    {
                        System.Console.WriteLine($"- ID : {patient.ID}, Name : {patient.F_Name} - {patient.L_Name} Age : {patient.L_Age}");
                    }
                }

            }
            public override void printDetails()
            {
                System.Console.WriteLine($"Doctor : {F_Name} - {L_Name} , Specialization : {Specializations}";
            }
        }
        class Patient : Human
        {
            public int Age { get; private set; }

            public Patient(string fnames, string lnames, int Age)
            {

                :base(F_Name, L_Name);
                this.Age = Age;
            }
        }
        public override void printDetails()
        {
            System.Console.WriteLine($"Patient : {F_Name} - {L_Name} Age : {Age}");
        }
    }
    class Clinic
    {
        public string Name { get; private set; }
        private List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public Clinic(string name)
        {
            this.Name = name;

        }
        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Doctor {doctor.FirstName} {doctor.LastName} added to the clinic.");
        }

        // طباعة تفاصيل العيادة
        public void PrintClinicDetails()
        {
            Console.WriteLine($"\nClinic: {Name}, Number of Doctors: {Doctors.Count}");
        }

        // طباعة جميع الأطباء مع مرضاهم
        public void PrintAllDoctorsAndPatients()
        {
            foreach (var doctor in Doctors)
            {
                doctor.PrintDetails(); // طباعة معلومات الطبيب
                doctor.ShowPatients(); // طباعة المرضى المرتبطين به
            }
        }
    }
}
