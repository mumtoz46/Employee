class Employee
{
 int _id;
 string _FirstName;
 string _LastName;
 int _salary;
 public  Employee (int id,string FirstName, string LastName, int salary)
 {
    _id = id;
    _FirstName = FirstName;
    _LastName = LastName;
    _salary = salary;
 }
 public int GetId()
 {
    return _id;
 }
 public string  GetFirstName()
 {
    return _FirstName;
 }
 public string GetLastName()
 {
    return _LastName;
 }
 public string Name ()

{
    return _FirstName;
}
public int GetSalary ()
{
    return _salary;
}
public void  SetSalary (int salary)
{
    _salary = salary;
}
public int GetAnnualSalary ()
{
    return _salary * 12;
}
public int RaisSalary (int percent)
{
    return _salary += (_salary *10)/100;
}
public string ToString ()
{
    return $"{_id} {_FirstName} {_LastName} {_salary}";
}

}