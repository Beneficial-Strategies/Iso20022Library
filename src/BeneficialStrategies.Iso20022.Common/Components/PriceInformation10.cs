// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_m-lZofNBEeCuA5Tr22BnwA_448139482")]
[DisplayName("Price Information")]
public record PriceInformation10
{
    /// <summary>
    /// Current value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_m-lZovNBEeCuA5Tr22BnwA_947656184")]
    [DisplayName("Current Price")]
    [IsoXmlTag("CurPric")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount CurrentPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_m-lZo_NBEeCuA5Tr22BnwA_334300416")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice27Choice_ Type { get; init; }

    /// <summary>
    /// Previous value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_m-lZpPNBEeCuA5Tr22BnwA_-389486155")]
    [DisplayName("Previous Price")]
    [IsoXmlTag("PrvsPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? PreviousPrice { get; init; }

    /// <summary>
    /// Difference or change between the previous price value and the current price value.
    /// </summary>
    [IsoId("_m-lZpfNBEeCuA5Tr22BnwA_-662771937")]
    [DisplayName("Amount Of Change")]
    [IsoXmlTag("AmtOfChng")]
    public PriceValueAndRate4? AmountOfChange { get; init; }
}
