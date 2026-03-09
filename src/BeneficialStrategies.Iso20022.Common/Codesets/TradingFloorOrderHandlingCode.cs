// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the parameters under which an order must be handled on the floor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yq878Np-Ed-ak6NoX_4Aeg_337179655")]
[Description(@"Description of the parameters under which an order must be handled on the floor.")]
[Derivations(typeof(TradingFloorOrderHandling1Code))]
public enum TradingFloorOrderHandlingCode
{
    /// <summary>
    /// Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.
    /// Encoded/decoded by serializers as &quot;ATPR&quot;.
    /// </summary>
    [EnumMember(Value = "ATPR")]
    [IsoId("_Yq878dp-Ed-ak6NoX_4Aeg_337179656")]
    [Description(@"Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.")]
    AutomatedPrivate,
    
    /// <summary>
    /// Indicates that the order should be executed automatically, public initiative, broker intervention allowed.
    /// Encoded/decoded by serializers as &quot;ATPU&quot;.
    /// </summary>
    [EnumMember(Value = "ATPU")]
    [IsoId("_Yq878tp-Ed-ak6NoX_4Aeg_337179657")]
    [Description(@"Indicates that the order should be executed automatically, public initiative, broker intervention allowed.")]
    AutomatedPublic,
    
    /// <summary>
    /// Manual order, best execution.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_Yq8789p-Ed-ak6NoX_4Aeg_337179658")]
    [Description(@"Manual order, best execution.")]
    Manual,
    
}
