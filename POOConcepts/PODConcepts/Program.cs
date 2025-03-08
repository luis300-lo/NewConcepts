// See https://aka.ms/new-console-template for more information
using PODConcepts;

try
{

    var date1 = new Date();
    var date2 = new Date(1974, 12, 5);
    var date3 = new Date(2019, 2, 29);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);

}
catch(Exception ex)
{
    Console.WriteLine(ex);
}

   