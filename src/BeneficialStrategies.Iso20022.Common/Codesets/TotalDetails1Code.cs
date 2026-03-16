// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ILmMsN6TEeiwsev40qZGEQ")]
[Description(
    @"Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation."
)]
[DerivedFrom(typeof(TotalDetailsCode))]
public enum TotalDetails1Code
{
    /// <summary>
    /// Give the totals result per Operator Identification value.
    /// Encoded/decoded by serializers as &quot;OPID&quot;.
    /// </summary>
    [EnumMember(Value = "OPID")]
    [IsoId("_KYx18d6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Operator Identification value.")]
    PerCashierIdentification = TotalDetailsCode.PerCashierIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Give the totals result per POI Identification value.
    /// Encoded/decoded by serializers as &quot;PIID&quot;.
    /// </summary>
    [EnumMember(Value = "PIID")]
    [IsoId("_KcKhId6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per POI Identification value.")]
    PerPOIIdentification = TotalDetailsCode.PerPOIIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Give the totals result per Totals Group Identification value.
    /// Encoded/decoded by serializers as &quot;TGID&quot;.
    /// </summary>
    [EnumMember(Value = "TGID")]
    [IsoId("_KplSEd6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Totals Group Identification value.")]
    PerTotalsGroup = TotalDetailsCode.PerTotalsGroup, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Give the totals result per Shift Number Identification value.
    /// Encoded/decoded by serializers as &quot;SNID&quot;.
    /// </summary>
    [EnumMember(Value = "SNID")]
    [IsoId("_Ks-kUd6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Shift Number Identification value.")]
    PerShiftNumber = TotalDetailsCode.PerShiftNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Give the totals result per Sale Identification value.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_KwBRQd6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Sale Identification value.")]
    PerSaleIdentification = TotalDetailsCode.PerSaleIdentification, // same ordinal as derivation source for type conversions
}
