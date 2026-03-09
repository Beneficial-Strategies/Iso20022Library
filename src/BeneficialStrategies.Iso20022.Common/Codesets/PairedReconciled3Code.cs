// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8qwjMJiCEeumhIk_Pv20Lg")]
[Description(@"Common report status for all individual reports sent / received.")]
[DerivedFrom(typeof(PairedReconciledV2Code))]
public enum PairedReconciled3Code
{
    /// <summary>
    /// Collateral associated with the loan(s) matched.
    /// Encoded/decoded by serializers as &quot;CLRC&quot;.
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_ByvJoZiDEeumhIk_Pv20Lg")]
    [Description(@"Collateral associated with the loan(s) matched.")]
    CollateralReconciled = PairedReconciledV2Code.CollateralReconciled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loan paired and matched.
    /// Encoded/decoded by serializers as &quot;LNRC&quot;.
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_CKSG8ZiDEeumhIk_Pv20Lg")]
    [Description(@"Loan paired and matched.")]
    LoanReconciled = PairedReconciledV2Code.LoanReconciled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loan is paired, but not reconciled.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_CarTYZiDEeumhIk_Pv20Lg")]
    [Description(@"Loan is paired, but not reconciled.")]
    Paired = PairedReconciledV2Code.Paired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Both loan and collateral matched.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_Cg7sYZiDEeumhIk_Pv20Lg")]
    [Description(@"Both loan and collateral matched.")]
    Reconciled = PairedReconciledV2Code.Reconciled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loan is unpaired.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_CoYYMZiDEeumhIk_Pv20Lg")]
    [Description(@"Loan is unpaired.")]
    Unpaired = PairedReconciledV2Code.Unpaired, // same ordinal as derivation source for type conversions
    
}
