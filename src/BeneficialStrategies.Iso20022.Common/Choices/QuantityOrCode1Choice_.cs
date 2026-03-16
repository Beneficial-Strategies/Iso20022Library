// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a quantity or a code value.
    /// </summary>
    [KnownType(typeof(QuantityOrCode1Choice.Quantity))]
    [KnownType(typeof(QuantityOrCode1Choice.Code))]
    [JsonDerivedType(
        typeof(QuantityOrCode1Choice.Quantity),
        nameof(QuantityOrCode1Choice.Quantity)
    )]
    [JsonDerivedType(typeof(QuantityOrCode1Choice.Code), nameof(QuantityOrCode1Choice.Code))]
    [IsoId("_9Z368K-VEemJ1NnLPsTFaw")]
    [DisplayName("Quantity Or Code 1 Choice")]
    public abstract record QuantityOrCode1Choice_ { }
}
