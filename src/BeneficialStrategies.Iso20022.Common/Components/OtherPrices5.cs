// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[IsoId("_vSVaYQeFEe2fOITqoTnSLQ")]
[DisplayName("Other Prices")]
public partial record OtherPrices5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the maximum price.
    /// </summary>
    [IsoId("_vkqggQeFEe2fOITqoTnSLQ")]
    [DisplayName("Maximum")]
    [IsoXmlTag("Max")]
    public Price14? Maximum { get; init; } 
    
    /// <summary>
    /// Specifies the transaction price.
    /// </summary>
    [IsoId("_vkqggweFEe2fOITqoTnSLQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Price14? Transaction { get; init; } 
    
    /// <summary>
    /// Market price including or excluding the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqghQeFEe2fOITqoTnSLQ")]
    [DisplayName("Market Broker Commission")]
    [IsoXmlTag("MktBrkrComssn")]
    public Price14? MarketBrokerCommission { get; init; } 
    
    /// <summary>
    /// In case of an order to buy, the price that the broker paid on the market plus the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqghweFEe2fOITqoTnSLQ")]
    [DisplayName("Marked Up")]
    [IsoXmlTag("MrkdUp")]
    public Price14? MarkedUp { get; init; } 
    
    /// <summary>
    /// In case of an order to sell, the price the broker receives in the market minus the broker&apos;s commission.
    /// </summary>
    [IsoId("_vkqgiQeFEe2fOITqoTnSLQ")]
    [DisplayName("Marked Down")]
    [IsoXmlTag("MrkdDwn")]
    public Price14? MarkedDown { get; init; } 
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// </summary>
    [IsoId("_vkqgiweFEe2fOITqoTnSLQ")]
    [DisplayName("Net Disclosed")]
    [IsoXmlTag("NetDscld")]
    public Price14? NetDisclosed { get; init; } 
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// </summary>
    [IsoId("_vkqgjQeFEe2fOITqoTnSLQ")]
    [DisplayName("Net Undisclosed")]
    [IsoXmlTag("NetUdscld")]
    public Price14? NetUndisclosed { get; init; } 
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// </summary>
    [IsoId("_vkqgjweFEe2fOITqoTnSLQ")]
    [DisplayName("Notional Gross")]
    [IsoXmlTag("NtnlGrss")]
    public Price14? NotionalGross { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of the benchmark prices at the time of each partial fill.
    /// </summary>
    [IsoId("_vkqgkQeFEe2fOITqoTnSLQ")]
    [DisplayName("Benchmark Weighted Average")]
    [IsoXmlTag("BchmkWghtdAvrg")]
    public Price14? BenchmarkWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of all market executions during the completion of the order.
    /// </summary>
    [IsoId("_vkqgkweFEe2fOITqoTnSLQ")]
    [DisplayName("All Markets Weighted Average")]
    [IsoXmlTag("AllMktsWghtdAvrg")]
    public Price14? AllMarketsWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is a benchmark price relating to the current partial fills (eg, last trade tick from market).
    /// </summary>
    [IsoId("_vkqglQeFEe2fOITqoTnSLQ")]
    [DisplayName("Benchmark")]
    [IsoXmlTag("Bchmk")]
    public Price14? Benchmark { get; init; } 
    
    /// <summary>
    /// Type of price that is not defined explicitly.
    /// </summary>
    [IsoId("_vkqglweFEe2fOITqoTnSLQ")]
    [DisplayName("Other Price")]
    [IsoXmlTag("OthrPric")]
    public Price14? OtherPrice { get; init; } 
    
    /// <summary>
    /// Price of securities representing a particular market or a portion of it.
    /// </summary>
    [IsoId("_vkqgmQeFEe2fOITqoTnSLQ")]
    [DisplayName("Index Price")]
    [IsoXmlTag("IndxPric")]
    public Price14? IndexPrice { get; init; } 
    
    /// <summary>
    /// Price used to differentiate from price on a confirmation of a marked up or marked down principal trade.
    /// </summary>
    [IsoId("_vkqgmweFEe2fOITqoTnSLQ")]
    [DisplayName("Reported Price")]
    [IsoXmlTag("RptdPric")]
    public Price14? ReportedPrice { get; init; } 
    
    /// <summary>
    /// Price of reference of the concerned financial instrument.
    /// </summary>
    [IsoId("_vkqgnQeFEe2fOITqoTnSLQ")]
    [DisplayName("Reference Price")]
    [IsoXmlTag("RefPric")]
    public PriceInformation28? ReferencePrice { get; init; } 
    
    
    #nullable disable
    
}
