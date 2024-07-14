using System.Linq.Expressions;
using Task.Helper;
using Task.Models;

//Expression<Func<Person,PersonDto>> expression;
//expression.Map

var persons = new List<Person>
{
    new Person{ Name = "Nancy",Surname="Davolio"},
    new Person {Name = "hakim" , Surname ="Habibli"}
};
//var result =  persons
//    .AsQueryable()
//    .Select(Helper.Map<Person,PersonDto>()).ToList().ForEach()