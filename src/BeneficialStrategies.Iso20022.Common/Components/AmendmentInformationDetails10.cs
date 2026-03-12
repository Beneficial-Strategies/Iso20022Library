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
[IsoId("__XwI8R72EeSxevWRRWxNAg")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails10
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("__pZSkR72EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("__pZSkx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("__pZSlR72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    
    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("__pZSlx72EeSxevWRRWxNAg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("__pZSmR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; } 
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("__pZSmx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("__pZSnR72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("__pZSnx72EeSxevWRRWxNAg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("__pZSoR72EeSxevWRRWxNAg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("__pZSox72EeSxevWRRWxNAg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency21Choice_? OriginalFrequency { get; init; } 
    
    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_JYz-Mh73EeSxevWRRWxNAg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 
    
    
    #nullable disable
    
}
