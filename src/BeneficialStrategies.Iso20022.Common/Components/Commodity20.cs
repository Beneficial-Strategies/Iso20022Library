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
/// Data specific to commodities and related fields used as a collateral.
/// </summary>
[IsoId("_MMF1181VEem4K5qLxnWwMA")]
[DisplayName("Commodity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commodity20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details on commodities assignments to sectors.
    /// </summary>
    [IsoId("_MR5i4c1VEem4K5qLxnWwMA")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    #else
    public AssetClassCommodity5Choice_? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the commodity.
    /// </summary>
    [IsoId("_MR5i481VEem4K5qLxnWwMA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity17? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity17? Quantity { get; init; } 
    #else
    public Quantity17? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Price of unit of asset or collateral component, including accrued interest for interest-bearing securities, used to value the commodity .
    /// </summary>
    [IsoId("_MR5i5c1VEem4K5qLxnWwMA")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
    #else
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_MR5i581VEem4K5qLxnWwMA")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
