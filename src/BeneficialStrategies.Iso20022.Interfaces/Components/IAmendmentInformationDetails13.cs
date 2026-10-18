// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_Acqr2249EeiU9cctagi5ow")]
public interface IAmendmentInformationDetails13 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_AlwWUW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_AlwWU249EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification135? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_AlwWVW49EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_AlwWV249EeiU9cctagi5ow")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount38? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_AlwWWW49EeiU9cctagi5ow")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification135? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_AlwWW249EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount38? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_AlwWXW49EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_AlwWX249EeiU9cctagi5ow")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount38? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_AlwWYW49EeiU9cctagi5ow")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_AlwWY249EeiU9cctagi5ow")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    IFrequency36Choice? OriginalFrequency { get; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_AlwWZW49EeiU9cctagi5ow")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    IMandateSetupReason1Choice? OriginalReason { get; }

    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_AlwWZ249EeiU9cctagi5ow")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    Exact2NumericText? OriginalTrackingDays { get; }
}
