// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount6Choice.InstructedAmount))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity),nameof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount6Choice.InstructedAmount),nameof(SecuritiesQuantityOrAmount6Choice.InstructedAmount))]
    [IsoId("_Np2b7RuyEeyhRdHRjakS2w")]
    [DisplayName("Securities Quantity Or Amount 6 Choice")]
    public abstract partial record SecuritiesQuantityOrAmount6Choice_
    {
    }
}
