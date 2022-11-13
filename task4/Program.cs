namespace task4
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            MyTree t = new MyTree();
            ToyDecorator dec1 = new ToyDecorator();
            GarlandDecorator dec2 = new GarlandDecorator();
            
            t.done();
            dec1.done();
            dec2.done();
            // Wait for user
            Console.Read();
        }
    }

    // "Component"
    abstract class Tree
    {
        public abstract void done();
    }

    // "ConcreteComponent"

    class MyTree : Tree
    {
        public override void done()
        {
            Console.WriteLine("There is a new tree!");
        }
    }

    abstract class Decorator : Tree
    {
        protected Tree tree;

        public void Set(MyTree TreeExp)
        {
            tree = TreeExp;
        }

        public override void done()
        {
            if (tree != null) tree.done();
        }
    }

    // "Decorator"
    class ToyDecorator : Decorator
    {
        List<string> ToysList = new List<string>();

        public override void done()
        {
            base.done();
            ToysList.Add("green and red glass toys");
            foreach (var toy in ToysList)
            {
                Console.WriteLine($"Decorated with {toy}");
            }
        }

        public void addToy(string toy)
        {
            ToysList.Add(toy);
        }
    }

    // "ConcreteDecoratorB" 
    class GarlandDecorator : Decorator
    {
        protected bool isShining = false;
        public override void done()
        {
            base.done();
            isShining = true;
            Console.WriteLine("Garland is shining!");
        }
    }
}