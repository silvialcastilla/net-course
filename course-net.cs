using Sistem; 

namespace Curso_de_net_core /*nombre del proyecto*/
{
    class Program /*clase*/
    {
         static void Main (string[] args){ /*método estático. void(no retorna información). Método Main de tipo string*/

            int year = 10; /*variable número*/
            Console.WriteLine("Hello Amigo!" + year); /*console.log*/
            Console.WriteLine("Hello Amigo {0}", year); /*le indicamos la posición*/
            Console.ReadLine();
        }
    }
}