// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p82osVXaEfC0lMwgjvMClw")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TypeOfAmount25Code>))]
public enum TypeOfAmount25Code
{
    /// <summary>
    /// Telephone connection-related charge
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_p_IgoVXaEfC0lMwgjvMClw")]
    [Description(@"Telephone connection-related charge")]
    Connect = TypeOfAmountCode.Connect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance charges
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_p_Igo1XaEfC0lMwgjvMClw")]
    [Description(@"Insurance charges")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges related to a long distance call.
    /// Encoded/decoded by serializers as &quot;LNDS&quot;.
    /// </summary>
    [EnumMember(Value = "LNDS")]
    [IsoId("_p_IgpVXaEfC0lMwgjvMClw")]
    [Description(@"Charges related to a long distance call.")]
    LongDistance = TypeOfAmountCode.LongDistance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_p_Igp1XaEfC0lMwgjvMClw")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone usage-related charge
    /// Encoded/decoded by serializers as &quot;USGE&quot;.
    /// </summary>
    [EnumMember(Value = "USGE")]
    [IsoId("_p_IgrVXaEfC0lMwgjvMClw")]
    [Description(@"Telephone usage-related charge")]
    Usage = TypeOfAmountCode.Usage, // same ordinal as derivation source for type conversions
}
