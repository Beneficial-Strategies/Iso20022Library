// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of taxes.
    /// </summary>
    [KnownType(typeof(TaxTypeFormat1Choice.Code))]
    [KnownType(typeof(TaxTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxTypeFormat1Choice.Code), nameof(TaxTypeFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(TaxTypeFormat1Choice.Proprietary),
        nameof(TaxTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_SumZEgEcEeCQm6a_G2yO_w_1045052724")]
    [DisplayName("Tax Type Format 1 Choice")]
    public abstract record TaxTypeFormat1Choice_ { }
}
