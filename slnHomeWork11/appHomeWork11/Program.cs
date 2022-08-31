namespace appHomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            try
            {
                employee.SetAge();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+Environment.NewLine+e.StackTrace);
            }

            try
            {
                employee.SetName();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
            }

            try
            {
                employee.SetSlary();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
            }


           

                Console.WriteLine($"Имя = {employee.Name}");
                Console.WriteLine($"Возраст = {employee.Age}");
                Console.WriteLine($"Зарплата = {employee.Salary}");
        }
    }
}