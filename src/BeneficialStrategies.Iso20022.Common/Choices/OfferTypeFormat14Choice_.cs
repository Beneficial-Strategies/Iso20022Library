// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Offer Type Format14Choice.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat14Choice.Code))]
    [KnownType(typeof(OfferTypeFormat14Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat14Choice.Code),nameof(OfferTypeFormat14Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat14Choice.Proprietary),nameof(OfferTypeFormat14Choice.Proprietary))]
    [IsoId("__6Ee8YSJEe-AUMVyVXihZg")]
    [DisplayName("Offer Type Format14Choice")]
    public abstract partial record OfferTypeFormat14Choice_
    {
    }
}
