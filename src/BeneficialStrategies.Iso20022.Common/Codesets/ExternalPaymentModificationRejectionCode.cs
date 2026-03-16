// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VSTREYlzEeePr-EGJjGYzQ")]
[Description(
    @"Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPaymentModificationRejection1Code))]
public enum ExternalPaymentModificationRejectionCode
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM01&quot;.
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_ucP6I_RYEeuLhpyIdtJzwg")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference,

    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as &quot;UM02&quot;.
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_ucP6JvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode)."
    )]
    UnableToModifyPaymentServiceLevel,

    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as &quot;UM03&quot;.
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_ucP6KfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode)."
    )]
    UnableToModifyCategoryPurpose,

    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM04&quot;.
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_ucZrIPRYEeuLhpyIdtJzwg")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate,

    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as &quot;UM05&quot;.
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_ucZrI_RYEeuLhpyIdtJzwg")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate,

    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as &quot;UM06&quot;.
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_ucZrJvRYEeuLhpyIdtJzwg")]
    [Description(
        @"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount)."
    )]
    UnableToModifyInterbankSettlementAccount,

    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM07&quot;.
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_ucZrKfRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor,

    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM08&quot;.
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_ucZrLPRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount,

    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;UM09&quot;.
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_uci1EPRYEeuLhpyIdtJzwg")]
    [Description(
        @"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent)."
    )]
    UnableToModifyInstructedReimbursementAgent,

    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;UM10&quot;.
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_uci1E_RYEeuLhpyIdtJzwg")]
    [Description(
        @"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution)."
    )]
    UnableToModifyThirdReimbursementAgent,

    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)
    /// Encoded/decoded by serializers as &quot;UM11&quot;.
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_uci1FvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)"
    )]
    UnableToModifyPaymentClearingChannel,

    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)
    /// Encoded/decoded by serializers as &quot;UM12&quot;.
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_ucsmEPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)"
    )]
    UnableToModifyCreditorAgentAccount,

    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM13&quot;.
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_ucsmE_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor,

    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM14&quot;.
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_ucsmFvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount,

    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM15&quot;.
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_ucsmGfRYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation,

    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM16&quot;.
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_ucsmHPRYEeuLhpyIdtJzwg")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose,

    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;UM17&quot;.
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_uc2XEPRYEeuLhpyIdtJzwg")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer,

    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as &quot;UM18&quot;.
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_uc_hAPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver)."
    )]
    UnableToModifyInstructionForNextAgent,

    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;UM19&quot;.
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_uc_hA_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent)."
    )]
    UnableToModifyInstructionForCreditorAgent,

    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as &quot;UM20&quot;.
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_udJSAPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment."
    )]
    InstructionCancelledSubmitNewInstruction,

    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as &quot;UM21&quot;.
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_udJSA_RYEeuLhpyIdtJzwg")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation,

    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM22&quot;.
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_udJSBvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount,

    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM23&quot;.
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_udTDAPRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount,

    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as &quot;UM24&quot;.
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_udTDA_RYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for debtor agent cannot be modified (applicable for direct debits)")]
    UnableToModifyInstructionForDebtorAgent,

    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as &quot;UM25&quot;.
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_udcM8PRYEeuLhpyIdtJzwg")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits)")]
    UnableToModifyRequestedCollectionDate,

    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM26&quot;.
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_udcM8_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType,

    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM27&quot;.
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_udcM9vRYEeuLhpyIdtJzwg")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount,

    /// <summary>
    /// Priority of payment message cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM28&quot;.
    /// </summary>
    [EnumMember(Value = "UM28")]
    [IsoId("_udl98PRYEeuLhpyIdtJzwg")]
    [Description(@"Priority of payment message cannot be modified.")]
    UnableToModifyPriority,
}
