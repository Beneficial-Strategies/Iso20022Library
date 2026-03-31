// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the reject of a modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z4u9sNp-Ed-ak6NoX_4Aeg_-2057540990")]
[Description(@"Specifies the reason for the reject of a modification request.")]
[Derivations(typeof(ModificationRejection2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentModificationRejectionV2Code>))]
#endif
public enum PaymentModificationRejectionV2Code
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM01&quot;.
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_Z4u9sdp-Ed-ak6NoX_4Aeg_-1946716667")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference,

    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as &quot;UM02&quot;.
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_Z4u9stp-Ed-ak6NoX_4Aeg_-1946716666")]
    [Description(
        @"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode)."
    )]
    UnableToModifyPaymentServiceLevel,

    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as &quot;UM03&quot;.
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_Z4u9s9p-Ed-ak6NoX_4Aeg_-1946716636")]
    [Description(
        @"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode)."
    )]
    UnableToModifyCategoryPurpose,

    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM04&quot;.
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_Z4u9tNp-Ed-ak6NoX_4Aeg_-1946716635")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate,

    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as &quot;UM05&quot;.
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_Z4u9tdp-Ed-ak6NoX_4Aeg_-1946716606")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate,

    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as &quot;UM06&quot;.
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_Z4u9ttp-Ed-ak6NoX_4Aeg_-1946716575")]
    [Description(
        @"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount)."
    )]
    UnableToModifyInterbankSettlementAccount,

    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM07&quot;.
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_Z4u9t9p-Ed-ak6NoX_4Aeg_-1946716574")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor,

    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM08&quot;.
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_Z4u9uNp-Ed-ak6NoX_4Aeg_-1946716544")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount,

    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;UM09&quot;.
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_Z4u9udp-Ed-ak6NoX_4Aeg_-1946716543")]
    [Description(
        @"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent)."
    )]
    UnableToModifyInstructedReimbursementAgent,

    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;UM10&quot;.
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_Z44usNp-Ed-ak6NoX_4Aeg_-1946716514")]
    [Description(
        @"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution)."
    )]
    UnableToModifyThirdReimbursementAgent,

    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme).
    /// Encoded/decoded by serializers as &quot;UM11&quot;.
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_Z44usdp-Ed-ak6NoX_4Aeg_-1946716513")]
    [Description(
        @"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)."
    )]
    UnableToModifyPaymentClearingChannel,

    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as &quot;UM12&quot;.
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_Z44ustp-Ed-ak6NoX_4Aeg_-1946716483")]
    [Description(
        @"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)."
    )]
    UnableToModifyCreditorAgentAccount,

    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM13&quot;.
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_Z44us9p-Ed-ak6NoX_4Aeg_-1946716453")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor,

    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM14&quot;.
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_Z44utNp-Ed-ak6NoX_4Aeg_-1946716452")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount,

    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM15&quot;.
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_Z44utdp-Ed-ak6NoX_4Aeg_-1946716422")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation,

    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM16&quot;.
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_Z44uttp-Ed-ak6NoX_4Aeg_-1946716421")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose,

    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;UM17&quot;.
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_Z44ut9p-Ed-ak6NoX_4Aeg_-1946716144")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer,

    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as &quot;UM18&quot;.
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_Z44uuNp-Ed-ak6NoX_4Aeg_-1946716143")]
    [Description(
        @"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver)."
    )]
    UnableToModifyInstructionForNextAgent,

    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;UM19&quot;.
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_Z44uudp-Ed-ak6NoX_4Aeg_-1946716113")]
    [Description(
        @"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent)."
    )]
    UnableToModifyInstructionForCreditorAgent,

    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as &quot;UM20&quot;.
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_Z5CfsNp-Ed-ak6NoX_4Aeg_-1946716082")]
    [Description(
        @"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment."
    )]
    InstructionCancelledSubmitNewInstruction,

    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as &quot;UM21&quot;.
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_Z5Cfsdp-Ed-ak6NoX_4Aeg_-1946716081")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation,

    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM22&quot;.
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_Z5Cfstp-Ed-ak6NoX_4Aeg_-666012404")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount,

    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM23&quot;.
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_Z5Cfs9p-Ed-ak6NoX_4Aeg_-606907289")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount,

    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM24&quot;.
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_Z5CftNp-Ed-ak6NoX_4Aeg_46948941")]
    [Description(
        @"Instruction for debtor agent cannot be modified (applicable for direct debits)."
    )]
    UnableToModifyInstructionForDebtorAgent,

    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as &quot;UM25&quot;.
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_Z5Cftdp-Ed-ak6NoX_4Aeg_1249104693")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits).")]
    UnableToModifyRequestedCollectionDate,

    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM26&quot;.
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_Z5Cfttp-Ed-ak6NoX_4Aeg_1695166859")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType,

    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as &quot;UM27&quot;.
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_Z5Cft9p-Ed-ak6NoX_4Aeg_1761659391")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount,
}
