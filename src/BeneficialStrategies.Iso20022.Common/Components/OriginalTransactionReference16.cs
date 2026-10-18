// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference16"/>
[IsoId("_tKG5QFkyEeGeoaLUQk__nA_-937586767")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference16
{
    /// <inheritdoc cref="IOriginalTransactionReference16.InterbankSettlementAmount"/>
    [IsoId("_tKG5QVkyEeGeoaLUQk__nA_-151524167")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.Amount"/>
    [IsoId("_tKG5QlkyEeGeoaLUQk__nA_-1540373861")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType3Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.InterbankSettlementDate"/>
    [IsoId("_tKG5Q1kyEeGeoaLUQk__nA_2090416730")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.RequestedCollectionDate"/>
    [IsoId("_tKG5RFkyEeGeoaLUQk__nA_-62996475")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.RequestedExecutionDate"/>
    [IsoId("_tKQqQFkyEeGeoaLUQk__nA_-442993583")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.CreditorSchemeIdentification"/>
    [IsoId("_tKQqQVkyEeGeoaLUQk__nA_-1569717154")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.SettlementInformation"/>
    [IsoId("_tKQqQlkyEeGeoaLUQk__nA_105348987")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction4? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.PaymentTypeInformation"/>
    [IsoId("_tKQqQ1kyEeGeoaLUQk__nA_403992860")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.PaymentMethod"/>
    [IsoId("_tKQqRFkyEeGeoaLUQk__nA_-701786252")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.MandateRelatedInformation"/>
    [IsoId("_tKZ0MFkyEeGeoaLUQk__nA_1000577705")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation8? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.RemittanceInformation"/>
    [IsoId("_tKZ0MVkyEeGeoaLUQk__nA_586151833")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.UltimateDebtor"/>
    [IsoId("_tKZ0MlkyEeGeoaLUQk__nA_-1493590143")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.Debtor"/>
    [IsoId("_tKZ0M1kyEeGeoaLUQk__nA_1293724448")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.DebtorAccount"/>
    [IsoId("_tKZ0NFkyEeGeoaLUQk__nA_1736712940")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.DebtorAgent"/>
    [IsoId("_tKjlMFkyEeGeoaLUQk__nA_361787928")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.DebtorAgentAccount"/>
    [IsoId("_tKjlMVkyEeGeoaLUQk__nA_804776420")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.CreditorAgent"/>
    [IsoId("_tKjlMlkyEeGeoaLUQk__nA_-904191464")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.CreditorAgentAccount"/>
    [IsoId("_tKjlM1kyEeGeoaLUQk__nA_1546906843")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.Creditor"/>
    [IsoId("_tKsvIFkyEeGeoaLUQk__nA_-1533208031")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.CreditorAccount"/>
    [IsoId("_tKsvIVkyEeGeoaLUQk__nA_297715138")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference16.UltimateCreditor"/>
    [IsoId("_tK2gIFkyEeGeoaLUQk__nA_622832645")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
