using System.Collections.Generic;
using Hive.SeedWorks.Characteristics;

namespace Hive.SeedWorks.TacticalPatterns
{
    /// <summary>
    /// Анемичная модель ограниченного контекста для Фабрики создания агрегата.
    /// Анемичная модель должна содержать объект-значения, реализующие интерфейс <see cref="IValueObject"/>.
    /// </summary>
    public interface IAnemicModel<TBoundedContext> :
        IComplexKey,
        IAggregateRoot<TBoundedContext>
        where TBoundedContext : IBoundedContext
    {
        /// <summary>
        /// Инварианты агрегата.
        /// </summary>
        IDictionary<string, IValueObject> Invariants { get; }
    }
}
