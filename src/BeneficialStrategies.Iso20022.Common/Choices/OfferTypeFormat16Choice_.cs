// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Offer Type Format16Choice.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat16Choice.Code))]
    [KnownType(typeof(OfferTypeFormat16Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat16Choice.Code), nameof(OfferTypeFormat16Choice.Code))]
    [JsonDerivedType(
        typeof(OfferTypeFormat16Choice.Proprietary),
        nameof(OfferTypeFormat16Choice.Proprietary)
    )]
    [IsoId("_nLhFfZt3Ee-wQIOX0djF2w")]
    [DisplayName("Offer Type Format16Choice")]
    public abstract record OfferTypeFormat16Choice_ { }
}
