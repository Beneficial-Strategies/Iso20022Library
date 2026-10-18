// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_TEbYU9p-Ed-ak6NoX_4Aeg_1795520331")]
public interface IAmendmentInformationDetails6 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_TEbYVNp-Ed-ak6NoX_4Aeg_1795520362")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_TEbYVdp-Ed-ak6NoX_4Aeg_1795520733")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification32? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_TEbYVtp-Ed-ak6NoX_4Aeg_1795521115")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification4? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent acount that has been modified.
    /// </summary>
    [IsoId("_TEbYV9p-Ed-ak6NoX_4Aeg_1795521226")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount16? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_TEbYWNp-Ed-ak6NoX_4Aeg_1795521042")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification32? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_TEbYWdp-Ed-ak6NoX_4Aeg_1795521196")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount16? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_TEbYWtp-Ed-ak6NoX_4Aeg_1795521134")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification4? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_TEbYW9p-Ed-ak6NoX_4Aeg_1795521257")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount16? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_TElJUNp-Ed-ak6NoX_4Aeg_1795520610")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_TElJUdp-Ed-ak6NoX_4Aeg_1795520671")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    Frequency1Code? OriginalFrequency { get; }
}
