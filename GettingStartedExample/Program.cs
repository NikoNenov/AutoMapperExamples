//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2022 Nikolay Nenov, Solothurn, Switzerland
//  </copyright>
// 
//  <summary>
//    Getting started example: How do I use AutoMapper
//  </summary>
// 
//  <date>17-02-2022</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using AutoMapper;
using GettingStartedExample.Models;

namespace GettingStartedExample
{
  public class Program
  {
    private static Mapper _mapper;

    public static void Main(string[] args)
    {
      Console.WriteLine("*** Getting started with AutoMapper! ***");

      // Initialize the mapper
      InitializeAutoMapper();
      
      // Creating the source object
      var employee = new Employee
      {
        Name = "James",
        Salary = 15000,
        Address = "London",
        Department = "IT"
      };
      Console.WriteLine($"1) Obj -> Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}, Department: {employee.Department}");

      // Using AutoMapper
      var employeeDTO = UseAutoMapper(employee);
      
      Console.WriteLine($"2) DTO -> Name: {employeeDTO.Name}, Salary: {employeeDTO.Salary}, Address: {employeeDTO.Address}, Department: {employeeDTO.Department}");
      Console.ReadLine();
    }

    /// <summary>
    /// Initialize AutoMapper configuration
    /// </summary>
    private static void InitializeAutoMapper()
    {
      // Initialize the AutoMapper
      var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());
      _mapper = new Mapper(config);
    }


    /// <summary>
    /// Using object-object mapper
    /// </summary>
    /// <param name="employee"></param>
    /// <returns>Employee DTO object</returns>
    private static EmployeeDTO UseAutoMapper(Employee employee)
    {
      // Using AutoMapper
      var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
      
      // OR
      // var employeeDTO2 = mapper.Map<Employee, EmployeeDTO>(emp);

      return employeeDTO;
    }
  }
}
