// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails15"/>
[IsoId("_wL-4oTEyEe6g-ffJsqGiSA")]
[Description(
    @"Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set."
)]
[DisplayName("Amendment Information Details15")]
public partial record AmendmentInformationDetails15
{
    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalCreditorAgent"/>
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalCreditorAgentAccount"/>
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount40? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalCreditorSchemeIdentification"/>
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification272? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalDebtor"/>
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification272? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalDebtorAccount"/>
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount40? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalDebtorAgent"/>
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalDebtorAgentAccount"/>
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount40? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalFinalCollectionDate"/>
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalFrequency"/>
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalMandateIdentification"/>
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalReason"/>
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails15.OriginalTrackingDays"/>
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
