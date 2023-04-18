using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorApp1.Classes
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Date InitialDate { get; set; }
        public Date CloseDate { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public int Employee_id { get; set; }
    }
}
