// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qBZgzL3EeKU9IrkkToqcw_633983663")]
[Description(
    @"Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security."
)]
[DerivedFrom(typeof(DTCBaseDisbursedCode))]
public enum DTCBaseDisbursed1Code
{
    /// <summary>
    /// Based on base security.
    /// Encoded/decoded by serializers as &quot;BASE&quot;.
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_1qBZhDL3EeKU9IrkkToqcw_-1482681313")]
    [Description(@"Based on base security.")]
    Base = DTCBaseDisbursedCode.Base, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Based on disbursed security.
    /// Encoded/decoded by serializers as &quot;DISB&quot;.
    /// </summary>
    [EnumMember(Value = "DISB")]
    [IsoId("_1qBZhTL3EeKU9IrkkToqcw_-1596520379")]
    [Description(@"Based on disbursed security.")]
    Disbursed = DTCBaseDisbursedCode.Disbursed, // same ordinal as derivation source for type conversions
}
