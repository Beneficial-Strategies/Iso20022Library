// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XZUVsWR8EeKFfdK0gKYFLQ")]
[Description(
    @"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate."
)]
[Derivations(
    typeof(FractionDispositionType10Code),
    typeof(FractionDispositionType11Code),
    typeof(FractionDispositionType8Code),
    typeof(FractionDispositionType9Code)
)]
public enum FractionDispositionTypeV2Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_XzP4pWR8EeKFfdK0gKYFLQ")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp,

    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_XzP4qWR8EeKFfdK0gKYFLQ")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction,

    /// <summary>
    /// Pre-allocate shares only if fully dealt.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_XzP4rWR8EeKFfdK0gKYFLQ")]
    [Description(@"Pre-allocate shares only if fully dealt.")]
    Full,

    /// <summary>
    /// No fractional shares are allowed.
    /// Encoded/decoded by serializers as &quot;NOFR&quot;.
    /// </summary>
    [EnumMember(Value = "NOFR")]
    [IsoId("_XzP4t2R8EeKFfdK0gKYFLQ")]
    [Description(@"No fractional shares are allowed.")]
    NoFraction,

    /// <summary>
    /// In case of a partial fill, pro-rate the allocations.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_XzP4wWR8EeKFfdK0gKYFLQ")]
    [Description(@"In case of a partial fill, pro-rate the allocations.")]
    ProRate,

    /// <summary>
    /// Round up to the next full unit/minimum nominal quantity at no cost.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_XzP4y2R8EeKFfdK0gKYFLQ")]
    [Description(@"Round up to the next full unit/minimum nominal quantity at no cost.")]
    RoundUp,

    /// <summary>
    /// Round the entitlement down to the last full unit/minimum nominal quantity, fractions are discarded.
    /// Encoded/decoded by serializers as &quot;RDDN&quot;.
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_XzP41WR8EeKFfdK0gKYFLQ")]
    [Description(
        @"Round the entitlement down to the last full unit/minimum nominal quantity, fractions are discarded."
    )]
    RoundDown,

    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down as specified in the respective RDUP and RDDN codes.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_XzP432R8EeKFfdK0gKYFLQ")]
    [Description(
        @"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down as specified in the respective RDUP and RDDN codes."
    )]
    RoundToNearest,

    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_XzP442R8EeKFfdK0gKYFLQ")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction,

    /// <summary>
    /// Do not pro-rate; discuss first.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_XzP452R8EeKFfdK0gKYFLQ")]
    [Description(@"Do not pro-rate; discuss first.")]
    DiscussFirst,

    /// <summary>
    /// Pre-allocate according to the amounts shown in a linked allocation instruction.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_XzP48WR8EeKFfdK0gKYFLQ")]
    [Description(
        @"Pre-allocate according to the amounts shown in a linked allocation instruction."
    )]
    Specific,

    /// <summary>
    /// Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down.
    /// Encoded/decoded by serializers as &quot;SSTD&quot;.
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_XzP4-2R8EeKFfdK0gKYFLQ")]
    [Description(
        @"Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down."
    )]
    Standard,

    /// <summary>
    /// Indicates that fractional value should be retained; no rounding.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_XzP4_2R8EeKFfdK0gKYFLQ")]
    [Description(@"Indicates that fractional value should be retained; no rounding.")]
    Retain,

    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_XzP5A2R8EeKFfdK0gKYFLQ")]
    [Description(@"Let fractions expire worthless.")]
    Expire,

    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_XzP5B2R8EeKFfdK0gKYFLQ")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown,
}
