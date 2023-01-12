namespace TaskMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK1
            var arrayTasks = new ArrayTasks();

            var mass = arrayTasks.EnterAray();

            arrayTasks.Print(mass);

            var newarray = arrayTasks.FindNumbers(mass);

            Console.WriteLine("Verilen massivde kvadrat koku olan ededlerden ibaret yeni massviv:");
            arrayTasks.Print(newarray);

            #endregion

            #region TASK2

            //var numberTasks = new NumberTasks();

            //var newnumber = numberTasks.EnterNumber();

            //Console.Write("Number is ");
            //numberTasks.Print(newnumber);

            //var reversenumber = numberTasks.ReserveNumber(newnumber);

            //Console.Write("Reverse number is ");
            //numberTasks.Print(reversenumber);

            #endregion
        }
    }
}