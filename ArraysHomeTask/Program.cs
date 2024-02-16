// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
int[] numbers = {1,2,3,4,5,6};
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    sum+= numbers[i];
}
Console.WriteLine(sum);
#endregion