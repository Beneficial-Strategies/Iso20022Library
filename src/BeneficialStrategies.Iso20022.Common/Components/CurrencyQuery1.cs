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
[IsoId("_71C2Q6MgEeCJ6YNENx4h-w_507537630")]
[DisplayName("Currency Query")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyQuery1
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
    [IsoId("_71C2RKMgEeCJ6YNENx4h-w_-73159754")]
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
    ///  Defines of the currency query criteria.
    /// </summary>
    [IsoId("_71C2RaMgEeCJ6YNENx4h-w_-1016665255")]
    [DisplayName("Currency Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyCrit")]
    #endif
    [IsoXmlTag("CcyCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCriteria1Choice_? CurrencyCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyCriteria1Choice_? CurrencyCriteria { get; init; } 
    #else
    public CurrencyCriteria1Choice_? CurrencyCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
