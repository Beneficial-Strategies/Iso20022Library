// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat12Choice.Code))]
    [KnownType(typeof(OfferTypeFormat12Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat12Choice.Code),nameof(OfferTypeFormat12Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat12Choice.Proprietary),nameof(OfferTypeFormat12Choice.Proprietary))]
    [IsoId("_xf7D0Re1EeyroI8qKgB7Mg")]
    [DisplayName("Offer Type Format 12 Choice")]
    public abstract partial record OfferTypeFormat12Choice_
    {
    }
}
