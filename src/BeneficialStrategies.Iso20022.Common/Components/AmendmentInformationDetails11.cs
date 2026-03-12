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
[IsoId("_sm5qyWk2Eeanu6HLe77Rkg")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails11
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_svFWUWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_svFWU2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_svFWVWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    
    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWV2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_svFWWWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; } 
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_svFWW2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_svFWXWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_svFWX2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_svFWYWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_svFWY2k2Eeanu6HLe77Rkg")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency36Choice_? OriginalFrequency { get; init; } 
    
    /// <summary>
    /// Original reason for the mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_svFWZWk2Eeanu6HLe77Rkg")]
    [DisplayName("Original Reason")]
    [IsoXmlTag("OrgnlRsn")]
    public MandateSetupReason1Choice_? OriginalReason { get; init; } 
    
    /// <summary>
    /// Original number of tracking days that has been modified.
    /// </summary>
    [IsoId("_oldnwWn1EearR-CA7eRZXQ")]
    [DisplayName("Original Tracking Days")]
    [IsoXmlTag("OrgnlTrckgDays")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? OriginalTrackingDays { get; init; } 
    
    
    #nullable disable
    
}
