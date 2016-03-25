using System;
using System.Windows.Forms;

namespace calculadora_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // passar as notas
            notas(2.0f, 1.0f, 1.4f, 1.0f);
        }

        static void notas(float n1, float n2, float n3, float n4)
        {
            float nFinal = (2 * n1 + 2 * n2 + 3 * n3 + 3 * n4 ) / 10;
            
            
            if ((nFinal + 10.0f) / 2 < 10.0f)
            {
                MessageBox.Show("Você já foi reprovado !");
            }
            
            
            else if (nFinal < 6.0f)
            {

                for (float i = 0.1f; i <= 10.0f; i++)
                {
                    if ((nFinal + i) / 2 >= 6.0f)
                    {
                        MessageBox.Show("Para passar você precisa de " + i + " na prova final.");
                        break;
                    }
                    
                }
                
            }
            
            else
            {
                MessageBox.Show("Sua média é: " + nFinal + ". Você foi aprovado!");
            }
          
        }
      
    }
}
