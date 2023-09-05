
using Company;

Employee employee = new("Trokovski","Zlatko",30000);
employee.Work();
employee.Pause();

Boss boss = new("Ford", "Trokovski", "Ilija", 60000);
boss.Work();
boss.Lead();
boss.Pause();

EmployeesTrainees trainee = new(8,4,"Dimitrievska","Angela",22500);
trainee.Learn();
trainee.Work();
trainee.Pause();



Console.ReadLine();
