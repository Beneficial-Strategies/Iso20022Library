// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails12"/>
[IsoId("_nuAWu7TREeeyuKckOGlwuA")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails12
{
    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalMandateIdentification"/>
    [IsoId("_n2tmsbTREeeyuKckOGlwuA")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalCreditorSchemeIdentification"/>
    [IsoId("_n2tms7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification125? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalCreditorAgent"/>
    [IsoId("_n2tmtbTREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalCreditorAgentAccount"/>
    [IsoId("_n2tmt7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalDebtor"/>
    [IsoId("_n2tmubTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification125? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalDebtorAccount"/>
    [IsoId("_n2tmu7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalDebtorAgent"/>
    [IsoId("_n2tmvbTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalDebtorAgentAccount"/>
    [IsoId("_n2tmv7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalFinalCollectionDate"/>
    [IsoId("_n2tmwbTREeeyuKckOGlwuA")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalFrequency"/>
    [IsoId("_n2tmw7TREeeyuKckOGlwuA")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalReason"/>
    [IsoId("_n2tmxbTREeeyuKckOGlwuA")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails12.OriginalTrackingDays"/>
    [IsoId("_n2tmx7TREeeyuKckOGlwuA")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
