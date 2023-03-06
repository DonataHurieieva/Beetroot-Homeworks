using System;


class Lesson4{


public static void Main()


{
const int x =1;
const int y =3;

int result =0;

for(int num=x;num<=y;num++) {
    result= result+num;
}

Console.WriteLine($" const x=1, const y=3  sum={result} ");

const int a =8;
const int b =4;

int result1 = 0;
int num1  = b;


while (num1 <= a) {
    result1= result1+num1;
    num1 ++;
}

Console.WriteLine($" const a=8, const b=4  sum={result1} ");

const int c =5;
const int d=5;
int num2= c;
int result2=0;
result2= result2+num2;

 do { 
    result2=result2+num2;
    num2++ ;
} while ( num2 <= d );

Console.WriteLine($" const c=5, const d=5  sum={result2} ");




}
}