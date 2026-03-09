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
/// Content of the Transaction Report Request message.
/// </summary>
[IsoId("_wej3AN6PEeiwsev40qZGEQ")]
[DisplayName("Report Transaction Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportTransactionRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Eligibility parameters for a transaction to be part of transaction report.
    /// </summary>
    [IsoId("_4eXmMN6PEeiwsev40qZGEQ")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    public ValueList<SearchCriteria1> SearchCriteria { get; init; } = new ValueList<SearchCriteria1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4eXmMN6PEeiwsev40qZGEQ
    
    /// <summary>
    /// Indicates the ordering in which the resulting transaction reports should be returned.
    /// </summary>
    [IsoId("_sN1MMN6QEeiwsev40qZGEQ")]
    [DisplayName("Search Output Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchOutptOrdr")]
    #endif
    [IsoXmlTag("SchOutptOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SearchOutputOrder1? SearchOutputOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SearchOutputOrder1? SearchOutputOrder { get; init; } 
    #else
    public SearchOutputOrder1? SearchOutputOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the order used for the criteria.
    /// </summary>
    [IsoId("_OLrKsN6REeiwsev40qZGEQ")]
    [DisplayName("Descending Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscndgOrdr")]
    #endif
    [IsoXmlTag("DscndgOrdr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DescendingOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DescendingOrder { get; init; } 
    #else
    public System.String? DescendingOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Index of the first transaction matching the search criteria.
    /// </summary>
    [IsoId("_RUyQsN6REeiwsev40qZGEQ")]
    [DisplayName("Block Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckStart")]
    #endif
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? BlockStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? BlockStart { get; init; } 
    #else
    public System.UInt64? BlockStart { get; set; } 
    #endif
    
    /// <summary>
    /// Index of the last transaction matching the search criteria.
    /// </summary>
    [IsoId("_WEN0QN6REeiwsev40qZGEQ")]
    [DisplayName("Block Stop")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckStop")]
    #endif
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? BlockStop { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? BlockStop { get; init; } 
    #else
    public System.UInt64? BlockStop { get; set; } 
    #endif
    
    
    #nullable disable
    
}
