// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the quantity sought type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oiLwzL3EeKU9IrkkToqcw_-1345943536")]
[Description(@"Specifies the quantity sought type.")]
[Derivations(typeof(DTCCQuantitySought1Code))]
public enum DTCCQuantitySoughtCode
{
    /// <summary>
    /// Quantity Sought expressed as quantity.
    /// Encoded/decoded by serializers as &quot;QTTY&quot;.
    /// </summary>
    [EnumMember(Value = "QTTY")]
    [IsoId("_1oiLxDL3EeKU9IrkkToqcw_1656668752")]
    [Description(@"Quantity Sought expressed as quantity.")]
    Quantity,
    
    /// <summary>
    /// Check Quantity Sought Comments for quantity sought (irregular expression).
    /// Encoded/decoded by serializers as &quot;CHCO&quot;.
    /// </summary>
    [EnumMember(Value = "CHCO")]
    [IsoId("_1oiLxTL3EeKU9IrkkToqcw_-517245427")]
    [Description(@"Check Quantity Sought Comments for quantity sought (irregular expression).")]
    CheckComments,
    
    /// <summary>
    /// Quantity sought is expressed as percentage.
    /// Encoded/decoded by serializers as &quot;PRTG&quot;.
    /// </summary>
    [EnumMember(Value = "PRTG")]
    [IsoId("_1orVsDL3EeKU9IrkkToqcw_1342787087")]
    [Description(@"Quantity sought is expressed as percentage.")]
    Percentage,
    
}
