// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples;

/// <summary>
/// A valid object for any interface of the model, made from the interface itself: for the types that have no named sample.
/// </summary>
/// <remarks>
/// <para>
/// <b>Minimal</b> sets the members that are required, and no others: a member that is not nullable. A list has one item, a choice its
/// first variant (by name), a code set its first value, and a primitive the first value of its format that the type accepts. The result is
/// the same on every call, and a new object each time.
/// </para>
/// <para>
/// A <b>named sample</b> (<c>Samples.CashAccount40.Valid.Standard.Minimal</c>) wins over the generated one, wherever the type appears, so a
/// type whose rules ask for more than its shape says (a rule that one of two optional members must be present, a list of at least two)
/// is made right once, by writing its sample.
/// </para>
/// <para>
/// The values are placeholders that fit the format. Do not write a test that depends on what they are: the generator may choose
/// others in a later version.
/// </para>
/// </remarks>
public static class IsoSample
{
    /// <summary>A valid object of the interface with its required members set (see the remarks).</summary>
    /// <typeparam name="T">An interface of the model: a message, a component, a choice or the variant of a choice.</typeparam>
    /// <exception cref="InvalidOperationException">The type is not an interface of the model, or a required member could not be given a value (the message names it).</exception>
    public static T Minimal<T>()
        where T : class => (T)Minimal(typeof(T));

    /// <summary>A valid object of the interface with its required members set (see the remarks).</summary>
    /// <param name="type">An interface of the model: a message, a component, a choice or the variant of a choice.</param>
    /// <exception cref="InvalidOperationException">The type is not an interface of the model, or a required member could not be given a value (the message names it).</exception>
    public static object Minimal(Type type)
    {
        if (type is null)
            throw new ArgumentNullException(nameof(type));
        var kind = Iso.KindOf(type);
        if (!type.IsInterface || kind is not (IsoKind.Message or IsoKind.Component or IsoKind.Choice or IsoKind.ChoiceVariant))
            throw new InvalidOperationException($"'{type.FullName}' is not an interface of the ISO 20022 model.");
        return SampleBuilder.Build(type, new List<Type>(), type.Name);
    }
}
