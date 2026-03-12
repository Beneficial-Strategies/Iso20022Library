// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat13Choice.Code))]
    [KnownType(typeof(OfferTypeFormat13Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat13Choice.Code),nameof(OfferTypeFormat13Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat13Choice.Proprietary),nameof(OfferTypeFormat13Choice.Proprietary))]
    [IsoId("_ptGn5zi7Eeydid5dcNPKvg")]
    [DisplayName("Offer Type Format 13 Choice")]
    public abstract partial record OfferTypeFormat13Choice_
    {
    }
}
