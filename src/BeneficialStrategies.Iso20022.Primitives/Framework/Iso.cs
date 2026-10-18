// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Metadata;

namespace BeneficialStrategies.Iso20022;

/// <summary>Questions about ISO 20022 model types that apply to all of them.</summary>
public static class Iso
{
    private static readonly ConcurrentDictionary<Type, IsoKind?> Kinds = new();

    /// <summary>
    /// The kind of an ISO 20022 model type, or <c>null</c> for a type that is not one (a serializer, an attribute, a BCL type).
    /// Every model type has exactly one kind. The marker interfaces decide, and a code set, which cannot implement an
    /// interface because it is an enum, is recognised by its <c>[IsoId]</c>. The answer is cached per type.
    /// </summary>
    public static IsoKind? KindOf(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);
        return Kinds.GetOrAdd(type, Classify);
    }

    /// <summary>Shorthand for <see cref="KindOf(Type)"/> on <typeparamref name="T"/>.</summary>
    public static IsoKind? KindOf<T>() => KindOf(typeof(T));

    // The order matters where one type carries two markers: a variant interface derives from its choice's interface, and
    // an external code is also a simple type, so the narrower kind is tested first.
    private static IsoKind? Classify(Type type)
    {
        if (type.IsEnum)
            return type.IsDefined(typeof(IsoIdAttribute), inherit: false) ? IsoKind.CodeSet : null;
        if (typeof(IOuterRecord).IsAssignableFrom(type)) return IsoKind.Message;
        if (typeof(IIsoAmount).IsAssignableFrom(type)) return IsoKind.Amount;
        if (typeof(IIsoOpenContent).IsAssignableFrom(type)) return IsoKind.OpenContent;
        if (typeof(IIsoChoiceVariant).IsAssignableFrom(type)) return IsoKind.ChoiceVariant;
        if (typeof(IIsoChoice).IsAssignableFrom(type)) return IsoKind.Choice;
        if (typeof(IIsoComponent).IsAssignableFrom(type)) return IsoKind.Component;
        if (typeof(IIsoExternalCode).IsAssignableFrom(type)) return IsoKind.ExternalCode;
        if (typeof(IIsoSimpleType).IsAssignableFrom(type)) return IsoKind.SimpleType;
        return null;
    }
}
