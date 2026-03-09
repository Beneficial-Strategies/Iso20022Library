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
/// Defines the query criteria.
/// </summary>
[IsoId("_1NvnkZlZEeeE1Ya-LgRsuQ")]
[DisplayName("Business Information Query Definition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessInformationQueryDefinition3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_1VwUE5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QueryType2Code? QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryType2Code? QueryType { get; init; } 
    #else
    public QueryType2Code? QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the general business information query criteria.
    /// </summary>
    [IsoId("_1VwUFZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Information Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlBizInfCrit")]
    #endif
    [IsoXmlTag("GnlBizInfCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeneralBusinessInformationCriteriaDefinition1Choice_? GeneralBusinessInformationCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralBusinessInformationCriteriaDefinition1Choice_? GeneralBusinessInformationCriteria { get; init; } 
    #else
    public GeneralBusinessInformationCriteriaDefinition1Choice_? GeneralBusinessInformationCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
