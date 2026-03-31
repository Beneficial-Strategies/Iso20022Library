// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to missing information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y11WR9p-Ed-ak6NoX_4Aeg_-1474250658")]
[Description(@"Specifies the reason of an unable to apply due to missing information.")]
[Derivations(
    typeof(UnableToApplyMissingInformation2Code),
    typeof(UnableToApplyMissingInformation3Code)
)]
public enum UnableToApplyMissingInformationV2Code
{
    /// <summary>
    /// RemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS01&quot;.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_Y11WSNp-Ed-ak6NoX_4Aeg_-490701802")]
    [Description(@"RemittanceInformation is missing.")]
    MissingRemittanceInformation,

    /// <summary>
    /// Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_Y11WSdp-Ed-ak6NoX_4Aeg_-490701741")]
    [Description(
        @"Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForNextAgent,

    /// <summary>
    /// Debtor is missing.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_Y1-gMNp-Ed-ak6NoX_4Aeg_-490701740")]
    [Description(@"Debtor is missing.")]
    MissingDebtor,

    /// <summary>
    /// DebtorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS04&quot;.
    /// </summary>
    [EnumMember(Value = "MS04")]
    [IsoId("_Y1-gMdp-Ed-ak6NoX_4Aeg_-490701710")]
    [Description(@"DebtorAccount is missing.")]
    MissingDebtorAccount,

    /// <summary>
    /// DebtorAgent is missing (former MissingFirstAgent for credit transfers).
    /// Encoded/decoded by serializers as &quot;MS05&quot;.
    /// </summary>
    [EnumMember(Value = "MS05")]
    [IsoId("_Y1-gMtp-Ed-ak6NoX_4Aeg_-490701680")]
    [Description(@"DebtorAgent is missing (former MissingFirstAgent for credit transfers).")]
    MissingDebtorAgent,

    /// <summary>
    /// Amount is missing.
    /// Encoded/decoded by serializers as &quot;MS06&quot;.
    /// </summary>
    [EnumMember(Value = "MS06")]
    [IsoId("_Y1-gM9p-Ed-ak6NoX_4Aeg_-490701679")]
    [Description(@"Amount is missing.")]
    MissingAmount,

    /// <summary>
    /// SettlementAccount is missing. (former MissingNostroVostroAccount).
    /// Encoded/decoded by serializers as &quot;MS07&quot;.
    /// </summary>
    [EnumMember(Value = "MS07")]
    [IsoId("_Y1-gNNp-Ed-ak6NoX_4Aeg_-490701649")]
    [Description(@"SettlementAccount is missing. (former MissingNostroVostroAccount).")]
    MissingSettlementAccount,

    /// <summary>
    /// Intermediary is missing.
    /// Encoded/decoded by serializers as &quot;MS08&quot;.
    /// </summary>
    [EnumMember(Value = "MS08")]
    [IsoId("_Y1-gNdp-Ed-ak6NoX_4Aeg_-490701648")]
    [Description(@"Intermediary is missing.")]
    MissingIntermediary,

    /// <summary>
    /// InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).
    /// Encoded/decoded by serializers as &quot;MS09&quot;.
    /// </summary>
    [EnumMember(Value = "MS09")]
    [IsoId("_Y1-gNtp-Ed-ak6NoX_4Aeg_-490701378")]
    [Description(@"InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).")]
    MissingInstructingReimbursementAgent,

    /// <summary>
    /// InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).
    /// Encoded/decoded by serializers as &quot;MS10&quot;.
    /// </summary>
    [EnumMember(Value = "MS10")]
    [IsoId("_Y1-gN9p-Ed-ak6NoX_4Aeg_-490701347")]
    [Description(@"InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).")]
    MissingInstructedReimbursementAgent,

    /// <summary>
    /// Third reimbursement agent is missing (former MissingReimbursementAgent).
    /// Encoded/decoded by serializers as &quot;MS11&quot;.
    /// </summary>
    [EnumMember(Value = "MS11")]
    [IsoId("_Y1-gONp-Ed-ak6NoX_4Aeg_-490701339")]
    [Description(@"Third reimbursement agent is missing (former MissingReimbursementAgent).")]
    MissingThirdReimbursementAgent,

    /// <summary>
    /// Creditor is missing.
    /// Encoded/decoded by serializers as &quot;MS12&quot;.
    /// </summary>
    [EnumMember(Value = "MS12")]
    [IsoId("_Y1-gOdp-Ed-ak6NoX_4Aeg_-490701316")]
    [Description(@"Creditor is missing.")]
    MissingCreditor,

    /// <summary>
    /// CreditorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS13&quot;.
    /// </summary>
    [EnumMember(Value = "MS13")]
    [IsoId("_Y2IRMNp-Ed-ak6NoX_4Aeg_-490701286")]
    [Description(@"CreditorAccount is missing.")]
    MissingCreditorAccount,

    /// <summary>
    /// Indicates the payment instruction is missing.
    /// Encoded/decoded by serializers as &quot;MS14&quot;.
    /// </summary>
    [EnumMember(Value = "MS14")]
    [IsoId("_Y2IRMdp-Ed-ak6NoX_4Aeg_-490701255")]
    [Description(@"Indicates the payment instruction is missing.")]
    MissingInstruction,

    /// <summary>
    /// Creditor agent is missing (former MissingFirstAgent for direct debits).
    /// Encoded/decoded by serializers as &quot;MS15&quot;.
    /// </summary>
    [EnumMember(Value = "MS15")]
    [IsoId("_Y2IRMtp-Ed-ak6NoX_4Aeg_852310705")]
    [Description(@"Creditor agent is missing (former MissingFirstAgent for direct debits).")]
    MissingCreditorAgent,

    /// <summary>
    /// Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS16&quot;.
    /// </summary>
    [EnumMember(Value = "MS16")]
    [IsoId("_Y2IRM9p-Ed-ak6NoX_4Aeg_-2078616993")]
    [Description(
        @"Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForCreditorAgent,

    /// <summary>
    /// Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS17&quot;.
    /// </summary>
    [EnumMember(Value = "MS17")]
    [IsoId("_Y2IRNNp-Ed-ak6NoX_4Aeg_-2068458262")]
    [Description(
        @"Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForDebtorAgent,

    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_mIv50EgsEeaGKYpLDboHPQ")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
}
