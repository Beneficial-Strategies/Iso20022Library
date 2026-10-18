// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual direct debit transaction(s) included in the message.
/// </summary>
[IsoId("_svFWZ2k2Eeanu6HLe77Rkg")]
public interface IDirectDebitTransactionInformation21 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_s3kkC2k2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification3 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_s3kkDWk2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation25? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_s3kkD2k2Eeanu6HLe77Rkg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_s3kkEWk2Eeanu6HLe77Rkg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_s3kkE2k2Eeanu6HLe77Rkg")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_s3kkFWk2Eeanu6HLe77Rkg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_s3kkF2k2Eeanu6HLe77Rkg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_s3kkGWk2Eeanu6HLe77Rkg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_s3kkG2k2Eeanu6HLe77Rkg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges2> ChargesInformation { get; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_s3kkHWk2Eeanu6HLe77Rkg")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    ISODate? RequestedCollectionDate { get; }

    /// <summary>
    /// Provides information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_s3kkH2k2Eeanu6HLe77Rkg")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    IDirectDebitTransaction9? DirectDebitTransaction { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_s3kkIWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification43 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_s3kkI2k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_s3kkJWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_s3kkJ2k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount24? CreditorAgentAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_s3kkKWk2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification43? UltimateCreditor { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the creditor or a party that initiates the direct debit on behalf of the creditor.
    /// </summary>
    [IsoId("_s3kkK2k2Eeanu6HLe77Rkg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification43? InitiatingParty { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s3kkLWk2Eeanu6HLe77Rkg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s3kkL2k2Eeanu6HLe77Rkg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_s3kkMWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_s3kkM2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount24? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_s3kkNWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_s3kkN2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount24? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the debtor agent.
    /// </summary>
    [IsoId("_s3kkOWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_s3kkO2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount24? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_s3kkPWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification43 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_s3kkP2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24 DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_s3kkQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_s3kkQ2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount24? DebtorAgentAccount { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_s3kkRWk2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification43? UltimateDebtor { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_s3kkR2k2Eeanu6HLe77Rkg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_s3kkSWk2Eeanu6HLe77Rkg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting3> RegulatoryReporting { get; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_s3kkS2k2Eeanu6HLe77Rkg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation4> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_s3kkTWk2Eeanu6HLe77Rkg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation11? RemittanceInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_s3kkT2k2Eeanu6HLe77Rkg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
