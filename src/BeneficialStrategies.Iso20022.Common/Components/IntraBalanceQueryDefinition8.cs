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
/// Defines the information that is searched through specific criteria.
/// </summary>
[IsoId("_30RF4Tp8EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Definition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceQueryDefinition8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalanceQueryDefinition8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceQueryDefinition8( MovementResponseType1Code reqQueryType,IntraBalanceQueryCriteria8 reqSearchCriteria )
    {
        QueryType = reqQueryType;
        SearchCriteria = reqSearchCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_3_TRMTp8EemwKdP955WBJQ")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MovementResponseType1Code QueryType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MovementResponseType1Code QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MovementResponseType1Code QueryType { get; init; } 
    #else
    public MovementResponseType1Code QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to extract the intra-balance movement instruction information.
    /// </summary>
    [IsoId("_3_TRMzp8EemwKdP955WBJQ")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraBalanceQueryCriteria8 SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraBalanceQueryCriteria8 SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalanceQueryCriteria8 SearchCriteria { get; init; } 
    #else
    public IntraBalanceQueryCriteria8 SearchCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
