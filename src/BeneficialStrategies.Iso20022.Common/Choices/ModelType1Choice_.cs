// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies type of margin models used by central counterparties.
    /// </summary>
    [KnownType(typeof(ModelType1Choice.Code))]
    [KnownType(typeof(ModelType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ModelType1Choice.Code), nameof(ModelType1Choice.Code))]
    [JsonDerivedType(typeof(ModelType1Choice.Proprietary), nameof(ModelType1Choice.Proprietary))]
    [IsoId("_jxanEI2GEeet3cKIYK84nw")]
    [DisplayName("Model Type 1 Choice")]
    public abstract record ModelType1Choice_ { }
}
