﻿
class Program {


public static void Main() {


int MaxValueResult = ReturnMaxValue(2,3,4,5);
int MaxValueResult1 = ReturnMaxValue(8,12,3,7);
int MaxValueResult2 = ReturnMaxValue(33,-10,0,6);


int MinValueresult= ReturnMinValue(2,8,10,0);
int MinValueresult1= ReturnMinValue(-5,12,6,1);
int MinValueresult2= ReturnMinValue(2,18,5,2);

Console.WriteLine($"\nMax values:\n{MaxValueResult},{MaxValueResult1},{MaxValueResult2}\n\nMin values:\n {MinValueresult},{MinValueresult1},{MinValueresult2}\n");

int res;
 TrySumIfOdd (2,5,out res);
 TrySumIfOdd (3,3,out res);
}

public static bool TrySumIfOdd ( int a, int b, out int sum){ 
  
         sum=a+b;
    
        int sum2=sum %2;
        bool odd= false;
        if (sum2 == 1 ){ 
            odd= true;
        }

        else { odd=false;}
        Console.WriteLine($"sum is:{sum} and it is {odd}");
        return odd;
    
}



     

public static int ReturnMaxValue (int a,int b,int c,int d) {

    int ab = a > b ? a : b;
    int dc= d>c?d:c;
    int MaxValue = ab>dc?ab:dc;
    return MaxValue;
    
    
    
    }
    

public static int ReturnMinValue (int a,int b,int c,int d){

a = 5 * a;

int ab = a < b ? a : b;
    int dc= d < c ? d : c;
    int MinValue = ab < dc ? ab : dc;
    return MinValue;
    


}}
