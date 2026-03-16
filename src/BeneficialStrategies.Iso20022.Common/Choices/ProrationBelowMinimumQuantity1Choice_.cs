// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Proration Below Minimum Quantity1Choice.
    /// </summary>
    [KnownType(typeof(ProrationBelowMinimumQuantity1Choice.Code))]
    [KnownType(typeof(ProrationBelowMinimumQuantity1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProrationBelowMinimumQuantity1Choice.Code),nameof(ProrationBelowMinimumQuantity1Choice.Code))]
    [JsonDerivedType(typeof(ProrationBelowMinimumQuantity1Choice.Proprietary),nameof(ProrationBelowMinimumQuantity1Choice.Proprietary))]
    [IsoId("_ETpRI4DCEe-eGe8fbP3Zug")]
    [DisplayName("Proration Below Minimum Quantity1Choice")]
    public abstract partial record ProrationBelowMinimumQuantity1Choice_
    {
    }
}
