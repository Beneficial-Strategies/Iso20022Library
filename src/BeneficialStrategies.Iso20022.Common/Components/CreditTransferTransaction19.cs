// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction19"/>
[IsoId("_eMUsmx77EeSxevWRRWxNAg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction19
{
    /// <inheritdoc cref="ICreditTransferTransaction19.PaymentIdentification"/>
    [IsoId("_edridx77EeSxevWRRWxNAg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.PaymentTypeInformation"/>
    [IsoId("_edrieR77EeSxevWRRWxNAg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InterbankSettlementAmount"/>
    [IsoId("_edriex77EeSxevWRRWxNAg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InterbankSettlementDate"/>
    [IsoId("_edrifR77EeSxevWRRWxNAg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.SettlementPriority"/>
    [IsoId("_edrifx77EeSxevWRRWxNAg")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.SettlementTimeIndication"/>
    [IsoId("_edrigR77EeSxevWRRWxNAg")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.SettlementTimeRequest"/>
    [IsoId("_edrigx77EeSxevWRRWxNAg")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.AcceptanceDateTime"/>
    [IsoId("_edrihR77EeSxevWRRWxNAg")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.PoolingAdjustmentDate"/>
    [IsoId("_edrihx77EeSxevWRRWxNAg")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InstructedAmount"/>
    [IsoId("_edriiR77EeSxevWRRWxNAg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.ExchangeRate"/>
    [IsoId("_edriix77EeSxevWRRWxNAg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.ChargeBearer"/>
    [IsoId("_edrijR77EeSxevWRRWxNAg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.ChargesInformation"/>
    [IsoId("_edrijx77EeSxevWRRWxNAg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction19.PreviousInstructingAgent"/>
    [IsoId("_edrikR77EeSxevWRRWxNAg")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.PreviousInstructingAgentAccount"/>
    [IsoId("_edrikx77EeSxevWRRWxNAg")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InstructingAgent"/>
    [IsoId("_edrilR77EeSxevWRRWxNAg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InstructedAgent"/>
    [IsoId("_edrilx77EeSxevWRRWxNAg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent1"/>
    [IsoId("_edrimR77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent1Account"/>
    [IsoId("_edrimx77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent2"/>
    [IsoId("_edrinR77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent2Account"/>
    [IsoId("_edrinx77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent3"/>
    [IsoId("_edrioR77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.IntermediaryAgent3Account"/>
    [IsoId("_edriox77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.UltimateDebtor"/>
    [IsoId("_edripR77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InitiatingParty"/>
    [IsoId("_edripx77EeSxevWRRWxNAg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.Debtor"/>
    [IsoId("_edriqR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.DebtorAccount"/>
    [IsoId("_edriqx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.DebtorAgent"/>
    [IsoId("_edrirR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.DebtorAgentAccount"/>
    [IsoId("_edrirx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.CreditorAgent"/>
    [IsoId("_edrisR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.CreditorAgentAccount"/>
    [IsoId("_edrisx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.Creditor"/>
    [IsoId("_edritR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.CreditorAccount"/>
    [IsoId("_edritx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.UltimateCreditor"/>
    [IsoId("_edriuR77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.InstructionForCreditorAgent"/>
    [IsoId("_edriux77EeSxevWRRWxNAg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction19.InstructionForNextAgent"/>
    [IsoId("_edrivR77EeSxevWRRWxNAg")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction19.Purpose"/>
    [IsoId("_edrivx77EeSxevWRRWxNAg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.RegulatoryReporting"/>
    [IsoId("_edriwR77EeSxevWRRWxNAg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction19.Tax"/>
    [IsoId("_Ye9eIR8cEeSxevWRRWxNAg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.RelatedRemittanceInformation"/>
    [IsoId("_edriwx77EeSxevWRRWxNAg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction19.RemittanceInformation"/>
    [IsoId("_edrixR77EeSxevWRRWxNAg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation10? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction19.SupplementaryData"/>
    [IsoId("_edrixx77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
