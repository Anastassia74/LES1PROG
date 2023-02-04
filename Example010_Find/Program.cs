int [] array = {11,2,23,81,65,36,17,81};
int n = array.Length;
int find = 81;
int index = 0;
while (index<n)
{
    if (array [index]==find)
    {
    System.Console.WriteLine(index);
    break;
    }
    //index=index+1;
    index++;
}
