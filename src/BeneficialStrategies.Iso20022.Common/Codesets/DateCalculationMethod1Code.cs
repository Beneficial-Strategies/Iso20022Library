// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the calculation method to be used to determine on which dates the shares have been acquired.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TNd2QFSVEempisJfoIfvvQ")]
[Description(
    @"Indicates the calculation method to be used to determine on which dates the shares have been acquired."
)]
[DerivedFrom(typeof(DateCalculationMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DateCalculationMethod1Code>))]
#endif
public enum DateCalculationMethod1Code
{
    /// <summary>
    /// First in, first out.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_U1m4wVSVEempisJfoIfvvQ")]
    [Description(@"First in, first out. ")]
    Fifo = DateCalculationMethodCode.Fifo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last in, first out.
    /// Encoded/decoded by serializers as &quot;LIFO&quot;.
    /// </summary>
    [EnumMember(Value = "LIFO")]
    [IsoId("_U6qX4VSVEempisJfoIfvvQ")]
    [Description(@"Last in, first out. ")]
    Lifo = DateCalculationMethodCode.Lifo, // same ordinal as derivation source for type conversions
}
