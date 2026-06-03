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
    [IsoId("_Fx-vMXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; }

    [IsoId("_Fx-vM3eKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; }

    [IsoId("_Fx-vNXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; }

    [IsoId("_Fx-vN3eKEfCdoODv2ypKfw")]
    [DisplayName("Technical Sender")]
    [IsoXmlTag("TechSndr")]
    public IsoBICFIDec2014Identifier? TechnicalSender { get; init; }

    [IsoId("_Fx-vOXeKEfCdoODv2ypKfw")]
    [DisplayName("Technical Receiver")]
    [IsoXmlTag("TechRcvr")]
    public IsoBICFIDec2014Identifier? TechnicalReceiver { get; init; }

    [IsoId("_Fx-vO3eKEfCdoODv2ypKfw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public PaymentIdentification10? PaymentIdentification { get; init; }

    [IsoId("_Fx-vPXeKEfCdoODv2ypKfw")]
    [DisplayName("Related Payment Identification")]
    [IsoXmlTag("RltdPmtId")]
    public RelatedTransactionData1? RelatedPaymentIdentification { get; init; }

    [IsoId("_Fx-vP3eKEfCdoODv2ypKfw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    [IsoId("_Fx-vQXeKEfCdoODv2ypKfw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    [IsoId("_Fx-vQ3eKEfCdoODv2ypKfw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    [IsoId("_Fx-vRXeKEfCdoODv2ypKfw")]
    [DisplayName("Payment Scenario")]
    [IsoXmlTag("PmtScnro")]
    public PaymentScenario1Choice? PaymentScenario { get; init; }

    [IsoId("_Fx-vR3eKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction9? SettlementInformation { get; init; }

    [IsoId("_Fx-vSXeKEfCdoODv2ypKfw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    [IsoId("_Fx-vS3eKEfCdoODv2ypKfw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    [IsoId("_Fx-vTXeKEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    [IsoId("_Fx-vT3eKEfCdoODv2ypKfw")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? ReturnedInterbankSettlementAmount { get; init; }

    [IsoId("_Fx-vUXeKEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    [IsoId("_Fx-vU3eKEfCdoODv2ypKfw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice? RequestedExecutionDate { get; init; }

    [IsoId("_Fx-vVXeKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    [IsoId("_Fx-vV3eKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    [IsoId("_Fx-vWXeKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    [IsoId("_Fx-vW3eKEfCdoODv2ypKfw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    [IsoId("_Fx-vXXeKEfCdoODv2ypKfw")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    [IsoId("_Fx-vX3eKEfCdoODv2ypKfw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    [IsoId("_Fx-vYXeKEfCdoODv2ypKfw")]
    [DisplayName("Equivalent Amount")]
    [IsoXmlTag("EqvtAmt")]
    public EquivalentAmount2? EquivalentAmount { get; init; }

    [IsoId("_Fx-vY3eKEfCdoODv2ypKfw")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; }

    [IsoId("_Fx-vZXeKEfCdoODv2ypKfw")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange15? ExchangeRateData { get; init; }

    [IsoId("_FknvMZ7HEfCMRLP3eeonuw")]
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForeignExchangeAgent { get; init; }

    [IsoId("_Fx-vZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    [IsoId("_Fx_WQXeKEfCdoODv2ypKfw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    [IsoId("_Fx_WQ3eKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Record")]
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord8> TrackerRecord { get; init; } = [];

    [IsoId("_Fx_WRXeKEfCdoODv2ypKfw")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData8? TrackerData { get; init; }

    [IsoId("_Fx_WR3eKEfCdoODv2ypKfw")]
    [DisplayName("Debit Confirmation URL Address")]
    [IsoXmlTag("DbtConfURLAdr")]
    public IsoMax2048Text? DebitConfirmationURLAddress { get; init; }

    [IsoId("_Fx_WSXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    [IsoId("_Fx_WS3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    [IsoId("_Fx_WTXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    [IsoId("_Fx_WT3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    [IsoId("_Fx_WUXeKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    [IsoId("_Fx_WU3eKEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    [IsoId("_Fx_WVXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    [IsoId("_Fx_WV3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    [IsoId("_Fx_WWXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    [IsoId("_Fx_WW3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    [IsoId("_Fx_WXXeKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    [IsoId("_Fx_WX3eKEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    [IsoId("_Fx_WYXeKEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    [IsoId("_Fx_WY3eKEfCdoODv2ypKfw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    [IsoId("_Fx_WZXeKEfCdoODv2ypKfw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice? Debtor { get; init; }

    [IsoId("_Fx_WZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    [IsoId("_Fx_WaXeKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    [IsoId("_Fx_Wa3eKEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    [IsoId("_Fx_WbXeKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    [IsoId("_Fx_Wb3eKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    [IsoId("_Fx_WcXeKEfCdoODv2ypKfw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice? Creditor { get; init; }

    [IsoId("_Fx_Wc3eKEfCdoODv2ypKfw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    [IsoId("_Fx_WdXeKEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    [IsoId("_Fx_Wd3eKEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    [IsoId("_Fx_WeXeKEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    [IsoId("_Fx_We3eKEfCdoODv2ypKfw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice? Purpose { get; init; }

    [IsoId("_Fx_WfXeKEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    [IsoId("_Fx_Wf3eKEfCdoODv2ypKfw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    [IsoId("_Fx_WgXeKEfCdoODv2ypKfw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    [IsoId("_Fx_Wg3eKEfCdoODv2ypKfw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    [IsoId("_Fx_WhXeKEfCdoODv2ypKfw")]
    [DisplayName("Reject Return Reason")]
    [IsoXmlTag("RjctRtrRsn")]
    public ValueList<PaymentRejectReturnReason1> RejectReturnReason { get; init; } = [];

    [IsoId("_Fx_Wh3eKEfCdoODv2ypKfw")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    public TransactionParties8? ReturnChain { get; init; }

    [IsoId("_Fx_WiXeKEfCdoODv2ypKfw")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction46? UnderlyingCustomerCreditTransfer { get; init; }
}
