// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate3"/>
[IsoId("_tzras1kyEeGeoaLUQk__nA_1855464724")]
[DisplayName("Mandate")]
public partial record Mandate3
{
    /// <inheritdoc cref="IMandate3.MandateIdentification"/>
    [IsoId("_tzratFkyEeGeoaLUQk__nA_110826690")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate3.MandateRequestIdentification"/>
    [IsoId("_tzratVkyEeGeoaLUQk__nA_-1199352703")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate3.Type"/>
    [IsoId("_tz1LsFkyEeGeoaLUQk__nA_2060556197")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandate3.Occurrences"/>
    [IsoId("_tz1LsVkyEeGeoaLUQk__nA_1305806323")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences2? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate3.CollectionAmount"/>
    [IsoId("_tz1LslkyEeGeoaLUQk__nA_-14233788")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate3.MaximumAmount"/>
    [IsoId("_tz1Ls1kyEeGeoaLUQk__nA_1883438696")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate3.CreditorSchemeIdentification"/>
    [IsoId("_tz1LtFkyEeGeoaLUQk__nA_1580382181")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate3.Creditor"/>
    [IsoId("_tz-8sFkyEeGeoaLUQk__nA_1962837289")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IMandate3.CreditorAccount"/>
    [IsoId("_tz-8sVkyEeGeoaLUQk__nA_-1878042738")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate3.CreditorAgent"/>
    [IsoId("_tz-8slkyEeGeoaLUQk__nA_-1552925231")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate3.UltimateCreditor"/>
    [IsoId("_tz-8s1kyEeGeoaLUQk__nA_191926028")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate3.Debtor"/>
    [IsoId("_tz-8tFkyEeGeoaLUQk__nA_44123102")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IMandate3.DebtorAccount"/>
    [IsoId("_t0IGoFkyEeGeoaLUQk__nA_1401934058")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate3.DebtorAgent"/>
    [IsoId("_t0IGoVkyEeGeoaLUQk__nA_-748612815")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate3.UltimateDebtor"/>
    [IsoId("_t0IGolkyEeGeoaLUQk__nA_12152338")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate3.ReferredDocument"/>
    [IsoId("_t0IGo1kyEeGeoaLUQk__nA_-1480815348")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }
}
