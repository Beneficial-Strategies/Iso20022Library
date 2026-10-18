// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction30"/>
[IsoId("_kriIgImcEeeKR__nUfxjwA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction30
{
    /// <inheritdoc cref="ICreditTransferTransaction30.PaymentIdentification"/>
    [IsoId("_kriIhImcEeeKR__nUfxjwA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PaymentTypeInformation"/>
    [IsoId("_kriIromcEeeKR__nUfxjwA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InterbankSettlementAmount"/>
    [IsoId("_kriIoYmcEeeKR__nUfxjwA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InterbankSettlementDate"/>
    [IsoId("_kriIqImcEeeKR__nUfxjwA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.SettlementPriority"/>
    [IsoId("_kriImYmcEeeKR__nUfxjwA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.SettlementTimeIndication"/>
    [IsoId("_kriInYmcEeeKR__nUfxjwA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.SettlementTimeRequest"/>
    [IsoId("_kriIqYmcEeeKR__nUfxjwA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.AcceptanceDateTime"/>
    [IsoId("_kriIkomcEeeKR__nUfxjwA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PoolingAdjustmentDate"/>
    [IsoId("_kriIjImcEeeKR__nUfxjwA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InstructedAmount"/>
    [IsoId("_kriIp4mcEeeKR__nUfxjwA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.ExchangeRate"/>
    [IsoId("_kriIh4mcEeeKR__nUfxjwA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.ChargeBearer"/>
    [IsoId("_kriIoomcEeeKR__nUfxjwA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.ChargesInformation"/>
    [IsoId("_kriIlImcEeeKR__nUfxjwA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent1"/>
    [IsoId("_kriItomcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent1Account"/>
    [IsoId("_kriIuYmcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount24? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent2"/>
    [IsoId("_kriIuomcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent2Account"/>
    [IsoId("_kriIiImcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount24? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent3"/>
    [IsoId("_kriIkImcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.PreviousInstructingAgent3Account"/>
    [IsoId("_kriIv4mcEeeKR__nUfxjwA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount24? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InstructingAgent"/>
    [IsoId("_kriIlYmcEeeKR__nUfxjwA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InstructedAgent"/>
    [IsoId("_kriIsYmcEeeKR__nUfxjwA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent1"/>
    [IsoId("_kriIg4mcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent1Account"/>
    [IsoId("_kriIvImcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent2"/>
    [IsoId("_kriIlomcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent2Account"/>
    [IsoId("_kriIs4mcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent3"/>
    [IsoId("_kriIsomcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.IntermediaryAgent3Account"/>
    [IsoId("_kriIrImcEeeKR__nUfxjwA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.UltimateDebtor"/>
    [IsoId("_kriIi4mcEeeKR__nUfxjwA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification125? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InitiatingParty"/>
    [IsoId("_kriIk4mcEeeKR__nUfxjwA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification125? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.Debtor"/>
    [IsoId("_kriIgYmcEeeKR__nUfxjwA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification125 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.DebtorAccount"/>
    [IsoId("_kriIpImcEeeKR__nUfxjwA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.DebtorAgent"/>
    [IsoId("_kriIsImcEeeKR__nUfxjwA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.DebtorAgentAccount"/>
    [IsoId("_kriIqomcEeeKR__nUfxjwA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.CreditorAgent"/>
    [IsoId("_kriInImcEeeKR__nUfxjwA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.CreditorAgentAccount"/>
    [IsoId("_kriImImcEeeKR__nUfxjwA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.Creditor"/>
    [IsoId("_kriIhYmcEeeKR__nUfxjwA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification125 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.CreditorAccount"/>
    [IsoId("_kriIm4mcEeeKR__nUfxjwA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.UltimateCreditor"/>
    [IsoId("_kriIpomcEeeKR__nUfxjwA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification125? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.InstructionForCreditorAgent"/>
    [IsoId("_kriIn4mcEeeKR__nUfxjwA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction30.InstructionForNextAgent"/>
    [IsoId("_kriInomcEeeKR__nUfxjwA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction30.Purpose"/>
    [IsoId("_kriImomcEeeKR__nUfxjwA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.RegulatoryReporting"/>
    [IsoId("_kriIu4mcEeeKR__nUfxjwA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction30.Tax"/>
    [IsoId("_kriIpYmcEeeKR__nUfxjwA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation6? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.RelatedRemittanceInformation"/>
    [IsoId("_kriIkYmcEeeKR__nUfxjwA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction30.RemittanceInformation"/>
    [IsoId("_kriIiomcEeeKR__nUfxjwA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation15? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction30.SupplementaryData"/>
    [IsoId("_kriIgomcEeeKR__nUfxjwA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
