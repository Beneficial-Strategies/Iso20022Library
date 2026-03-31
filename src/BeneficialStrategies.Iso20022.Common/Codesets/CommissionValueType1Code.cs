// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of value of the commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAkIcdp-Ed-ak6NoX_4Aeg_-623760703")]
[Description(@"Specifies a type of value of the commission.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CommissionValueType1Code>))]
#endif
public enum CommissionValueType1Code
{
    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as &quot;PEUN&quot;.
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_bAkIctp-Ed-ak6NoX_4Aeg_-559114087")]
    [Description(@"Price expressed per unit.")]
    PerUnit = PriceValueTypeCode.PerUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as &quot;ABSO&quot;.
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_bAkIc9p-Ed-ak6NoX_4Aeg_-555420258")]
    [Description(@"Price is expressed as absolute.")]
    Absolute = PriceValueTypeCode.Absolute, // same ordinal as derivation source for type conversions
}
