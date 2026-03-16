// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Offer Type Format15Choice.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat15Choice.Code))]
    [KnownType(typeof(OfferTypeFormat15Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat15Choice.Code),nameof(OfferTypeFormat15Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat15Choice.Proprietary),nameof(OfferTypeFormat15Choice.Proprietary))]
    [IsoId("_l6TUu5t3Ee-wQIOX0djF2w")]
    [DisplayName("Offer Type Format15Choice")]
    public abstract partial record OfferTypeFormat15Choice_
    {
    }
}
