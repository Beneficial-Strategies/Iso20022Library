// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_nuAWu7TREeeyuKckOGlwuA")]
public interface IAmendmentInformationDetails12 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_n2tmsbTREeeyuKckOGlwuA")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    Max35Text? OriginalMandateIdentification { get; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_n2tms7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    IPartyIdentification125? OriginalCreditorSchemeIdentification { get; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_n2tmtbTREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_n2tmt7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    ICashAccount24? OriginalCreditorAgentAccount { get; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_n2tmubTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    IPartyIdentification125? OriginalDebtor { get; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_n2tmu7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    ICashAccount24? OriginalDebtorAccount { get; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_n2tmvbTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    IBranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_n2tmv7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    ICashAccount24? OriginalDebtorAgentAccount { get; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_n2tmwbTREeeyuKckOGlwuA")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    ISODate? OriginalFinalCollectionDate { get; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_n2tmw7TREeeyuKckOGlwuA")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    IFrequency36Choice? OriginalFrequency { get; }

    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_n2tmxbTREeeyuKckOGlwuA")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    IMandateSetupReason1Choice? OriginalReason { get; }

    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_n2tmx7TREeeyuKckOGlwuA")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    Exact2NumericText? OriginalTrackingDays { get; }
}
