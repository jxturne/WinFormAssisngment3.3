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

            //Student student = new Student();
            Data_cs.students.Add(new Student() { FName="Justin", LName="Turner", Grade='B', Id=1, MonthAdmiited=Monthofadmission.January.ToString() });
            Data_cs.students.Add(new Student() { FName="Mike", LName="Trout", Grade='C', Id=2, MonthAdmiited=Monthofadmission.February.ToString() });
            Data_cs.students.Add(new Student() { FName="Mookie", LName="Betts", Grade='F', Id=3, MonthAdmiited=Monthofadmission.March.ToString() });
            Data_cs.students.Add(new Student() { FName="Babe", LName="Ruth", Grade='A', Id=4, MonthAdmiited=Monthofadmission.April.ToString() });   
            Application.Run(new Form1());
        }
       
}
    }


