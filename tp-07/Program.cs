//EJERCICIO 1
// using CalculatorSpace;

// Calculator calculator = new Calculator();
// int validOption;
// string? operand;
// double validOperand;

// do {
//     printMenu();
//     string? option = Console.ReadLine();
//     while(!int.TryParse(option, out validOption)) {
//         Console.WriteLine("\nIngresar una opcion valida\n");
//         printMenu();
//         option = Console.ReadLine();
//     }
//     switch(validOption) {
//         case 1:
//             Console.WriteLine("Ingresar un numero a sumar");
//             operand = Console.ReadLine();
//             while(!double.TryParse(operand, out validOperand)) {
//                 Console.WriteLine("\nIngresar un valor valido");
//                 Console.WriteLine("Ingresar un numero a sumar");
//                 operand = Console.ReadLine(); 
//             }
//             calculator.Add(validOperand);
//             break;
//         case 2:
//             Console.WriteLine("Ingresar un numero a restar");
//             operand = Console.ReadLine();
//             while(!double.TryParse(operand, out validOperand)) {
//                 Console.WriteLine("\nIngresar un valor valido");
//                 Console.WriteLine("Ingresar un numero a sumar");
//                 operand = Console.ReadLine(); 
//             }
//             calculator.Substract(validOperand);
//             break;
//         case 3:
//             Console.WriteLine("Ingresar un numero a multiplicar");
//             operand = Console.ReadLine();
//             while(!double.TryParse(operand, out validOperand)) {
//                 Console.WriteLine("\nIngresar un valor valido");
//                 Console.WriteLine("Ingresar un numero a sumar");
//                 operand = Console.ReadLine(); 
//             }
//             calculator.Multiply(validOperand);
//             break;
//         case 4:
//             Console.WriteLine("Ingresar un numero a dividir");
//             operand = Console.ReadLine();
//             while(!double.TryParse(operand, out validOperand)) {
//                 Console.WriteLine("\nIngresar un valor valido");
//                 Console.WriteLine("Ingresar un numero a sumar");
//                 operand = Console.ReadLine(); 
//             }
//             calculator.Divide(validOperand);
//             break;
//         default:
//             Console.WriteLine("\nNo se encontro la opcion buscada\n");
//             break;
//     }
//     Console.WriteLine("\nResultado guardado: " + calculator.GetResult);
//     Console.WriteLine("\nPresionar tecla para continuar. Escape para salir\n");
// } while (!(Console.ReadKey().Key == ConsoleKey.Escape));

// void printMenu() {
//     Console.WriteLine("\n---MENU---\n");
//     Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir");
// }

//EJERCICIO 2
Employee firstEmployee = new Employee("Juan", "Garcia", new DateTime(1995, 01, 23), 'S', 'M', new DateTime(2015, 03, 23), 100000, Charges.Auxiliar);
Employee secondEmployee = new Employee("Paula", "Gimenez", new DateTime(1974, 02, 26), 'M', 'F', new DateTime(2001, 03, 23), 200000, Charges.Engeneer);
Employee thirdEmployee = new Employee("Roman", "Diaz", new DateTime(1985, 05, 25), 'M', 'M', new DateTime(2010, 03, 23), 80000, Charges.Specialist);
Employee[] employees = {firstEmployee, secondEmployee, thirdEmployee};
Employee oldestEmployee = firstEmployee;
Console.WriteLine("Salario total entre los empleados: " + (firstEmployee.Salary() + secondEmployee.Salary() + thirdEmployee.Salary()));
foreach(Employee employee in employees) {
    if(employee.YearsToRetire() < oldestEmployee.YearsToRetire()) {
        oldestEmployee = employee;
    }
}
Console.WriteLine("\nInformacion del empleado mas viejo\n");
oldestEmployee.DisplayData();