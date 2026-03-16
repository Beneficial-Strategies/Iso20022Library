// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8N7QU6MgEeCJ6YNENx4h-w_814542161")]
[Description(@"Specifies the type of standing order.")]
[Derivations(typeof(StandingOrderType1Code))]
public enum StandingOrderTypeCode
{
    /// <summary>
    /// Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.
    /// Encoded/decoded by serializers as &quot;USTO&quot;.
    /// </summary>
    [EnumMember(Value = "USTO")]
    [IsoId("_8N7QVKMgEeCJ6YNENx4h-w_-1951616938")]
    [Description(
        @"Liquidity transfer standing order type, that has been customised or defined to the specific need of the user."
    )]
    UserDefinedStandingOrder,

    /// <summary>
    /// Liquidity transfer standing order type, as predefined in the system.
    /// Encoded/decoded by serializers as &quot;PSTO&quot;.
    /// </summary>
    [EnumMember(Value = "PSTO")]
    [IsoId("_8N7QVaMgEeCJ6YNENx4h-w_1666330764")]
    [Description(@"Liquidity transfer standing order type, as predefined in the system.")]
    PredefinedStandingOrder,
}
