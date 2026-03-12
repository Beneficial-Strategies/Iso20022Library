// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount3Choice.InstructedAmount))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity),nameof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount3Choice.InstructedAmount),nameof(SecuritiesQuantityOrAmount3Choice.InstructedAmount))]
    [IsoId("_nRxjkdNPEee-r40DhxXRmg")]
    [DisplayName("Securities Quantity Or Amount 3 Choice")]
    public abstract partial record SecuritiesQuantityOrAmount3Choice_
    {
    }
}
