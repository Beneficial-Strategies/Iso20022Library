// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UkVd4GSCEeKFfdK0gKYFLQ")]
[Description(@"Indicates that fractional value should be retained; no rounding.")]
[DerivedFrom(typeof(FractionDispositionTypeV2Code))]
public enum FractionDispositionType10Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_XLY_sWSCEeKFfdK0gKYFLQ")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp = FractionDispositionTypeV2Code.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_XVO4MWSCEeKFfdK0gKYFLQ")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction = FractionDispositionTypeV2Code.CashInLieuOfFraction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_XtEwcWSCEeKFfdK0gKYFLQ")]
    [Description(@"Let fractions expire worthless.")]
    Expire = FractionDispositionTypeV2Code.Expire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_YNHicWSCEeKFfdK0gKYFLQ")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeV2Code.IssueFraction, // same ordinal as derivation source for type conversions
}
