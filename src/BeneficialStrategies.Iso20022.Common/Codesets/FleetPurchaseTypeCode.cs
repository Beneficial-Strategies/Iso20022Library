// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of codes representing type of fleet purchases.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I2eB0_jCEeiJaN6-Lf-c_w")]
[Description(@"List of codes representing type of fleet purchases.")]
[Derivations(typeof(FleetPurchaseType1Code))]
public enum FleetPurchaseTypeCode
{
    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_I2eB1PjCEeiJaN6-Lf-c_w")]
    [Description(@"Fuel")]
    Fuel,
    
    /// <summary>
    /// Non fuel
    /// Encoded/decoded by serializers as &quot;NONF&quot;.
    /// </summary>
    [EnumMember(Value = "NONF")]
    [IsoId("_I2eB1fjCEeiJaN6-Lf-c_w")]
    [Description(@"Non fuel")]
    NonFuel,
    
    /// <summary>
    /// Fuel and non fuel
    /// Encoded/decoded by serializers as &quot;FANF&quot;.
    /// </summary>
    [EnumMember(Value = "FANF")]
    [IsoId("_eghTcPjCEeiJaN6-Lf-c_w")]
    [Description(@"Fuel and non fuel")]
    FuelAndNonFuel,
    
}
