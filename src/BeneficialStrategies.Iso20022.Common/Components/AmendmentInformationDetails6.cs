// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails6"/>
[IsoId("_TEbYU9p-Ed-ak6NoX_4Aeg_1795520331")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails6
{
    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalMandateIdentification"/>
    [IsoId("_TEbYVNp-Ed-ak6NoX_4Aeg_1795520362")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalCreditorSchemeIdentification"/>
    [IsoId("_TEbYVdp-Ed-ak6NoX_4Aeg_1795520733")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification32? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalCreditorAgent"/>
    [IsoId("_TEbYVtp-Ed-ak6NoX_4Aeg_1795521115")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalCreditorAgentAccount"/>
    [IsoId("_TEbYV9p-Ed-ak6NoX_4Aeg_1795521226")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount16? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalDebtor"/>
    [IsoId("_TEbYWNp-Ed-ak6NoX_4Aeg_1795521042")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification32? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalDebtorAccount"/>
    [IsoId("_TEbYWdp-Ed-ak6NoX_4Aeg_1795521196")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount16? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalDebtorAgent"/>
    [IsoId("_TEbYWtp-Ed-ak6NoX_4Aeg_1795521134")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalDebtorAgentAccount"/>
    [IsoId("_TEbYW9p-Ed-ak6NoX_4Aeg_1795521257")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount16? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalFinalCollectionDate"/>
    [IsoId("_TElJUNp-Ed-ak6NoX_4Aeg_1795520610")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails6.OriginalFrequency"/>
    [IsoId("_TElJUdp-Ed-ak6NoX_4Aeg_1795520671")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency1Code? OriginalFrequency { get; init; }
}
