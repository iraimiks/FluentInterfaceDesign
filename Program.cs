namespace FluentInterfaceDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] someNumbers = { 4, 3, 2, 1 };

            var processedValues = someNumbers
                .Select(n => n * 10)
                .Where(n => n > 10);

            foreach (int n in someNumbers)
            {
                Console.WriteLine(n * 10);
            }

            Console.WriteLine("00000000000000000000000000000");
            ShowElements(processedValues);
            Console.WriteLine("00000000000000000000000000000");

            FluentEmployee employeeObj = new FluentEmployee();

            employeeObj
                .NameOfEmployee("Toms Berzins")
                .EmployeeDateOfBirth("11/11/1995")
                .EmployeeDeoartment("Vilnus")
                .EmployeeAddress("Gedimino str. 9");

            employeeObj.ShowDetailsOfEmployee();
        }

        static void ShowElements(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}