// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails1"/>
[IsoId("_TD_Td9p-Ed-ak6NoX_4Aeg_-361247398")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails1
{
    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalMandateIdentification"/>
    [IsoId("_TD_TeNp-Ed-ak6NoX_4Aeg_-361245426")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalCreditorSchemeIdentification"/>
    [IsoId("_TD_Tedp-Ed-ak6NoX_4Aeg_-359400006")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification8? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalCreditorAgent"/>
    [IsoId("_TD_Tetp-Ed-ak6NoX_4Aeg_-349242133")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalCreditorAgentAccount"/>
    [IsoId("_TD_Te9p-Ed-ak6NoX_4Aeg_-1544541657")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount7? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalDebtor"/>
    [IsoId("_TD_TfNp-Ed-ak6NoX_4Aeg_-358475824")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification8? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalDebtorAccount"/>
    [IsoId("_TD_Tfdp-Ed-ak6NoX_4Aeg_-358477856")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount7? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalDebtorAgent"/>
    [IsoId("_TEIdYNp-Ed-ak6NoX_4Aeg_-357551638")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalDebtorAgentAccount"/>
    [IsoId("_TEIdYdp-Ed-ak6NoX_4Aeg_485623160")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount7? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalFinalCollectionDate"/>
    [IsoId("_TEIdYtp-Ed-ak6NoX_4Aeg_-359401499")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails1.OriginalFrequency"/>
    [IsoId("_TEIdY9p-Ed-ak6NoX_4Aeg_-359401284")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency1Code? OriginalFrequency { get; init; }
}
