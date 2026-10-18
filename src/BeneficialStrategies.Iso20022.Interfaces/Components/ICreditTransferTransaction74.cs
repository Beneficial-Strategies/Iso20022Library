// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("93934465-b451-4b8f-9290-2b4ac7d51d84")]
public interface ICreditTransferTransaction74 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("93934465-0001-0001-0001-b4514b8f9290")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification6 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("93934465-0002-0002-0002-b4514b8f9290")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("93934465-0003-0003-0003-b4514b8f9290")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountType4Choice Amount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("93934465-0004-0004-0004-b4514b8f9290")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 1).
    /// </summary>
    [IsoId("93934465-0005-0005-0005-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("93934465-0006-0006-0006-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 2).
    /// </summary>
    [IsoId("93934465-0007-0007-0007-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("93934465-0008-0008-0008-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 3).
    /// </summary>
    [IsoId("93934465-0009-0009-0009-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("93934465-0010-0010-0010-b4514b8f9290")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("93934465-0011-0011-0011-b4514b8f9290")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("93934465-0012-0012-0012-b4514b8f9290")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("93934465-0013-0013-0013-b4514b8f9290")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("93934465-0014-0014-0014-b4514b8f9290")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("93934465-0015-0015-0015-b4514b8f9290")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("93934465-0016-0016-0016-b4514b8f9290")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("93934465-0017-0017-0017-b4514b8f9290")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("93934465-0018-0018-0018-b4514b8f9290")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("93934465-0019-0019-0019-b4514b8f9290")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("93934465-0020-0020-0020-b4514b8f9290")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("93934465-0021-0021-0021-b4514b8f9290")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction.
    /// </summary>
    [IsoId("93934465-0022-0022-0022-b4514b8f9290")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Information provided for regulatory and statutory requirements.
    /// </summary>
    [IsoId("93934465-0023-0023-0023-b4514b8f9290")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting10> RegulatoryReporting { get; }

    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("93934465-0024-0024-0024-b4514b8f9290")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation8> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Electronic documents referenced in the transaction.
    /// </summary>
    [IsoId("93934465-0025-0025-0025-b4514b8f9290")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    IEnumerable<IDocument15> EnclosedFile { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("93934465-0026-0026-0026-b4514b8f9290")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
