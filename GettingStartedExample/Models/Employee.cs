//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Employee model
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace GettingStartedExample.Models
{
  public class Employee
  {
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public string Department { get; set; }
  }
}