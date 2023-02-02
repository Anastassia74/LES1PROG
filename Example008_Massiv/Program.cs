int Maxim (int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1=15;
int b1=10;
int c1=12;
int a2=15500;
int b2=10;
int c2=40;
int a3=77731;
int b3=210;
int c3=46;

// int max1 = Maxim (a1, b1, c1);
// int max2 = Maxim (a2, b2, c2);
// int max3 = Maxim (a3, b3, c3);
// int maxtotal = Maxim (max1, max2, max3);

int maxtotal = Maxim (
    Maxim (a1, b1, c1),
    Maxim (a2, b2, c2), 
    Maxim (a3, b3, c3));
System.Console.WriteLine(maxtotal);

// int max =a1;
// if (b1>max) max=b1;
// if (c1>max) max=c1;
// if (a2>max) max=a2;
// if (b2>max) max=b2;
// if (c2>max) max=c2;
// if (a3>max) max=a3;
// if (b3>max) max=b3;
// if (c3>max) max=c3;
//System.Console.WriteLine(max);