namespace Assignment_4___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstname, lastname, login, item1, item2;
            int age, grade, id;
            double wage, average, num1, num2, num3, price1, price2, discount, total, subtotal, tax, totalowed;

            //Name, Age and Salary
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Wow! Only " + age + "? How much do you make an hour?");
            double.TryParse(Console.ReadLine(), out wage);
            Console.WriteLine(wage.ToString("C") + " an hour! Can I have some money?");
            Console.WriteLine();

            //Information collection
            Console.WriteLine("Please enter your information");
            Console.Write("First name: ");
            firstname = Console.ReadLine();
            Console.Write("Last name: ");
            lastname = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student ID: ");
            Int32.TryParse(Console.ReadLine(), out id);
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine("Thank You!");
            Console.WriteLine();
            Console.WriteLine("Your information: ");
            Console.WriteLine("Login: " + login);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + lastname + ", " + firstname);
            Console.WriteLine("Average: " + average + "%");
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine();

            //Age +/- 5 years
            Console.WriteLine("Hey " + name + " did you know that in 5 years you will be " + (age + 5) + " years old?");
            Console.WriteLine("You were also " + (age - 5) + " years old 5 years ago.");
            Console.WriteLine();

            //Dumb Calculator
            Console.Write("Please input a number: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Please input a second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.Write("Please input a third number: ");
            double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("Those numbers divided by 2 equals " + ((num1 + num2 + num3) / 2));
            Console.WriteLine();

            //Cash Register
            Console.WriteLine("Welcome to the cash register!");
            Console.Write("Please input the name of your first item: ");
            item1 = Console.ReadLine();
            Console.Write("Please input the cost of your first item: ");
            double.TryParse(Console.ReadLine(), out price1);
            Console.Write("Please input the name of your second item: ");
            item2 = Console.ReadLine();
            Console.Write("Please input the cost of your second item: ");
            double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine();
            // This generates the receipt
            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: " + price1.ToString("C"));
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: " + price2.ToString("C"));
            Console.WriteLine("====================");
            total = Math.Round(price1 + price2, 2);
            Console.WriteLine("Total:" + total.ToString("C"));
            discount = Math.Round((price1 + price2) / 5, 2);
            Console.WriteLine("Discount (20%): " + discount.ToString("C"));
            subtotal = Math.Round(total - discount);
            Console.WriteLine("Subtotal: " + subtotal.ToString("C"));
            tax = Math.Round(subtotal * 0.13, 2);
            Console.WriteLine("Tax (13%): " + tax.ToString("C"));
            Console.WriteLine("====================");
            totalowed = subtotal + tax;
            Console.WriteLine("Total Owed: " + totalowed.ToString("C"));
            Console.WriteLine();


        }
    }
}
