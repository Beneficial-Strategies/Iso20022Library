// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a settlement failure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amyWh9p-Ed-ak6NoX_4Aeg_534843622")]
[Description(@"Specifies the reason of a settlement failure.")]
[Derivations(typeof(FailedSettlementReason1Code))]
public enum FailedSettlementReasonCode
{
    /// <summary>
    /// Credit account is not eligible.
    /// Encoded/decoded by serializers as &quot;CANE&quot;.
    /// </summary>
    [EnumMember(Value = "CANE")]
    [IsoId("_amyWiNp-Ed-ak6NoX_4Aeg_822057797")]
    [Description(@"Credit account is not eligible.")]
    CreditAccountNotEligible,
    
    /// <summary>
    /// Credit account is disabled.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_am7gcNp-Ed-ak6NoX_4Aeg_822058068")]
    [Description(@"Credit account is disabled.")]
    CreditAccountDisabled,
    
    /// <summary>
    /// Debit account is not eligible.
    /// Encoded/decoded by serializers as &quot;DANE&quot;.
    /// </summary>
    [EnumMember(Value = "DANE")]
    [IsoId("_am7gcdp-Ed-ak6NoX_4Aeg_822058076")]
    [Description(@"Debit account is not eligible.")]
    DebitAccountNotEligible,
    
    /// <summary>
    /// Debit account is disabled.
    /// Encoded/decoded by serializers as &quot;AADI&quot;.
    /// </summary>
    [EnumMember(Value = "AADI")]
    [IsoId("_am7gctp-Ed-ak6NoX_4Aeg_822058099")]
    [Description(@"Debit account is disabled.")]
    DebitAccountDisabled,
    
    /// <summary>
    /// Insufficient securities on the account to settle.
    /// Encoded/decoded by serializers as &quot;INSE&quot;.
    /// </summary>
    [EnumMember(Value = "INSE")]
    [IsoId("_am7gc9p-Ed-ak6NoX_4Aeg_822058107")]
    [Description(@"Insufficient securities on the account to settle.")]
    InsufficientSecurities,
    
    /// <summary>
    /// The distribution is incomplete.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_am7gdNp-Ed-ak6NoX_4Aeg_822058129")]
    [Description(@"The distribution is incomplete.")]
    IncompleteDistribution,
    
    /// <summary>
    /// Insufficient cash on the account to settle.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_am7gddp-Ed-ak6NoX_4Aeg_822058130")]
    [Description(@"Insufficient cash on the account to settle.")]
    InsufficientCash,
    
}
