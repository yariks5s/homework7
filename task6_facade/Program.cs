namespace task6_facade
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Homework facade = new Homework();
            facade.OOP();
            facade.Matlog();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class RewievTheLecture
    {
        public void Lecture()
        {
            Console.WriteLine(" RewievTheLecture Method");
        }
    }

    // Subsystem ClassB" 
    class MakeLab
    {
        public void Lab()
        {
            Console.WriteLine(" MakeLab Method");
        }
    }


    // Subsystem ClassC" 
    class MakeTasks
    {
        public void Tasks()
        {
            Console.WriteLine(" MakeTasks Method");
        }
    }
    // Subsystem ClassD" 
    class SolveModule
    {
        public void Module()
        {
            Console.WriteLine(" SolveModule Method");
        }
    }
    // "Homework" 
    class Homework
    {
        RewievTheLecture lecture;
        MakeLab lab;
        MakeTasks tasks;
        SolveModule module;

        public Homework()
        {
            lecture = new RewievTheLecture();
            lab = new MakeLab();
            tasks = new MakeTasks();
            module = new SolveModule();
        }

        public void OOP()
        {
            Console.WriteLine("\nOOP() ---- ");
            lecture.Lecture();
            lab.Lab();
            tasks.Tasks();
        }

        public void Matlog()
        {
            Console.WriteLine("\nMatlog() ---- ");
            lecture.Lecture();
            tasks.Tasks();
            module.Module();
        }
    }
}