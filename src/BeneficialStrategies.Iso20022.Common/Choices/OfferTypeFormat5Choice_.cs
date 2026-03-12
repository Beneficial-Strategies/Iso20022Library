// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat5Choice.Code))]
    [KnownType(typeof(OfferTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat5Choice.Code),nameof(OfferTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat5Choice.Proprietary),nameof(OfferTypeFormat5Choice.Proprietary))]
    [IsoId("_P7vtNSHjEeOQ7qT4JUI53A")]
    [DisplayName("Offer Type Format 5 Choice")]
    public abstract partial record OfferTypeFormat5Choice_
    {
    }
}
