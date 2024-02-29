using Azure.Core;
using JWTPractice.Context;
using JWTPractice.Interfaces;
using JWTPractice.Models;

namespace JWTPractice.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _jwtContext;
        public EmployeeService(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _jwtContext.Employees.Add(employee);
            _jwtContext.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
                if (emp == null) throw new Exception("User not found");
                else
                {
                    _jwtContext.Employees.Remove(emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Employee> GetEmployeeDetails()
        {
            var  emp = _jwtContext.Employees.ToList();
            return emp;
        }

        public Employee GetEmployeeDetails(int id)
        {
            var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
            return emp;

        }

        public Employee UpdateEmployee(Employee employee)
        {
           var updatedEmp = _jwtContext.Employees.Update(employee);
            _jwtContext.SaveChanges();
            return updatedEmp.Entity;

        }
    }
}
