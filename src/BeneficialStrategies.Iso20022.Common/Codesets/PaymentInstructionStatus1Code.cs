// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VmaM6Np-Ed-ak6NoX_4Aeg_504928904")]
[Description(@"Specifies the state of a payment.")]
[DerivedFrom(typeof(PaymentInstructionStatusCode))]
public enum PaymentInstructionStatus1Code
{
    /// <summary>
    /// Transaction has been accepted by the clearing agent.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_VmaM6dp-Ed-ak6NoX_4Aeg_504928912")]
    [Description(@"Transaction has been accepted by the clearing agent.")]
    Accepted = PaymentInstructionStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been validated by the clearing agent.
    /// Encoded/decoded by serializers as &quot;VALD&quot;.
    /// </summary>
    [EnumMember(Value = "VALD")]
    [IsoId("_VmjW0Np-Ed-ak6NoX_4Aeg_504928913")]
    [Description(@"Transaction has been validated by the clearing agent.")]
    Validated = PaymentInstructionStatusCode.Validated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been authorised by the transaction administrator or authorised party.
    /// Encoded/decoded by serializers as &quot;AUTD&quot;.
    /// </summary>
    [EnumMember(Value = "AUTD")]
    [IsoId("_VmjW0dp-Ed-ak6NoX_4Aeg_504928914")]
    [Description(@"Transaction has been authorised by the transaction administrator or authorised party.")]
    Authorised = PaymentInstructionStatusCode.Authorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;INVD&quot;.
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_VmjW0tp-Ed-ak6NoX_4Aeg_504928915")]
    [Description(@"Transaction is invalid.")]
    Invalid = PaymentInstructionStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been matched with a corresponding transaction by the clearing agent.
    /// Encoded/decoded by serializers as &quot;MATD&quot;.
    /// </summary>
    [EnumMember(Value = "MATD")]
    [IsoId("_VmjW09p-Ed-ak6NoX_4Aeg_504928916")]
    [Description(@"Transaction has been matched with a corresponding transaction by the clearing agent.")]
    Matched = PaymentInstructionStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction but failed.
    /// Encoded/decoded by serializers as &quot;UMAC&quot;.
    /// </summary>
    [EnumMember(Value = "UMAC")]
    [IsoId("_VmjW1Np-Ed-ak6NoX_4Aeg_504928917")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction but failed.")]
    Unmatched = PaymentInstructionStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction, but some non-essential characteristics of both transactions failed to match.
    /// Encoded/decoded by serializers as &quot;MMTD&quot;.
    /// </summary>
    [EnumMember(Value = "MMTD")]
    [IsoId("_VmjW1dp-Ed-ak6NoX_4Aeg_504928929")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction, but some non-essential characteristics of both transactions failed to match.")]
    Mismatched = PaymentInstructionStatusCode.Mismatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for future settlement.
    /// Encoded/decoded by serializers as &quot;STLE&quot;.
    /// </summary>
    [EnumMember(Value = "STLE")]
    [IsoId("_VmjW1tp-Ed-ak6NoX_4Aeg_504928930")]
    [Description(@"Transaction is eligible for future settlement.")]
    SettlementEligible = PaymentInstructionStatusCode.SettlementEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for immediate settlement.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_VmjW19p-Ed-ak6NoX_4Aeg_504928931")]
    [Description(@"Transaction is eligible for immediate settlement.")]
    SettlementMature = PaymentInstructionStatusCode.SettlementMature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been suspended by the clearing agent.
    /// Encoded/decoded by serializers as &quot;SSPD&quot;.
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_VmtH0Np-Ed-ak6NoX_4Aeg_504928932")]
    [Description(@"Transaction has been suspended by the clearing agent.")]
    Suspended = PaymentInstructionStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.
    /// Encoded/decoded by serializers as &quot;PCAN&quot;.
    /// </summary>
    [EnumMember(Value = "PCAN")]
    [IsoId("_VmtH0dp-Ed-ak6NoX_4Aeg_504928933")]
    [Description(@"Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.")]
    PendingCancellation = PaymentInstructionStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for settlement, but is pending.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_VmtH0tp-Ed-ak6NoX_4Aeg_504928934")]
    [Description(@"Transaction is eligible for settlement, but is pending.")]
    PendingSettlement = PaymentInstructionStatusCode.PendingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction eligible for immediate settlement, has failed to settle.
    /// Encoded/decoded by serializers as &quot;PFST&quot;.
    /// </summary>
    [EnumMember(Value = "PFST")]
    [IsoId("_VmtH09p-Ed-ak6NoX_4Aeg_504928935")]
    [Description(@"Transaction eligible for immediate settlement, has failed to settle.")]
    PendingFailingSettlement = PaymentInstructionStatusCode.PendingFailingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Sender multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SMLR&quot;.
    /// </summary>
    [EnumMember(Value = "SMLR")]
    [IsoId("_VmtH1Np-Ed-ak6NoX_4Aeg_504928943")]
    [Description(@"Transaction causes the 'Sender multilateral limit' to be exceeded and cannot currently be processed.")]
    SenderMultilateralLimitRelated = PaymentInstructionStatusCode.SenderMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Receiver multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;RMLR&quot;.
    /// </summary>
    [EnumMember(Value = "RMLR")]
    [IsoId("_VmtH1dp-Ed-ak6NoX_4Aeg_504928944")]
    [Description(@"Transaction causes the 'Receiver multilateral limit' to be exceeded and cannot currently be processed.")]
    ReceiverMultilateralLimitRelated = PaymentInstructionStatusCode.ReceiverMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SRBL&quot;.
    /// </summary>
    [EnumMember(Value = "SRBL")]
    [IsoId("_VmtH1tp-Ed-ak6NoX_4Aeg_504928945")]
    [Description(@"Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.")]
    SenderReceiverBilateralLimitRelated = PaymentInstructionStatusCode.SenderReceiverBilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_VmtH19p-Ed-ak6NoX_4Aeg_504928946")]
    [Description(@"Transaction has been successfully processed by the clearing agent.")]
    Settled = PaymentInstructionStatusCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been rejected by the clearing agent.
    /// Encoded/decoded by serializers as &quot;RJTD&quot;.
    /// </summary>
    [EnumMember(Value = "RJTD")]
    [IsoId("_VmtH2Np-Ed-ak6NoX_4Aeg_504928947")]
    [Description(@"Transaction has been rejected by the clearing agent.")]
    Rejected = PaymentInstructionStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VmtH2dp-Ed-ak6NoX_4Aeg_504928948")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled = PaymentInstructionStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.
    /// Encoded/decoded by serializers as &quot;FNLD&quot;.
    /// </summary>
    [EnumMember(Value = "FNLD")]
    [IsoId("_Vm240Np-Ed-ak6NoX_4Aeg_504928957")]
    [Description(@"Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.")]
    Finalised = PaymentInstructionStatusCode.Finalised, // same ordinal as derivation source for type conversions
    
}
