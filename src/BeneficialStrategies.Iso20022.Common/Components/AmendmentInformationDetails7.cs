// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_TDrxctp-Ed-ak6NoX_4Aeg_2077407286")]
[DisplayName("Amendment Information Details")]
public partial record AmendmentInformationDetails7
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_TDrxc9p-Ed-ak6NoX_4Aeg_-1141104100")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_TDrxdNp-Ed-ak6NoX_4Aeg_-1266041943")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_TDrxddp-Ed-ak6NoX_4Aeg_-214908871")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_TDrxdtp-Ed-ak6NoX_4Aeg_1821763564")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; } 
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_TDrxd9p-Ed-ak6NoX_4Aeg_-2019116463")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount16? OriginalDebtorAccount { get; init; } 
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_TDrxeNp-Ed-ak6NoX_4Aeg_-188193294")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_TDrxedp-Ed-ak6NoX_4Aeg_-2120936435")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_TD1icNp-Ed-ak6NoX_4Aeg_459131634")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency1Code? OriginalFrequency { get; init; } 
    
    
    #nullable disable
    
}
