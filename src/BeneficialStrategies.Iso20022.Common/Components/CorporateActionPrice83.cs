// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price83.
/// </summary>
[IsoId("_DRjUEYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price83")]
public partial record CorporateActionPrice83
{
    #nullable enable

    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat77Choice_? CashInLieuOfSharePrice { get; init; } 

    /// <summary>
    /// Cash Value For Tax.
    /// </summary>
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public AmountPrice2? CashValueForTax { get; init; } 

    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat75Choice_? GenericCashPricePaidPerProduct { get; init; } 

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat76Choice_? GenericCashPriceReceivedPerProduct { get; init; } 

    /// <summary>
    /// Indicative Or Market Price.
    /// </summary>
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice13Choice_? IndicativeOrMarketPrice { get; init; } 

    
    #nullable disable
    
}
