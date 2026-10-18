// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_sm5qyWk2Eeanu6HLe77Rkg")]
public interface IAmendmentInformationDetails11 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_svFWUWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_svFWU2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification43? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_svFWVWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWV2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount24? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_svFWWWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification43? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_svFWW2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount24? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_svFWXWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWX2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount24? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_svFWYWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_svFWY2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    IFrequency36Choice? OriginalFrequency { get; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_svFWZWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    IMandateSetupReason1Choice? OriginalReason { get; }

    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_oldnwWn1EearR-CA7eRZXQ")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    Exact2NumericText? OriginalTrackingDays { get; }
}
