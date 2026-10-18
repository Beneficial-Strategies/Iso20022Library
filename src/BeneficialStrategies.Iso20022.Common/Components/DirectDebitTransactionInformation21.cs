// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation21"/>
[IsoId("_svFWZ2k2Eeanu6HLe77Rkg")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation21
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation21.PaymentIdentification"/>
    [IsoId("_s3kkC2k2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.PaymentTypeInformation"/>
    [IsoId("_s3kkDWk2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InterbankSettlementAmount"/>
    [IsoId("_s3kkD2k2Eeanu6HLe77Rkg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InterbankSettlementDate"/>
    [IsoId("_s3kkEWk2Eeanu6HLe77Rkg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.SettlementPriority"/>
    [IsoId("_s3kkE2k2Eeanu6HLe77Rkg")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InstructedAmount"/>
    [IsoId("_s3kkFWk2Eeanu6HLe77Rkg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.ExchangeRate"/>
    [IsoId("_s3kkF2k2Eeanu6HLe77Rkg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.ChargeBearer"/>
    [IsoId("_s3kkGWk2Eeanu6HLe77Rkg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.ChargesInformation"/>
    [IsoId("_s3kkG2k2Eeanu6HLe77Rkg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.RequestedCollectionDate"/>
    [IsoId("_s3kkHWk2Eeanu6HLe77Rkg")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.DirectDebitTransaction"/>
    [IsoId("_s3kkH2k2Eeanu6HLe77Rkg")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction9? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.Creditor"/>
    [IsoId("_s3kkIWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.CreditorAccount"/>
    [IsoId("_s3kkI2k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.CreditorAgent"/>
    [IsoId("_s3kkJWk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.CreditorAgentAccount"/>
    [IsoId("_s3kkJ2k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.UltimateCreditor"/>
    [IsoId("_s3kkKWk2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InitiatingParty"/>
    [IsoId("_s3kkK2k2Eeanu6HLe77Rkg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InstructingAgent"/>
    [IsoId("_s3kkLWk2Eeanu6HLe77Rkg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.InstructedAgent"/>
    [IsoId("_s3kkL2k2Eeanu6HLe77Rkg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent1"/>
    [IsoId("_s3kkMWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent1Account"/>
    [IsoId("_s3kkM2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent2"/>
    [IsoId("_s3kkNWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent2Account"/>
    [IsoId("_s3kkN2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent3"/>
    [IsoId("_s3kkOWk2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.IntermediaryAgent3Account"/>
    [IsoId("_s3kkO2k2Eeanu6HLe77Rkg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.Debtor"/>
    [IsoId("_s3kkPWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.DebtorAccount"/>
    [IsoId("_s3kkP2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.DebtorAgent"/>
    [IsoId("_s3kkQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.DebtorAgentAccount"/>
    [IsoId("_s3kkQ2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.UltimateDebtor"/>
    [IsoId("_s3kkRWk2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.Purpose"/>
    [IsoId("_s3kkR2k2Eeanu6HLe77Rkg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.RegulatoryReporting"/>
    [IsoId("_s3kkSWk2Eeanu6HLe77Rkg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.RelatedRemittanceInformation"/>
    [IsoId("_s3kkS2k2Eeanu6HLe77Rkg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.RemittanceInformation"/>
    [IsoId("_s3kkTWk2Eeanu6HLe77Rkg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation21.SupplementaryData"/>
    [IsoId("_s3kkT2k2Eeanu6HLe77Rkg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
