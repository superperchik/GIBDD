using GIBDD_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIBDD_API.Models
{
    public class ResponseGIBDD
    {
        public ResponseGIBDD (Driver driver)
        {
            id = driver.id;
            name = driver.name;
            middlename = driver.middlename;
            fathersname = driver.fathersname;
            passportnumber = driver.passportnumber;
            passportserial = driver.passportserial;
            postcode = driver.postcode;
            address = driver.address;
            addresslife = driver.addresslife;
            company = driver.company;
            jobname = driver.jobname;
            phone = driver.phone;
            email = driver.email;
            description = driver.description;
           // image = driver.image.ToList().FirstOrDefault()?.ImageSourse;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public string fathersname { get; set; }
        public string passportserial { get; set; }
        public string passportnumber { get; set; }
        public Nullable<int> postcode { get; set; }
        public string address { get; set; }
        public string addresslife { get; set; }
        public string company { get; set; }
        public string jobname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
    }
}