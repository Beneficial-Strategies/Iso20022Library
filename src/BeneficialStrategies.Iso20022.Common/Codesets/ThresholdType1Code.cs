// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines whether the threshold was applied on an unsecured or securited basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YgYDotp-Ed-ak6NoX_4Aeg_-651849166")]
[Description(@"Defines whether the threshold was applied on an unsecured or securited basis.")]
[DerivedFrom(typeof(ThresholdTypeCode))]
public enum ThresholdType1Code
{
    /// <summary>
    /// Means that once the threshold is breached, collateral must be posted to cover the full exposure.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YgYDo9p-Ed-ak6NoX_4Aeg_-1711823422")]
    [Description(
        @"Means that once the threshold is breached, collateral must be posted to cover the full exposure."
    )]
    Secured = ThresholdTypeCode.Secured, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Means that the threshold provides a predetermined level of free trading. Once the threshold is breached, collateral must be posted to cover the exposure over and above the threshold level.
    /// Encoded/decoded by serializers as &quot;UNSE&quot;.
    /// </summary>
    [EnumMember(Value = "UNSE")]
    [IsoId("_YgYDpNp-Ed-ak6NoX_4Aeg_-244674659")]
    [Description(
        @"Means that the threshold provides a predetermined level of free trading. Once the threshold is breached, collateral must be posted to cover the exposure over and above the threshold level."
    )]
    Unsecured = ThresholdTypeCode.Unsecured, // same ordinal as derivation source for type conversions
}
