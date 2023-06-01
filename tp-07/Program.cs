using CalculatorSpace;

Calculator calculator = new Calculator();
int validOption;
string? operand;
double validOperand;

do {
    printMenu();
    string? option = Console.ReadLine();
    while(!int.TryParse(option, out validOption)) {
        Console.WriteLine("\nIngresar una opcion valida\n");
        printMenu();
        option = Console.ReadLine();
    }
    switch(validOption) {
        case 1:
            Console.WriteLine("Ingresar un numero a sumar");
            operand = Console.ReadLine();
            while(!double.TryParse(operand, out validOperand)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operand = Console.ReadLine(); 
            }
            calculator.Add(validOperand);
            break;
        case 2:
            Console.WriteLine("Ingresar un numero a restar");
            operand = Console.ReadLine();
            while(!double.TryParse(operand, out validOperand)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operand = Console.ReadLine(); 
            }
            calculator.Substract(validOperand);
            break;
        case 3:
            Console.WriteLine("Ingresar un numero a multiplicar");
            operand = Console.ReadLine();
            while(!double.TryParse(operand, out validOperand)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operand = Console.ReadLine(); 
            }
            calculator.Multiply(validOperand);
            break;
        case 4:
            Console.WriteLine("Ingresar un numero a dividir");
            operand = Console.ReadLine();
            while(!double.TryParse(operand, out validOperand)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operand = Console.ReadLine(); 
            }
            calculator.Divide(validOperand);
            break;
        default:
            Console.WriteLine("\nNo se encontro la opcion buscada\n");
            break;
    }
    Console.WriteLine("\nResultado guardado: " + calculator.GetResult);
    Console.WriteLine("\nPresionar tecla para continuar. Escape para salir\n");
} while (!(Console.ReadKey().Key == ConsoleKey.Escape));

void printMenu() {
    Console.WriteLine("\n---MENU---\n");
    Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir");
}