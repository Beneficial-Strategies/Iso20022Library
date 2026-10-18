// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation17"/>
[IsoId("_MHNOoRmHEeS15voCZPa1ZA")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation17
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation17.PaymentIdentification"/>
    [IsoId("_MWiEKxmHEeS15voCZPa1ZA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.PaymentTypeInformation"/>
    [IsoId("_MWiELRmHEeS15voCZPa1ZA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InterbankSettlementAmount"/>
    [IsoId("_MWiELxmHEeS15voCZPa1ZA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InterbankSettlementDate"/>
    [IsoId("_MWiEMRmHEeS15voCZPa1ZA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.SettlementPriority"/>
    [IsoId("_zdUu0RmGEeS15voCZPa1ZA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InstructedAmount"/>
    [IsoId("_MWiEMxmHEeS15voCZPa1ZA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.ExchangeRate"/>
    [IsoId("_MWiENRmHEeS15voCZPa1ZA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.ChargeBearer"/>
    [IsoId("_MWiENxmHEeS15voCZPa1ZA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.ChargesInformation"/>
    [IsoId("_MWiEORmHEeS15voCZPa1ZA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.RequestedCollectionDate"/>
    [IsoId("_MWiEOxmHEeS15voCZPa1ZA")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.DirectDebitTransaction"/>
    [IsoId("_MWr1ERmHEeS15voCZPa1ZA")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction8? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.Creditor"/>
    [IsoId("_MWr1ExmHEeS15voCZPa1ZA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.CreditorAccount"/>
    [IsoId("_MWr1FRmHEeS15voCZPa1ZA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.CreditorAgent"/>
    [IsoId("_MWr1FxmHEeS15voCZPa1ZA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.CreditorAgentAccount"/>
    [IsoId("_MWr1GRmHEeS15voCZPa1ZA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.UltimateCreditor"/>
    [IsoId("_MWr1GxmHEeS15voCZPa1ZA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InitiatingParty"/>
    [IsoId("_MWr1HRmHEeS15voCZPa1ZA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InstructingAgent"/>
    [IsoId("_MWr1HxmHEeS15voCZPa1ZA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.InstructedAgent"/>
    [IsoId("_MWr1IRmHEeS15voCZPa1ZA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent1"/>
    [IsoId("_MWr1IxmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent1Account"/>
    [IsoId("_MWr1JRmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent2"/>
    [IsoId("_MWr1JxmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent2Account"/>
    [IsoId("_MWr1KRmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent3"/>
    [IsoId("_MWr1KxmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.IntermediaryAgent3Account"/>
    [IsoId("_MWr1LRmHEeS15voCZPa1ZA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.Debtor"/>
    [IsoId("_MWr1LxmHEeS15voCZPa1ZA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.DebtorAccount"/>
    [IsoId("_MWr1MRmHEeS15voCZPa1ZA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.DebtorAgent"/>
    [IsoId("_MWr1MxmHEeS15voCZPa1ZA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.DebtorAgentAccount"/>
    [IsoId("_MWr1NRmHEeS15voCZPa1ZA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.UltimateDebtor"/>
    [IsoId("_MWr1NxmHEeS15voCZPa1ZA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.Purpose"/>
    [IsoId("_MWr1ORmHEeS15voCZPa1ZA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.RegulatoryReporting"/>
    [IsoId("_MWr1OxmHEeS15voCZPa1ZA")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.RelatedRemittanceInformation"/>
    [IsoId("_MWr1PRmHEeS15voCZPa1ZA")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.RemittanceInformation"/>
    [IsoId("_MWr1PxmHEeS15voCZPa1ZA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation10? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation17.SupplementaryData"/>
    [IsoId("_MWr1QRmHEeS15voCZPa1ZA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
