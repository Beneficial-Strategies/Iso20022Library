// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of settlement advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JpEXQHygEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of settlement advice.")]
[Derivations(typeof(SettlementAdviceType1Code))]
public enum SettlementAdviceTypeCode
{
    /// <summary>
    /// Settlement advice related to an undertaking issuance.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_3zXEgHygEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking issuance.")]
    UndertakingIssuance,
    
    /// <summary>
    /// Settlement advice related to a claim for payment.
    /// Encoded/decoded by serializers as &quot;CLAM&quot;.
    /// </summary>
    [EnumMember(Value = "CLAM")]
    [IsoId("_4cpSEHygEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a claim for payment.")]
    PaymentClaim,
    
    /// <summary>
    /// Settlement advice related to an undertaking amendment.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_KKCg4HyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking amendment.")]
    UndertakingAmendment,
    
    /// <summary>
    /// Settlement advice related to an undertaking termination.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_R6UmUHyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking termination.")]
    Termination,
    
    /// <summary>
    /// Settlement advice related to a manual booking of charges.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_cCLAEHyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a manual booking of charges.")]
    ManualChargesBooking,
    
    /// <summary>
    /// Settlement advice related to an automatic booking of charges.
    /// Encoded/decoded by serializers as &quot;ACHG&quot;.
    /// </summary>
    [EnumMember(Value = "ACHG")]
    [IsoId("_j1SXEHyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an automatic booking of charges.")]
    AutomaticChargesBooking,
    
    /// <summary>
    /// Settlement advice related to a refund.
    /// Encoded/decoded by serializers as &quot;REFD&quot;.
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_sgvEQHyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a refund.")]
    Refund,
    
    /// <summary>
    /// Settlement advice related to correspondent bank charges.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_yKlosHyhEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to correspondent bank charges.")]
    CorrespondentBankCharges,
    
}
