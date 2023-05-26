public class Calculator {
    double result;
    public Calculator() => result = 0;
    public void Add(double expresion) => this.result += expresion;
    public void Substract(double expresion) => this.result -= expresion;
    public void Multiply(double expresion) => this.result *= expresion;
    public void Divide(double expresion) {
        if(expresion == 0) {
            Console.WriteLine("\nSe intento dividir en 0\n");
            return;
        }
        this.result /= expresion;
    }
    public void ClearResult() => result = 0;
    public double GetResult { get => result; }
};