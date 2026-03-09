// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z7RUV9p-Ed-ak6NoX_4Aeg_-481257913")]
[Description(@"Indicates the status of a single payment transaction or of a group of payment transactions.")]
[Derivations(typeof(TransactionIndividualStatus2Code),typeof(CancellationIndividualStatus1Code),typeof(TransactionGroupStatus2Code),typeof(TransactionIndividualStatus5Code),typeof(TransactionIndividualStatus4Code),typeof(PartialGroupStatus1Code),typeof(ValidationGroupStatus1Code),typeof(ValidationGroupStatus2Code),typeof(GroupCancellationStatus1Code),typeof(TransactionGroupStatus1Code),typeof(CancellationIndividualStatus2Code),typeof(TransactionIndividualStatus3Code),typeof(PartialGroupStatus2Code),typeof(TransactionGroupStatus3Code),typeof(TransactionIndividualStatus1Code))]
public enum PaymentStatusCode
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Z7RUWNp-Ed-ak6NoX_4Aeg_-451704730")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Payment initiation has been received by the receiving agent.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_Z7bFUNp-Ed-ak6NoX_4Aeg_-1507094868")]
    [Description(@"Payment initiation has been received by the receiving agent.")]
    Received,
    
    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved &apos;accepted&apos; status.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Z7bFUdp-Ed-ak6NoX_4Aeg_-1496935674")]
    [Description(@"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Z7bFUtp-Ed-ak6NoX_4Aeg_-1496011653")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Z7bFU9p-Ed-ak6NoX_4Aeg_-1495088071")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.")]
    Pending,
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Z7bFVNp-Ed-ak6NoX_4Aeg_-1890634200")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_Z7bFVdp-Ed-ak6NoX_4Aeg_-1889712538")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_Z7bFVtp-Ed-ak6NoX_4Aeg_-1888790569")]
    [Description(@"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// Request is accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_Z7bFV9p-Ed-ak6NoX_4Aeg_438394182")]
    [Description(@"Request is accepted.")]
    Accepted,
    
    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_Z7bFWNp-Ed-ak6NoX_4Aeg_-142722251")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_Z7bFWdp-Ed-ak6NoX_4Aeg_-142722191")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_Z7kPQNp-Ed-ak6NoX_4Aeg_-142721883")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange,
    
    /// <summary>
    /// Cancellation is partially accepted.
    /// Encoded/decoded by serializers as &quot;PACR&quot;.
    /// </summary>
    [EnumMember(Value = "PACR")]
    [IsoId("_Z7kPQdp-Ed-ak6NoX_4Aeg_-1563496056")]
    [Description(@"Cancellation is partially accepted.")]
    PartiallyAcceptedCancellationRequest,
    
    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_Z7kPQtp-Ed-ak6NoX_4Aeg_-1562576023")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest,
    
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed. 
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_qm694KZpEeatnf2letP_og")]
    [Description(@"Settlement on the creditor's account has been completed. ")]
    AcceptedCreditSettlementCompleted,
    
    /// <summary>
    /// Payment is cancelled.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_YZlTYBylEeispO42NVVLrw")]
    [Description(@"Payment is cancelled.")]
    PaymentCancelled,
    
    /// <summary>
    /// There is no cancellation process ongoing
    /// Encoded/decoded by serializers as &quot;NULL&quot;.
    /// </summary>
    [EnumMember(Value = "NULL")]
    [IsoId("_hUfY4BylEeispO42NVVLrw")]
    [Description(@"There is no cancellation process ongoing")]
    NoCancellationProcess,
    
}
