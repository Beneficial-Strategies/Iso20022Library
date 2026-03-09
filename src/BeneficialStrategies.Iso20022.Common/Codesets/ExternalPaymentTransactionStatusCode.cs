// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an individual payment instructions, as published in an external payment transaction status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mTPNQLf8Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the status of an individual payment instructions, as published in an external payment transaction status code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPaymentTransactionStatus1Code))]
public enum ExternalPaymentTransactionStatusCode
{
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed.
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_uV_hKfRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement on the creditor's account has been completed.")]
    AcceptedSettlementCompletedCreditorAccount,
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_uWIrEPRYEeuLhpyIdtJzwg")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// Preceding check of technical validation and customer profile was successful and an automatic funds check was positive.
    /// Encoded/decoded by serializers as &quot;ACFC&quot;.
    /// </summary>
    [EnumMember(Value = "ACFC")]
    [IsoId("_uWIrE_RYEeuLhpyIdtJzwg")]
    [Description(@"Preceding check of technical validation and customer profile was successful and an automatic funds check was positive.")]
    AcceptedFundsChecked,
    
    /// <summary>
    /// Payment instruction to issue a cheque has been accepted, and the cheque has been issued but not yet been deposited or cleared.
    /// Encoded/decoded by serializers as &quot;ACIS&quot;.
    /// </summary>
    [EnumMember(Value = "ACIS")]
    [IsoId("_uWIrFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction to issue a cheque has been accepted, and the cheque has been issued but not yet been deposited or cleared.")]
    AcceptedandChequeIssued,
    
    /// <summary>
    /// Settlement completed.|Usage : this can be used by a Market Infrastructure reporting to Infrastructure Participant or an Account Servicer to Account Owner to report that the transaction account entry has been completed.|Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_uWIrGfRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement completed.|Usage : this can be used by a Market Infrastructure reporting to Infrastructure Participant or an Account Servicer to Account Owner to report that the transaction account entry has been completed.|Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|")]
    AcceptedSettlementCompletedDebitorAccount,
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment instruction has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_uWIrHPRYEeuLhpyIdtJzwg")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment instruction has been accepted for execution.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_uWScEPRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication and syntactical and semantical validation are successful")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_uWScE_RYEeuLhpyIdtJzwg")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange,
    
    /// <summary>
    /// Payment instruction included in the credit transfer is accepted without being posted to the creditor customer’s account.
    /// Encoded/decoded by serializers as &quot;ACWP&quot;.
    /// </summary>
    [EnumMember(Value = "ACWP")]
    [IsoId("_uWcNEPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction included in the credit transfer is accepted without being posted to the creditor customer’s account.")]
    AcceptedWithoutPosting,
    
    /// <summary>
    /// Payment transaction previously reported with status &apos;ACWP&apos; is blocked, for example, funds will neither be posted to the Creditor&apos;s account, nor be returned to the Debtor.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_uWcNE_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment transaction previously reported with status 'ACWP' is blocked, for example, funds will neither be posted to the Creditor's account, nor be returned to the Debtor.")]
    Blocked,
    
    /// <summary>
    /// Payment initiation has been successfully cancelled after having received a request for cancellation.|Usage: code to be used in the context of APIs only.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_uWcNFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment initiation has been successfully cancelled after having received a request for cancellation.|Usage: code to be used in the context of APIs only.")]
    Cancelled,
    
    /// <summary>
    /// Cash has been picked up by the Creditor.
    /// Encoded/decoded by serializers as &quot;CPUC&quot;.
    /// </summary>
    [EnumMember(Value = "CPUC")]
    [IsoId("_uWcNGfRYEeuLhpyIdtJzwg")]
    [Description(@"Cash has been picked up by the Creditor.")]
    CashPickedUpByCreditor,
    
    /// <summary>
    /// Payment initiation needs multiple authentications, where some but not yet all have been performed. Syntactical and semantical validations are successful.
    /// Encoded/decoded by serializers as &quot;PATC&quot;.
    /// </summary>
    [EnumMember(Value = "PATC")]
    [IsoId("_uWlXAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment initiation needs multiple authentications, where some but not yet all have been performed. Syntactical and semantical validations are successful.")]
    PartiallyAcceptedTechnicalCorrect,
    
    /// <summary>
    /// Payment instruction is pending. Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_uWlXA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction is pending. Further checks and status update will be performed.")]
    Pending,
    
    /// <summary>
    /// Request for Payment has been presented to the Debtor.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uWvIAPRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Payment has been presented to the Debtor.")]
    Presented,
    
    /// <summary>
    /// Payment instruction has been received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_uWvIA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction has been received.")]
    Received,
    
    /// <summary>
    /// Payment instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uW4R8PRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Status of transaction released from the Debtor Agent and accepted by the clearing.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_MjE0EOGIEeyiZZWde7CbVw")]
    [Description(@"Status of transaction released from the Debtor Agent and accepted by the clearing.")]
    AcceptedClearingProcessed,
    
}
