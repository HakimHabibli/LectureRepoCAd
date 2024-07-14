using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task.Helper
{
    public class Helper
    {
        public Expression<Func<Source, Destination>> Map<Source, Destination>(Expression<Func<Source, Destination>> exp) 
        {
            var sourceParameter = Expression.Parameter(typeof(Source), "source");
            var bindings = new List<MemberBinding>();

            foreach (PropertyInfo item in typeof(Destination).GetProperties())
            {
                var sourceProperty = typeof(Source).GetProperty(item.Name);
                if (sourceProperty!=null) 
                {
                    var sourcePropertyExpression = Expression.Property(sourceParameter, sourceProperty);
                    var propertyBind = Expression.Bind(item, sourcePropertyExpression);
                    bindings.Add(propertyBind);
                }
              
            }
            var body = Expression.MemberInit(Expression.New(typeof(Destination)), bindings);
            return Expression.Lambda<Func<Source, Destination>>(body, sourceParameter);
        }
        

    }
}
