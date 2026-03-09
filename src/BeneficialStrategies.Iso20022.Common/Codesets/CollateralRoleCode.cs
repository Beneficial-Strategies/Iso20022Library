// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_glgtoCDCEeaned5xL18mUQ")]
[Description(@"Identifies whether the reporting counterparty is a collateral provider or a collateral taker.")]
[Derivations(typeof(CollateralRole1Code))]
public enum CollateralRoleCode
{
    /// <summary>
    /// Collateral taker. 
    /// Encoded/decoded by serializers as &quot;TAKE&quot;.
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_jS1PgCDCEeaned5xL18mUQ")]
    [Description(@"Collateral taker. ")]
    CollateralTaker,
    
    /// <summary>
    /// Collateral giver.
    /// Encoded/decoded by serializers as &quot;GIVE&quot;.
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_lgnVsCDCEeaned5xL18mUQ")]
    [Description(@"Collateral giver.")]
    CollateralGiver,
    
}
