using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi_TodoApi.Models;
using CoreWebApi_TodoApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi_TodoApi.Repositories
{
    public class EmployeeRepository_EFCore : IEmployeeRepository<Employee>
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository_EFCore(EmployeeContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
