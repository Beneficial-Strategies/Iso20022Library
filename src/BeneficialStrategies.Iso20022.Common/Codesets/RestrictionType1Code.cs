// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcArmliEeGaMcKyqKNRfQ_2033612003")]
[Description(@"Specifies the type of restriction.")]
[DerivedFrom(typeof(RestrictionTypeCode))]
public enum RestrictionType1Code
{
    /// <summary>
    /// Selling restriction.
    /// Encoded/decoded by serializers as &quot;SELR&quot;.
    /// </summary>
    [EnumMember(Value = "SELR")]
    [IsoId("_hbcAr2liEeGaMcKyqKNRfQ_-1297174021")]
    [Description(@"Selling restriction.")]
    Selling = RestrictionTypeCode.Selling, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buying restriction.
    /// Encoded/decoded by serializers as &quot;BUYR&quot;.
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_hbcAsGliEeGaMcKyqKNRfQ_-268302593")]
    [Description(@"Buying restriction.")]
    Buying = RestrictionTypeCode.Buying, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Placing restriction.
    /// Encoded/decoded by serializers as &quot;PLAR&quot;.
    /// </summary>
    [EnumMember(Value = "PLAR")]
    [IsoId("_hbcAsWliEeGaMcKyqKNRfQ_809717745")]
    [Description(@"Placing restriction.")]
    Placing = RestrictionTypeCode.Placing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding restriction.
    /// Encoded/decoded by serializers as &quot;HOLR&quot;.
    /// </summary>
    [EnumMember(Value = "HOLR")]
    [IsoId("_hblKkGliEeGaMcKyqKNRfQ_-1548024378")]
    [Description(@"Holding restriction.")]
    Holding = RestrictionTypeCode.Holding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voting restriction.
    /// Encoded/decoded by serializers as &quot;VOTR&quot;.
    /// </summary>
    [EnumMember(Value = "VOTR")]
    [IsoId("_hblKkWliEeGaMcKyqKNRfQ_798618968")]
    [Description(@"Voting restriction.")]
    Voting = RestrictionTypeCode.Voting, // same ordinal as derivation source for type conversions
}
