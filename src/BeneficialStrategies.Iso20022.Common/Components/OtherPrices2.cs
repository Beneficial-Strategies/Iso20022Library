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
[IsoId("__ayE0TAiEeOUGqA1wUwNLA")]
[DisplayName("Other Prices")]
public partial record OtherPrices2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the maximum price.
    /// </summary>
    [IsoId("__yuqwTAiEeOUGqA1wUwNLA")]
    [DisplayName("Maximum")]
    [IsoXmlTag("Max")]
    public Price4? Maximum { get; init; } 
    
    /// <summary>
    /// Specifies the transaction price.
    /// </summary>
    [IsoId("__yuqwzAiEeOUGqA1wUwNLA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Price4? Transaction { get; init; } 
    
    /// <summary>
    /// Market price including or excluding the broker&apos;s commission.
    /// </summary>
    [IsoId("__yuqxTAiEeOUGqA1wUwNLA")]
    [DisplayName("Market Broker Commission")]
    [IsoXmlTag("MktBrkrComssn")]
    public Price4? MarketBrokerCommission { get; init; } 
    
    /// <summary>
    /// In case of an order to buy, the price that the broker paid on the market plus the broker&apos;s commission.
    /// </summary>
    [IsoId("__yuqxzAiEeOUGqA1wUwNLA")]
    [DisplayName("Marked Up")]
    [IsoXmlTag("MrkdUp")]
    public Price4? MarkedUp { get; init; } 
    
    /// <summary>
    /// In case of an order to sell, the price the broker receives in the market minus the broker&apos;s commission.
    /// </summary>
    [IsoId("__yuqyTAiEeOUGqA1wUwNLA")]
    [DisplayName("Marked Down")]
    [IsoXmlTag("MrkdDwn")]
    public Price4? MarkedDown { get; init; } 
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// </summary>
    [IsoId("__yuqyzAiEeOUGqA1wUwNLA")]
    [DisplayName("Net Disclosed")]
    [IsoXmlTag("NetDscld")]
    public Price4? NetDisclosed { get; init; } 
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// </summary>
    [IsoId("__yuqzTAiEeOUGqA1wUwNLA")]
    [DisplayName("Net Undisclosed")]
    [IsoXmlTag("NetUdscld")]
    public Price4? NetUndisclosed { get; init; } 
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// </summary>
    [IsoId("__yuqzzAiEeOUGqA1wUwNLA")]
    [DisplayName("Notional Gross")]
    [IsoXmlTag("NtnlGrss")]
    public Price4? NotionalGross { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of the benchmark prices at the time of each partial fill.
    /// </summary>
    [IsoId("__yuq0TAiEeOUGqA1wUwNLA")]
    [DisplayName("Benchmark Weighted Average")]
    [IsoXmlTag("BchmkWghtdAvrg")]
    public Price4? BenchmarkWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of all market executions during the completion of the order.
    /// </summary>
    [IsoId("__yuq0zAiEeOUGqA1wUwNLA")]
    [DisplayName("All Markets Weighted Average")]
    [IsoXmlTag("AllMktsWghtdAvrg")]
    public Price4? AllMarketsWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is a benchmark price relating to the current partial fills (eg, last trade tick from market).
    /// </summary>
    [IsoId("__yuq1TAiEeOUGqA1wUwNLA")]
    [DisplayName("Benchmark")]
    [IsoXmlTag("Bchmk")]
    public Price4? Benchmark { get; init; } 
    
    /// <summary>
    /// Type of price that is not defined explicitly.
    /// </summary>
    [IsoId("__yuq1zAiEeOUGqA1wUwNLA")]
    [DisplayName("Other Price")]
    [IsoXmlTag("OthrPric")]
    public Price4? OtherPrice { get; init; } 
    
    /// <summary>
    /// Price of securities representing a particular market or a portion of it.
    /// </summary>
    [IsoId("__yuq2TAiEeOUGqA1wUwNLA")]
    [DisplayName("Index Price")]
    [IsoXmlTag("IndxPric")]
    public Price4? IndexPrice { get; init; } 
    
    /// <summary>
    /// Price used to differentiate from price on a confirmation of a marked up or marked down principal trade.
    /// </summary>
    [IsoId("__yuq2zAiEeOUGqA1wUwNLA")]
    [DisplayName("Reported Price")]
    [IsoXmlTag("RptdPric")]
    public Price4? ReportedPrice { get; init; } 
    
    /// <summary>
    /// Price of reference of the concerned financial instrument.
    /// </summary>
    [IsoId("__yuq3TAiEeOUGqA1wUwNLA")]
    [DisplayName("Reference Price")]
    [IsoXmlTag("RefPric")]
    public PriceInformation11? ReferencePrice { get; init; } 
    
    
    #nullable disable
    
}
