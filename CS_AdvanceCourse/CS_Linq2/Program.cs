using CS_Linq;

Employee employee = new Employee();

List<Employee> employeeList = new List<Employee>()
{
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 2, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 3, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 4, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 5, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 11, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 18, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 21, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 43, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 32, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 33, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 44, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 31, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 67, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 56, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 61, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 78, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 81, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 76, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 34, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = , empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},
    new Employee{empId = 1, empName = "nayan", empContactDetails=123,empGender="male",empLocation="Pune"},

};
