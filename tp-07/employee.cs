public enum Charges { Auxiliar, Administrative, Engeneer, Specialist, Researcher }

public class Employee {
    string name, surname;
    DateTime birthDate;
    char civilState;
    char gender;
    DateTime companyJoinedDate;
    double basicSalary;
    Charges charge;

    public Employee(string name, string surname, DateTime birthDate, char civilState, char gender, DateTime companyJoinedDate, double basicSalary, Charges charge) {
        this.name = name;
        this.surname = surname;
        this.birthDate = birthDate;
        this.civilState = civilState;
        this.gender = gender;
        this.companyJoinedDate = companyJoinedDate;
        this.basicSalary = basicSalary;
        this.charge = charge;
    }
    public int CalculateAntiquity() { return DateTime.Now.Year - companyJoinedDate.Year; } 
    public int CalculateAge() { return DateTime.Now.Year - birthDate.Year; }
    public int YearsToRetire() { 
        if(gender == 'M') {
            return 65 - CalculateAge(); 
        }
        return 60 - CalculateAge();
    }
    public double Salary() {
        double salaryIncrement = CalculateAntiquity() > 20 ? salaryIncrement = basicSalary * 0.25 : salaryIncrement = (basicSalary * 0.1) * 20;
        if(charge == Charges.Engeneer || charge == Charges.Specialist) {
            salaryIncrement *= 1.50;
        }
        if(civilState == 'M') {
            salaryIncrement += 15000;
        }
        return basicSalary + salaryIncrement;
    }
    public void DisplayData() {
        Console.WriteLine("Nombre: " + this.name);
        Console.WriteLine("Apellido: " + this.surname);
        Console.WriteLine("Fecha de nacimiento: " + this.birthDate.ToString());
        Console.WriteLine("Edad: " + this.CalculateAge());
        Console.WriteLine("Estado civil: " + this.civilState);
        Console.WriteLine("Genero: " + this.gender);
        Console.WriteLine("Fecha de ingreso a la empresa: " + this.companyJoinedDate.ToString());
        Console.WriteLine("Salario basico: " + this.basicSalary);
        Console.WriteLine("Cargo: " + this.charge.ToString());
        Console.WriteLine("Antiguedad en la empresa: " + this.CalculateAntiquity());
        Console.WriteLine("Anios para jubilarse: " + this.YearsToRetire());
        Console.WriteLine("Salario: " + this.Salary());
    }
}