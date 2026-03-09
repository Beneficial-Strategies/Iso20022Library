// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines whether the threshold was applied on an unsecured or securited basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YgYDpdp-Ed-ak6NoX_4Aeg_820677101")]
[Description(@"Defines whether the threshold was applied on an unsecured or securited basis.")]
[Derivations(typeof(ThresholdType1Code))]
public enum ThresholdTypeCode
{
    /// <summary>
    /// Means that once the threshold is breached, collateral must be posted to cover the full exposure.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YgYDptp-Ed-ak6NoX_4Aeg_1096006152")]
    [Description(@"Means that once the threshold is breached, collateral must be posted to cover the full exposure.")]
    Secured,
    
    /// <summary>
    /// Means that the threshold provides a predetermined level of free trading. Once the threshold is breached, collateral must be posted to cover the exposure over and above the threshold level.
    /// Encoded/decoded by serializers as &quot;UNSE&quot;.
    /// </summary>
    [EnumMember(Value = "UNSE")]
    [IsoId("_YgYDp9p-Ed-ak6NoX_4Aeg_1832001640")]
    [Description(@"Means that the threshold provides a predetermined level of free trading. Once the threshold is breached, collateral must be posted to cover the exposure over and above the threshold level.")]
    Unsecured,
    
}
