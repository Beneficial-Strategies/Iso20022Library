// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction7"/>
[IsoId("_pFi8YSHMEeKXpaAk3g3urA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction7
{
    /// <inheritdoc cref="ICreditTransferTransaction7.PaymentIdentification"/>
    [IsoId("_paaZbSHMEeKXpaAk3g3urA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.PaymentTypeInformation"/>
    [IsoId("_paaZcSHMEeKXpaAk3g3urA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InterbankSettlementAmount"/>
    [IsoId("_paaZeSHMEeKXpaAk3g3urA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InterbankSettlementDate"/>
    [IsoId("_paaZgSHMEeKXpaAk3g3urA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.SettlementPriority"/>
    [IsoId("_paaZiSHMEeKXpaAk3g3urA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.SettlementTimeIndication"/>
    [IsoId("_paaZjSHMEeKXpaAk3g3urA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.SettlementTimeRequest"/>
    [IsoId("_paaZkSHMEeKXpaAk3g3urA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.AcceptanceDateTime"/>
    [IsoId("_paaZlSHMEeKXpaAk3g3urA")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.PoolingAdjustmentDate"/>
    [IsoId("_paaZmSHMEeKXpaAk3g3urA")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InstructedAmount"/>
    [IsoId("_paaZnSHMEeKXpaAk3g3urA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.ExchangeRate"/>
    [IsoId("_paaZoSHMEeKXpaAk3g3urA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.ChargeBearer"/>
    [IsoId("_paaZqSHMEeKXpaAk3g3urA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.ChargesInformation"/>
    [IsoId("_paaZrSHMEeKXpaAk3g3urA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction7.PreviousInstructingAgent"/>
    [IsoId("_paaZsSHMEeKXpaAk3g3urA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.PreviousInstructingAgentAccount"/>
    [IsoId("_paaZtSHMEeKXpaAk3g3urA")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InstructingAgent"/>
    [IsoId("_paaZuSHMEeKXpaAk3g3urA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InstructedAgent"/>
    [IsoId("_paaZwSHMEeKXpaAk3g3urA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent1"/>
    [IsoId("_paaZySHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent1Account"/>
    [IsoId("_paaZzSHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent2"/>
    [IsoId("_paaZ0SHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent2Account"/>
    [IsoId("_paaZ1SHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent3"/>
    [IsoId("_paaZ2SHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.IntermediaryAgent3Account"/>
    [IsoId("_paaZ3SHMEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.UltimateDebtor"/>
    [IsoId("_paaZ4SHMEeKXpaAk3g3urA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InitiatingParty"/>
    [IsoId("_paaZ5SHMEeKXpaAk3g3urA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.Debtor"/>
    [IsoId("_paaZ6SHMEeKXpaAk3g3urA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.DebtorAccount"/>
    [IsoId("_paaZ7SHMEeKXpaAk3g3urA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.DebtorAgent"/>
    [IsoId("_paaZ8SHMEeKXpaAk3g3urA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.DebtorAgentAccount"/>
    [IsoId("_paaZ9SHMEeKXpaAk3g3urA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.CreditorAgent"/>
    [IsoId("_paaZ-SHMEeKXpaAk3g3urA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.CreditorAgentAccount"/>
    [IsoId("_paaZ_SHMEeKXpaAk3g3urA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.Creditor"/>
    [IsoId("_paaaASHMEeKXpaAk3g3urA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.CreditorAccount"/>
    [IsoId("_paaaBSHMEeKXpaAk3g3urA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.UltimateCreditor"/>
    [IsoId("_paaaDSHMEeKXpaAk3g3urA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.InstructionForCreditorAgent"/>
    [IsoId("_paaaESHMEeKXpaAk3g3urA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction7.InstructionForNextAgent"/>
    [IsoId("_paaaGSHMEeKXpaAk3g3urA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction7.Purpose"/>
    [IsoId("_paaaHSHMEeKXpaAk3g3urA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.RegulatoryReporting"/>
    [IsoId("_paaaISHMEeKXpaAk3g3urA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction7.RelatedRemittanceInformation"/>
    [IsoId("_paaaJSHMEeKXpaAk3g3urA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction7.RemittanceInformation"/>
    [IsoId("_paaaKSHMEeKXpaAk3g3urA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction7.SupplementaryData"/>
    [IsoId("_v36oEyHMEeKXpaAk3g3urA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
