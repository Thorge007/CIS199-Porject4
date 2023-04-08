//Grading ID: S0941
//CIS 199-02
//Program 4
//Due: (4/18/21)
//This assignment creates a repair record for a auto repair company. Uses 2 classes, methods and arrays. Includes example data set and updated data set.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class RepairRecord
    {
        //backing fields
        private int _serviceLocationZip;
        private string _makeModel;
        private string _serialNumber;
        private int _modelYear;
        private int _appointmentLength;
        private string _technicianName;
        private bool _warrantyCoverage;

        private const int flatFee = 25; //default flat fee if warranty coverage = false
        private const double costPerMinute = 1.50; //cost per minute if warranty coverage = false
        private const int coverageCharge = 20; //cost if warranty coverage = true
        private const int defaultZip = 40204; //default zipcode if entered zipcode is not between 00000 and 99999
        private const string defaultMake = "Unknown Make/Model"; //default value is entered make/model is invalid
        private const string defaultSerialNumber = "A000000000"; //default value is entered Serial Number is invalid
        private const int defaultAppointmentLength = 30; //default value is entered Appointment Length is invalid
        private const string defaultTechnicianName = "John Smith"; //default value is entered Technician Name is invalid

        public int appointmentHours; //variable to hold appartment hours value
        private double cost; //variable to hold cost value after calculation

        // Precondition: None
        // Postcondition: The RepairRecord object has been initialized with the specified
        //                Zip
        public RepairRecord(int zipCode, int modelYear, string makeModel, string serialNumber, int appointmentLength, string technicianName, bool warrantyCoverage)
        {
            //Properties set these to check for invalid data
            ZipCode = zipCode;
            MakeModel = makeModel;
            SerialNumber = serialNumber;
            TechnicianName = technicianName;
            AppointmentLength = appointmentLength;
            ModelYear = modelYear;
            WarrantyCoverage = warrantyCoverage;

        }

        public int ZipCode
        {
            // Precondition: None
            // Postcondition: The Zipcode has been returned
            get
            {
                return _serviceLocationZip;
            }
            // Precondition: 00000 <= value <= 99999 OR set to default value (40204)
            // Postcondition: The Zip code is set to that specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _serviceLocationZip = value;
                else
                    _serviceLocationZip = defaultZip;
            }
    
        }

        public string MakeModel
        {
            // Precondition: None
            // Postcondition: The Make/Model has been returned
            get
            {
                return _makeModel;
            }
            // Precondition: Can't be empty
            // Postcondition: The Make/Model is set to that specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _makeModel = value;
                else
                    _makeModel = defaultMake;
            }

        }

        public string SerialNumber
        {
            // Precondition: None
            // Postcondition: The SerialNumber has been returned
            get
            {
                return _serialNumber;
            }
            // Precondition: Value = 10
            // Postcondition: The Serial Number is set to that specified value
            set
            {
                if (value.Length == 10)
                    _serialNumber = value;
                else
                    _serialNumber = defaultSerialNumber;

            }

        }

        public string TechnicianName
        {
            // Precondition: None
            // Postcondition: The Technician Name has been returned
            get
            {
                return _technicianName;
            }
            // Precondition: Can't be empty
            // Postcondition: The Technician name is set to that specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _technicianName = value;
                else
                    _technicianName = defaultTechnicianName;
            }

        }

        public int AppointmentLength
        {
            // Precondition: None
            // Postcondition: The Appointment Length has been returned
            get
            {
                return _appointmentLength;
            }
            // Precondition: 15 <= value <= 180 OR set to default value (30)
            // Postcondition: The Appointment Length is set to that specified value
            set
            {
                if (value >= 15 && value <= 180)
                    _appointmentLength = value;
                else
                    _appointmentLength = defaultAppointmentLength;
            }

        }

        public double AppointmentHours
        {
            // Precondition: Length int is divided by 60
            // Postcondition: Appointment length converted to hours and returned
            get
            {
                appointmentHours = _appointmentLength / 60;
                return appointmentHours;
            }
        }

        public int ModelYear
        {
            // Precondition: None
            // Postcondition: The Model Year is returned
            get
            {
                return _modelYear;
            }
            // Precondition: None
            // Postcondition: The Model Year is set to that specified value
            set
            {
                _modelYear = value;
            }

        }

        public bool WarrantyCoverage
        {
            // Precondition: None
            // Postcondition: The Warranty has been returned (can be true or false)
            get
            {
                return _warrantyCoverage;
            }
            // Precondition: Warranty must be true or false
            // Postcondition: Warranty is set to that specified value (true or false)
            set
            {
                _warrantyCoverage = value;
            }

        }

        //Method that calculates cost based on if there is warranty coverage or not
        public double calcCost()
        {
            if (WarrantyCoverage == true)
                cost = coverageCharge;
            else
                cost = flatFee + (costPerMinute * AppointmentLength);
            return cost; //returns a double named cost
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the data in the Repair record array
        //                ZipCode, ModelYear, MakeModel, Serial Number, Appointment Length, Appointment Hours, Technician Name, Warranty Coverage
        public override string ToString()
        {
            string objectString;

            // The formatted string to be returned
            objectString = $"{"\nService Location Zip Code: " + ZipCode + "\nYear: " + ModelYear + "\nMake and Model: " + MakeModel + "\nSerial Number: " + SerialNumber + "\nAppointment Length: " + AppointmentLength + "\nAppointment Hours: " + AppointmentHours + "\nTechnician Name: " + TechnicianName + "\nWarranty Coverage?: " + WarrantyCoverage} ";

            return objectString;
        }
    }
}
