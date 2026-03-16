// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat10Choice.Code))]
    [KnownType(typeof(OfferTypeFormat10Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat10Choice.Code), nameof(OfferTypeFormat10Choice.Code))]
    [JsonDerivedType(
        typeof(OfferTypeFormat10Choice.Proprietary),
        nameof(OfferTypeFormat10Choice.Proprietary)
    )]
    [IsoId("_8aKE8UEFEeWVgfuHGaKtRQ")]
    [DisplayName("Offer Type Format 10 Choice")]
    public abstract record OfferTypeFormat10Choice_ { }
}
