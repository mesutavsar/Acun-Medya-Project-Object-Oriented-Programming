using EmployeesAndManagers2;

Employee emp1 = new Employee("Mesut", "Avşar", "01.01.2020", 15000);

Manager mng1 =  new Manager("Tuğçe","Taşkın","01.01.2015",100000,50);

Console.WriteLine(emp1.Name);

mng1.numberOfWorker = 45;

Console.WriteLine(mng1.numberOfWorker);