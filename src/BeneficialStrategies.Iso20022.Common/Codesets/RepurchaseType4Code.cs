// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTx2hNp-Ed-ak6NoX_4Aeg_657240655")]
[Description(@"Specifies the type of repurchase process.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
public enum RepurchaseType4Code
{
    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZTx2hdp-Ed-ak6NoX_4Aeg_708958784")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall = RepurchaseTypeCode.RepurchaseCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZTx2htp-Ed-ak6NoX_4Aeg_708958801")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeCode.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZTx2h9p-Ed-ak6NoX_4Aeg_708958802")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Rollover = RepurchaseTypeCode.Rollover, // same ordinal as derivation source for type conversions
}
