// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the parameters under which an order must be handled on the floor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqzyBdp-Ed-ak6NoX_4Aeg_530358384")]
[Description(@"Description of the parameters under which an order must be handled on the floor.")]
[DerivedFrom(typeof(TradingFloorOrderHandlingCode))]
public enum TradingFloorOrderHandling1Code
{
    /// <summary>
    /// Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.
    /// Encoded/decoded by serializers as &quot;ATPR&quot;.
    /// </summary>
    [EnumMember(Value = "ATPR")]
    [IsoId("_YqzyBtp-Ed-ak6NoX_4Aeg_828654274")]
    [Description(@"Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.")]
    AutomatedPrivate = TradingFloorOrderHandlingCode.AutomatedPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order should be executed automatically, public initiative, broker intervention allowed.
    /// Encoded/decoded by serializers as &quot;ATPU&quot;.
    /// </summary>
    [EnumMember(Value = "ATPU")]
    [IsoId("_YqzyB9p-Ed-ak6NoX_4Aeg_828654317")]
    [Description(@"Indicates that the order should be executed automatically, public initiative, broker intervention allowed.")]
    AutomatedPublic = TradingFloorOrderHandlingCode.AutomatedPublic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual order, best execution.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_YqzyCNp-Ed-ak6NoX_4Aeg_828654352")]
    [Description(@"Manual order, best execution.")]
    Manual = TradingFloorOrderHandlingCode.Manual, // same ordinal as derivation source for type conversions
    
}
