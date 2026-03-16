// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price93.
/// </summary>
[IsoId("_kv7zS5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Price93")]
public partial record CorporateActionPrice93
{
    #nullable enable

    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat85Choice_? CashInLieuOfSharePrice { get; init; } 

    /// <summary>
    /// Cash Value For Tax.
    /// </summary>
    [DisplayName("Cash Value For Tax")]
    [IsoXmlTag("CshValForTax")]
    public AmountPrice4? CashValueForTax { get; init; } 

    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat86Choice_? GenericCashPricePaidPerProduct { get; init; } 

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat87Choice_? GenericCashPriceReceivedPerProduct { get; init; } 

    /// <summary>
    /// Indicative Or Market Price.
    /// </summary>
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice16Choice_? IndicativeOrMarketPrice { get; init; } 

    
    #nullable disable
    
}
