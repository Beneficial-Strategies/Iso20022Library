// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Proration Below Minimum Quantity2Choice.
    /// </summary>
    [KnownType(typeof(ProrationBelowMinimumQuantity2Choice.Code))]
    [KnownType(typeof(ProrationBelowMinimumQuantity2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProrationBelowMinimumQuantity2Choice.Code),
        nameof(ProrationBelowMinimumQuantity2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProrationBelowMinimumQuantity2Choice.Proprietary),
        nameof(ProrationBelowMinimumQuantity2Choice.Proprietary)
    )]
    [IsoId("_G1b586GnEe-4O7NbwmwJkQ")]
    [DisplayName("Proration Below Minimum Quantity2Choice")]
    public abstract record ProrationBelowMinimumQuantity2Choice_ { }
}
