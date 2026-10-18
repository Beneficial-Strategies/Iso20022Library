// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference15"/>
[IsoId("_UQuMVdp-Ed-ak6NoX_4Aeg_-471281227")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference15
{
    /// <inheritdoc cref="IOriginalTransactionReference15.InterbankSettlementAmount"/>
    [IsoId("_UQuMVtp-Ed-ak6NoX_4Aeg_1521771473")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.Amount"/>
    [IsoId("_UQuMV9p-Ed-ak6NoX_4Aeg_4278386")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType3Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.InterbankSettlementDate"/>
    [IsoId("_UQuMWNp-Ed-ak6NoX_4Aeg_-890053678")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.RequestedCollectionDate"/>
    [IsoId("_UQuMWdp-Ed-ak6NoX_4Aeg_302118168")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.RequestedExecutionDate"/>
    [IsoId("_UQ39UNp-Ed-ak6NoX_4Aeg_1081322944")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.CreditorSchemeIdentification"/>
    [IsoId("_UQ39Udp-Ed-ak6NoX_4Aeg_-115483396")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.SettlementInformation"/>
    [IsoId("_UQ39Utp-Ed-ak6NoX_4Aeg_-1925706267")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInformation16? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.PaymentTypeInformation"/>
    [IsoId("_UQ39U9p-Ed-ak6NoX_4Aeg_-250640126")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.PaymentMethod"/>
    [IsoId("_UQ39VNp-Ed-ak6NoX_4Aeg_-643349493")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.MandateRelatedInformation"/>
    [IsoId("_UQ39Vdp-Ed-ak6NoX_4Aeg_295534332")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation7? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.RemittanceInformation"/>
    [IsoId("_UQ39Vtp-Ed-ak6NoX_4Aeg_1819779617")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.UltimateDebtor"/>
    [IsoId("_UQ39V9p-Ed-ak6NoX_4Aeg_-1714422526")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.Debtor"/>
    [IsoId("_UQ39WNp-Ed-ak6NoX_4Aeg_-1725521303")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.DebtorAccount"/>
    [IsoId("_UQ39Wdp-Ed-ak6NoX_4Aeg_-1849579256")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.DebtorAgent"/>
    [IsoId("_URBuUNp-Ed-ak6NoX_4Aeg_937735335")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.CreditorAgent"/>
    [IsoId("_URBuUdp-Ed-ak6NoX_4Aeg_-1426510634")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.Creditor"/>
    [IsoId("_URBuUtp-Ed-ak6NoX_4Aeg_-983522142")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.CreditorAccount"/>
    [IsoId("_URBuU9p-Ed-ak6NoX_4Aeg_-333868284")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference15.UltimateCreditor"/>
    [IsoId("_URBuVNp-Ed-ak6NoX_4Aeg_313057803")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
