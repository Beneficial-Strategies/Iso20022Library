// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Data3.
/// </summary>
[IsoId("_ogYF4RAXEe6N57R8Wekj-w")]
[DisplayName("Order Data3")]
public record OrderData3
{
    /// <summary>
    /// Auction Data.
    /// </summary>
    [DisplayName("Auction Data")]
    [IsoXmlTag("AuctnData")]
    public AuctionData2? AuctionData { get; init; }

    /// <summary>
    /// Order Data.
    /// </summary>
    [DisplayName("Order Data")]
    [IsoXmlTag("OrdrData")]
    public OrderData4? OrderData { get; init; }

    /// <summary>
    /// Order Identification Data.
    /// </summary>
    [DisplayName("Order Identification Data")]
    [IsoXmlTag("OrdrIdData")]
    public required OrderIdentification2 OrderIdentificationData { get; init; }
}
