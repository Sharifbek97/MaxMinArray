Console.Write("\tEnter numbers of elements of array: ");
var n = int.Parse(Console.ReadLine());
var numbers= new int[n];
var rnd = new Random();
int i;
Console.Write("\tGiven elements of array: ");
for ( i = 0; i < n ; ++i)
{
    numbers[i] = rnd.Next(-20, 40);
    Console.Write(numbers[i]+"   ");
}
var min = numbers[0];
var max = numbers[0];
    Console.Write("\n");
for ( i = 0; i < n; ++i)
{
        if (max < numbers[i])
        {
            max = numbers[i];
        } 
        if (min > numbers[i])
        {
            min = numbers[i];
        }  
}
Console.Write("\tThe bigger's of elements of array: " + max);
Console.Write("\n\tThe smaller's of elements of array: " + min);
