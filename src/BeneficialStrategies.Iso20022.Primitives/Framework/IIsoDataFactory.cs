// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// Makes the object a reader fills when the type it is asked for is an interface (a message, a component or a
    /// choice variant). The object it returns implements the interface that was asked for and has a public settable property for
    /// every property of the interface, with the same name and type; the reader sets them one by one.
    /// </summary>
    /// <remarks>
    /// The records of <c>BeneficialStrategies.Iso20022.Common</c> need no factory: asked for a record, the reader
    /// creates it itself. A factory is for readers that know only the interfaces; the
    /// <c>BeneficialStrategies.Iso20022.Factory</c> package supplies one that builds the classes at run time.
    /// </remarks>
    public interface IIsoDataFactory
    {
        /// <summary>Creates an empty object that implements <paramref name="type"/>, an interface.</summary>
        object Create(Type type);
    }

    /// <summary>
    /// The factory used when none is given: it cannot make an object for an interface, and says what to do about that.
    /// </summary>
    public sealed class NoDataFactory : IIsoDataFactory
    {
        /// <summary>The only instance.</summary>
        public static NoDataFactory Instance { get; } = new NoDataFactory();

        private NoDataFactory() { }

        /// <inheritdoc />
        public object Create(Type type) =>
            throw new InvalidOperationException(
                $"'{type.Name}' is an interface and there is no factory to make an object for it. "
                    + "Read into the record that implements it, or pass an IIsoDataFactory "
                    + "(for example the one in the BeneficialStrategies.Iso20022.Factory package)."
            );
    }
}
