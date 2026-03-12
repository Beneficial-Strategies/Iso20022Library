// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_nuAWu7TREeeyuKckOGlwuA")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails12
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_n2tmsbTREeeyuKckOGlwuA")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_n2tms7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification125? OriginalCreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_n2tmtbTREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    
    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_n2tmt7TREeeyuKckOGlwuA")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_n2tmubTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification125? OriginalDebtor { get; init; } 
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_n2tmu7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_n2tmvbTREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_n2tmv7TREeeyuKckOGlwuA")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_n2tmwbTREeeyuKckOGlwuA")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_n2tmw7TREeeyuKckOGlwuA")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; } 
    
    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_n2tmxbTREeeyuKckOGlwuA")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 
    
    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_n2tmx7TREeeyuKckOGlwuA")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; } 
    
    
    #nullable disable
    
}
