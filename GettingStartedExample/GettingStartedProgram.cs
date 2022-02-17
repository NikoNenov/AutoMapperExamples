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
  public class GettingStartedProgram
  {

    public static void Main(string[] args)
    {
      Console.WriteLine("*** Getting started with AutoMapper! ***");


      // Initialize the mapper
      var mapper = InitializeAutoMapper();
      
      // Creating the source object
      var employee = new Employee
      {
        Name = "James",
        Salary = 15000,
        Address = "London",
        Department = "IT"
      };
      Console.WriteLine($"1) Employee     -> Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}, Department: {employee.Department}");

      // Using AutoMapper
      var employeeDTO = mapper.Map<EmployeeDTO>(employee);
      Console.WriteLine($"2) Employee DTO -> Name: {employeeDTO.Name}, Salary: {employeeDTO.Salary}, Address: {employeeDTO.Address}, Department: {employeeDTO.Department}");

      // 3) What will happen if the source and destination property names are different?
      var memberDTO = mapper.Map<Employee, MemberDTO>(employee);
      Console.WriteLine($"3) Member DTO   -> Name: {memberDTO.FullName}, Salary: {memberDTO.Salary}, Address: {memberDTO.Address}, Department: {memberDTO.Dept}");

      // 4) How to map two properties when the names are different using AutoMapper?
      var staffMemberDTO = mapper.Map<StaffMemberDTO>(employee);
      Console.WriteLine($"4) StaffMember  -> Name: {staffMemberDTO.FullName}, Salary: {staffMemberDTO.Salary}, Address: {staffMemberDTO.Address}, Department: {staffMemberDTO.Dept}");


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
        // Using AutoMapper
        cfg.CreateMap<Employee, EmployeeDTO>();

        // 3) What will happen if the source and destination property names are different?
        cfg.CreateMap<Employee, MemberDTO>();

        // 4) How to map two properties when the names are different using AutoMapper?
        cfg.CreateMap<Employee, StaffMemberDTO>()
          .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
          .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department));
      });

      return new Mapper(config);
    }
  }
}
