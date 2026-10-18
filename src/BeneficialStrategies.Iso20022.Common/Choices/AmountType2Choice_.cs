// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IAmountType2Choice"/>
    [KnownType(typeof(AmountType2Choice.InstructedAmount))]
    [KnownType(typeof(AmountType2Choice.EquivalentAmount))]
    [JsonDerivedType(
        typeof(AmountType2Choice.InstructedAmount),
        nameof(AmountType2Choice.InstructedAmount)
    )]
    [JsonDerivedType(
        typeof(AmountType2Choice.EquivalentAmount),
        nameof(AmountType2Choice.EquivalentAmount)
    )]
    [IsoId("_Pxu4jNp-Ed-ak6NoX_4Aeg_-1148058999")]
    [DisplayName("Amount Type 2 Choice")]
    public abstract partial record AmountType2Choice_ { }
}
