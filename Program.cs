namespace Week4Assignment4._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Person sample1 = new Person() { FirstName = "Tony", LastName = "Danza", MobilePhone = 4548182000, Address = "456 Elm St"};
            Person sample2 = new Person() { FirstName = "Betty", LastName = "White", MobilePhone = 4162754863, Address = "742 Fremont Ave" };
            Person sample3 = new Person() { FirstName = "Betty", LastName = "Ford", MobilePhone = 5134862197, Address = "16 Golden Rod Ln" };

            Data.PhoneBook.Add(sample1.LastName + sample1.FirstName, sample1);
            Data.PhoneBook.Add(sample2.LastName + sample2.FirstName, sample2);
            Data.PhoneBook.Add(sample3.LastName + sample3.FirstName, sample3);
            Application.Run(new Form1());
        }
    }
}