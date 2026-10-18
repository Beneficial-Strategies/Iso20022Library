// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_tQqNMFkyEeGeoaLUQk__nA_734910466")]
public interface ICreditTransferTransaction2 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_tQqNMVkyEeGeoaLUQk__nA_1075158669")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification3 PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_tQqNMlkyEeGeoaLUQk__nA_-1388885458")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation21? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_tQqNM1kyEeGeoaLUQk__nA_-1818031476")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveCurrencyAndAmount InterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_tQqNNFkyEeGeoaLUQk__nA_895285762")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_tQz-MFkyEeGeoaLUQk__nA_-1580535271")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_tQz-MVkyEeGeoaLUQk__nA_-324396261")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_tQz-MlkyEeGeoaLUQk__nA_-335495038")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_tQz-M1kyEeGeoaLUQk__nA_1077380890")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    ISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_tQz-NFkyEeGeoaLUQk__nA_-2069483299")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    ISODate? PoolingAdjustmentDate { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_tQ9vMFkyEeGeoaLUQk__nA_-711672343")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_tQ9vMVkyEeGeoaLUQk__nA_1739425964")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_tQ9vMlkyEeGeoaLUQk__nA_-566587723")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_tQ9vM1kyEeGeoaLUQk__nA_1718422715")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges2> ChargesInformation { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_tQ9vNFkyEeGeoaLUQk__nA_-2073308402")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tRG5IFkyEeGeoaLUQk__nA_-398242261")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    ICashAccount24? PreviousInstructingAgentAccount { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_tRG5IVkyEeGeoaLUQk__nA_-1788023981")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_tRG5IlkyEeGeoaLUQk__nA_-1027258828")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_tRG5I1kyEeGeoaLUQk__nA_-1268995986")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tRG5JFkyEeGeoaLUQk__nA_-1683421858")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount24? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_tRQqIFkyEeGeoaLUQk__nA_531803462")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tRQqIVkyEeGeoaLUQk__nA_-975849243")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount24? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_tRQqIlkyEeGeoaLUQk__nA_-857978258")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tRQqI1kyEeGeoaLUQk__nA_-532860751")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount24? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_tRQqJFkyEeGeoaLUQk__nA_1211990508")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification43? UltimateDebtor { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_tRabIFkyEeGeoaLUQk__nA_-1464797271")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification43? InitiatingParty { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_tRabIVkyEeGeoaLUQk__nA_-413664199")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification43 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_tRabIlkyEeGeoaLUQk__nA_2037434108")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount24? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_tRabI1kyEeGeoaLUQk__nA_1623008236")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tRjlEFkyEeGeoaLUQk__nA_788242403")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount24? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_tRjlEVkyEeGeoaLUQk__nA_1113359910")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_tRtWEFkyEeGeoaLUQk__nA_-779223776")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount24? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_tRtWEVkyEeGeoaLUQk__nA_-609549665")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification43 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_tRtWElkyEeGeoaLUQk__nA_-640929808")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount24? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_tRtWE1kyEeGeoaLUQk__nA_1076154295")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification43? UltimateCreditor { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_tRtWFFkyEeGeoaLUQk__nA_1530241564")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent1> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_tR2gAFkyEeGeoaLUQk__nA_1519142787")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_tR2gAVkyEeGeoaLUQk__nA_1701762718")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_tR2gAlkyEeGeoaLUQk__nA_1487172023")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    IEnumerable<IRegulatoryReporting3> RegulatoryReporting { get; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_tSARAFkyEeGeoaLUQk__nA_1941259292")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    IEnumerable<IRemittanceLocation2> RelatedRemittanceInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_tSARAVkyEeGeoaLUQk__nA_-522784835")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation7? RemittanceInformation { get; }
}
