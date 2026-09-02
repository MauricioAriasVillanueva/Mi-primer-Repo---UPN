// En un curso q aun acepta inscripciones
// Se solicita ingresar 2 notas por estudiante
// Teniendo en cuento q no se sabe el numero de estudiantes


int x = 0;
while (x == 0)
{
   
        System.Console.WriteLine("Ingrese la nota 1 del estudiante");
        int nota1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la nota 2 del estudiante");
        int nota2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la nota 3 del estudiante");
        int nota3 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Deseas ingresar notas de otro estudiante (s/n)");
    char estudiante = char.Parse(Console.ReadLine());
    if (estudiante =='s') x = 0;
    else x = 1;
}