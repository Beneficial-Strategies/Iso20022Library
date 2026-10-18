// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails13"/>
[IsoId("_Acqr2249EeiU9cctagi5ow")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails13
{
    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalMandateIdentification"/>
    [IsoId("_AlwWUW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalCreditorSchemeIdentification"/>
    [IsoId("_AlwWU249EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification135? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalCreditorAgent"/>
    [IsoId("_AlwWVW49EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalCreditorAgentAccount"/>
    [IsoId("_AlwWV249EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount38? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalDebtor"/>
    [IsoId("_AlwWWW49EeiU9cctagi5ow")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification135? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalDebtorAccount"/>
    [IsoId("_AlwWW249EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount38? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalDebtorAgent"/>
    [IsoId("_AlwWXW49EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalDebtorAgentAccount"/>
    [IsoId("_AlwWX249EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount38? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalFinalCollectionDate"/>
    [IsoId("_AlwWYW49EeiU9cctagi5ow")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalFrequency"/>
    [IsoId("_AlwWY249EeiU9cctagi5ow")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalReason"/>
    [IsoId("_AlwWZW49EeiU9cctagi5ow")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails13.OriginalTrackingDays"/>
    [IsoId("_AlwWZ249EeiU9cctagi5ow")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
