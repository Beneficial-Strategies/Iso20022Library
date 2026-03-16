// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat3Choice.Code))]
    [KnownType(typeof(OfferTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat3Choice.Code), nameof(OfferTypeFormat3Choice.Code))]
    [JsonDerivedType(
        typeof(OfferTypeFormat3Choice.Proprietary),
        nameof(OfferTypeFormat3Choice.Proprietary)
    )]
    [IsoId("_q9LvwS87EeKNZpaVtgp8Wg")]
    [DisplayName("Offer Type Format 3 Choice")]
    public abstract record OfferTypeFormat3Choice_ { }
}
