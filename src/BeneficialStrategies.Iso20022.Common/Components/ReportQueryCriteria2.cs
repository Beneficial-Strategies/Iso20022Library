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
/// Defines the criteria which are used to search for generated report.
/// </summary>
[IsoId("_3NLDgZb6Eee4htziCyV8eA")]
[DisplayName("Report Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportQueryCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportQueryCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportQueryCriteria2( ReportQuerySearchCriteria2 reqSearchCriteria )
    {
        SearchCriteria = reqSearchCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria. 
    /// </summary>
    [IsoId("_3b6DEZb6Eee4htziCyV8eA")]
    [DisplayName("New Query Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewQryNm")]
    #endif
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NewQueryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewQueryName { get; init; } 
    #else
    public System.String? NewQueryName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("_3b6DE5b6Eee4htziCyV8eA")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportQuerySearchCriteria2 SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportQuerySearchCriteria2 SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportQuerySearchCriteria2 SearchCriteria { get; init; } 
    #else
    public ReportQuerySearchCriteria2 SearchCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
