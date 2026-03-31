// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_yBJdeeEPEd-1Ktb5rVaajw")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice19
{
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_yBTOUeEPEd-1Ktb5rVaajw")]
    [DisplayName("Indicative Or Market Price")]
    [IsoXmlTag("IndctvOrMktPric")]
    public IndicativeOrMarketPrice2Choice_? IndicativeOrMarketPrice { get; init; }

    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or a number of points above an index.
    /// </summary>
    [IsoId("_yBTOU-EPEd-1Ktb5rVaajw")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public PriceFormat5Choice_? ExercisePrice { get; init; }

    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_yBTOVeEPEd-1Ktb5rVaajw")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat5Choice_? IssuePrice { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_yBTOV-EPEd-1Ktb5rVaajw")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat21Choice_? GenericCashPriceReceivedPerProduct { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_yBTOWeEPEd-1Ktb5rVaajw")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat5Choice_? GenericCashPricePaidPerProduct { get; init; }
}
