// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the bid for the continuous order books.
/// </summary>
[IsoId("_mzylAGIaEfCeoPFCHQnhvA")]
[DisplayName("Bid Data1")]
public record BidData1
{
    /// <summary>
    /// Best bid in continuous order books.
    /// </summary>
    [IsoId("_w2kRgGIaEfCeoPFCHQnhvA")]
    [DisplayName("Best Bid")]
    [IsoXmlTag("BestBid")]
    public required IsoDecimalNumber BestBid { get; init; }

    /// <summary>
    /// Aggregated volume attached to the best bid.
    /// </summary>
    [IsoId("_1MtyYGIaEfCeoPFCHQnhvA")]
    [DisplayName("Best Bid Volume")]
    [IsoXmlTag("BestBidVol")]
    public required IsoDecimalNumber BestBidVolume { get; init; }
}
