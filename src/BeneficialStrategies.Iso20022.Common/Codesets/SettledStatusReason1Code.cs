// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a partially settled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKsL8dp-Ed-ak6NoX_4Aeg_228584754")]
[Description(@"Specifies the reason for a partially settled status.")]
[DerivedFrom(typeof(SettledStatusReasonCode))]
public enum SettledStatusReason1Code
{
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as &quot;UPST&quot;.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZKsL8tp-Ed-ak6NoX_4Aeg_514877099")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled = SettledStatusReasonCode.UnitsPartiallySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZKsL89p-Ed-ak6NoX_4Aeg_514877159")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled = SettledStatusReasonCode.CashPartiallySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as &quot;UCPS&quot;.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZKsL9Np-Ed-ak6NoX_4Aeg_514878209")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled = SettledStatusReasonCode.UnitsCashPartiallySettled, // same ordinal as derivation source for type conversions
    
}
