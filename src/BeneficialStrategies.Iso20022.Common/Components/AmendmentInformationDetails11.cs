// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmendmentInformationDetails11"/>
[IsoId("_sm5qyWk2Eeanu6HLe77Rkg")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails11
{
    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalMandateIdentification"/>
    [IsoId("_svFWUWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalCreditorSchemeIdentification"/>
    [IsoId("_svFWU2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalCreditorAgent"/>
    [IsoId("_svFWVWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalCreditorAgentAccount"/>
    [IsoId("_svFWV2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalDebtor"/>
    [IsoId("_svFWWWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalDebtorAccount"/>
    [IsoId("_svFWW2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalDebtorAgent"/>
    [IsoId("_svFWXWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalDebtorAgentAccount"/>
    [IsoId("_svFWX2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalFinalCollectionDate"/>
    [IsoId("_svFWYWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalFrequency"/>
    [IsoId("_svFWY2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalReason"/>
    [IsoId("_svFWZWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <inheritdoc cref="IAmendmentInformationDetails11.OriginalTrackingDays"/>
    [IsoId("_oldnwWn1EearR-CA7eRZXQ")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
