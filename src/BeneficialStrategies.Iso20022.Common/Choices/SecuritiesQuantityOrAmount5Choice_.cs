// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount5Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount5Choice.InstructedAmount))]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount5Choice.SecuritiesQuantity),
        nameof(SecuritiesQuantityOrAmount5Choice.SecuritiesQuantity)
    )]
    [JsonDerivedType(
        typeof(SecuritiesQuantityOrAmount5Choice.InstructedAmount),
        nameof(SecuritiesQuantityOrAmount5Choice.InstructedAmount)
    )]
    [IsoId("_qY_3qffREeiNZp_PtLohLw")]
    [DisplayName("Securities Quantity Or Amount 5 Choice")]
    public abstract record SecuritiesQuantityOrAmount5Choice_ { }
}
