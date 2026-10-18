// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_a5rpG9cZEeqRFcf2R4bPBw")]
public interface IAmendmentInformationDetails14 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_a7EwMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_a7EwM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification135? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_a7EwNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_a7EwN9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount40? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_a7EwOdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification135? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_a7EwO9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount40? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_a7EwPdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_a7EwP9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount40? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_a7EwQdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_a7EwQ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    IFrequency36Choice? OriginalFrequency { get; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_a7EwRdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    IMandateSetupReason1Choice? OriginalReason { get; }

    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_a7EwR9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    Exact2NumericText? OriginalTrackingDays { get; }
}
