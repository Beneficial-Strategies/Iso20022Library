// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("__XwI8R72EeSxevWRRWxNAg")]
public interface IAmendmentInformationDetails10 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("__pZSkR72EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("__pZSkx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification43? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("__pZSlR72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("__pZSlx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount24? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("__pZSmR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification43? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("__pZSmx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount24? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("__pZSnR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("__pZSnx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount24? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("__pZSoR72EeSxevWRRWxNAg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("__pZSox72EeSxevWRRWxNAg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    IFrequency21Choice? OriginalFrequency { get; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_JYz-Mh73EeSxevWRRWxNAg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    IMandateSetupReason1Choice? OriginalReason { get; }
}
