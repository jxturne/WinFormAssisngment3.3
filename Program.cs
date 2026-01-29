namespace Assi3._3
{
     enum Monthofadmission
    {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

    }
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

            Student student = new Student();
            student.MonthofAdmission(Monthofadmission.January);
            Application.Run(new Form1());
        }
        public static List<Student>
            {
}
    }

}
