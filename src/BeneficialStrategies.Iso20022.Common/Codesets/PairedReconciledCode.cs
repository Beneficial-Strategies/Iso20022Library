// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8y6XACmsEeerta_tWXAsWQ")]
[Description(@"Common report status for all individual reports sent / received.")]
[Derivations(typeof(PairedReconciled1Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum PairedReconciledCode
{
    /// <summary>
    /// Reconciled.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_AjtvICmtEeerta_tWXAsWQ")]
    [Description(@"Reconciled.")]
    Reconciled,

    /// <summary>
    /// Paired.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_BvjQICmtEeerta_tWXAsWQ")]
    [Description(@"Paired.")]
    Paired,

    /// <summary>
    /// Status should be reported when the loan is unpaired.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_U0AQkGofEeu35dLEXN5XLw")]
    [Description(@"Status should be reported when the loan is unpaired.")]
    Unpaired,

    /// <summary>
    /// Status should be reported when the loan was paired and matched.
    /// Encoded/decoded by serializers as &quot;LNRC&quot;.
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_C-AocHBLEeuTl53AHNKO7w")]
    [Description(@"Status should be reported when the loan was paired and matched.")]
    LoanReconciled,

    /// <summary>
    /// Status should be reported when the collateral associated with the loan(s) was matched.
    /// Encoded/decoded by serializers as &quot;CLRC&quot;.
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_S6_CgHBLEeuTl53AHNKO7w")]
    [Description(
        @"Status should be reported when the collateral associated with the loan(s) was matched."
    )]
    CollateralReconciled,
}
