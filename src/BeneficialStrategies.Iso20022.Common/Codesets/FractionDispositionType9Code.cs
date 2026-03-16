// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H0tJkGSCEeKFfdK0gKYFLQ")]
[Description(@"Indicates that fractional value should be retained; no rounding.")]
[DerivedFrom(typeof(FractionDispositionTypeV2Code))]
public enum FractionDispositionType9Code
{
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_O5HAcWSCEeKFfdK0gKYFLQ")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeV2Code.IssueFraction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round the entitlement down to the last full unit/minimum nominal quantity, fractions are discarded.
    /// Encoded/decoded by serializers as &quot;RDDN&quot;.
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_Pm4FYWSCEeKFfdK0gKYFLQ")]
    [Description(
        @"Round the entitlement down to the last full unit/minimum nominal quantity, fractions are discarded."
    )]
    RoundDown = FractionDispositionTypeV2Code.RoundDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down as specified in the respective RDUP and RDDN codes.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_Pvz-8WSCEeKFfdK0gKYFLQ")]
    [Description(
        @"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down as specified in the respective RDUP and RDDN codes."
    )]
    RoundToNearest = FractionDispositionTypeV2Code.RoundToNearest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up to the next full unit/minimum nominal quantity at no cost.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_PypQgWSCEeKFfdK0gKYFLQ")]
    [Description(@"Round up to the next full unit/minimum nominal quantity at no cost.")]
    RoundUp = FractionDispositionTypeV2Code.RoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_QNn8UWSCEeKFfdK0gKYFLQ")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown = FractionDispositionTypeV2Code.Unknown, // same ordinal as derivation source for type conversions
}
