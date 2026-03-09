// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_TEbYU9p-Ed-ak6NoX_4Aeg_1795520331")]
[DisplayName("Amendment Information Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentInformationDetails6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_TEbYVNp-Ed-ak6NoX_4Aeg_1795520362")]
    [DisplayName("Original Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndtId")]
    #endif
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMandateIdentification { get; init; } 
    #else
    public System.String? OriginalMandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_TEbYVdp-Ed-ak6NoX_4Aeg_1795520733")]
    [DisplayName("Original Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrSchmeId")]
    #endif
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? OriginalCreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? OriginalCreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification32? OriginalCreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_TEbYVtp-Ed-ak6NoX_4Aeg_1795521115")]
    [DisplayName("Original Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrAgt")]
    #endif
    [IsoXmlTag("OrgnlCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? OriginalCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? OriginalCreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? OriginalCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent acount that has been modified.
    /// </summary>
    [IsoId("_TEbYV9p-Ed-ak6NoX_4Aeg_1795521226")]
    [DisplayName("Original Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrAgtAcct")]
    #endif
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? OriginalCreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? OriginalCreditorAgentAccount { get; init; } 
    #else
    public CashAccount16? OriginalCreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_TEbYWNp-Ed-ak6NoX_4Aeg_1795521042")]
    [DisplayName("Original Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtr")]
    #endif
    [IsoXmlTag("OrgnlDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? OriginalDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? OriginalDebtor { get; init; } 
    #else
    public PartyIdentification32? OriginalDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_TEbYWdp-Ed-ak6NoX_4Aeg_1795521196")]
    [DisplayName("Original Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAcct")]
    #endif
    [IsoXmlTag("OrgnlDbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? OriginalDebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? OriginalDebtorAccount { get; init; } 
    #else
    public CashAccount16? OriginalDebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_TEbYWtp-Ed-ak6NoX_4Aeg_1795521134")]
    [DisplayName("Original Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAgt")]
    #endif
    [IsoXmlTag("OrgnlDbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? OriginalDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? OriginalDebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? OriginalDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_TEbYW9p-Ed-ak6NoX_4Aeg_1795521257")]
    [DisplayName("Original Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAgtAcct")]
    #endif
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? OriginalDebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? OriginalDebtorAgentAccount { get; init; } 
    #else
    public CashAccount16? OriginalDebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_TElJUNp-Ed-ak6NoX_4Aeg_1795520610")]
    [DisplayName("Original Final Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlFnlColltnDt")]
    #endif
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalFinalCollectionDate { get; init; } 
    #else
    public System.DateOnly? OriginalFinalCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_TElJUdp-Ed-ak6NoX_4Aeg_1795520671")]
    [DisplayName("Original Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlFrqcy")]
    #endif
    [IsoXmlTag("OrgnlFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? OriginalFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? OriginalFrequency { get; init; } 
    #else
    public Frequency1Code? OriginalFrequency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
