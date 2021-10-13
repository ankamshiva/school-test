using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace School.Core.Models
{
    public class Student
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
    }

    public enum Grade
    {
        [EnumMember(Value = "Grade1")]
        Grade1,
        [EnumMember(Value = "Grade2")]
        Grade2,
        [EnumMember(Value = "Grade3")]
        Grade3,
        [EnumMember(Value = "Grade4")]
        Grade4
    }
    public enum Class
    {
        [EnumMember(Value = "Class1")]
        Class1,
        [EnumMember(Value = "Class2")]
        Class2,
        [EnumMember(Value = "Class3")]
        Class3,
        [EnumMember(Value = "Class4")]
        Class4
    }
}
