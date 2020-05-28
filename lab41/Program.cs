using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public class Test
{

    public class Student
    {

        private string name = "Stepan";
        private string lastName = "Boyko";
        private string group = "KT-21";
        private int year = 2020;
        private string address = "Lviv";
        private int passport = 131321323;
        private int age = 20;
        private int telephone = 0971234567;
        private int rating = 80;

        public Student()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setGroup(string group)
        {
            this.group = group;
        }

        public string getGroup()
        {
            return this.group;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setPassport(int passport)
        {
            this.passport = passport;
        }

        public int getPassport()
        {
            return this.passport;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setTelephone(int telephone)
        {
            this.telephone = telephone;
        }

        public int getTelephone()
        {
            return this.telephone;
        }

        public void setRating(int rating)
        {
            this.rating = rating;
        }

        public int getRating()
        {
            return this.rating;
        }


        public string studentRating(int R)
        {

            if (R >= 90)
            {
                return "Greet the excellent student";
            }
            else if (R >= 75)
            {
                return "You can study better";

            }
            else
            {
                return "You should spend more time studying";
            }
        }

        public void test_studentRating()
        {

            int a = 80;
            int b = 97;
            int c = 67;

            Console.WriteLine(studentRating(a));
            Console.WriteLine(studentRating(b));
            Console.WriteLine(studentRating(c));

        }
    }




    public static void Main()
    {

        Student st1 = new Student();

        st1.test_studentRating();

    }
}