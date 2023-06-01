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