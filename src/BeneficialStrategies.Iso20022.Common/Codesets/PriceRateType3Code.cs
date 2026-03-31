// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aI_AM9p-Ed-ak6NoX_4Aeg_2030331251")]
[Description(@"Specifies the type of price rate.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceRateType3Code>))]
#endif
public enum PriceRateType3Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aI_ANNp-Ed-ak6NoX_4Aeg_2030331253")]
    [Description(
        @"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100."
    )]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aI_ANdp-Ed-ak6NoX_4Aeg_2030331282")]
    [Description(
        @"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100."
    )]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a percentage of par.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_aI_ANtp-Ed-ak6NoX_4Aeg_2030331283")]
    [Description(@"Price expressed as a percentage of par.")]
    Percentage = PriceValueTypeCode.Percentage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as &quot;YIEL&quot;.
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_aI_AN9p-Ed-ak6NoX_4Aeg_2030331312")]
    [Description(@"Price expressed as a yield.")]
    Yield = PriceValueTypeCode.Yield, // same ordinal as derivation source for type conversions
}
