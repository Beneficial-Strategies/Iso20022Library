// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [KnownType(typeof(AmountType3Choice.InstructedAmount))]
    [KnownType(typeof(AmountType3Choice.EquivalentAmount))]
    [JsonDerivedType(
        typeof(AmountType3Choice.InstructedAmount),
        nameof(AmountType3Choice.InstructedAmount)
    )]
    [JsonDerivedType(
        typeof(AmountType3Choice.EquivalentAmount),
        nameof(AmountType3Choice.EquivalentAmount)
    )]
    [IsoId("_P57LMNp-Ed-ak6NoX_4Aeg_326234878")]
    [DisplayName("Amount Type 3 Choice")]
    public abstract record AmountType3Choice_ { }
}
