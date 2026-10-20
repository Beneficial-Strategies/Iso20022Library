// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>
/// Makes the objects for the message interfaces of the library, with classes it builds at run time: one sealed class per
/// interface, built the first time the interface is asked for (or ahead of time with <see cref="Warm"/>) and then reused.
/// </summary>
/// <remarks>
/// A class is built for each interface once per process and kept: the classes are shared by every factory, and a
/// dynamic assembly cannot be unloaded. Building a class takes a fraction of a millisecond; <see cref="Warm"/> moves that
/// to startup for the messages you read. The factory is safe to use from several threads. It does not work where
/// <c>System.Reflection.Emit</c> is not available (Native AOT); read into the message records instead.
/// </remarks>
public sealed class IsoDataFactory : IIsoDataFactory
{
    private static readonly object EmitLock = new();
    private static readonly ConcurrentDictionary<Type, Func<object>> Constructors = new();

    /// <inheritdoc />
    public object Create(Type type)
    {
        if (type is null)
            throw new System.ArgumentNullException(nameof(type));
        return Constructors.TryGetValue(type, out var create) ? create() : Constructor(type)();
    }

    /// <summary>The class built for an interface (built now if it has not been).</summary>
    public Type ImplementationOf(Type type) => Constructor(type)().GetType();

    /// <summary>
    /// Builds the classes for the messages, with everything they reach: components, and every variant of every choice.
    /// Call it at startup for the messages you will read, so that no read pays for building a class.
    /// </summary>
    /// <param name="messages">Message interfaces, for example <c>typeof(IFIToFICustomerCreditTransferV14)</c>.</param>
    public void Warm(params Type[] messages)
    {
        foreach (var message in messages)
        foreach (var type in InterfaceGraph.Closure(message))
            Constructor(type);
    }

    private static Func<object> Constructor(Type type)
    {
        if (Constructors.TryGetValue(type, out var known))
            return known;
        lock (EmitLock)
        {
            if (Constructors.TryGetValue(type, out known))
                return known;
            var built = ClassEmitter.Emit(type);
            var create = Expression
                .Lambda<Func<object>>(Expression.Convert(Expression.New(built), typeof(object)))
                .Compile();
            Constructors[type] = create;
            return create;
        }
    }
}
