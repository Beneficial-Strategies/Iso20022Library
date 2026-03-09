// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsCg1ph8EeumhIk_Pv20Lg")]
[Description(@"Common report status for all individual reports sent / received.")]
[Derivations(typeof(PairedReconciled3Code))]
public enum PairedReconciledV2Code
{
    /// <summary>
    /// Both loan and collateral matched.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YsCg2Zh8EeumhIk_Pv20Lg")]
    [Description(@"Both loan and collateral matched.")]
    Reconciled,
    
    /// <summary>
    /// Loan is paired, but not reconciled.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_YsCg2Jh8EeumhIk_Pv20Lg")]
    [Description(@"Loan is paired, but not reconciled.")]
    Paired,
    
    /// <summary>
    /// Loan is unpaired.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_YsCg25h8EeumhIk_Pv20Lg")]
    [Description(@"Loan is unpaired.")]
    Unpaired,
    
    /// <summary>
    /// Loan paired and matched.
    /// Encoded/decoded by serializers as &quot;LNRC&quot;.
    /// </summary>
    [EnumMember(Value = "LNRC")]
    [IsoId("_YsCg2ph8EeumhIk_Pv20Lg")]
    [Description(@"Loan paired and matched.")]
    LoanReconciled,
    
    /// <summary>
    /// Collateral associated with the loan(s) matched.
    /// Encoded/decoded by serializers as &quot;CLRC&quot;.
    /// </summary>
    [EnumMember(Value = "CLRC")]
    [IsoId("_YsCg15h8EeumhIk_Pv20Lg")]
    [Description(@"Collateral associated with the loan(s) matched.")]
    CollateralReconciled,
    
}
