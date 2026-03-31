// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount4Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount4Choice.InstructedAmount))]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount4Choice.SecuritiesQuantity),
        nameof(SecuritiesQuantityOrAmount4Choice.SecuritiesQuantity)
    )]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount4Choice.InstructedAmount),
        nameof(SecuritiesQuantityOrAmount4Choice.InstructedAmount)
    )]
    [IsoId("_Hvo4mbXQEeiTob_PrFFUxA")]
    [DisplayName("Securities Quantity Or Amount 4 Choice")]
    public abstract record SecuritiesQuantityOrAmount4Choice_ { }
}
