// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a quantity expressed in units, face amount or amortised amount and a quantity expressed as an amount.
    /// </summary>
    [KnownType(typeof(QuantityOrAmount2Choice.Quantity))]
    [KnownType(typeof(QuantityOrAmount2Choice.Amount))]
    [JsonDerivedType(
        typeof(QuantityOrAmount2Choice.Quantity),
        nameof(QuantityOrAmount2Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(QuantityOrAmount2Choice.Amount),
        nameof(QuantityOrAmount2Choice.Amount)
    )]
    [IsoId("_wFZWYQeCEe2fOITqoTnSLQ")]
    [DisplayName("Quantity Or Amount 2 Choice")]
    public abstract record QuantityOrAmount2Choice_ { }
}
