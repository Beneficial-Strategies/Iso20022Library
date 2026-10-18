// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction39"/>
[IsoId("_447bMXL-EeidQ_AAdEzxQA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction39
{
    /// <inheritdoc cref="ICreditTransferTransaction39.PaymentIdentification"/>
    [IsoId("_5DqEjXL-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification7 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PaymentTypeInformation"/>
    [IsoId("_5DqEj3L-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InterbankSettlementAmount"/>
    [IsoId("_5DqEkXL-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InterbankSettlementDate"/>
    [IsoId("_5DqEk3L-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.SettlementPriority"/>
    [IsoId("_5DqElXL-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.SettlementTimeIndication"/>
    [IsoId("_5DqEl3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.SettlementTimeRequest"/>
    [IsoId("_5DqEmXL-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.AcceptanceDateTime"/>
    [IsoId("_5DqEm3L-EeidQ_AAdEzxQA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PoolingAdjustmentDate"/>
    [IsoId("_5DqEnXL-EeidQ_AAdEzxQA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InstructedAmount"/>
    [IsoId("_5DqEn3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.ExchangeRate"/>
    [IsoId("_5DqEoXL-EeidQ_AAdEzxQA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.ChargeBearer"/>
    [IsoId("_5DqEo3L-EeidQ_AAdEzxQA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.ChargesInformation"/>
    [IsoId("_5DqEpXL-EeidQ_AAdEzxQA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent1"/>
    [IsoId("_5DqEp3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent1Account"/>
    [IsoId("_5DqEqXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent2"/>
    [IsoId("_5DqEq3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent2Account"/>
    [IsoId("_5DqErXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent3"/>
    [IsoId("_5DqEr3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.PreviousInstructingAgent3Account"/>
    [IsoId("_5DqEsXL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InstructingAgent"/>
    [IsoId("_5DqEs3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InstructedAgent"/>
    [IsoId("_5DqEtXL-EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent1"/>
    [IsoId("_5DqEt3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent1Account"/>
    [IsoId("_5DqEuXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent2"/>
    [IsoId("_5DqEu3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent2Account"/>
    [IsoId("_5DqEvXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent3"/>
    [IsoId("_5DqEv3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.IntermediaryAgent3Account"/>
    [IsoId("_5DqEwXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.UltimateDebtor"/>
    [IsoId("_5DqEw3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InitiatingParty"/>
    [IsoId("_5DqExXL-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.Debtor"/>
    [IsoId("_5DqEx3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.DebtorAccount"/>
    [IsoId("_5DqEyXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.DebtorAgent"/>
    [IsoId("_5DqEy3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.DebtorAgentAccount"/>
    [IsoId("_5DqEzXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.CreditorAgent"/>
    [IsoId("_5DqEz3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.CreditorAgentAccount"/>
    [IsoId("_5DqE0XL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.Creditor"/>
    [IsoId("_5DqE03L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.CreditorAccount"/>
    [IsoId("_5DqE1XL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.UltimateCreditor"/>
    [IsoId("_5DqE13L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.InstructionForCreditorAgent"/>
    [IsoId("_5DqE2XL-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction39.InstructionForNextAgent"/>
    [IsoId("_5DqE23L-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction39.Purpose"/>
    [IsoId("_5DqE3XL-EeidQ_AAdEzxQA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.RegulatoryReporting"/>
    [IsoId("_5DqE33L-EeidQ_AAdEzxQA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction39.Tax"/>
    [IsoId("_5DqE4XL-EeidQ_AAdEzxQA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.RelatedRemittanceInformation"/>
    [IsoId("_5DqE43L-EeidQ_AAdEzxQA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction39.RemittanceInformation"/>
    [IsoId("_5DqE5XL-EeidQ_AAdEzxQA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction39.SupplementaryData"/>
    [IsoId("_5DqE53L-EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
