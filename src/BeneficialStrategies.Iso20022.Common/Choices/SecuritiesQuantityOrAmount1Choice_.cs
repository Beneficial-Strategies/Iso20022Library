// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount1Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount1Choice.InstructedAmount))]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount1Choice.SecuritiesQuantity),
        nameof(SecuritiesQuantityOrAmount1Choice.SecuritiesQuantity)
    )]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount1Choice.InstructedAmount),
        nameof(SecuritiesQuantityOrAmount1Choice.InstructedAmount)
    )]
    [IsoId("_r_r7QIlXEeavwKddCbm3hg")]
    [DisplayName("Securities Quantity Or Amount 1 Choice")]
    public abstract record SecuritiesQuantityOrAmount1Choice_ { }
}
