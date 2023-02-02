int Maxim (int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

//              0  1  2  3 4  5   6    7  8                
int[] array = {10,11,19,9676,36,89,105,1987,6};
array[4]=12;
System.Console.WriteLine(array[4]);

int maxtotal = Maxim (
    Maxim (array[0], array[1], array[2]),
    Maxim (array[3], array[4], array[5]), 
    Maxim (array[6], array[7], array[8])
    );
System.Console.WriteLine(maxtotal);

