namespace Cafeteria.Modules.Departments
{
    public class DepartmentsModule
    {
        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name, string description)
        {
            departments.Add(new Department { Name = name, Description = description });
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
    }

    public class Department
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
