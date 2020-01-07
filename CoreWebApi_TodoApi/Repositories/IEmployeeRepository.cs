using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi_TodoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi_TodoApi.Repositories
{
    public interface IEmployeeRepository<T> where T:class
    {
         IEnumerable<T> GetAllEmployees();
    }
}
