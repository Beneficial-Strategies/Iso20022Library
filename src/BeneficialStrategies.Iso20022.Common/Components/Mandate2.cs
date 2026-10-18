// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate2"/>
[IsoId("_tzFk1FkyEeGeoaLUQk__nA_-1336724626")]
[DisplayName("Mandate")]
public partial record Mandate2
{
    /// <inheritdoc cref="IMandate2.MandateIdentification"/>
    [IsoId("_tzFk1VkyEeGeoaLUQk__nA_-422390729")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate2.MandateRequestIdentification"/>
    [IsoId("_tzFk1lkyEeGeoaLUQk__nA_-1653312282")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate2.Type"/>
    [IsoId("_tzPV0FkyEeGeoaLUQk__nA_1762453646")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandate2.Occurrences"/>
    [IsoId("_tzPV0VkyEeGeoaLUQk__nA_1887837166")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences2? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate2.CollectionAmount"/>
    [IsoId("_tzPV0lkyEeGeoaLUQk__nA_-1534115730")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate2.MaximumAmount"/>
    [IsoId("_tzPV01kyEeGeoaLUQk__nA_916982577")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate2.CreditorSchemeIdentification"/>
    [IsoId("_tzPV1FkyEeGeoaLUQk__nA_680675377")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate2.Creditor"/>
    [IsoId("_tzYfwFkyEeGeoaLUQk__nA_362898716")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IMandate2.CreditorAccount"/>
    [IsoId("_tzYfwVkyEeGeoaLUQk__nA_299996813")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate2.CreditorAgent"/>
    [IsoId("_tzYfwlkyEeGeoaLUQk__nA_288898036")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate2.UltimateCreditor"/>
    [IsoId("_tzYfw1kyEeGeoaLUQk__nA_1211061346")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate2.Debtor"/>
    [IsoId("_tzYfxFkyEeGeoaLUQk__nA_1031028459")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IMandate2.DebtorAccount"/>
    [IsoId("_tziQwFkyEeGeoaLUQk__nA_180954941")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate2.DebtorAgent"/>
    [IsoId("_tziQwVkyEeGeoaLUQk__nA_1258975279")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate2.UltimateDebtor"/>
    [IsoId("_tziQwlkyEeGeoaLUQk__nA_424209446")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate2.ReferredDocument"/>
    [IsoId("_tziQw1kyEeGeoaLUQk__nA_878296715")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }
}
