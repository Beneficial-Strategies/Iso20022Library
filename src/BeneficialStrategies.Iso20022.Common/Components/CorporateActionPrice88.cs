// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price88.
/// </summary>
[IsoId("_D5CK0YV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price88")]
public partial record CorporateActionPrice88
{
    #nullable enable

    /// <summary>
    /// Generic Cash Price Paid Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat77Choice_? GenericCashPricePaidPerProduct { get; init; } 

    /// <summary>
    /// Generic Cash Price Received Per Product.
    /// </summary>
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat78Choice_? GenericCashPriceReceivedPerProduct { get; init; } 

    /// <summary>
    /// Indicative Or Market Price.
    /// </summary>
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice13Choice_? IndicativeOrMarketPrice { get; init; } 

    /// <summary>
    /// Issue Price.
    /// </summary>
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat77Choice_? IssuePrice { get; init; } 

    
    #nullable disable
    
}
