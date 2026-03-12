// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor, expressed in debtor&apos;s account currency or converted in another currency.
    /// </summary>
    [KnownType(typeof(AmountType1Choice.InstructedAmount))]
    [KnownType(typeof(AmountType1Choice.EquivalentAmount))]
    [JsonDerivedType(typeof(AmountType1Choice.InstructedAmount),nameof(AmountType1Choice.InstructedAmount))]
    [JsonDerivedType(typeof(AmountType1Choice.EquivalentAmount),nameof(AmountType1Choice.EquivalentAmount))]
    [IsoId("_PrUuhtp-Ed-ak6NoX_4Aeg_-1333132724")]
    [DisplayName("Amount Type 1 Choice")]
    public abstract partial record AmountType1Choice_
    {
    }
}
