// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateInformation2"/>
[IsoId("_T28aaNp-Ed-ak6NoX_4Aeg_-1312343153")]
[DisplayName("Mandate Information")]
public partial record MandateInformation2
{
    /// <inheritdoc cref="IMandateInformation2.MandateIdentification"/>
    [IsoId("_T28aadp-Ed-ak6NoX_4Aeg_-1312343061")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation2.MandateRequestIdentification"/>
    [IsoId("_T3GLYNp-Ed-ak6NoX_4Aeg_-1312343122")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation2.Type"/>
    [IsoId("_T3GLYdp-Ed-ak6NoX_4Aeg_-1312342136")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandateInformation2.Occurrences"/>
    [IsoId("_T3GLYtp-Ed-ak6NoX_4Aeg_-1312342166")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences1? Occurrences { get; init; }

    /// <inheritdoc cref="IMandateInformation2.CollectionAmount"/>
    [IsoId("_T3GLY9p-Ed-ak6NoX_4Aeg_-1312343060")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandateInformation2.MaximumAmount"/>
    [IsoId("_T3GLZNp-Ed-ak6NoX_4Aeg_-1312343031")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandateInformation2.CreditorSchemeIdentification"/>
    [IsoId("_T3GLZdp-Ed-ak6NoX_4Aeg_-1312342012")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandateInformation2.Creditor"/>
    [IsoId("_T3GLZtp-Ed-ak6NoX_4Aeg_-1312342690")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <inheritdoc cref="IMandateInformation2.CreditorAccount"/>
    [IsoId("_T3GLZ9p-Ed-ak6NoX_4Aeg_-1312342968")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandateInformation2.CreditorAgent"/>
    [IsoId("_T3GLaNp-Ed-ak6NoX_4Aeg_-1312342258")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandateInformation2.UltimateCreditor"/>
    [IsoId("_T3GLadp-Ed-ak6NoX_4Aeg_-1312342629")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandateInformation2.Debtor"/>
    [IsoId("_T3P8YNp-Ed-ak6NoX_4Aeg_-1312342598")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="IMandateInformation2.DebtorAccount"/>
    [IsoId("_T3P8Ydp-Ed-ak6NoX_4Aeg_-1312342938")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandateInformation2.DebtorAgent"/>
    [IsoId("_T3P8Ytp-Ed-ak6NoX_4Aeg_-1312342228")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandateInformation2.UltimateDebtor"/>
    [IsoId("_T3P8Y9p-Ed-ak6NoX_4Aeg_-1312342537")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandateInformation2.ReferredDocument"/>
    [IsoId("_T3P8ZNp-Ed-ak6NoX_4Aeg_-1312342074")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }
}
