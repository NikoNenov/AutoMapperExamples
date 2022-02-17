//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Employee model (Data transfer object)
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace ComplexMappingExample.Models
{
  public class EmployeeDTO
  {
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }
    
    public AddressDTO AddressDTO { get; set; }
  }
}
