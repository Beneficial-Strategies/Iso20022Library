// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the state of a payment at the clearing agent side is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VmQb4tp-Ed-ak6NoX_4Aeg_612436489")]
[Description(@"Indicates that the state of a payment at the clearing agent side is pending.")]
[DerivedFrom(typeof(PaymentInstructionStatusCode))]
public enum PendingStatus1Code
{
    /// <summary>
    /// Transaction has been accepted by the clearing agent.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_VmQb49p-Ed-ak6NoX_4Aeg_612436491")]
    [Description(@"Transaction has been accepted by the clearing agent.")]
    Accepted = PaymentInstructionStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been validated by the clearing agent.
    /// Encoded/decoded by serializers as &quot;VALD&quot;.
    /// </summary>
    [EnumMember(Value = "VALD")]
    [IsoId("_VmQb5Np-Ed-ak6NoX_4Aeg_612436499")]
    [Description(@"Transaction has been validated by the clearing agent.")]
    Validated = PaymentInstructionStatusCode.Validated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been matched with a corresponding transaction by the clearing agent.
    /// Encoded/decoded by serializers as &quot;MATD&quot;.
    /// </summary>
    [EnumMember(Value = "MATD")]
    [IsoId("_VmQb5dp-Ed-ak6NoX_4Aeg_612436500")]
    [Description(@"Transaction has been matched with a corresponding transaction by the clearing agent.")]
    Matched = PaymentInstructionStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been authorised by the transaction administrator or authorised party.
    /// Encoded/decoded by serializers as &quot;AUTD&quot;.
    /// </summary>
    [EnumMember(Value = "AUTD")]
    [IsoId("_VmQb5tp-Ed-ak6NoX_4Aeg_612436501")]
    [Description(@"Transaction has been authorised by the transaction administrator or authorised party.")]
    Authorised = PaymentInstructionStatusCode.Authorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;INVD&quot;.
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_VmQb59p-Ed-ak6NoX_4Aeg_612436502")]
    [Description(@"Transaction is invalid.")]
    Invalid = PaymentInstructionStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction but failed.
    /// Encoded/decoded by serializers as &quot;UMAC&quot;.
    /// </summary>
    [EnumMember(Value = "UMAC")]
    [IsoId("_VmQb6Np-Ed-ak6NoX_4Aeg_612436503")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction but failed.")]
    Unmatched = PaymentInstructionStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for future settlement.
    /// Encoded/decoded by serializers as &quot;STLE&quot;.
    /// </summary>
    [EnumMember(Value = "STLE")]
    [IsoId("_VmQb6dp-Ed-ak6NoX_4Aeg_612436504")]
    [Description(@"Transaction is eligible for future settlement.")]
    SettlementEligible = PaymentInstructionStatusCode.SettlementEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for immediate settlement.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_VmaM4Np-Ed-ak6NoX_4Aeg_612436513")]
    [Description(@"Transaction is eligible for immediate settlement.")]
    SettlementMature = PaymentInstructionStatusCode.SettlementMature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been suspended by the clearing agent.
    /// Encoded/decoded by serializers as &quot;SSPD&quot;.
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_VmaM4dp-Ed-ak6NoX_4Aeg_612436514")]
    [Description(@"Transaction has been suspended by the clearing agent.")]
    Suspended = PaymentInstructionStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.
    /// Encoded/decoded by serializers as &quot;PCAN&quot;.
    /// </summary>
    [EnumMember(Value = "PCAN")]
    [IsoId("_VmaM4tp-Ed-ak6NoX_4Aeg_612436515")]
    [Description(@"Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.")]
    PendingCancellation = PaymentInstructionStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for settlement, but is pending.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_VmaM49p-Ed-ak6NoX_4Aeg_612436516")]
    [Description(@"Transaction is eligible for settlement, but is pending.")]
    PendingSettlement = PaymentInstructionStatusCode.PendingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction eligible for immediate settlement, has failed to settle.
    /// Encoded/decoded by serializers as &quot;PFST&quot;.
    /// </summary>
    [EnumMember(Value = "PFST")]
    [IsoId("_VmaM5Np-Ed-ak6NoX_4Aeg_612436517")]
    [Description(@"Transaction eligible for immediate settlement, has failed to settle.")]
    PendingFailingSettlement = PaymentInstructionStatusCode.PendingFailingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Sender multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SMLR&quot;.
    /// </summary>
    [EnumMember(Value = "SMLR")]
    [IsoId("_VmaM5dp-Ed-ak6NoX_4Aeg_612436518")]
    [Description(@"Transaction causes the 'Sender multilateral limit' to be exceeded and cannot currently be processed.")]
    SenderMultilateralLimitRelated = PaymentInstructionStatusCode.SenderMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Receiver multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;RMLR&quot;.
    /// </summary>
    [EnumMember(Value = "RMLR")]
    [IsoId("_VmaM5tp-Ed-ak6NoX_4Aeg_612436519")]
    [Description(@"Transaction causes the 'Receiver multilateral limit' to be exceeded and cannot currently be processed.")]
    ReceiverMultilateralLimitRelated = PaymentInstructionStatusCode.ReceiverMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SRBL&quot;.
    /// </summary>
    [EnumMember(Value = "SRBL")]
    [IsoId("_VmaM59p-Ed-ak6NoX_4Aeg_612436520")]
    [Description(@"Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.")]
    SenderReceiverBilateralLimitRelated = PaymentInstructionStatusCode.SenderReceiverBilateralLimitRelated, // same ordinal as derivation source for type conversions
    
}
