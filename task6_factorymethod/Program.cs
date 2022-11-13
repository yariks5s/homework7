namespace task6
{
    //абстрактний клас творця, який має абстрактний метод FactoryMethod, що приймає тип продукта
    public abstract class Creator
    {
        public abstract Product FactoryMethod(int type);
    }

    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(int type)
        {
            switch (type)
            {
                //повертає об'єкт Book, якщо type==1
                case 1: return new Book();
                //повертає об'єкт Bread, якщо type==2  
                case 2: return new Bread();
                //повертає об'єкт Water, якщо type==3  
                case 3: return new Water();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    public abstract class Product 
    {
        int price, quantity;
    } //абстрактний клас продукт

    //конкретні продукти з різною реалізацією
    public class Book : Product 
    {
        int numOfPages;
        string publisher;
        public Book() { Console.WriteLine("New book created"); }
    }

    public class Bread : Product 
    {
        int type;
        DateTime expirationDate;
        public Bread() { Console.WriteLine("New bread created"); }
    }
    public class Water : Product
    {
        double volume;
        bool isCarbonated;
        public Water() { Console.WriteLine("New water created"); }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Creator creator = new ConcreteCreator();
            for (int i = 1; i <= 3; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = creator.FactoryMethod(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}