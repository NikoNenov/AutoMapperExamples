//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Address model (Data transfer object)
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace ComplexMappingExample.Models
{
  public class AddressDTO
  {
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
  }
}
