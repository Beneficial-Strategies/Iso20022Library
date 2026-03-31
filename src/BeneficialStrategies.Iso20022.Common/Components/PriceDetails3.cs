// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the prices related to a corporate action option.
/// </summary>
[IsoId("_5aw-RuzaEd-Z2q4-Bbm3ZA")]
[DisplayName("Price Details")]
public record PriceDetails3
{
    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or a number of points above an index.
    /// </summary>
    [IsoId("_XrRAMOtLEd-PFJLHKom6FA")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public PriceFormat23Choice_? ExercisePrice { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_ZGwt0OtLEd-PFJLHKom6FA")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat19Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_OyHXIffhEd-ebNlrGf0-3Q")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat22Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
