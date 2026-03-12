// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_TXznUtp-Ed-ak6NoX_4Aeg_603653069")]
[DisplayName("Corporate Action Price")]
public partial record CorporateActionPrice8
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_TXznU9p-Ed-ak6NoX_4Aeg_-1462857594")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice2Choice_? IndicativeOrMarketPrice { get; init; } 
    
    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or a number of points above an index.
    /// </summary>
    [IsoId("_TXznVNp-Ed-ak6NoX_4Aeg_1057101923")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public PriceFormat5Choice_? ExercisePrice { get; init; } 
    
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_TXznVdp-Ed-ak6NoX_4Aeg_1089427251")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat5Choice_? IssuePrice { get; init; } 
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_TXznVtp-Ed-ak6NoX_4Aeg_1406194303")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat9Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_TXznV9p-Ed-ak6NoX_4Aeg_1446828667")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat5Choice_? GenericCashPricePaidPerProduct { get; init; } 
    
    
    #nullable disable
    
}
