// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
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
    public abstract record AmountType4Choice_ { }
}
