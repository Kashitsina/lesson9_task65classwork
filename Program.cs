
void Zadacha65()
{
  // Задайте значение M и N.напишите программу ,которая выведет все натуральные числа в промежутке от М до N


  int numberN = 5 ;
  int numberM = 10;

  Recursion(numberN , numberM);
  Console.WriteLine();


  void Recursion(int numberN, int numberM)
  {
    if (numberN == numberM - 1 ) return ;
     
    Console.Write(numberN +1 + "  ");
    numberN ++;
    Recursion( numberN, numberM);
    
  }
   
  

}
Zadacha65();
