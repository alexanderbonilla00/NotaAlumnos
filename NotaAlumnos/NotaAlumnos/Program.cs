using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cMaterias = 0;

            Console.WriteLine("Cuantas materias Tiene: ");
            cMaterias = Convert.ToInt32(Console.ReadLine());

            if (cMaterias <= 0)
            {
                Console.WriteLine("Cantidad de Materias no Válidas");

            }

            float[] nota = new float[cMaterias];
            float[] creditos = new float[cMaterias];
            string[] materia = new string[cMaterias];
            int contador = 0;          
            float tCreditos = 0.0f;
            float tNotas = 0.0f;
            float promedio = 0.0f;

            for (contador = 0; contador <cMaterias; contador++)
            {
                Console.WriteLine("Introduzca El Nombre de la materia #{0}", contador + 1);
                materia[contador] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Introduzca la nota de la materia #{0}", contador + 1);
                nota[contador] = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Introduzca los Creditos de la materia #{0}", contador + 1);
                creditos[contador] = Convert.ToSingle(Console.ReadLine());
            }
            contador = 0;
            for (contador = 0; contador <cMaterias; contador++)
            {
                tNotas+= nota[contador] * creditos[contador];
                tCreditos+= creditos[contador];
            }

            promedio += (tNotas / tCreditos);

            contador = 0;
            Console.Clear();

            for (contador = 0; contador <cMaterias; contador++)
            {
                Console.Write(materia[contador]);
                Console.Write(": ");
                Console.Write(nota[contador]);
                Console.Write(", Creditos: ");
                Console.WriteLine(creditos[contador]);
            }
            Console.WriteLine();
            Console.WriteLine("Su promedio es: {0}", promedio);
        }

    }
}
