using AdoNetProject.Dtos;

namespace AdoNetProject.Interfaces
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(EmployeeDTO employee);
        void UpdateEmployee(int EmployeeId, EmployeeDTO employee);
        void DeleteEmployee(int EmployeeId);
        void EmployeeDeepDelete(int EmployeeId);
        void GetAllEmployees();
        void GetEmployeeById(int EmployeeId);
    }
}
