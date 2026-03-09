// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for rejecting a modification reject.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aMHMs9p-Ed-ak6NoX_4Aeg_-2138458517")]
[Description(@"Specifies the reason for rejecting a modification reject.")]
[DerivedFrom(typeof(PaymentModificationRejectionV2Code))]
public enum ModificationRejection2Code
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM01&quot;.
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_aMHMtNp-Ed-ak6NoX_4Aeg_-2138458495")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference = PaymentModificationRejectionV2Code.UnableToModifyRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as &quot;UM02&quot;.
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_aMHMtdp-Ed-ak6NoX_4Aeg_-2138458486")]
    [Description(@"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).")]
    UnableToModifyPaymentServiceLevel = PaymentModificationRejectionV2Code.UnableToModifyPaymentServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as &quot;UM03&quot;.
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_aMHMttp-Ed-ak6NoX_4Aeg_-2138458464")]
    [Description(@"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).")]
    UnableToModifyCategoryPurpose = PaymentModificationRejectionV2Code.UnableToModifyCategoryPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM04&quot;.
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_aMHMt9p-Ed-ak6NoX_4Aeg_-2138458434")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate = PaymentModificationRejectionV2Code.UnableToModifyRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as &quot;UM05&quot;.
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_aMHMuNp-Ed-ak6NoX_4Aeg_-2138458433")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate = PaymentModificationRejectionV2Code.UnableToModifyInterbankSettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as &quot;UM06&quot;.
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_aMHMudp-Ed-ak6NoX_4Aeg_-2138458155")]
    [Description(@"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).")]
    UnableToModifyInterbankSettlementAccount = PaymentModificationRejectionV2Code.UnableToModifyInterbankSettlementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM07&quot;.
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_aMQWoNp-Ed-ak6NoX_4Aeg_-2138458124")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor = PaymentModificationRejectionV2Code.UnableToModifyDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM08&quot;.
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_aMQWodp-Ed-ak6NoX_4Aeg_-2138458094")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount = PaymentModificationRejectionV2Code.UnableToModifyDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;UM09&quot;.
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_aMQWotp-Ed-ak6NoX_4Aeg_-2138458093")]
    [Description(@"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).")]
    UnableToModifyInstructedReimbursementAgent = PaymentModificationRejectionV2Code.UnableToModifyInstructedReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;UM10&quot;.
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_aMQWo9p-Ed-ak6NoX_4Aeg_-2138458063")]
    [Description(@"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).")]
    UnableToModifyThirdReimbursementAgent = PaymentModificationRejectionV2Code.UnableToModifyThirdReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme).
    /// Encoded/decoded by serializers as &quot;UM11&quot;.
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_aMQWpNp-Ed-ak6NoX_4Aeg_-2138458032")]
    [Description(@"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme).")]
    UnableToModifyPaymentClearingChannel = PaymentModificationRejectionV2Code.UnableToModifyPaymentClearingChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as &quot;UM12&quot;.
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_aMQWpdp-Ed-ak6NoX_4Aeg_-2138458031")]
    [Description(@"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution).")]
    UnableToModifyCreditorAgentAccount = PaymentModificationRejectionV2Code.UnableToModifyCreditorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM13&quot;.
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_aMQWptp-Ed-ak6NoX_4Aeg_-2138458002")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor = PaymentModificationRejectionV2Code.UnableToModifyCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM14&quot;.
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_aMQWp9p-Ed-ak6NoX_4Aeg_-2138457971")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount = PaymentModificationRejectionV2Code.UnableToModifyCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM15&quot;.
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_aMQWqNp-Ed-ak6NoX_4Aeg_-2138457970")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation = PaymentModificationRejectionV2Code.UnableToModifyRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM16&quot;.
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_aMQWqdp-Ed-ak6NoX_4Aeg_-2138457941")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose = PaymentModificationRejectionV2Code.UnableToModifyPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;UM17&quot;.
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_aMaHoNp-Ed-ak6NoX_4Aeg_-2138457940")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer = PaymentModificationRejectionV2Code.UnableToModifyChargeBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as &quot;UM18&quot;.
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_aMaHodp-Ed-ak6NoX_4Aeg_-2138457910")]
    [Description(@"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).")]
    UnableToModifyInstructionForNextAgent = PaymentModificationRejectionV2Code.UnableToModifyInstructionForNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;UM19&quot;.
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_aMaHotp-Ed-ak6NoX_4Aeg_-2138457879")]
    [Description(@"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).")]
    UnableToModifyInstructionForCreditorAgent = PaymentModificationRejectionV2Code.UnableToModifyInstructionForCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as &quot;UM20&quot;.
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_aMaHo9p-Ed-ak6NoX_4Aeg_-2138457878")]
    [Description(@"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.")]
    InstructionCancelledSubmitNewInstruction = PaymentModificationRejectionV2Code.InstructionCancelledSubmitNewInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as &quot;UM21&quot;.
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_aMaHpNp-Ed-ak6NoX_4Aeg_-2138457632")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation = PaymentModificationRejectionV2Code.UnableToModifySubmitCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM22&quot;.
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_aMaHpdp-Ed-ak6NoX_4Aeg_-2138457599")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount = PaymentModificationRejectionV2Code.UnableToModifyDebtorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM23&quot;.
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_aMaHptp-Ed-ak6NoX_4Aeg_-2138457569")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount = PaymentModificationRejectionV2Code.UnableToModifyInterbankSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM24&quot;.
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_aMaHp9p-Ed-ak6NoX_4Aeg_-2138457567")]
    [Description(@"Instruction for debtor agent cannot be modified (applicable for direct debits).")]
    UnableToModifyInstructionForDebtorAgent = PaymentModificationRejectionV2Code.UnableToModifyInstructionForDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM25&quot;.
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_aMaHqNp-Ed-ak6NoX_4Aeg_-2138457539")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits).")]
    UnableToModifyRequestedCollectionDate = PaymentModificationRejectionV2Code.UnableToModifyRequestedCollectionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM26&quot;.
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_aMaHqdp-Ed-ak6NoX_4Aeg_-2137537536")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType = PaymentModificationRejectionV2Code.UnableToModifyPaymentType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM27&quot;.
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_aMj4oNp-Ed-ak6NoX_4Aeg_-2137537506")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount = PaymentModificationRejectionV2Code.UnableToModifyInstructedAmount, // same ordinal as derivation source for type conversions
    
}
