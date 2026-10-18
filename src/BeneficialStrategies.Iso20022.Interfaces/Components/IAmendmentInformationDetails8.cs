// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_teX5FFkyEeGeoaLUQk__nA_528536611")]
public interface IAmendmentInformationDetails8 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_tehqEFkyEeGeoaLUQk__nA_670667391")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_tehqEVkyEeGeoaLUQk__nA_1004495065")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification43? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_tehqElkyEeGeoaLUQk__nA_-488026944")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_tehqE1kyEeGeoaLUQk__nA_-499125721")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount24? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_tehqFFkyEeGeoaLUQk__nA_-174008214")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification43? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_teq0AFkyEeGeoaLUQk__nA_1785884717")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount24? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_teq0AVkyEeGeoaLUQk__nA_2024930314")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_teq0AlkyEeGeoaLUQk__nA_2013831537")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount24? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_teq0A1kyEeGeoaLUQk__nA_-2076799323")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_teq0BFkyEeGeoaLUQk__nA_-1622712054")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    Frequency6Code? OriginalFrequency { get; }
}
