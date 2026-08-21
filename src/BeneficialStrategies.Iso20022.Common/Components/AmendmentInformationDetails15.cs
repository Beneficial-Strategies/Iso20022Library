// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_wL-4oTEyEe6g-ffJsqGiSA")]
[Description(
    @"Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set."
)]
[DisplayName("Amendment Information Details15")]
public record AmendmentInformationDetails15
{
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalCreditorAgent { get; init; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount40? OriginalCreditorAgentAccount { get; init; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification272? OriginalCreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification272? OriginalDebtor { get; init; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount40? OriginalDebtorAccount { get; init; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalDebtorAgent { get; init; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount40? OriginalDebtorAgentAccount { get; init; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; }

    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; }
}
