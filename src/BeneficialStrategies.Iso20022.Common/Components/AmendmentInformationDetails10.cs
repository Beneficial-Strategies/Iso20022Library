// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails10"/>
[IsoId("__XwI8R72EeSxevWRRWxNAg")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails10
{
    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalMandateIdentification"/>
    [IsoId("__pZSkR72EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalCreditorSchemeIdentification"/>
    [IsoId("__pZSkx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalCreditorAgent"/>
    [IsoId("__pZSlR72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalCreditorAgentAccount"/>
    [IsoId("__pZSlx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalDebtor"/>
    [IsoId("__pZSmR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalDebtorAccount"/>
    [IsoId("__pZSmx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalDebtorAgent"/>
    [IsoId("__pZSnR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalDebtorAgentAccount"/>
    [IsoId("__pZSnx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalFinalCollectionDate"/>
    [IsoId("__pZSoR72EeSxevWRRWxNAg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalFrequency"/>
    [IsoId("__pZSox72EeSxevWRRWxNAg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency21Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails10.OriginalReason"/>
    [IsoId("_JYz-Mh73EeSxevWRRWxNAg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }
}
