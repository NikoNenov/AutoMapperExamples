
//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Complex mapping example.
//
//    When both the type involved in the mapping contains properties of the complex type then in such scenarios we need to use the AutoMapper Complex Mapping in C#.
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using AutoMapper;
using ComplexMappingExample.Models;

namespace ComplexMappingExample
{
  public class ComplexMappingProgram
  {

    public static void Main(string[] args)
    {
      Console.WriteLine("*** AutoMapper - Complex Mapping ***");


      // Initialize the mapper
      var mapper = InitializeAutoMapper();

      // Create and populate the Employee object
      var employeeAddress = new Address()
      {
        City = "Langendorf",
        State = "Solothurn",
        Country = "Switzerland"
      };

      var employee = new Employee
      {
        Name = "Tomas",
        Salary = 17000,
        Department = "IT",
        Address = employeeAddress
      };
      Console.WriteLine($"1) Employee     -> Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}, " +
                        $"City: {employee.Address.City}, State: {employee.Address.State}, Country: {employee.Address.Country}");

      // Using AutoMapper
      var employeeDTO = mapper.Map<EmployeeDTO>(employee);
      Console.WriteLine($"2) Employee DTO -> Name: {employeeDTO.Name}, Salary: {employeeDTO.Salary}, Department: {employeeDTO.Department}, " +
                        $"City: {employeeDTO.AddressDTO.City}, State: {employeeDTO.AddressDTO.State}, Country: {employeeDTO.AddressDTO.Country}");



      Console.ReadLine();
    }

    /// <summary>
    /// Initialize AutoMapper configuration
    /// </summary>
    private static Mapper InitializeAutoMapper()
    {
      // Initialize the AutoMapper
      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<Address, AddressDTO>();
        cfg.CreateMap<Employee, EmployeeDTO>()
          .ForMember(dest => dest.AddressDTO, act => act.MapFrom(src => src.Address));
      });

      return new Mapper(config);
    }

  }
}