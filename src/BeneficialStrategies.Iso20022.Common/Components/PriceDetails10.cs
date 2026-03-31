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
[IsoId("_utkFcROBEeKyONjZVQUqzg")]
[DisplayName("Price Details")]
public record PriceDetails10
{
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [IsoId("_vDw-9ROBEeKyONjZVQUqzg")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat23Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_vDw--ROBEeKyONjZVQUqzg")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat20Choice_? GenericCashPriceReceivedPerProduct { get; init; }
}
