// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYaAsdp-Ed-ak6NoX_4Aeg_-51113838")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[Derivations(typeof(CancellationReason3Code),typeof(CancellationReason5Code),typeof(CancellationReason1Code),typeof(CancellationReason4Code),typeof(CancellationReason2Code))]
public enum CancellationReasonCode
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bYaAstp-Ed-ak6NoX_4Aeg_870293849")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bYaAs9p-Ed-ak6NoX_4Aeg_870294322")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bYaAtNp-Ed-ak6NoX_4Aeg_870294347")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bYaAtdp-Ed-ak6NoX_4Aeg_870294364")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bYaAttp-Ed-ak6NoX_4Aeg_870294382")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Payment is a suspicious payment.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bYaAt9p-Ed-ak6NoX_4Aeg_881376013")]
    [Description(@"Payment is a suspicious payment.")]
    SuspiciousPayment,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_bYaAuNp-Ed-ak6NoX_4Aeg_-1860763140")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_bYjKoNp-Ed-ak6NoX_4Aeg_-1731468970")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as &quot;CUTA&quot;.
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_bYjKodp-Ed-ak6NoX_4Aeg_1014049617")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_t9NxNFkyEeGeoaLUQk__nA_-772063853")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_t9XiMFkyEeGeoaLUQk__nA_34147394")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
    /// <summary>
    /// Cover payment has been cancelled or returned.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_rCYTIByoEeispO42NVVLrw")]
    [Description(@"Cover payment has been cancelled or returned.")]
    CoverCancelledOrReturned,
    
}
