// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key elements used to identify the original transaction(s) that is being referred to.
/// </summary>
[IsoId("_Fpe6gXeKEfCdoODv2ypKfw")]
[DisplayName("Tracker Payment Transaction15")]
public record TrackerPaymentTransaction15
{
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_Fx-vMXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; }

    /// <summary>
    /// Party that provides information on the status and related details of a transaction.
    /// </summary>
    [IsoId("_Fx-vM3eKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; }

    /// <summary>
    /// Party that is updated on the status and related details of a transaction.
    /// </summary>
    [IsoId("_Fx-vNXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; }

    /// <summary>
    /// The party indicated as sender in the technical header of an ISO payment message.
    /// </summary>
    [IsoId("_Fx-vN3eKEfCdoODv2ypKfw")]
    [DisplayName("Technical Sender")]
    [IsoXmlTag("TechSndr")]
    public IsoBICFIDec2014Identifier? TechnicalSender { get; init; }

    /// <summary>
    /// The party indicated as receiver in the technical header of an ISO payment message.
    /// </summary>
    [IsoId("_Fx-vOXeKEfCdoODv2ypKfw")]
    [DisplayName("Technical Receiver")]
    [IsoXmlTag("TechRcvr")]
    public IsoBICFIDec2014Identifier? TechnicalReceiver { get; init; }

    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_Fx-vO3eKEfCdoODv2ypKfw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public PaymentIdentification10? PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements identifying transactions associated with the payment instruction.
    /// </summary>
    [IsoId("_Fx-vPXeKEfCdoODv2ypKfw")]
    [DisplayName("Related Payment Identification")]
    [IsoXmlTag("RltdPmtId")]
    public RelatedTransactionData1? RelatedPaymentIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_Fx-vP3eKEfCdoODv2ypKfw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_Fx-vQXeKEfCdoODv2ypKfw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_Fx-vQ3eKEfCdoODv2ypKfw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Specifies the business scenarios in which the payment is executed, such as customer credit transfer or cover payment.
    /// </summary>
    [IsoId("_Fx-vRXeKEfCdoODv2ypKfw")]
    [DisplayName("Payment Scenario")]
    [IsoXmlTag("PmtScnro")]
    public PaymentScenario1Choice_? PaymentScenario { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_Fx-vR3eKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction9? SettlementInformation { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Fx-vSXeKEfCdoODv2ypKfw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Fx-vS3eKEfCdoODv2ypKfw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_Fx-vTXeKEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    [IsoId("_Fx-vT3eKEfCdoODv2ypKfw")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? ReturnedInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Fx-vUXeKEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [IsoId("_Fx-vU3eKEfCdoODv2ypKfw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    [IsoId("_Fx-vVXeKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_Fx-vV3eKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_Fx-vWXeKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_Fx-vW3eKEfCdoODv2ypKfw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("_Fx-vXXeKEfCdoODv2ypKfw")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.|Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_Fx-vX3eKEfCdoODv2ypKfw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, expressed in the currency of the debtor's account, and the currency in which the amount is to be moved.
    /// </summary>
    [IsoId("_Fx-vYXeKEfCdoODv2ypKfw")]
    [DisplayName("Equivalent Amount")]
    [IsoXmlTag("EqvtAmt")]
    public EquivalentAmount2? EquivalentAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.|Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_Fx-vY3eKEfCdoODv2ypKfw")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    /// <summary>
    /// Provides details on the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_Fx-vZXeKEfCdoODv2ypKfw")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange15? ExchangeRateData { get; init; }

    /// <summary>
    /// Agent that performed the foreign exchange operation.
    /// </summary>
    [IsoId("_FknvMZ7HEfCMRLP3eeonuw")]
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForeignExchangeAgent { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_Fx-vZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_Fx_WQXeKEfCdoODv2ypKfw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Provides tracker transaction information for a specific agent involved in the transaction chain. 
    /// </summary>
    [IsoId("_Fx_WQ3eKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord8> TrackerRecord { get; init; } = [];

    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("_Fx_WRXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData8? TrackerData { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example an address used over the www (HTTP) service that provides confirmation a payment has debited an account.
    /// </summary>
    [IsoId("_Fx_WR3eKEfCdoODv2ypKfw")]
    [DisplayName("Debit Confirmation URL Address")]
    [IsoXmlTag("DbtConfURLAdr")]
    public IsoMax2048Text? DebitConfirmationURLAddress { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Fx_WSXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WS3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Fx_WTXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WT3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_Fx_WUXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WU3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_Fx_WVXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WV3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_Fx_WWXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WW3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_Fx_WXXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_WX3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Fx_WYXeKEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_Fx_WY3eKEfCdoODv2ypKfw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Fx_WZXeKEfCdoODv2ypKfw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_Fx_WZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Fx_WaXeKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Fx_Wa3eKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Fx_WbXeKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Fx_Wb3eKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_Fx_WcXeKEfCdoODv2ypKfw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Fx_Wc3eKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Fx_WdXeKEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_Fx_Wd3eKEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    [IsoId("_Fx_WeXeKEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_Fx_We3eKEfCdoODv2ypKfw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_Fx_WfXeKEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_Fx_Wf3eKEfCdoODv2ypKfw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_Fx_WgXeKEfCdoODv2ypKfw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("_Fx_Wg3eKEfCdoODv2ypKfw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_Fx_WhXeKEfCdoODv2ypKfw")]
    [DisplayName("Reject Return Reason")]
    [IsoXmlTag("RjctRtrRsn")]
    public ValueList<PaymentRejectReturnReason1> RejectReturnReason { get; init; } = [];

    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    [IsoId("_Fx_Wh3eKEfCdoODv2ypKfw")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties8? ReturnChain { get; init; }

    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    [IsoId("_Fx_WiXeKEfCdoODv2ypKfw")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction46? UnderlyingCustomerCreditTransfer { get; init; }
}
