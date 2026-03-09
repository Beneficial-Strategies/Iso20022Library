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
/// Defines the criteria which are used to search for an account and to report on the account. A name may be given to the new query.
/// </summary>
[IsoId("__xWrgTpsEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValueCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("__7yZ4TpsEemk2e6qGBk8IQ")]
    [DisplayName("Query Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryNm")]
    #endif
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryName { get; init; } 
    #else
    public System.String? QueryName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("__7yZ4zpsEemk2e6qGBk8IQ")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValueSearchCriteria3? SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValueSearchCriteria3? SearchCriteria { get; init; } 
    #else
    public CollateralValueSearchCriteria3? SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("__7yZ5TpsEemk2e6qGBk8IQ")]
    [DisplayName("Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrCrit")]
    #endif
    [IsoXmlTag("RtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValueReturnCriteria1? ReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValueReturnCriteria1? ReturnCriteria { get; init; } 
    #else
    public CollateralValueReturnCriteria1? ReturnCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
