using System;

namespace Strange_Numbers
                                                                                                                                                            {
class Program
                                                                                                                                                            {
static void Main(string[] args                                                                                                                              )
                                                                                                                                                            {
bool eLQuito = false                                                                                                                                        ;
int                                                                                                                                                numeroUNO;
                                                                                                                                                            int 
NUmeRodOs                                                                                                                                                   ;
do                                                                                                                                                          {
Console.WriteLine("Welcome to your virtual calculator i can give you the sum of two numbers or the cubic root of two identical numbers"                     );
Console.WriteLine("Here are your command choices: start or quit"                                                                                            );
string input = Console.ReadLine(                                                                                                                            );switch (input
                                                                                                                                                            )
                                                                                                                                                            {
case "start"                                                                                                                                                :
Console.WriteLine("Please write your first number"                                                                                                          );string 
       firstnumber = Console.ReadLine(                                                                                                                      );
numeroUNO = int.Parse(firstnumber                                                                                                                           );
Console.WriteLine("Please write your second number"                                                                                                         );
string secondnumber = Console.ReadLine(                                                                                                                     );
NUmeRodOs = int.Parse(secondnumber                                                                                                                          );
if(numeroUNO != NUmeRodOs || NUmeRodOs != numeroUNO                                                                                                         )
                                                                                                                                                            {
int a = numeroUNO + NUmeRodOs                                                                                                                               ;
Console.WriteLine(a)                                                                                                                                        ;
                                                                                                                                                            }
else 
if
                            (numeroUNO == NUmeRodOs || NUmeRodOs == numeroUNO                                                                               )
                                                                                                                                                            {
int yote = (numeroUNO + NUmeRodOs) *                                                                                                                        3;
Console.WriteLine(yote)                                                                                                                                     ;
                                                                                                                                                            }
Console.WriteLine("Good job now you can try again"                                                                                                          );
break                                                                                                                                                       ;
case "quit"                                                                                                                                                 :
eLQuito = true                                                                                                                                              ;
break                                                                                                                                                       ;
                                                                                                                                                            }
                                                                                                                                                            } 
while (
!eLQuito
)                                                                                                                                                           ;
                                                                                                                                                            }
                                                                                                                                                            }
                                                                                                                                                            }
