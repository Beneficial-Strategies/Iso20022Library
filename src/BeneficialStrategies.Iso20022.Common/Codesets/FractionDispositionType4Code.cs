// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arjhxdp-Ed-ak6NoX_4Aeg_-1202257975")]
[Description(
    @"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate."
)]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FractionDispositionType4Code>))]
#endif
public enum FractionDispositionType4Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arjhxtp-Ed-ak6NoX_4Aeg_-1202257973")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp = FractionDispositionTypeCode.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arjhx9p-Ed-ak6NoX_4Aeg_-1202257957")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction = FractionDispositionTypeCode.CashInLieuOfFraction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_arjhyNp-Ed-ak6NoX_4Aeg_-1202257956")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeCode.IssueFraction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDDN&quot;.
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_arjhydp-Ed-ak6NoX_4Aeg_-1202257955")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = FractionDispositionTypeCode.RoundDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_arsrsNp-Ed-ak6NoX_4Aeg_-1202257940")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = FractionDispositionTypeCode.RoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_arsrsdp-Ed-ak6NoX_4Aeg_-1202257931")]
    [Description(
        @"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down."
    )]
    RoundToNearest = FractionDispositionTypeCode.RoundToNearest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_arsrstp-Ed-ak6NoX_4Aeg_-501305688")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown = FractionDispositionTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
