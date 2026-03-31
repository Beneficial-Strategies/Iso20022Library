// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat1Choice.Code))]
    [KnownType(typeof(OfferTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(OfferTypeFormat1Choice.Code), nameof(OfferTypeFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(OfferTypeFormat1Choice.Proprietary),
        nameof(OfferTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3nigtp-Ed-ak6NoX_4Aeg_789019440")]
    [DisplayName("Offer Type Format 1 Choice")]
    public abstract record OfferTypeFormat1Choice_ { }
}
