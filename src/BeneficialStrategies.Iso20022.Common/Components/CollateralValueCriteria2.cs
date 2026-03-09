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
[IsoId("_zewXpeFgEeWIA4E9cYSxxQ")]
[DisplayName("Collateral Value Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValueCriteria2
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
    [IsoId("_zn-lEeFgEeWIA4E9cYSxxQ")]
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
    [IsoId("_zn-lE-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValueSearchCriteria2? SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValueSearchCriteria2? SearchCriteria { get; init; } 
    #else
    public CollateralValueSearchCriteria2? SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("_zn-lFeFgEeWIA4E9cYSxxQ")]
    [DisplayName("Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrCrit")]
    #endif
    [IsoXmlTag("RtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountReturnCriteria2? ReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountReturnCriteria2? ReturnCriteria { get; init; } 
    #else
    public CashAccountReturnCriteria2? ReturnCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
