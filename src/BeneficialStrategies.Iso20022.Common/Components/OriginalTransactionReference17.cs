// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference17"/>
[IsoId("_tZ5owFkyEeGeoaLUQk__nA_1065726726")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference17
{
    /// <inheritdoc cref="IOriginalTransactionReference17.InterbankSettlementAmount"/>
    [IsoId("_tZ5owVkyEeGeoaLUQk__nA_-8065103")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.Amount"/>
    [IsoId("_tZ5owlkyEeGeoaLUQk__nA_-1689370348")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType3Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.InterbankSettlementDate"/>
    [IsoId("_tZ5ow1kyEeGeoaLUQk__nA_1825549627")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.RequestedCollectionDate"/>
    [IsoId("_tZ5oxFkyEeGeoaLUQk__nA_-931291456")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.RequestedExecutionDate"/>
    [IsoId("_taDZwFkyEeGeoaLUQk__nA_541954794")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.CreditorSchemeIdentification"/>
    [IsoId("_taDZwVkyEeGeoaLUQk__nA_-1139784664")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.SettlementInformation"/>
    [IsoId("_taDZwlkyEeGeoaLUQk__nA_-1021913679")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction1? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.PaymentTypeInformation"/>
    [IsoId("_taDZw1kyEeGeoaLUQk__nA_-2060622407")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.PaymentMethod"/>
    [IsoId("_taDZxFkyEeGeoaLUQk__nA_209190163")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.MandateRelatedInformation"/>
    [IsoId("_taMjsFkyEeGeoaLUQk__nA_503179451")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation9? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.RemittanceInformation"/>
    [IsoId("_taMjsVkyEeGeoaLUQk__nA_759725101")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.UltimateDebtor"/>
    [IsoId("_taMjslkyEeGeoaLUQk__nA_508697755")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.Debtor"/>
    [IsoId("_taMjs1kyEeGeoaLUQk__nA_-682305422")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.DebtorAccount"/>
    [IsoId("_taMjtFkyEeGeoaLUQk__nA_-807243265")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.DebtorAgent"/>
    [IsoId("_taWUsFkyEeGeoaLUQk__nA_114920045")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.CreditorAgent"/>
    [IsoId("_taWUsVkyEeGeoaLUQk__nA_-1951725003")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.Creditor"/>
    [IsoId("_taWUslkyEeGeoaLUQk__nA_333285435")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.CreditorAccount"/>
    [IsoId("_taWUs1kyEeGeoaLUQk__nA_776273927")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference17.UltimateCreditor"/>
    [IsoId("_taWUtFkyEeGeoaLUQk__nA_1250851596")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
