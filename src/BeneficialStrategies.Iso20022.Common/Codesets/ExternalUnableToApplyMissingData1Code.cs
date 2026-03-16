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
[IsoId("_p-vHsN4jEeqt1ZcLzWyWFw")]
[Description(
    @"Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalUnableToApplyMissingDataCode))]
public enum ExternalUnableToApplyMissingData1Code
{
    /// <summary>
    /// RemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS01&quot;.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_uwqq8vRYEeuLhpyIdtJzwg")]
    [Description(@"RemittanceInformation is missing.")]
    MissingRemittanceInformation =
        ExternalUnableToApplyMissingDataCode.MissingRemittanceInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_uwqq9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForNextAgent =
        ExternalUnableToApplyMissingDataCode.MissingInstructionForNextAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debtor is missing.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_uwz04vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor is missing.")]
    MissingDebtor = ExternalUnableToApplyMissingDataCode.MissingDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DebtorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS04&quot;.
    /// </summary>
    [EnumMember(Value = "MS04")]
    [IsoId("_uwz05fRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount is missing.")]
    MissingDebtorAccount = ExternalUnableToApplyMissingDataCode.MissingDebtorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DebtorAgent is missing (former MissingFirstAgent for credit transfers).
    /// Encoded/decoded by serializers as &quot;MS05&quot;.
    /// </summary>
    [EnumMember(Value = "MS05")]
    [IsoId("_uwz06PRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAgent is missing (former MissingFirstAgent for credit transfers).")]
    MissingDebtorAgent = ExternalUnableToApplyMissingDataCode.MissingDebtorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount is missing.
    /// Encoded/decoded by serializers as &quot;MS06&quot;.
    /// </summary>
    [EnumMember(Value = "MS06")]
    [IsoId("_uwz06_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount is missing.")]
    MissingAmount = ExternalUnableToApplyMissingDataCode.MissingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SettlementAccount is missing. (former MissingNostroVostroAccount).
    /// Encoded/decoded by serializers as &quot;MS07&quot;.
    /// </summary>
    [EnumMember(Value = "MS07")]
    [IsoId("_uw9l4vRYEeuLhpyIdtJzwg")]
    [Description(@"SettlementAccount is missing. (former MissingNostroVostroAccount).")]
    MissingSettlementAccount = ExternalUnableToApplyMissingDataCode.MissingSettlementAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is missing.
    /// Encoded/decoded by serializers as &quot;MS08&quot;.
    /// </summary>
    [EnumMember(Value = "MS08")]
    [IsoId("_uw9l5fRYEeuLhpyIdtJzwg")]
    [Description(@"Intermediary is missing.")]
    MissingIntermediary = ExternalUnableToApplyMissingDataCode.MissingIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).
    /// Encoded/decoded by serializers as &quot;MS09&quot;.
    /// </summary>
    [EnumMember(Value = "MS09")]
    [IsoId("_uw9l6PRYEeuLhpyIdtJzwg")]
    [Description(@"InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).")]
    MissingInstructingReimbursementAgent =
        ExternalUnableToApplyMissingDataCode.MissingInstructingReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).
    /// Encoded/decoded by serializers as &quot;MS10&quot;.
    /// </summary>
    [EnumMember(Value = "MS10")]
    [IsoId("_uw9l6_RYEeuLhpyIdtJzwg")]
    [Description(@"InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).")]
    MissingInstructedReimbursementAgent =
        ExternalUnableToApplyMissingDataCode.MissingInstructedReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Third reimbursement agent is missing (former MissingReimbursementAgent).
    /// Encoded/decoded by serializers as &quot;MS11&quot;.
    /// </summary>
    [EnumMember(Value = "MS11")]
    [IsoId("_uxHW4vRYEeuLhpyIdtJzwg")]
    [Description(@"Third reimbursement agent is missing (former MissingReimbursementAgent).")]
    MissingThirdReimbursementAgent =
        ExternalUnableToApplyMissingDataCode.MissingThirdReimbursementAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor is missing.
    /// Encoded/decoded by serializers as &quot;MS12&quot;.
    /// </summary>
    [EnumMember(Value = "MS12")]
    [IsoId("_uxHW5fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor is missing.")]
    MissingCreditor = ExternalUnableToApplyMissingDataCode.MissingCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CreditorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS13&quot;.
    /// </summary>
    [EnumMember(Value = "MS13")]
    [IsoId("_uxQg0vRYEeuLhpyIdtJzwg")]
    [Description(@"CreditorAccount is missing.")]
    MissingCreditorAccount = ExternalUnableToApplyMissingDataCode.MissingCreditorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instruction is missing.
    /// Encoded/decoded by serializers as &quot;MS14&quot;.
    /// </summary>
    [EnumMember(Value = "MS14")]
    [IsoId("_uxQg1fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment instruction is missing.")]
    MissingInstruction = ExternalUnableToApplyMissingDataCode.MissingInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor agent is missing (former MissingFirstAgent for direct debits).
    /// Encoded/decoded by serializers as &quot;MS15&quot;.
    /// </summary>
    [EnumMember(Value = "MS15")]
    [IsoId("_uxQg2PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor agent is missing (former MissingFirstAgent for direct debits).")]
    MissingCreditorAgent = ExternalUnableToApplyMissingDataCode.MissingCreditorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS16&quot;.
    /// </summary>
    [EnumMember(Value = "MS16")]
    [IsoId("_uxQg2_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForCreditorAgent =
        ExternalUnableToApplyMissingDataCode.MissingInstructionForCreditorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS17&quot;.
    /// </summary>
    [EnumMember(Value = "MS17")]
    [IsoId("_uxaR0vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information)."
    )]
    MissingInstructionForDebtorAgent =
        ExternalUnableToApplyMissingDataCode.MissingInstructionForDebtorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RelatedRemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS18&quot;.
    /// </summary>
    [EnumMember(Value = "MS18")]
    [IsoId("_uxaR1fRYEeuLhpyIdtJzwg")]
    [Description(@"RelatedRemittanceInformation is missing.")]
    MissingRelatedRemittanceInformation =
        ExternalUnableToApplyMissingDataCode.MissingRelatedRemittanceInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_uxjbwvRYEeuLhpyIdtJzwg")]
    [Description(@"See narrative field for additional information.")]
    Narrative = ExternalUnableToApplyMissingDataCode.Narrative, // same ordinal as derivation source for type conversions
}
