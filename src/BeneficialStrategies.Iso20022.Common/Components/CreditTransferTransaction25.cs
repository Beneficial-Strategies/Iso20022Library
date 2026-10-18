// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction25"/>
[IsoId("_2fvO7Tq4EeWZFYSPlduMhw")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction25
{
    /// <inheritdoc cref="ICreditTransferTransaction25.PaymentIdentification"/>
    [IsoId("_2m4_4zq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.PaymentTypeInformation"/>
    [IsoId("_2m4_5Tq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InterbankSettlementAmount"/>
    [IsoId("_2m4_5zq4EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InterbankSettlementDate"/>
    [IsoId("_2m4_6Tq4EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.SettlementPriority"/>
    [IsoId("_2m4_6zq4EeWZFYSPlduMhw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.SettlementTimeIndication"/>
    [IsoId("_2m4_7Tq4EeWZFYSPlduMhw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.SettlementTimeRequest"/>
    [IsoId("_2m4_7zq4EeWZFYSPlduMhw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.AcceptanceDateTime"/>
    [IsoId("_2m4_8Tq4EeWZFYSPlduMhw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.PoolingAdjustmentDate"/>
    [IsoId("_2m4_8zq4EeWZFYSPlduMhw")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InstructedAmount"/>
    [IsoId("_2m4_9Tq4EeWZFYSPlduMhw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.ExchangeRate"/>
    [IsoId("_2m4_9zq4EeWZFYSPlduMhw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.ChargeBearer"/>
    [IsoId("_2m4_-Tq4EeWZFYSPlduMhw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.ChargesInformation"/>
    [IsoId("_2m4_-zq4EeWZFYSPlduMhw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction25.PreviousInstructingAgent"/>
    [IsoId("_2m4__Tq4EeWZFYSPlduMhw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.PreviousInstructingAgentAccount"/>
    [IsoId("_2m4__zq4EeWZFYSPlduMhw")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InstructingAgent"/>
    [IsoId("_2m5AATq4EeWZFYSPlduMhw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InstructedAgent"/>
    [IsoId("_2m5AAzq4EeWZFYSPlduMhw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent1"/>
    [IsoId("_2m5ABTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent1Account"/>
    [IsoId("_2m5ABzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent2"/>
    [IsoId("_2m5ACTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent2Account"/>
    [IsoId("_2m5ACzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent3"/>
    [IsoId("_2m5ADTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.IntermediaryAgent3Account"/>
    [IsoId("_2m5ADzq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.UltimateDebtor"/>
    [IsoId("_2m5AETq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InitiatingParty"/>
    [IsoId("_2m5AEzq4EeWZFYSPlduMhw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.Debtor"/>
    [IsoId("_2m5AFTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.DebtorAccount"/>
    [IsoId("_2m5AFzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.DebtorAgent"/>
    [IsoId("_2m5AGTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.DebtorAgentAccount"/>
    [IsoId("_2m5AGzq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.CreditorAgent"/>
    [IsoId("_2m5AHTq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.CreditorAgentAccount"/>
    [IsoId("_2m5AHzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.Creditor"/>
    [IsoId("_2m5AITq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.CreditorAccount"/>
    [IsoId("_2m5AIzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.UltimateCreditor"/>
    [IsoId("_2m5AJTq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.InstructionForCreditorAgent"/>
    [IsoId("_2m5AJzq4EeWZFYSPlduMhw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction25.InstructionForNextAgent"/>
    [IsoId("_2m5AKTq4EeWZFYSPlduMhw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction25.Purpose"/>
    [IsoId("_2m5AKzq4EeWZFYSPlduMhw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.RegulatoryReporting"/>
    [IsoId("_2m5ALTq4EeWZFYSPlduMhw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction25.Tax"/>
    [IsoId("_2m5ALzq4EeWZFYSPlduMhw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.RelatedRemittanceInformation"/>
    [IsoId("_2m5AMTq4EeWZFYSPlduMhw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction25.RemittanceInformation"/>
    [IsoId("_2m5AMzq4EeWZFYSPlduMhw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction25.SupplementaryData"/>
    [IsoId("_2m5ANTq4EeWZFYSPlduMhw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
