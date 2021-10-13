using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace School.Core.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")] 
        public Grade Grade { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public Class Class { get; set; }
        public DateTime TeachingFrom { get; set; }
    }
}
