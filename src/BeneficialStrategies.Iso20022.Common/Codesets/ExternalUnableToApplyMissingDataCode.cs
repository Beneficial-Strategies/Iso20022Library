// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-vHdN4jEeqt1ZcLzWyWFw")]
[Description(
    @"Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUnableToApplyMissingData1Code))]
public enum ExternalUnableToApplyMissingDataCode
{
    /// <summary>
    /// RemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS01&quot;.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_p-vHdd4jEeqt1ZcLzWyWFw")]
    [Description(@"RemittanceInformation is missing.")]
    MissingRemittanceInformation,

    /// <summary>
    /// Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_p-vHfd4jEeqt1ZcLzWyWFw")]
    [Description(
        @"Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForNextAgent,

    /// <summary>
    /// Debtor is missing.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_p-vHg94jEeqt1ZcLzWyWFw")]
    [Description(@"Debtor is missing.")]
    MissingDebtor,

    /// <summary>
    /// DebtorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS04&quot;.
    /// </summary>
    [EnumMember(Value = "MS04")]
    [IsoId("_p-vHet4jEeqt1ZcLzWyWFw")]
    [Description(@"DebtorAccount is missing.")]
    MissingDebtorAccount,

    /// <summary>
    /// DebtorAgent is missing (former MissingFirstAgent for credit transfers).
    /// Encoded/decoded by serializers as &quot;MS05&quot;.
    /// </summary>
    [EnumMember(Value = "MS05")]
    [IsoId("_p-vHf94jEeqt1ZcLzWyWFw")]
    [Description(@"DebtorAgent is missing (former MissingFirstAgent for credit transfers).")]
    MissingDebtorAgent,

    /// <summary>
    /// Amount is missing.
    /// Encoded/decoded by serializers as &quot;MS06&quot;.
    /// </summary>
    [EnumMember(Value = "MS06")]
    [IsoId("_p-vHft4jEeqt1ZcLzWyWFw")]
    [Description(@"Amount is missing.")]
    MissingAmount,

    /// <summary>
    /// SettlementAccount is missing. (former MissingNostroVostroAccount).
    /// Encoded/decoded by serializers as &quot;MS07&quot;.
    /// </summary>
    [EnumMember(Value = "MS07")]
    [IsoId("_p-vHht4jEeqt1ZcLzWyWFw")]
    [Description(@"SettlementAccount is missing. (former MissingNostroVostroAccount).")]
    MissingSettlementAccount,

    /// <summary>
    /// Intermediary is missing.
    /// Encoded/decoded by serializers as &quot;MS08&quot;.
    /// </summary>
    [EnumMember(Value = "MS08")]
    [IsoId("_p-vHfN4jEeqt1ZcLzWyWFw")]
    [Description(@"Intermediary is missing.")]
    MissingIntermediary,

    /// <summary>
    /// InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).
    /// Encoded/decoded by serializers as &quot;MS09&quot;.
    /// </summary>
    [EnumMember(Value = "MS09")]
    [IsoId("_p-vHgd4jEeqt1ZcLzWyWFw")]
    [Description(@"InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).")]
    MissingInstructingReimbursementAgent,

    /// <summary>
    /// InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).
    /// Encoded/decoded by serializers as &quot;MS10&quot;.
    /// </summary>
    [EnumMember(Value = "MS10")]
    [IsoId("_p-vHe94jEeqt1ZcLzWyWFw")]
    [Description(@"InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).")]
    MissingInstructedReimbursementAgent,

    /// <summary>
    /// Third reimbursement agent is missing (former MissingReimbursementAgent).
    /// Encoded/decoded by serializers as &quot;MS11&quot;.
    /// </summary>
    [EnumMember(Value = "MS11")]
    [IsoId("_p-vHh94jEeqt1ZcLzWyWFw")]
    [Description(@"Third reimbursement agent is missing (former MissingReimbursementAgent).")]
    MissingThirdReimbursementAgent,

    /// <summary>
    /// Creditor is missing.
    /// Encoded/decoded by serializers as &quot;MS12&quot;.
    /// </summary>
    [EnumMember(Value = "MS12")]
    [IsoId("_p-vHd94jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor is missing.")]
    MissingCreditor,

    /// <summary>
    /// CreditorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS13&quot;.
    /// </summary>
    [EnumMember(Value = "MS13")]
    [IsoId("_p-vHhN4jEeqt1ZcLzWyWFw")]
    [Description(@"CreditorAccount is missing.")]
    MissingCreditorAccount,

    /// <summary>
    /// Payment instruction is missing.
    /// Encoded/decoded by serializers as &quot;MS14&quot;.
    /// </summary>
    [EnumMember(Value = "MS14")]
    [IsoId("_p-vHdt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment instruction is missing.")]
    MissingInstruction,

    /// <summary>
    /// Creditor agent is missing (former MissingFirstAgent for direct debits).
    /// Encoded/decoded by serializers as &quot;MS15&quot;.
    /// </summary>
    [EnumMember(Value = "MS15")]
    [IsoId("_p-vHeN4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor agent is missing (former MissingFirstAgent for direct debits).")]
    MissingCreditorAgent,

    /// <summary>
    /// Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS16&quot;.
    /// </summary>
    [EnumMember(Value = "MS16")]
    [IsoId("_p-vHhd4jEeqt1ZcLzWyWFw")]
    [Description(
        @"Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForCreditorAgent,

    /// <summary>
    /// Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS17&quot;.
    /// </summary>
    [EnumMember(Value = "MS17")]
    [IsoId("_p-vHgt4jEeqt1ZcLzWyWFw")]
    [Description(
        @"Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForDebtorAgent,

    /// <summary>
    /// RelatedRemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS18&quot;.
    /// </summary>
    [EnumMember(Value = "MS18")]
    [IsoId("_p-vHgN4jEeqt1ZcLzWyWFw")]
    [Description(@"RelatedRemittanceInformation is missing.")]
    MissingRelatedRemittanceInformation,

    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_p-vHed4jEeqt1ZcLzWyWFw")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
}
