// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment information details providing the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_TD_Td9p-Ed-ak6NoX_4Aeg_-361247398")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails1
{
    #nullable enable
    
    /// <summary>
    /// Original mandate identification that has been modified.
    /// </summary>
    [IsoId("_TD_TeNp-Ed-ak6NoX_4Aeg_-361245426")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_TD_Tedp-Ed-ak6NoX_4Aeg_-359400006")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification8? OriginalCreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_TD_Tetp-Ed-ak6NoX_4Aeg_-349242133")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? OriginalCreditorAgent { get; init; } 
    
    /// <summary>
    /// Original creditor agent acount that has been modified.
    /// </summary>
    [IsoId("_TD_Te9p-Ed-ak6NoX_4Aeg_-1544541657")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount7? OriginalCreditorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_TD_TfNp-Ed-ak6NoX_4Aeg_-358475824")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification8? OriginalDebtor { get; init; } 
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_TD_Tfdp-Ed-ak6NoX_4Aeg_-358477856")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount7? OriginalDebtorAccount { get; init; } 
    
    /// <summary>
    /// Original debtor&apos;s agent that has been modified.
    /// </summary>
    [IsoId("_TEIdYNp-Ed-ak6NoX_4Aeg_-357551638")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? OriginalDebtorAgent { get; init; } 
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_TEIdYdp-Ed-ak6NoX_4Aeg_485623160")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount7? OriginalDebtorAgentAccount { get; init; } 
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_TEIdYtp-Ed-ak6NoX_4Aeg_-359401499")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_TEIdY9p-Ed-ak6NoX_4Aeg_-359401284")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency1Code? OriginalFrequency { get; init; } 
    
    
    #nullable disable
    
}
