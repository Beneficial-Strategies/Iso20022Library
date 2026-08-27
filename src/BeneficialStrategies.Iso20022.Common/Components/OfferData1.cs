// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the offer for continuous order books.
/// </summary>
[IsoId("_CdhEoGIcEfCeoPFCHQnhvA")]
[DisplayName("Offer Data1")]
public record OfferData1
{
    /// <summary>
    /// Best offer in continuous order books.
    /// </summary>
    [IsoId("_WgtGIGIcEfCeoPFCHQnhvA")]
    [DisplayName("Best Offer")]
    [IsoXmlTag("BestOffer")]
    public required IsoDecimalNumber BestOffer { get; init; }

    /// <summary>
    /// The aggregated volume attached to the best offer.
    /// </summary>
    [IsoId("_gffqgGIcEfCeoPFCHQnhvA")]
    [DisplayName("Best Offer Volume")]
    [IsoXmlTag("BestOfferVol")]
    public required IsoDecimalNumber BestOfferVolume { get; init; }
}
