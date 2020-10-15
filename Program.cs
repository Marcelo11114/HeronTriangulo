using System;

namespace HeronTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
           Double LA, LB, LC, AR,SP ; // VARIAVEIS (CA)adjacente (CO)oposto (HI)potenusa
           String T;
          
           
          do
           
           {
               Console.Clear(); 
               
          // Montar caixa titulo
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("      +------------------+");
           Console.WriteLine("      |                  |");
           Console.WriteLine("      +------------------+");

           Console.SetCursorPosition(8, 1);
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Formula de Heron");
           Console.SetCursorPosition(0, 3);
           Console.ResetColor();
           //
             
           //

           Console.Write("Lado A : ");
                LA = Convert.ToDouble(Console.ReadLine());
           Console.Write("Lado B : ");
                LB = Convert.ToDouble(Console.ReadLine());
           Console.Write("Lado C : ");
                LC = Convert.ToDouble(Console.ReadLine());
                
            double CBC = Math.Abs(LB-LC);// MATH.ABS retorna o valor 
            double CAC = Math.Abs(LA-LC);// absoluto da operação
            double CAB = Math.Abs(LA-LB); // 

            bool cond1 = false; // prepara as variaveis como bool
            bool cond2 = false; // setando-as em condição falsa
            bool cond3 = false; //

          if (CBC < LA && LA < LB + LC) // se as condições forem verdadeiras 
            {                           // seta as variaveis cond(n)
                cond1 = true;           //        como veradeiras
            }
            if (CAC < LB && LB < LA + LC)
            {
                cond2 = true;
            }
            if (CAB < LC && LC < LA + LB)
            {
                cond3 = true;
            }
            if (cond1 && cond2 && cond3) // se todas forem verdadeira
                                         // executa rotina abaixo
            {                           // responsavel pelo resultado                                   
                Console.ForegroundColor = ConsoleColor.DarkYellow;   
                SP=(LA+LB+LC)/2;
                AR = Math.Sqrt(SP * (SP - LA) * (SP - LB) * (SP - LC));
                Console.WriteLine($"\nSemiperimetro = {SP}cm");
                Console.WriteLine($"Area do Triangulo = {AR:N2} cm^2");
                  
                Console.Write("É um triangulo ");                               
                   // verifica qual tipo de tringulo
                if (LA == LB && LB == LC){ Console.WriteLine("Equilatero");DrawEquilatero();}
                 else {if (LA != LB && LB != LC){ Console.WriteLine("Escaleno");DrawEscaleno();}
                        else {Console.WriteLine("Isósceles");DrawIsoceles();}}
                Console.ResetColor();

            }
               else // caso nao sejam true executa aviso de triangulo
                {   // impossivel
                
                     Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("\nTringulo não existe!\n");
                     Console.ResetColor();
                }
                // sair ou outro calculo
           Console.Write("(S)air?:");           
           T = Console.ReadLine().ToUpper();
           }

           while(T != "S");

           Console.Clear();  
        }// fecha Main

           static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
          {
           ConsoleColor CorC = (ConsoleColor)COR_Caracter;
           ConsoleColor CorF = (ConsoleColor)COR_Fundo;
           Console.ForegroundColor = CorC;
           Console.BackgroundColor = CorF;
            Console.SetCursorPosition(X, Y);
            Console.Write(S);
            Console.ResetColor();
          }//fecha print
           static void DrawEquilatero()
           {
            print("      *",10,0, 40, 4);
            print("     ***",10,0, 40, 5);
            print("    *****",10,0, 40, 6);
            print("   *******",10,0, 40, 7);
            print("  *********",10,0, 40, 8);
            print(" ***********",10,0, 40, 9);
            print("*************\n",10,0, 40, 10);
           }// fecha DrawEquilatero

            static void DrawEscaleno()
           {
            print("*",10,0, 40, 4);
            print("***",10,0, 40, 5);
            print("*****",10,0, 40, 6);
            print("*******",10,0, 40, 7);
            print("*********",10,0, 40, 8);
            print("***********",10,0, 40, 9);
            print("*************\n",10,0, 40, 10);
           }// fecha DrawEscaleno

            static void DrawIsoceles()
           {
            print("*",10,0, 40, 4);
            print(" ***",10,0, 40, 5);
            print("  *****",10,0, 40, 6);
            print("   *******",10,0, 40, 7);
            print("    *********",10,0, 40, 8);
            print("     ***********",10,0, 40, 9);
            print("      *************\n",10,0, 40, 10);
           }// fecha  DrawIsoceles
       
    }
}