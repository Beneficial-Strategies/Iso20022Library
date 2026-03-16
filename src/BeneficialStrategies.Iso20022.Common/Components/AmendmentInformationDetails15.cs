// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment Information Details15.
/// </summary>
[IsoId("_wL-4oTEyEe6g-ffJsqGiSA")]
[DisplayName("Amendment Information Details15")]
public partial record AmendmentInformationDetails15
{
    #nullable enable

    /// <summary>
    /// Original Creditor Agent.
    /// </summary>
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalCreditorAgent { get; init; } 

    /// <summary>
    /// Original Creditor Agent Account.
    /// </summary>
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount40? OriginalCreditorAgentAccount { get; init; } 

    /// <summary>
    /// Original Creditor Scheme Identification.
    /// </summary>
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification272? OriginalCreditorSchemeIdentification { get; init; } 

    /// <summary>
    /// Original Debtor.
    /// </summary>
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification272? OriginalDebtor { get; init; } 

    /// <summary>
    /// Original Debtor Account.
    /// </summary>
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount40? OriginalDebtorAccount { get; init; } 

    /// <summary>
    /// Original Debtor Agent.
    /// </summary>
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? OriginalDebtorAgent { get; init; } 

    /// <summary>
    /// Original Debtor Agent Account.
    /// </summary>
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount40? OriginalDebtorAgentAccount { get; init; } 

    /// <summary>
    /// Original Final Collection Date.
    /// </summary>
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 

    /// <summary>
    /// Original Frequency.
    /// </summary>
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; } 

    /// <summary>
    /// Original Mandate Identification.
    /// </summary>
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 

    /// <summary>
    /// Original Reason.
    /// </summary>
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 

    /// <summary>
    /// Original Tracking Days.
    /// </summary>
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; } 

    
    #nullable disable
    
}
