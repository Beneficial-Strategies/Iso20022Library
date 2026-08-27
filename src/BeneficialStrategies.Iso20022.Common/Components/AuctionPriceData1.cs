// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the auction price for the auction trading system
/// </summary>
[IsoId("_F4ikkGIdEfCeoPFCHQnhvA")]
[DisplayName("Auction Price Data1")]
public record AuctionPriceData1
{
    /// <summary>
    /// Lowest auction price.
    /// </summary>
    [IsoId("_O_VJ8GIdEfCeoPFCHQnhvA")]
    [DisplayName("Lowest")]
    [IsoXmlTag("Lwst")]
    public required IsoDecimalNumber Lowest { get; init; }

    /// <summary>
    /// Highest auction price.
    /// </summary>
    [IsoId("_WLJ3cGIdEfCeoPFCHQnhvA")]
    [DisplayName("Highest")]
    [IsoXmlTag("Hghst")]
    public required IsoDecimalNumber Highest { get; init; }

    /// <summary>
    /// Volume weighted auction price.
    /// </summary>
    [IsoId("_aUtGwGIdEfCeoPFCHQnhvA")]
    [DisplayName("Volume Weighted")]
    [IsoXmlTag("VolWghtd")]
    public required IsoDecimalNumber VolumeWeighted { get; init; }

    /// <summary>
    /// Major currency unit in which the best bid and offer prices are expressed.
    /// </summary>
    [IsoId("_d-nzwGIdEfCeoPFCHQnhvA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }
}
