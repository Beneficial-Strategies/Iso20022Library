// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to missing information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hRURLkgsEeaGKYpLDboHPQ")]
[Description(@"Specifies the reason of an unable to apply due to missing information.")]
[DerivedFrom(typeof(UnableToApplyMissingInformationV2Code))]
public enum UnableToApplyMissingInformation3Code
{
    /// <summary>
    /// RemittanceInformation is missing.
    /// Encoded/decoded by serializers as &quot;MS01&quot;.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_hRUROUgsEeaGKYpLDboHPQ")]
    [Description(@"RemittanceInformation is missing.")]
    MissingRemittanceInformation = UnableToApplyMissingInformationV2Code.MissingRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_hRURMUgsEeaGKYpLDboHPQ")]
    [Description(@"Instruction for next agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).")]
    MissingInstructionForNextAgent = UnableToApplyMissingInformationV2Code.MissingInstructionForNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor is missing.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_hRURP0gsEeaGKYpLDboHPQ")]
    [Description(@"Debtor is missing.")]
    MissingDebtor = UnableToApplyMissingInformationV2Code.MissingDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS04&quot;.
    /// </summary>
    [EnumMember(Value = "MS04")]
    [IsoId("_hRURL0gsEeaGKYpLDboHPQ")]
    [Description(@"DebtorAccount is missing.")]
    MissingDebtorAccount = UnableToApplyMissingInformationV2Code.MissingDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAgent is missing (former MissingFirstAgent for credit transfers).
    /// Encoded/decoded by serializers as &quot;MS05&quot;.
    /// </summary>
    [EnumMember(Value = "MS05")]
    [IsoId("_hRURPkgsEeaGKYpLDboHPQ")]
    [Description(@"DebtorAgent is missing (former MissingFirstAgent for credit transfers).")]
    MissingDebtorAgent = UnableToApplyMissingInformationV2Code.MissingDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount is missing.
    /// Encoded/decoded by serializers as &quot;MS06&quot;.
    /// </summary>
    [EnumMember(Value = "MS06")]
    [IsoId("_hRURM0gsEeaGKYpLDboHPQ")]
    [Description(@"Amount is missing.")]
    MissingAmount = UnableToApplyMissingInformationV2Code.MissingAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SettlementAccount is missing. (former MissingNostroVostroAccount).
    /// Encoded/decoded by serializers as &quot;MS07&quot;.
    /// </summary>
    [EnumMember(Value = "MS07")]
    [IsoId("_hRUROkgsEeaGKYpLDboHPQ")]
    [Description(@"SettlementAccount is missing. (former MissingNostroVostroAccount).")]
    MissingSettlementAccount = UnableToApplyMissingInformationV2Code.MissingSettlementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary is missing.
    /// Encoded/decoded by serializers as &quot;MS08&quot;.
    /// </summary>
    [EnumMember(Value = "MS08")]
    [IsoId("_hRURMEgsEeaGKYpLDboHPQ")]
    [Description(@"Intermediary is missing.")]
    MissingIntermediary = UnableToApplyMissingInformationV2Code.MissingIntermediary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).
    /// Encoded/decoded by serializers as &quot;MS09&quot;.
    /// </summary>
    [EnumMember(Value = "MS09")]
    [IsoId("_hRUROEgsEeaGKYpLDboHPQ")]
    [Description(@"InstructingReimbursementAgent is missing (former MissingReimbursementAgent1).")]
    MissingInstructingReimbursementAgent = UnableToApplyMissingInformationV2Code.MissingInstructingReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).
    /// Encoded/decoded by serializers as &quot;MS10&quot;.
    /// </summary>
    [EnumMember(Value = "MS10")]
    [IsoId("_hRURNEgsEeaGKYpLDboHPQ")]
    [Description(@"InstructedReimbursementAgent is missing (former MissingReimbursementAgent2).")]
    MissingInstructedReimbursementAgent = UnableToApplyMissingInformationV2Code.MissingInstructedReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Third reimbursement agent is missing (former MissingReimbursementAgent).
    /// Encoded/decoded by serializers as &quot;MS11&quot;.
    /// </summary>
    [EnumMember(Value = "MS11")]
    [IsoId("_hRURPUgsEeaGKYpLDboHPQ")]
    [Description(@"Third reimbursement agent is missing (former MissingReimbursementAgent).")]
    MissingThirdReimbursementAgent = UnableToApplyMissingInformationV2Code.MissingThirdReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor is missing.
    /// Encoded/decoded by serializers as &quot;MS12&quot;.
    /// </summary>
    [EnumMember(Value = "MS12")]
    [IsoId("_hRURN0gsEeaGKYpLDboHPQ")]
    [Description(@"Creditor is missing.")]
    MissingCreditor = UnableToApplyMissingInformationV2Code.MissingCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CreditorAccount is missing.
    /// Encoded/decoded by serializers as &quot;MS13&quot;.
    /// </summary>
    [EnumMember(Value = "MS13")]
    [IsoId("_hRURNUgsEeaGKYpLDboHPQ")]
    [Description(@"CreditorAccount is missing.")]
    MissingCreditorAccount = UnableToApplyMissingInformationV2Code.MissingCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the payment instruction is missing.
    /// Encoded/decoded by serializers as &quot;MS14&quot;.
    /// </summary>
    [EnumMember(Value = "MS14")]
    [IsoId("_hRURNkgsEeaGKYpLDboHPQ")]
    [Description(@"Indicates the payment instruction is missing.")]
    MissingInstruction = UnableToApplyMissingInformationV2Code.MissingInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor agent is missing (former MissingFirstAgent for direct debits).
    /// Encoded/decoded by serializers as &quot;MS15&quot;.
    /// </summary>
    [EnumMember(Value = "MS15")]
    [IsoId("_hRURPEgsEeaGKYpLDboHPQ")]
    [Description(@"Creditor agent is missing (former MissingFirstAgent for direct debits).")]
    MissingCreditorAgent = UnableToApplyMissingInformationV2Code.MissingCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS16&quot;.
    /// </summary>
    [EnumMember(Value = "MS16")]
    [IsoId("_hRURO0gsEeaGKYpLDboHPQ")]
    [Description(@"Instruction for creditor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).")]
    MissingInstructionForCreditorAgent = UnableToApplyMissingInformationV2Code.MissingInstructionForCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).
    /// Encoded/decoded by serializers as &quot;MS17&quot;.
    /// </summary>
    [EnumMember(Value = "MS17")]
    [IsoId("_hRURMkgsEeaGKYpLDboHPQ")]
    [Description(@"Instruction for debtor agent is missing (former MissingSenderToReceiverInformation split into debtor, credit and next agent information).")]
    MissingInstructionForDebtorAgent = UnableToApplyMissingInformationV2Code.MissingInstructionForDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_Cv78sUgtEeaGKYpLDboHPQ")]
    [Description(@"See narrative field for additional information.")]
    Narrative = UnableToApplyMissingInformationV2Code.Narrative, // same ordinal as derivation source for type conversions
    
}
