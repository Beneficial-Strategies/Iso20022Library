// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of allowed balance adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6URjBJqlEeGSON8vddiWzQ_7389297")]
[Description(@"Defines the type of allowed balance adjustment.")]
[DerivedFrom(typeof(BalanceAdjustmentTypeCode))]
public enum BalanceAdjustmentType1Code
{
    /// <summary>
    /// Adjustment applies to the average ledger (book) balance.
    /// Encoded/decoded by serializers as &quot;LDGR&quot;.
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_6URjBZqlEeGSON8vddiWzQ_-1813350112")]
    [Description(@"Adjustment applies to the average ledger (book) balance.")]
    Ledger = BalanceAdjustmentTypeCode.Ledger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment applies to the average float (unavailable) balance.
    /// Encoded/decoded by serializers as &quot;FLOT&quot;.
    /// </summary>
    [EnumMember(Value = "FLOT")]
    [IsoId("_6URjBpqlEeGSON8vddiWzQ_-1052584959")]
    [Description(@"Adjustment applies to the average float (unavailable) balance.")]
    Float = BalanceAdjustmentTypeCode.Float, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment applies to the average collected (book less float) balance.
    /// Encoded/decoded by serializers as &quot;CLLD&quot;.
    /// </summary>
    [EnumMember(Value = "CLLD")]
    [IsoId("_6URjB5qlEeGSON8vddiWzQ_414563804")]
    [Description(@"Adjustment applies to the average collected (book less float) balance.")]
    Collected = BalanceAdjustmentTypeCode.Collected, // same ordinal as derivation source for type conversions
}
