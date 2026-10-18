// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction58"/>
[IsoId("_OwAjXRlWEe2Do_UtrNmb2g")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction58
{
    /// <inheritdoc cref="ICreditTransferTransaction58.PaymentIdentification"/>
    [IsoId("_O54Q-xlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PaymentTypeInformation"/>
    [IsoId("_O54Q_RlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InterbankSettlementAmount"/>
    [IsoId("_O54Q_xlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InterbankSettlementDate"/>
    [IsoId("_O54RARlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.SettlementPriority"/>
    [IsoId("_O54RAxlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.SettlementTimeIndication"/>
    [IsoId("_O54RBRlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.SettlementTimeRequest"/>
    [IsoId("_O54RBxlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.AcceptanceDateTime"/>
    [IsoId("_O54RCRlWEe2Do_UtrNmb2g")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PoolingAdjustmentDate"/>
    [IsoId("_O54RCxlWEe2Do_UtrNmb2g")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InstructedAmount"/>
    [IsoId("_O54RDRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.ExchangeRate"/>
    [IsoId("_O54RDxlWEe2Do_UtrNmb2g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.ChargeBearer"/>
    [IsoId("_O54RERlWEe2Do_UtrNmb2g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.ChargesInformation"/>
    [IsoId("_O54RExlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction58.MandateRelatedInformation"/>
    [IsoId("_O54RFRlWEe2Do_UtrNmb2g")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent1"/>
    [IsoId("_O54RFxlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent1Account"/>
    [IsoId("_O54RGRlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent2"/>
    [IsoId("_O54RGxlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent2Account"/>
    [IsoId("_O54RHRlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent3"/>
    [IsoId("_O54RHxlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.PreviousInstructingAgent3Account"/>
    [IsoId("_O54RIRlWEe2Do_UtrNmb2g")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InstructingAgent"/>
    [IsoId("_O54RIxlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InstructedAgent"/>
    [IsoId("_O54RJRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent1"/>
    [IsoId("_O54RJxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent1Account"/>
    [IsoId("_O54RKRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent2"/>
    [IsoId("_O54RKxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent2Account"/>
    [IsoId("_O54RLRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent3"/>
    [IsoId("_O54RLxlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.IntermediaryAgent3Account"/>
    [IsoId("_O54RMRlWEe2Do_UtrNmb2g")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.UltimateDebtor"/>
    [IsoId("_O54RMxlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InitiatingParty"/>
    [IsoId("_O54RNRlWEe2Do_UtrNmb2g")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.Debtor"/>
    [IsoId("_O54RNxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.DebtorAccount"/>
    [IsoId("_O54RORlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.DebtorAgent"/>
    [IsoId("_O54ROxlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.DebtorAgentAccount"/>
    [IsoId("_O54RPRlWEe2Do_UtrNmb2g")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.CreditorAgent"/>
    [IsoId("_O54RPxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.CreditorAgentAccount"/>
    [IsoId("_O54RQRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.Creditor"/>
    [IsoId("_O54RQxlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.CreditorAccount"/>
    [IsoId("_O54RRRlWEe2Do_UtrNmb2g")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.UltimateCreditor"/>
    [IsoId("_O54RRxlWEe2Do_UtrNmb2g")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.InstructionForCreditorAgent"/>
    [IsoId("_O54RSRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction58.InstructionForNextAgent"/>
    [IsoId("_O54RSxlWEe2Do_UtrNmb2g")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction58.Purpose"/>
    [IsoId("_O54RTRlWEe2Do_UtrNmb2g")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.RegulatoryReporting"/>
    [IsoId("_O54RTxlWEe2Do_UtrNmb2g")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction58.Tax"/>
    [IsoId("_O54RURlWEe2Do_UtrNmb2g")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation10? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.RelatedRemittanceInformation"/>
    [IsoId("_O54RUxlWEe2Do_UtrNmb2g")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction58.RemittanceInformation"/>
    [IsoId("_O54RVRlWEe2Do_UtrNmb2g")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction58.SupplementaryData"/>
    [IsoId("_O54RVxlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
