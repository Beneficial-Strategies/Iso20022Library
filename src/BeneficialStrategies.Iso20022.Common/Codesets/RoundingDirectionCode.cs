// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rounding direction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-LZ9Np-Ed-ak6NoX_4Aeg_404618713")]
[Description(@"Specifies the rounding direction.")]
[Derivations(typeof(RoundingDirection1Code),typeof(RoundingDirection2Code))]
public enum RoundingDirectionCode
{
    /// <summary>
    /// Pre-allocate shares only if fully dealt.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_Y-LZ9dp-Ed-ak6NoX_4Aeg_1751583430")]
    [Description(@"Pre-allocate shares only if fully dealt.")]
    Full,
    
    /// <summary>
    /// No fractional shares are allowed.
    /// Encoded/decoded by serializers as &quot;NOFR&quot;.
    /// </summary>
    [EnumMember(Value = "NOFR")]
    [IsoId("_Y-LZ9tp-Ed-ak6NoX_4Aeg_1751583431")]
    [Description(@"No fractional shares are allowed.")]
    NoFraction,
    
    /// <summary>
    /// In case of a partial fill, pro-rate the allocations.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_Y-LZ99p-Ed-ak6NoX_4Aeg_1751583432")]
    [Description(@"In case of a partial fill, pro-rate the allocations.")]
    ProRate,
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_Y-LZ-Np-Ed-ak6NoX_4Aeg_1751583433")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp,
    
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDWN&quot;.
    /// </summary>
    [EnumMember(Value = "RDWN")]
    [IsoId("_Y-Uj4Np-Ed-ak6NoX_4Aeg_1751583434")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown,
    
    /// <summary>
    /// Round up or down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_Y-Uj4dp-Ed-ak6NoX_4Aeg_2066033829")]
    [Description(@"Round up or down to the nearest whole number.")]
    RoundToNearest,
    
    /// <summary>
    /// Do not round.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_Y-Uj4tp-Ed-ak6NoX_4Aeg_2066033830")]
    [Description(@"Do not round.")]
    IssueFraction,
    
    /// <summary>
    /// Do not pro-rate; discuss first.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_Y-Uj49p-Ed-ak6NoX_4Aeg_-1000435685")]
    [Description(@"Do not pro-rate; discuss first.")]
    DiscussFirst,
    
    /// <summary>
    /// Pre-allocate according to the amounts shown in a linked allocation instruction.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_Y-Uj5Np-Ed-ak6NoX_4Aeg_979483854")]
    [Description(@"Pre-allocate according to the amounts shown in a linked allocation instruction.")]
    Specific,
    
    /// <summary>
    /// Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down.
    /// Encoded/decoded by serializers as &quot;SSTD&quot;.
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_Y-Uj5dp-Ed-ak6NoX_4Aeg_-1928673858")]
    [Description(@"Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down.")]
    Standard,
    
    /// <summary>
    /// Indicates that fractional value should be retained; no rounding.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_Y-Uj5tp-Ed-ak6NoX_4Aeg_-1928673766")]
    [Description(@"Indicates that fractional value should be retained; no rounding.")]
    Retain,
    
}
