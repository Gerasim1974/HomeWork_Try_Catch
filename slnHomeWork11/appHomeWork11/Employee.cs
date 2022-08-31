using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork11
{
    internal class Employee
    {
        int _age;
        string _name;
        double _salary;

        public Employee()
        {
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(); 
        }


        public int Age
        {
            get { return _age; }
            set
            {
                    if (value < 18)
                    {
                     throw new ArgumentOutOfRangeException("Дети до 18 лет не допускаются!");
                      
                }
                    else if (value > 125)
                    {
                    throw new ArgumentOutOfRangeException("Люди столько не живут!");
                }
                    else
                    {
                        _age = value;
                    }
            }
        }
        public void SetAge()
        {
            Console.WriteLine("введите возраст (целое число лет)");
            int age;
            try
            {
              age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new ArgumentException("Не является целым числом");
            }
            Age = age;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("пустое значение не допустимо");
                    }
                    else if ((value as String).Length > 125)
                    {
                        throw new ArgumentOutOfRangeException("имя не может привышать 125 символов");
                    }
                    else
                    {
                        _name = value;
                    }
            }
        }
        public void SetName()
        {
                Console.WriteLine("Введите имя не более 125 символов");
                Name = Console.ReadLine();
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                   if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Зарплата должна быть больше 0");
                    }
                   else
                    {
                        _salary = value;
                    }

            }
        }
        public void SetSlary()
        {
            double salary;
            try
            { 
                Console.WriteLine("Введите зарплату");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException("Зарплата должна быть числом");

            }
            Salary = salary;
        }
    }
}
