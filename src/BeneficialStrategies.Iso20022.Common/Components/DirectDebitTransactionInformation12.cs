// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation12"/>
[IsoId("_tUrxkFkyEeGeoaLUQk__nA_-2047920164")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation12
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation12.PaymentIdentification"/>
    [IsoId("_tUrxkVkyEeGeoaLUQk__nA_551558008")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.PaymentTypeInformation"/>
    [IsoId("_tUrxklkyEeGeoaLUQk__nA_-758621385")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InterbankSettlementAmount"/>
    [IsoId("_tUrxk1kyEeGeoaLUQk__nA_-434864572")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InterbankSettlementDate"/>
    [IsoId("_tU1ikFkyEeGeoaLUQk__nA_-2068792151")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InstructedAmount"/>
    [IsoId("_tU1ikVkyEeGeoaLUQk__nA_2090400804")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.ExchangeRate"/>
    [IsoId("_tU1iklkyEeGeoaLUQk__nA_-1443801339")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.ChargeBearer"/>
    [IsoId("_tU1ik1kyEeGeoaLUQk__nA_-1761578000")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.ChargesInformation"/>
    [IsoId("_tU1ilFkyEeGeoaLUQk__nA_1019327771")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.RequestedCollectionDate"/>
    [IsoId("_tU_TkFkyEeGeoaLUQk__nA_830110322")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.DirectDebitTransaction"/>
    [IsoId("_tU_TkVkyEeGeoaLUQk__nA_287125238")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction7? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.Creditor"/>
    [IsoId("_tU_TklkyEeGeoaLUQk__nA_-1096402097")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.CreditorAccount"/>
    [IsoId("_tU_Tk1kyEeGeoaLUQk__nA_-771284590")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.CreditorAgent"/>
    [IsoId("_tU_TlFkyEeGeoaLUQk__nA_306735748")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.CreditorAgentAccount"/>
    [IsoId("_tVIdgFkyEeGeoaLUQk__nA_1427653938")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.UltimateCreditor"/>
    [IsoId("_tVIdgVkyEeGeoaLUQk__nA_1416555161")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InitiatingParty"/>
    [IsoId("_tVIdglkyEeGeoaLUQk__nA_-663186815")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InstructingAgent"/>
    [IsoId("_tVIdg1kyEeGeoaLUQk__nA_-1735191874")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.InstructedAgent"/>
    [IsoId("_tVIdhFkyEeGeoaLUQk__nA_-1281104605")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent1"/>
    [IsoId("_tVSOgFkyEeGeoaLUQk__nA_1827572889")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent1Account"/>
    [IsoId("_tVSOgVkyEeGeoaLUQk__nA_992807056")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent2"/>
    [IsoId("_tVbYcFkyEeGeoaLUQk__nA_1914970366")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent2Account"/>
    [IsoId("_tVbYcVkyEeGeoaLUQk__nA_-282228963")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent3"/>
    [IsoId("_tVbYclkyEeGeoaLUQk__nA_439116736")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.IntermediaryAgent3Account"/>
    [IsoId("_tVbYc1kyEeGeoaLUQk__nA_2041484101")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.Debtor"/>
    [IsoId("_tVbYdFkyEeGeoaLUQk__nA_-1202350123")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.DebtorAccount"/>
    [IsoId("_tVlJcFkyEeGeoaLUQk__nA_1573865691")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.DebtorAgent"/>
    [IsoId("_tVlJcVkyEeGeoaLUQk__nA_1691736676")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.DebtorAgentAccount"/>
    [IsoId("_tVlJclkyEeGeoaLUQk__nA_-436091167")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.UltimateDebtor"/>
    [IsoId("_tVlJc1kyEeGeoaLUQk__nA_-318220182")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.Purpose"/>
    [IsoId("_tVlJdFkyEeGeoaLUQk__nA_-79174585")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.RegulatoryReporting"/>
    [IsoId("_tVu6cFkyEeGeoaLUQk__nA_303280523")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.RelatedRemittanceInformation"/>
    [IsoId("_tVu6cVkyEeGeoaLUQk__nA_292181746")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation12.RemittanceInformation"/>
    [IsoId("_tVu6clkyEeGeoaLUQk__nA_1052946899")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
