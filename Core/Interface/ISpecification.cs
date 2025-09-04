using System;
using System.Linq.Expressions;

namespace Core.Interface;

public interface ISpecification<T>
{
        Expression<Func<T, bool>>? Criteria { get; }

}
