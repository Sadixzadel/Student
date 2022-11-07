using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Student1;

public class Student
{
    public string FirstName;
    public string LastName;
    public string Group;
    public double AverageMark;

    public Student(string firstName, string lastName, string group, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        AverageMark = averageMark;
    }

    public double GetScholarship()
    {
        if (AverageMark == 5)
        {
            return 100;
        }
        else
        {
            return  80;
        }
        
    }
}
public class Aspirant : Student
{
    public string ScientificWork { get; set; }
    public Aspirant(string firstName, string lastName, string group, double averageMark, string scientificWork) : base(firstName, lastName, group, averageMark)
    {
        ScientificWork = scientificWork;
    }

    public new double GetScholarship()
    {
        if (AverageMark == 5)
        {
            return 100;
        }
        else
        {
            return 80;
        }

    }
}

