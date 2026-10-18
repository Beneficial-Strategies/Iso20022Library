// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference13"/>
[IsoId("_P1c64Np-Ed-ak6NoX_4Aeg_440658084")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference13
{
    /// <inheritdoc cref="IOriginalTransactionReference13.InterbankSettlementAmount"/>
    [IsoId("_P1c64dp-Ed-ak6NoX_4Aeg_440658115")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.Amount"/>
    [IsoId("_P1c64tp-Ed-ak6NoX_4Aeg_440659472")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType3Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.InterbankSettlementDate"/>
    [IsoId("_P1c649p-Ed-ak6NoX_4Aeg_440658145")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.RequestedCollectionDate"/>
    [IsoId("_P1c65Np-Ed-ak6NoX_4Aeg_440658207")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.RequestedExecutionDate"/>
    [IsoId("_P1c65dp-Ed-ak6NoX_4Aeg_440658485")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.CreditorSchemeIdentification"/>
    [IsoId("_P1c65tp-Ed-ak6NoX_4Aeg_440659071")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.SettlementInformation"/>
    [IsoId("_P1c659p-Ed-ak6NoX_4Aeg_440659441")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInformation13? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.PaymentTypeInformation"/>
    [IsoId("_P1c66Np-Ed-ak6NoX_4Aeg_441579681")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.PaymentMethod"/>
    [IsoId("_P1mr4Np-Ed-ak6NoX_4Aeg_440658516")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.MandateRelatedInformation"/>
    [IsoId("_P1mr4dp-Ed-ak6NoX_4Aeg_440659163")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation6? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.RemittanceInformation"/>
    [IsoId("_P1mr4tp-Ed-ak6NoX_4Aeg_440659132")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.UltimateDebtor"/>
    [IsoId("_P1mr49p-Ed-ak6NoX_4Aeg_440658918")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.Debtor"/>
    [IsoId("_P1mr5Np-Ed-ak6NoX_4Aeg_440658978")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification32? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.DebtorAccount"/>
    [IsoId("_P1mr5dp-Ed-ak6NoX_4Aeg_440659533")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.DebtorAgent"/>
    [IsoId("_P1mr5tp-Ed-ak6NoX_4Aeg_-1180106960")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.DebtorAgentAccount"/>
    [IsoId("_P1mr59p-Ed-ak6NoX_4Aeg_441579619")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.CreditorAgent"/>
    [IsoId("_P1mr6Np-Ed-ak6NoX_4Aeg_-1180106951")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.CreditorAgentAccount"/>
    [IsoId("_P1mr6dp-Ed-ak6NoX_4Aeg_441579589")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.Creditor"/>
    [IsoId("_P1wc4Np-Ed-ak6NoX_4Aeg_440659040")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification32? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.CreditorAccount"/>
    [IsoId("_P1wc4dp-Ed-ak6NoX_4Aeg_441579527")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference13.UltimateCreditor"/>
    [IsoId("_P1wc4tp-Ed-ak6NoX_4Aeg_440659010")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }
}
