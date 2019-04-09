using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee JamesH = new Employee("James", "Hetfield", "Singer/Guitarist");
            Employee KirkH = new Employee("Kirk", "Hammet", "Guitarist");
            Employee RobertT = new Employee("Robert", "Trujillo", "Bassist");
            Employee LarsU = new Employee("Lars", "Ulrich", "Drummer");

            Company Metallica = new Company("Metallica");

            Metallica.Hire(JamesH);
            Metallica.Hire(KirkH);
            Metallica.Hire(RobertT);
            Metallica.Hire(LarsU);

            Metallica.Print();

            Employee AdamJ = new Employee("Adam", "Jones", "Guitarist");
            Employee MaynardK = new Employee("Maynard", "Keenan", "Singer");
            Employee DanyC = new Employee("Dany", "Carey", "Bassist");
            Employee JustinC = new Employee("Justin", "Chancellor", "Drummer");

            Company Tool = new Company("Tool");
            Tool.Hire(AdamJ);
            Tool.Hire(MaynardK);
            Tool.Hire(DanyC);
            Tool.Hire(JustinC);

            Tool.Print();
        }
    }
}
