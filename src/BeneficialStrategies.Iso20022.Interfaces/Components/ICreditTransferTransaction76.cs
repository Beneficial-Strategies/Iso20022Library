// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("c1b2745a-8979-4069-a0c7-2a93a3ff6de8")]
public interface ICreditTransferTransaction76 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("c1b2745a-0001-0001-0001-89794069a0c7")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification6 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("c1b2745a-0002-0002-0002-89794069a0c7")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("c1b2745a-0003-0003-0003-89794069a0c7")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountType4Choice Amount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("c1b2745a-0004-0004-0004-89794069a0c7")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 1).
    /// </summary>
    [IsoId("c1b2745a-0005-0005-0005-89794069a0c7")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("c1b2745a-0006-0006-0006-89794069a0c7")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 2).
    /// </summary>
    [IsoId("c1b2745a-0007-0007-0007-89794069a0c7")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("c1b2745a-0008-0008-0008-89794069a0c7")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 3).
    /// </summary>
    [IsoId("c1b2745a-0009-0009-0009-89794069a0c7")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("c1b2745a-0010-0010-0010-89794069a0c7")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("c1b2745a-0011-0011-0011-89794069a0c7")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("c1b2745a-0012-0012-0012-89794069a0c7")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("c1b2745a-0013-0013-0013-89794069a0c7")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("c1b2745a-0014-0014-0014-89794069a0c7")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("c1b2745a-0015-0015-0015-89794069a0c7")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("c1b2745a-0016-0016-0016-89794069a0c7")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("c1b2745a-0017-0017-0017-89794069a0c7")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("c1b2745a-0018-0018-0018-89794069a0c7")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("c1b2745a-0019-0019-0019-89794069a0c7")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272? Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("c1b2745a-0020-0020-0020-89794069a0c7")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("c1b2745a-0021-0021-0021-89794069a0c7")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Information for the debtor's agent on how to process the instruction.
    /// </summary>
    [IsoId("c1b2745a-0022-0022-0022-89794069a0c7")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    IInstructionForDebtorAgent1? InstructionForDebtorAgent { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction.
    /// </summary>
    [IsoId("c1b2745a-0023-0023-0023-89794069a0c7")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Information provided for regulatory and statutory requirements.
    /// </summary>
    [IsoId("c1b2745a-0024-0024-0024-89794069a0c7")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting10> RegulatoryReporting { get; }

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("c1b2745a-0025-0025-0025-89794069a0c7")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation8> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("c1b2745a-0026-0026-0026-89794069a0c7")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation22? RemittanceInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("c1b2745a-0027-0027-0027-89794069a0c7")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
