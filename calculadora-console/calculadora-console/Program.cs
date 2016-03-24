using System;
using System.Windows.Forms;

namespace calculadora_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // passar as notas
            notas(6.0f, 6.0f, 5.9f, 6.0f);
        }

        public static void notas(float n1, float n2, float n3, float n4)
        {
            float nFinal = (2 * n1 + 2 * n2 + 3 * n3 + 3 * n4 ) / 10;
            
            if (nFinal < 6.0f)
            {
                for (float i = 0.1f; i != 10.0f; i++)
                {
                    if (((nFinal + i) / 2) >= 6.0f)
                    {
                        MessageBox.Show("Para passar você precisa de " + i + " na prova final.");
                        break;
                    }
                    
                }
                
            }
            
            else if (nFinal >= 6) 
            {
                MessageBox.Show("Sua média é: " + nFinal + " Você foi aprovado!");
            }
          
        }
    }
}
