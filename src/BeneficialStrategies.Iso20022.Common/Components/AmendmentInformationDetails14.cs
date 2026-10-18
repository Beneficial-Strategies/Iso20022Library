// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails14"/>
[IsoId("_a5rpG9cZEeqRFcf2R4bPBw")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails14
{
    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalMandateIdentification"/>
    [IsoId("_a7EwMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalCreditorSchemeIdentification"/>
    [IsoId("_a7EwM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification135? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalCreditorAgent"/>
    [IsoId("_a7EwNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalCreditorAgentAccount"/>
    [IsoId("_a7EwN9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount40? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalDebtor"/>
    [IsoId("_a7EwOdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification135? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalDebtorAccount"/>
    [IsoId("_a7EwO9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount40? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalDebtorAgent"/>
    [IsoId("_a7EwPdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalDebtorAgentAccount"/>
    [IsoId("_a7EwP9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount40? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalFinalCollectionDate"/>
    [IsoId("_a7EwQdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalFrequency"/>
    [IsoId("_a7EwQ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalReason"/>
    [IsoId("_a7EwRdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails14.OriginalTrackingDays"/>
    [IsoId("_a7EwR9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
