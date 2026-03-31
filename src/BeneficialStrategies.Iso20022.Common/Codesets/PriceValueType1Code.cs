// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJIKJ9p-Ed-ak6NoX_4Aeg_1793790743")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceValueType1Code>))]
#endif
public enum PriceValueType1Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJIKKNp-Ed-ak6NoX_4Aeg_-2127153341")]
    [Description(
        @"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100."
    )]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJR7INp-Ed-ak6NoX_4Aeg_-2125306944")]
    [Description(
        @"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100."
    )]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_aJR7Idp-Ed-ak6NoX_4Aeg_1927701255")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions
}
