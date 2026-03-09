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
/// Specifies the type of price and information about the price.
/// </summary>
[IsoId("_vSVaYQeFEe2fOITqoTnSLQ")]
[DisplayName("Other Prices")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherPrices5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the maximum price.
    /// </summary>
    [IsoId("_vkqggQeFEe2fOITqoTnSLQ")]
    [DisplayName("Maximum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Max")]
    #endif
    [IsoXmlTag("Max")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? Maximum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? Maximum { get; init; } 
    #else
    public Price14? Maximum { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the transaction price.
    /// </summary>
    [IsoId("_vkqggweFEe2fOITqoTnSLQ")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? Transaction { get; init; } 
    #else
    public Price14? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Market price including or excluding the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqghQeFEe2fOITqoTnSLQ")]
    [DisplayName("Market Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktBrkrComssn")]
    #endif
    [IsoXmlTag("MktBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? MarketBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? MarketBrokerCommission { get; init; } 
    #else
    public Price14? MarketBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// In case of an order to buy, the price that the broker paid on the market plus the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqghweFEe2fOITqoTnSLQ")]
    [DisplayName("Marked Up")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkdUp")]
    #endif
    [IsoXmlTag("MrkdUp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? MarkedUp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? MarkedUp { get; init; } 
    #else
    public Price14? MarkedUp { get; set; } 
    #endif
    
    /// <summary>
    /// In case of an order to sell, the price the broker receives in the market minus the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqgiQeFEe2fOITqoTnSLQ")]
    [DisplayName("Marked Down")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkdDwn")]
    #endif
    [IsoXmlTag("MrkdDwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? MarkedDown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? MarkedDown { get; init; } 
    #else
    public Price14? MarkedDown { get; set; } 
    #endif
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// </summary>
    [IsoId("_vkqgiweFEe2fOITqoTnSLQ")]
    [DisplayName("Net Disclosed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetDscld")]
    #endif
    [IsoXmlTag("NetDscld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? NetDisclosed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? NetDisclosed { get; init; } 
    #else
    public Price14? NetDisclosed { get; set; } 
    #endif
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// </summary>
    [IsoId("_vkqgjQeFEe2fOITqoTnSLQ")]
    [DisplayName("Net Undisclosed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetUdscld")]
    #endif
    [IsoXmlTag("NetUdscld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? NetUndisclosed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? NetUndisclosed { get; init; } 
    #else
    public Price14? NetUndisclosed { get; set; } 
    #endif
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// </summary>
    [IsoId("_vkqgjweFEe2fOITqoTnSLQ")]
    [DisplayName("Notional Gross")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlGrss")]
    #endif
    [IsoXmlTag("NtnlGrss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? NotionalGross { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? NotionalGross { get; init; } 
    #else
    public Price14? NotionalGross { get; set; } 
    #endif
    
    /// <summary>
    /// Price is weighted average price of the benchmark prices at the time of each partial fill.
    /// </summary>
    [IsoId("_vkqgkQeFEe2fOITqoTnSLQ")]
    [DisplayName("Benchmark Weighted Average")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkWghtdAvrg")]
    #endif
    [IsoXmlTag("BchmkWghtdAvrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? BenchmarkWeightedAverage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? BenchmarkWeightedAverage { get; init; } 
    #else
    public Price14? BenchmarkWeightedAverage { get; set; } 
    #endif
    
    /// <summary>
    /// Price is weighted average price of all market executions during the completion of the order.
    /// </summary>
    [IsoId("_vkqgkweFEe2fOITqoTnSLQ")]
    [DisplayName("All Markets Weighted Average")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllMktsWghtdAvrg")]
    #endif
    [IsoXmlTag("AllMktsWghtdAvrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? AllMarketsWeightedAverage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? AllMarketsWeightedAverage { get; init; } 
    #else
    public Price14? AllMarketsWeightedAverage { get; set; } 
    #endif
    
    /// <summary>
    /// Price is a benchmark price relating to the current partial fills (eg, last trade tick from market).
    /// </summary>
    [IsoId("_vkqglQeFEe2fOITqoTnSLQ")]
    [DisplayName("Benchmark")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bchmk")]
    #endif
    [IsoXmlTag("Bchmk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? Benchmark { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? Benchmark { get; init; } 
    #else
    public Price14? Benchmark { get; set; } 
    #endif
    
    /// <summary>
    /// Type of price that is not defined explicitly.
    /// </summary>
    [IsoId("_vkqglweFEe2fOITqoTnSLQ")]
    [DisplayName("Other Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPric")]
    #endif
    [IsoXmlTag("OthrPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? OtherPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? OtherPrice { get; init; } 
    #else
    public Price14? OtherPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price of securities representing a particular market or a portion of it.
    /// </summary>
    [IsoId("_vkqgmQeFEe2fOITqoTnSLQ")]
    [DisplayName("Index Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxPric")]
    #endif
    [IsoXmlTag("IndxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? IndexPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? IndexPrice { get; init; } 
    #else
    public Price14? IndexPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price used to differentiate from price on a confirmation of a marked up or marked down principal trade.
    /// </summary>
    [IsoId("_vkqgmweFEe2fOITqoTnSLQ")]
    [DisplayName("Reported Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdPric")]
    #endif
    [IsoXmlTag("RptdPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? ReportedPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? ReportedPrice { get; init; } 
    #else
    public Price14? ReportedPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price of reference of the concerned financial instrument.
    /// </summary>
    [IsoId("_vkqgnQeFEe2fOITqoTnSLQ")]
    [DisplayName("Reference Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPric")]
    #endif
    [IsoXmlTag("RefPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation28? ReferencePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation28? ReferencePrice { get; init; } 
    #else
    public PriceInformation28? ReferencePrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
