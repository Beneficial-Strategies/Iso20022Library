// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat11Choice.Code))]
    [KnownType(typeof(OfferTypeFormat11Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat11Choice.Code), nameof(OfferTypeFormat11Choice.Code))]
    [JsonDerivedType(
        typeof(OfferTypeFormat11Choice.Proprietary),
        nameof(OfferTypeFormat11Choice.Proprietary)
    )]
    [IsoId("_cta945KQEeWHWpTQn1FFVg")]
    [DisplayName("Offer Type Format 11 Choice")]
    public abstract record OfferTypeFormat11Choice_ { }
}
