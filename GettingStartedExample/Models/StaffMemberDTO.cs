//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Staff member model. It is similar to employee class, but some properties (FullName and Dept) have different names.
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace GettingStartedExample.Models
{
  public class StaffMemberDTO
  {
    public string FullName { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public string Dept { get; set; }
  }
}
