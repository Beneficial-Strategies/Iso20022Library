// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the state of a payment at the clearing agent side is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGJuo9p-Ed-ak6NoX_4Aeg_1263998543")]
[Description(@"Indicates that the state of a payment at the clearing agent side is pending.")]
[DerivedFrom(typeof(PaymentInstructionStatusCode))]
public enum PendingStatus4Code
{
    /// <summary>
    /// Transaction has been accepted by the clearing agent.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_aGJupNp-Ed-ak6NoX_4Aeg_1263998562")]
    [Description(@"Transaction has been accepted by the clearing agent.")]
    Accepted = PaymentInstructionStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been validated by the clearing agent.
    /// Encoded/decoded by serializers as &quot;VALD&quot;.
    /// </summary>
    [EnumMember(Value = "VALD")]
    [IsoId("_aGJupdp-Ed-ak6NoX_4Aeg_1263998838")]
    [Description(@"Transaction has been validated by the clearing agent.")]
    Validated = PaymentInstructionStatusCode.Validated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been matched with a corresponding transaction by the clearing agent.
    /// Encoded/decoded by serializers as &quot;MATD&quot;.
    /// </summary>
    [EnumMember(Value = "MATD")]
    [IsoId("_aGJuptp-Ed-ak6NoX_4Aeg_1263998873")]
    [Description(@"Transaction has been matched with a corresponding transaction by the clearing agent.")]
    Matched = PaymentInstructionStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been authorised by the transaction administrator or authorised party.
    /// Encoded/decoded by serializers as &quot;AUTD&quot;.
    /// </summary>
    [EnumMember(Value = "AUTD")]
    [IsoId("_aGJup9p-Ed-ak6NoX_4Aeg_1263998915")]
    [Description(@"Transaction has been authorised by the transaction administrator or authorised party.")]
    Authorised = PaymentInstructionStatusCode.Authorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;INVD&quot;.
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_aGJuqNp-Ed-ak6NoX_4Aeg_1263998933")]
    [Description(@"Transaction is invalid.")]
    Invalid = PaymentInstructionStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction but failed.
    /// Encoded/decoded by serializers as &quot;UMAC&quot;.
    /// </summary>
    [EnumMember(Value = "UMAC")]
    [IsoId("_aGJuqdp-Ed-ak6NoX_4Aeg_1263998968")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction but failed.")]
    Unmatched = PaymentInstructionStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for future settlement.
    /// Encoded/decoded by serializers as &quot;STLE&quot;.
    /// </summary>
    [EnumMember(Value = "STLE")]
    [IsoId("_aGS4kNp-Ed-ak6NoX_4Aeg_1263999258")]
    [Description(@"Transaction is eligible for future settlement.")]
    SettlementEligible = PaymentInstructionStatusCode.SettlementEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for immediate settlement.
    /// Encoded/decoded by serializers as &quot;STLM&quot;.
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_aGS4kdp-Ed-ak6NoX_4Aeg_1263999276")]
    [Description(@"Transaction is eligible for immediate settlement.")]
    SettlementMature = PaymentInstructionStatusCode.SettlementMature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been suspended by the clearing agent.
    /// Encoded/decoded by serializers as &quot;SSPD&quot;.
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_aGS4ktp-Ed-ak6NoX_4Aeg_1263999318")]
    [Description(@"Transaction has been suspended by the clearing agent.")]
    Suspended = PaymentInstructionStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.
    /// Encoded/decoded by serializers as &quot;PCAN&quot;.
    /// </summary>
    [EnumMember(Value = "PCAN")]
    [IsoId("_aGS4k9p-Ed-ak6NoX_4Aeg_1263999336")]
    [Description(@"Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.")]
    PendingCancellation = PaymentInstructionStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is eligible for settlement, but is pending.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_aGS4lNp-Ed-ak6NoX_4Aeg_1263999371")]
    [Description(@"Transaction is eligible for settlement, but is pending.")]
    PendingSettlement = PaymentInstructionStatusCode.PendingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction eligible for immediate settlement, has failed to settle.
    /// Encoded/decoded by serializers as &quot;PFST&quot;.
    /// </summary>
    [EnumMember(Value = "PFST")]
    [IsoId("_aGS4ldp-Ed-ak6NoX_4Aeg_1263999413")]
    [Description(@"Transaction eligible for immediate settlement, has failed to settle.")]
    PendingFailingSettlement = PaymentInstructionStatusCode.PendingFailingSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Sender multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SMLR&quot;.
    /// </summary>
    [EnumMember(Value = "SMLR")]
    [IsoId("_aGS4ltp-Ed-ak6NoX_4Aeg_1263999431")]
    [Description(@"Transaction causes the 'Sender multilateral limit' to be exceeded and cannot currently be processed.")]
    SenderMultilateralLimitRelated = PaymentInstructionStatusCode.SenderMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the &apos;Receiver multilateral limit&apos; to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;RMLR&quot;.
    /// </summary>
    [EnumMember(Value = "RMLR")]
    [IsoId("_aGS4l9p-Ed-ak6NoX_4Aeg_1263999473")]
    [Description(@"Transaction causes the 'Receiver multilateral limit' to be exceeded and cannot currently be processed.")]
    ReceiverMultilateralLimitRelated = PaymentInstructionStatusCode.ReceiverMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SRBL&quot;.
    /// </summary>
    [EnumMember(Value = "SRBL")]
    [IsoId("_aGS4mNp-Ed-ak6NoX_4Aeg_1263999508")]
    [Description(@"Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.")]
    SenderReceiverBilateralLimitRelated = PaymentInstructionStatusCode.SenderReceiverBilateralLimitRelated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the message is queued to the receiving payment system and is awaiting processing because the receiving payment system is not operational (open) at that point in time.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_aGS4mdp-Ed-ak6NoX_4Aeg_1263999526")]
    [Description(@"Specifies that the message is queued to the receiving payment system and is awaiting processing because the receiving payment system is not operational (open) at that point in time.")]
    HeldForServiceAvailability = PaymentInstructionStatusCode.HeldForServiceAvailability, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction causes the multilateral limits fixed between Sender and Receiver to be exceeded by the total amount of submitted payments at the end of the day and cannot currently be processed.
    /// Encoded/decoded by serializers as &quot;SRML&quot;.
    /// </summary>
    [EnumMember(Value = "SRML")]
    [IsoId("_aGcpkNp-Ed-ak6NoX_4Aeg_588640614")]
    [Description(@"Transaction causes the multilateral limits fixed between Sender and Receiver to be exceeded by the total amount of submitted payments at the end of the day and cannot currently be processed.")]
    SenderReceiverMultilateralLimitRelated = PaymentInstructionStatusCode.SenderReceiverMultilateralLimitRelated, // same ordinal as derivation source for type conversions
    
}
