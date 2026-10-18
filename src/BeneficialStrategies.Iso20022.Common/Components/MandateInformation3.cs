// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateInformation3"/>
[IsoId("_T3P8a9p-Ed-ak6NoX_4Aeg_1018029248")]
[DisplayName("Mandate Information")]
public partial record MandateInformation3
{
    /// <inheritdoc cref="IMandateInformation3.MandateIdentification"/>
    [IsoId("_T3P8bNp-Ed-ak6NoX_4Aeg_1018029309")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation3.MandateRequestIdentification"/>
    [IsoId("_T3P8bdp-Ed-ak6NoX_4Aeg_1018029278")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation3.Type"/>
    [IsoId("_T3ZGUNp-Ed-ak6NoX_4Aeg_1018030197")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandateInformation3.Occurrences"/>
    [IsoId("_T3ZGUdp-Ed-ak6NoX_4Aeg_1018030166")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences1? Occurrences { get; init; }

    /// <inheritdoc cref="IMandateInformation3.CollectionAmount"/>
    [IsoId("_T3ZGUtp-Ed-ak6NoX_4Aeg_1018029340")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandateInformation3.MaximumAmount"/>
    [IsoId("_T3ZGU9p-Ed-ak6NoX_4Aeg_1018029363")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandateInformation3.CreditorSchemeIdentification"/>
    [IsoId("_T3ZGVNp-Ed-ak6NoX_4Aeg_1018030320")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation3.Creditor"/>
    [IsoId("_T3ZGVdp-Ed-ak6NoX_4Aeg_1018029673")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification32? Creditor { get; init; }

    /// <inheritdoc cref="IMandateInformation3.CreditorAccount"/>
    [IsoId("_T3ZGVtp-Ed-ak6NoX_4Aeg_1018029402")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandateInformation3.CreditorAgent"/>
    [IsoId("_T3ZGV9p-Ed-ak6NoX_4Aeg_1018030105")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandateInformation3.UltimateCreditor"/>
    [IsoId("_T3ZGWNp-Ed-ak6NoX_4Aeg_1018029734")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandateInformation3.Debtor"/>
    [IsoId("_T3ZGWdp-Ed-ak6NoX_4Aeg_1018029765")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification32? Debtor { get; init; }

    /// <inheritdoc cref="IMandateInformation3.DebtorAccount"/>
    [IsoId("_T3i3UNp-Ed-ak6NoX_4Aeg_1018029425")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandateInformation3.DebtorAgent"/>
    [IsoId("_T3i3Udp-Ed-ak6NoX_4Aeg_1018030135")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandateInformation3.UltimateDebtor"/>
    [IsoId("_T3i3Utp-Ed-ak6NoX_4Aeg_1018029796")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandateInformation3.ReferredDocument"/>
    [IsoId("_T3i3U9p-Ed-ak6NoX_4Aeg_1018030258")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }
}
