// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount7Choice.InstructedAmount))]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity),
        nameof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity)
    )]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount7Choice.InstructedAmount),
        nameof(SecuritiesQuantityOrAmount7Choice.InstructedAmount)
    )]
    [IsoId("_pizbXzi7Eeydid5dcNPKvg")]
    [DisplayName("Securities Quantity Or Amount 7 Choice")]
    public abstract record SecuritiesQuantityOrAmount7Choice_ { }
}
