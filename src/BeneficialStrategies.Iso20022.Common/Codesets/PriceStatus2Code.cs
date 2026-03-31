// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the price of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6j0dcAbBEeqrW7Meu5r3kQ")]
[Description(@"Status of the price of a financial instrument.")]
[DerivedFrom(typeof(PriceStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceStatus2Code>))]
#endif
public enum PriceStatus2Code
{
    /// <summary>
    /// Price is pending.
    /// Encoded/decoded by serializers as &quot;PNDG&quot;.
    /// </summary>
    [EnumMember(Value = "PNDG")]
    [IsoId("_DfTKsQbCEeqrW7Meu5r3kQ")]
    [Description(@"Price is pending.")]
    Pending = PriceStatusCode.Pending, // same ordinal as derivation source for type conversions
}
