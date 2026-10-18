// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction43"/>
[IsoId("_QynVkcQAEemsic1bQcEtLA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction43
{
    /// <inheritdoc cref="ICreditTransferTransaction43.PaymentIdentification"/>
    [IsoId("_Q-f1ncQAEemsic1bQcEtLA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PaymentTypeInformation"/>
    [IsoId("_Q-f1n8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InterbankSettlementAmount"/>
    [IsoId("_Q-f1ocQAEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InterbankSettlementDate"/>
    [IsoId("_Q-f1o8QAEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.SettlementPriority"/>
    [IsoId("_Q-f1pcQAEemsic1bQcEtLA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.SettlementTimeIndication"/>
    [IsoId("_Q-f1p8QAEemsic1bQcEtLA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.SettlementTimeRequest"/>
    [IsoId("_Q-f1qcQAEemsic1bQcEtLA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.AcceptanceDateTime"/>
    [IsoId("_Q-f1q8QAEemsic1bQcEtLA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PoolingAdjustmentDate"/>
    [IsoId("_Q-f1rcQAEemsic1bQcEtLA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InstructedAmount"/>
    [IsoId("_Q-f1r8QAEemsic1bQcEtLA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.ExchangeRate"/>
    [IsoId("_Q-f1scQAEemsic1bQcEtLA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.ChargeBearer"/>
    [IsoId("_Q-f1s8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.ChargesInformation"/>
    [IsoId("_Q-f1tcQAEemsic1bQcEtLA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction43.MandateRelatedInformation"/>
    [IsoId("_nnbHEQbQEeqF8ePC1fs2Gg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent1"/>
    [IsoId("_Q-f1t8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent1Account"/>
    [IsoId("_Q-f1ucQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent2"/>
    [IsoId("_Q-f1u8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent2Account"/>
    [IsoId("_Q-f1vcQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent3"/>
    [IsoId("_Q-f1v8QAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.PreviousInstructingAgent3Account"/>
    [IsoId("_Q-f1wcQAEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InstructingAgent"/>
    [IsoId("_Q-f1w8QAEemsic1bQcEtLA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InstructedAgent"/>
    [IsoId("_Q-f1xcQAEemsic1bQcEtLA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent1"/>
    [IsoId("_Q-f1x8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent1Account"/>
    [IsoId("_Q-f1ycQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent2"/>
    [IsoId("_Q-f1y8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent2Account"/>
    [IsoId("_Q-f1zcQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent3"/>
    [IsoId("_Q-f1z8QAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.IntermediaryAgent3Account"/>
    [IsoId("_Q-f10cQAEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.UltimateDebtor"/>
    [IsoId("_Q-f108QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InitiatingParty"/>
    [IsoId("_Q-f11cQAEemsic1bQcEtLA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.Debtor"/>
    [IsoId("_Q-f118QAEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.DebtorAccount"/>
    [IsoId("_Q-f12cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.DebtorAgent"/>
    [IsoId("_Q-f128QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.DebtorAgentAccount"/>
    [IsoId("_Q-f13cQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.CreditorAgent"/>
    [IsoId("_Q-f138QAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.CreditorAgentAccount"/>
    [IsoId("_Q-f14cQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.Creditor"/>
    [IsoId("_Q-f148QAEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.CreditorAccount"/>
    [IsoId("_Q-f15cQAEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.UltimateCreditor"/>
    [IsoId("_Q-f158QAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.InstructionForCreditorAgent"/>
    [IsoId("_Q-f16cQAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction43.InstructionForNextAgent"/>
    [IsoId("_Q-f168QAEemsic1bQcEtLA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction43.Purpose"/>
    [IsoId("_Q-f17cQAEemsic1bQcEtLA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.RegulatoryReporting"/>
    [IsoId("_Q-f178QAEemsic1bQcEtLA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction43.Tax"/>
    [IsoId("_Q-f18cQAEemsic1bQcEtLA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.RelatedRemittanceInformation"/>
    [IsoId("_Q-f188QAEemsic1bQcEtLA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction43.RemittanceInformation"/>
    [IsoId("_Q-f19cQAEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction43.SupplementaryData"/>
    [IsoId("_Q-f198QAEemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
