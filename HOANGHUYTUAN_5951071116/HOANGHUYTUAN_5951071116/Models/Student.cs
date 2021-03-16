using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HOANGHUYTUAN_5951071116.Models
{
    public class Student
    {
        [DataMember(Name =  "Msv")]
        public string Msv { get; set; }
        [DataMember(Name = "Ten")]
        public string Ten { get; set; }
        [DataMember(Name = "DiaChi")]
        public string DiaChi { get; set; }
        [DataMember(Name = "Email")]
        public string Email { get; set; }
    }
}