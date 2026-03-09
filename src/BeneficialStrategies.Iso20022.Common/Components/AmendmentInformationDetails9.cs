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
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_te0lAFkyEeGeoaLUQk__nA_-1080741410")]
[DisplayName("Amendment Information Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentInformationDetails9
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
    [IsoId("_te0lAVkyEeGeoaLUQk__nA_-786752122")]
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
    [IsoId("_te0lAlkyEeGeoaLUQk__nA_-1987316393")]
    [DisplayName("Original Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrSchmeId")]
    #endif
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_te0lA1kyEeGeoaLUQk__nA_-1998415170")]
    [DisplayName("Original Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCdtrAgt")]
    #endif
    [IsoXmlTag("OrgnlCdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_te9u8FkyEeGeoaLUQk__nA_-584178548")]
    [DisplayName("Original Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtr")]
    #endif
    [IsoXmlTag("OrgnlDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? OriginalDebtor { get; init; } 
    #else
    public PartyIdentification43? OriginalDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_te9u8VkyEeGeoaLUQk__nA_-552379473")]
    [DisplayName("Original Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAcct")]
    #endif
    [IsoXmlTag("OrgnlDbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? OriginalDebtorAccount { get; init; } 
    #else
    public CashAccount24? OriginalDebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_te9u8lkyEeGeoaLUQk__nA_-1694300912")]
    [DisplayName("Original Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDbtrAgt")]
    #endif
    [IsoXmlTag("OrgnlDbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_te9u81kyEeGeoaLUQk__nA_-197353443")]
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
    [IsoId("_te9u9FkyEeGeoaLUQk__nA_-1269358502")]
    [DisplayName("Original Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlFrqcy")]
    #endif
    [IsoXmlTag("OrgnlFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency6Code? OriginalFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency6Code? OriginalFrequency { get; init; } 
    #else
    public Frequency6Code? OriginalFrequency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
