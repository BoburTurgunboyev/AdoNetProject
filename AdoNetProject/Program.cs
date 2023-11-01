using AdoNetProject.Models;

namespace AdoNetProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EmployeeService employee = new EmployeeService();

            //List<string> strings = new List<string>() { "Sanjarbek", "Alisher", "Javohir", "Jonibek", "Mahmud", "Mohir", "Sariq Dev", "Najot Ta'lim", "PDP", "Udevs" };

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() { Id = 1,Name = "Sanjarbek",Surname = "Berdikulov",Email="bsanjarbek06@gmail.com",Password="Sanjarbek2060",Login="Berdikulov"},
            //    new Employee() { Id = 2,Name = "Alisher",Surname = "Boltaboyev",Email="Alisher@gmail.com",Password="Alisher",Login="Boltaboyev"},
            //    new Employee() { Id = 3,Name = "Javohir",Surname = "Bo'riyev",Email="Javohir@gmail.com",Password="Bo'riyev",Login="Bo'riyev"},
            //    new Employee() { Id = 4,Name = "Jonibek",Surname = "Minorov",Email="Jonibek@gmail.com",Password="Alisher",Login="Aliyev"},
            //    new Employee() { Id = 5,Name = "Jon",Surname = "Aliyev",Email="Jon@gmail.com",Password="Aliyev",Login="Memati"},
            //    new Employee() { Id = 6,Name = "Muslim",Surname = "Memati",Email="Memati@gmail.com",Password="Toshtemirov",Login="Memati"},
            //    new Employee() { Id = 7,Name = "Amor",Surname = "Toshtemirov",Email="Toshtemirov@gmail.com",Password="Sanjarbek2060",Login="Toshtemirov"},
            //    new Employee() { Id = 8,Name = "Asliddin",Surname = "Eshmatov",Email="Asliddin@gmail.com",Password="Asliddin",Login="Eshmatov"},
            //    new Employee() { Id = 1,Name = "Mirjalol",Surname = "Nematov",Email="Nematov@gmail.com",Password="Mirjalol",Login="Nematov"},
            //};

            //List<Employee> employees2 = new List<Employee>()
            //{
            //    new Employee() { Id = 1,Name = "Sanjarbek",Surname = "Berdikulov",Email="bsanjarbek06@gmail.com",Password="Sanjarbek2060",Login="Berdikulov"},
            //    new Employee() { Id = 2,Name = "Alisher",Surname = "Boltaboyev",Email="Alisher@gmail.com",Password="Alisher",Login="Boltaboyev"},
            //    new Employee() { Id = 3,Name = "Javohir",Surname = "Bo'riyev",Email="Javohir@gmail.com",Password="Bo'riyev",Login="Bo'riyev"},
            //    new Employee() { Id = 4,Name = "Jonibek",Surname = "Minorov",Email="Jonibek@gmail.com",Password="Jonibek",Login="Aliyev"},
            //    new Employee() { Id = 5,Name = "Jon",Surname = "Aliyev",Email="Jon@gmail.com",Password="Aliyev",Login="Memati"},
            //    new Employee() { Id = 6,Name = "Muslim",Surname = "Memati",Email="Memati@gmail.com",Password="Toshtemirov",Login="Memati"},
            //    new Employee() { Id = 7,Name = "Amor",Surname = "Toshtemirov",Email="Toshtemirov@gmail.com",Password="Sanjarbek2060",Login="Toshtemirov"},
            //    new Employee() { Id = 8,Name = "Asliddin",Surname = "Eshmatov",Email="Asliddin@gmail.com",Password="Asliddin",Login="Eshmatov"},
            //    new Employee() { Id = 1,Name = "Mirjalol",Surname = "Nematov",Email="Nematov@gmail.com",Password="Mirjalol",Login="Nematov"},
            //};

            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };

            //List<int> ints2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> aralashInts = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 2, 3, 2, 3, 5, 6, 7, 5, 6, 7, 5, 4, 3, 6, 7, 8, 9, 9 };


            //List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };


            //List<Student> students = new List<Student>()
            //{
            //    new Student() {Id = 1,firstName = "Sanjarbek",lastName = "Berdikulov",uquvShakli="Kunduzgi"},
            //    new Student() {Id = 2,firstName = "Bahriddin",lastName = "Abdusalomov",uquvShakli="Kechgi"},
            //    new Student() {Id = 3,firstName = "Sardor",lastName = "Sohibnazarov",uquvShakli="Kunduzgi"},
            //    new Student() {Id = 4,firstName = "Sarvar",lastName = "Murodovich",uquvShakli="Kechgi"},
            //    new Student() {Id = 5,firstName = "Jonibek",lastName = "Turdiyev",uquvShakli="Kunduzgi"},
            //    new Student() {Id = 6,firstName = "Jonibek",lastName = "Turdiyev",uquvShakli="Bilmadim"},
            //};

            //List<Teacher> teachers = new List<Teacher>()
            //{
            //    new Teacher() {Id = 1,firstName = "Kamoliddin",lastName = "Bekmirzayev",uquvShakli="Kunduzgi"},
            //    new Teacher() {Id = 2,firstName = "MuhammadAbdulloh",lastName = "Komilov",uquvShakli="Kechgi"},
            //};


            //var res = students.IntersectBy(teachers.Select(x => x.Id),x => x.Id);

            //foreach (var i in res)
            //{
            //    Console.WriteLine(i.firstName);
            //}




            //employee.DeleteEmployee(7);

            //EmployeeDTO em = new EmployeeDTO();

            //employee.GetEmployeeById(7);

            //em.Name = "sanjarbek";
            //em.Surname = "berdikulov";
            //em.Email = "alisher@gmail.com";
            //em.Login = "ali";
            //em.Password = "alisher1980";
            //em.Role = Enums.Role.Admin;

            //employee.CreateEmployee(em);

            //employee.UpdateEmployee(6, em);
            //employee.EmployeeDeepDelete(8);
        }
    }
    //class Teacher
    //{
    //    public int Id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public string uquvShakli { get; set; }
    //}
    //class Student
    //{
    //    public int Id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public string uquvShakli { get; set; }
    //}
}