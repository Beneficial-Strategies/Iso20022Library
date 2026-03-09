// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the collateral substitution request is new or updated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcDkUdp-Ed-ak6NoX_4Aeg_406031234")]
[Description(@"Indicates whether the collateral substitution request is new or updated.")]
[Derivations(typeof(CollateralSubstitutionSequence1Code))]
public enum CollateralSubstitutionSequenceCode
{
    /// <summary>
    /// Indicates this is a new collateral substitution request.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YcDkUtp-Ed-ak6NoX_4Aeg_556952094")]
    [Description(@"Indicates this is a new collateral substitution request.")]
    Initial,
    
    /// <summary>
    /// Indicates this is an updated collateral substitution request.
    /// Encoded/decoded by serializers as &quot;UPDD&quot;.
    /// </summary>
    [EnumMember(Value = "UPDD")]
    [IsoId("_YcDkU9p-Ed-ak6NoX_4Aeg_-1690630387")]
    [Description(@"Indicates this is an updated collateral substitution request.")]
    Updated,
    
}
