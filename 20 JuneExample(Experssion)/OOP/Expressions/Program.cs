using Expressions.Models;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

#region IlkOrnek

//Expression<Func<int, int>> square = x => x * x;

////Func<int, int > result  =  square.Compile();
//var result  =  square.Compile();

//Console.WriteLine(result(5));
#endregion

#region Ornekiki

//Expression<Func<int, int, bool>> IsGreater = (n1, n2) => n1 > n2;
//Func<int,int,bool> IsGreaterFunc = IsGreater.Compile();
//Console.WriteLine(IsGreaterFunc(5,3));
//Console.WriteLine(IsGreaterFunc(2,5));
#endregion


var employees = new List<Employee>
{
 new Employee { FirstName = "Hakim",Name = "Habibli",Age = 2},
 new Employee { FirstName = "Hakim1",Name = "Habibli1",Age = 14},
 new Employee { FirstName = "Hakim2",Name = "Habibli2",Age = 27}
};
Expression<Func<Employee, bool>> isAdultExpression = e => e.Age >= 14;
if (isAdultExpression.Body is BinaryExpression binaryExpression) 
{ 
    Console.WriteLine(binaryExpression);
    Console.WriteLine(binaryExpression.Left);
    Console.WriteLine(binaryExpression.Right);
    Console.WriteLine(binaryExpression.NodeType);
}

var adultEmployees1 = employees.AsQueryable().Where(isAdultExpression).Select(x => new
{
    x.FirstName,
    x.Name,
    x.Age
}).ToList();
var adultEmployees = employees.Where(x => isAdultExpression.Compile()(x)).ToList();
adultEmployees.ForEach (x => Console.WriteLine(x));
adultEmployees1.ForEach(x => Console.WriteLine(x));


string Metn1 = "Hakim";
string Metn2 = "Suat";
string Metn3 = "Fari(*z";

List<string> Lists = new();
Lists.Add(Metn1);
Lists.Add(Metn2);
Lists.Add(Metn3);

Expression<Func<string, string>> IsCleared = x => x.ToLower().Replace("(", " ").Replace("z"," ").Replace("*"," ");
var retVal = Lists.AsQueryable().Select(x => x.ToLower().Replace("(", " ").Replace("z", " ").Replace("*", " ") ).ToList();
retVal.ForEach(x => Console.WriteLine(x));

//var result = IsCleared.Where
//Console.WriteLine(result(Metn1));
//var ClearedLists = Lists.AsQueryable().Where().ToList();

List<Person> persons = new();
Person person = new Person() 
{
    FirstName = "Hakim",
    LastName = "Habibli",

};
Person person1 = new Person()
{
    FirstName = "Hakim1",
    LastName = "Habibli1",

};
Person person2 = new Person()
{
    FirstName = "Hakim2",
    LastName = "Habibli2",

};
Person person3 = new Person()
{
    FirstName = "Hakim3",
    LastName = "Habibli3",

};
persons.Add(person);
persons.Add(person1);
persons.Add(person2);
persons.Add(person3);



