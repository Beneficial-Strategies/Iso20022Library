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
[IsoId("_AVY2oNokEeC60axPepSq7g_-1057295935")]
[DisplayName("Other Prices")]
public partial record OtherPrices1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the maximum price.
    /// </summary>
    [IsoId("_AVY2odokEeC60axPepSq7g_-412748143")]
    [DisplayName("Maximum")]
    [IsoXmlTag("Max")]
    public Price4? Maximum { get; init; } 
    
    /// <summary>
    /// Specifies the transaction price.
    /// </summary>
    [IsoId("_AVY2otokEeC60axPepSq7g_-135108701")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Price4? Transaction { get; init; } 
    
    /// <summary>
    /// Market price including or excluding the broker&apos;s commission.
    /// </summary>
    [IsoId("_AVY2o9okEeC60axPepSq7g_970383057")]
    [DisplayName("Market Broker Commission")]
    [IsoXmlTag("MktBrkrComssn")]
    public Price4? MarketBrokerCommission { get; init; } 
    
    /// <summary>
    /// In case of an order to buy, the price that the broker paid on the market plus the broker&apos;s commission.
    /// </summary>
    [IsoId("_AViAkNokEeC60axPepSq7g_1236215092")]
    [DisplayName("Marked Up")]
    [IsoXmlTag("MrkdUp")]
    public Price4? MarkedUp { get; init; } 
    
    /// <summary>
    /// In case of an order to sell, the price the broker receives in the market minus the broker&apos;s commission.
    /// </summary>
    [IsoId("_AViAkdokEeC60axPepSq7g_1920876019")]
    [DisplayName("Marked Down")]
    [IsoXmlTag("MrkdDwn")]
    public Price4? MarkedDown { get; init; } 
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// </summary>
    [IsoId("_AViAktokEeC60axPepSq7g_-1534685855")]
    [DisplayName("Net Disclosed")]
    [IsoXmlTag("NetDscld")]
    public Price4? NetDisclosed { get; init; } 
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// </summary>
    [IsoId("_AViAk9okEeC60axPepSq7g_-1231512314")]
    [DisplayName("Net Undisclosed")]
    [IsoXmlTag("NetUdscld")]
    public Price4? NetUndisclosed { get; init; } 
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// </summary>
    [IsoId("_AViAlNokEeC60axPepSq7g_-1798499143")]
    [DisplayName("Notional Gross")]
    [IsoXmlTag("NtnlGrss")]
    public Price4? NotionalGross { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of the benchmark prices at the time of each partial fill.
    /// </summary>
    [IsoId("_AViAldokEeC60axPepSq7g_-734038973")]
    [DisplayName("Benchmark Weighted Average")]
    [IsoXmlTag("BchmkWghtdAvrg")]
    public Price4? BenchmarkWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is weighted average price of all market executions during the completion of the order.
    /// </summary>
    [IsoId("_AViAltokEeC60axPepSq7g_-368908451")]
    [DisplayName("All Markets Weighted Average")]
    [IsoXmlTag("AllMktsWghtdAvrg")]
    public Price4? AllMarketsWeightedAverage { get; init; } 
    
    /// <summary>
    /// Price is a benchmark price relating to the current partial fills (eg, last trade tick from market).
    /// </summary>
    [IsoId("_AVrxkNokEeC60axPepSq7g_-924946064")]
    [DisplayName("Benchmark")]
    [IsoXmlTag("Bchmk")]
    public Price4? Benchmark { get; init; } 
    
    /// <summary>
    /// Type of price that is not defined explicitly.
    /// </summary>
    [IsoId("_AVrxkdokEeC60axPepSq7g_422248478")]
    [DisplayName("Other Price")]
    [IsoXmlTag("OthrPric")]
    public Price4? OtherPrice { get; init; } 
    
    /// <summary>
    /// Price of securities representing a particular market or a portion of it.
    /// </summary>
    [IsoId("_AVrxktokEeC60axPepSq7g_2006009430")]
    [DisplayName("Index Price")]
    [IsoXmlTag("IndxPric")]
    public Price4? IndexPrice { get; init; } 
    
    /// <summary>
    /// Price used to differentiate from price on a confirmation of a marked up or marked down principal trade.
    /// </summary>
    [IsoId("_AVrxk9okEeC60axPepSq7g_-1153816314")]
    [DisplayName("Reported Price")]
    [IsoXmlTag("RptdPric")]
    public Price4? ReportedPrice { get; init; } 
    
    /// <summary>
    /// Price of reference of the concerned financial instrument.
    /// </summary>
    [IsoId("_AVrxlNokEeC60axPepSq7g_51510680")]
    [DisplayName("Reference Price")]
    [IsoXmlTag("RefPric")]
    public PriceInformation9? ReferencePrice { get; init; } 
    
    
    #nullable disable
    
}
