// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails9"/>
[IsoId("_te0lAFkyEeGeoaLUQk__nA_-1080741410")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails9
{
    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalMandateIdentification"/>
    [IsoId("_te0lAVkyEeGeoaLUQk__nA_-786752122")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalCreditorSchemeIdentification"/>
    [IsoId("_te0lAlkyEeGeoaLUQk__nA_-1987316393")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalCreditorAgent"/>
    [IsoId("_te0lA1kyEeGeoaLUQk__nA_-1998415170")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalDebtor"/>
    [IsoId("_te9u8FkyEeGeoaLUQk__nA_-584178548")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalDebtorAccount"/>
    [IsoId("_te9u8VkyEeGeoaLUQk__nA_-552379473")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalDebtorAgent"/>
    [IsoId("_te9u8lkyEeGeoaLUQk__nA_-1694300912")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalFinalCollectionDate"/>
    [IsoId("_te9u81kyEeGeoaLUQk__nA_-197353443")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails9.OriginalFrequency"/>
    [IsoId("_te9u9FkyEeGeoaLUQk__nA_-1269358502")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency6Code? OriginalFrequency { get; init; }
}
