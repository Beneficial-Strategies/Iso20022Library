// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IAmountType4Choice"/>
    [KnownType(typeof(AmountType4Choice.InstructedAmount))]
    [KnownType(typeof(AmountType4Choice.EquivalentAmount))]
    [JsonDerivedType(
        typeof(AmountType4Choice.InstructedAmount),
        nameof(AmountType4Choice.InstructedAmount)
    )]
    [JsonDerivedType(
        typeof(AmountType4Choice.EquivalentAmount),
        nameof(AmountType4Choice.EquivalentAmount)
    )]
    [IsoId("__S0AAVkJEeSeLKjZh_lWZw")]
    [DisplayName("Amount Type 4 Choice")]
    public abstract partial record AmountType4Choice_ { }
}
