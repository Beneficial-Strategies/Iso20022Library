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
/// Transparency calculation specific details for an commodity derivatives.
/// </summary>
[IsoId("_exiPYU-nEeiVsYLJl6hleg")]
[DisplayName("Commodity Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommodityDerivative4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommodityDerivative4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommodityDerivative4( string reqNotionalCurrency )
    {
        NotionalCurrency = reqNotionalCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    [IsoId("_e8jMkU-nEeiVsYLJl6hleg")]
    [DisplayName("Class Specific")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssSpcfc")]
    #endif
    [IsoXmlTag("ClssSpcfc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommodityDerivative2Choice_? ClassSpecific { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommodityDerivative2Choice_? ClassSpecific { get; init; } 
    #else
    public CommodityDerivative2Choice_? ClassSpecific { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_e8jMk0-nEeiVsYLJl6hleg")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string NotionalCurrency { get; init; } 
    #else
    public string NotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
