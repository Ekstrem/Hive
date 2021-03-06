﻿using Hive.SeedWorks.Characteristics;

namespace Hive.SeedWorks.TacticalPatterns
{

    /// <summary>
    /// Агрегат.
    /// </summary>
    /// <typeparam name="TBoundedContext">Ограниченный контест.</typeparam>
    public interface IAggregate<TBoundedContext> :
        IComplexKey,
        ICommandSubject,
        IAnemicModel<TBoundedContext>,
        IBoundedContextScope<TBoundedContext>
        where TBoundedContext : IBoundedContext
    {
    }
}
