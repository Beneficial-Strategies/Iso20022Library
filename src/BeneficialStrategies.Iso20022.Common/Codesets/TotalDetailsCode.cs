// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uDmwIN6SEeiwsev40qZGEQ")]
[Description(@"Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.")]
[Derivations(typeof(TotalDetails1Code))]
public enum TotalDetailsCode
{
    /// <summary>
    /// Give the totals result per POI Identification value.
    /// Encoded/decoded by serializers as &quot;PIID&quot;.
    /// </summary>
    [EnumMember(Value = "PIID")]
    [IsoId("_2UMGQN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per POI Identification value.")]
    PerPOIIdentification,
    
    /// <summary>
    /// Give the totals result per Sale Identification value.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_2Yc7MN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Sale Identification value.")]
    PerSaleIdentification,
    
    /// <summary>
    /// Give the totals result per Operator Identification value.
    /// Encoded/decoded by serializers as &quot;OPID&quot;.
    /// </summary>
    [EnumMember(Value = "OPID")]
    [IsoId("_2czPsN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Operator Identification value.")]
    PerCashierIdentification,
    
    /// <summary>
    /// Give the totals result per Totals Group Identification value.
    /// Encoded/decoded by serializers as &quot;TGID&quot;.
    /// </summary>
    [EnumMember(Value = "TGID")]
    [IsoId("_2mfXMN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Totals Group Identification value.")]
    PerTotalsGroup,
    
    /// <summary>
    /// Give the totals result per Shift Number Identification value.
    /// Encoded/decoded by serializers as &quot;SNID&quot;.
    /// </summary>
    [EnumMember(Value = "SNID")]
    [IsoId("_Af9WsN6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Shift Number Identification value.")]
    PerShiftNumber,
    
}
