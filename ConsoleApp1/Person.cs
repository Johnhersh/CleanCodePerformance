using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1;

public class Person
{
    [Range(20, 100, ErrorMessage = "Age must be between 20 and 100")]
    public int Age { get; set; }
}