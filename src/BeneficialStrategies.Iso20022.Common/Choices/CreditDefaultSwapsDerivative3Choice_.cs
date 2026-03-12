// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice structure allowing a credit default swap derivative to be defined.
    /// </summary>
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative))]
    [KnownType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap),nameof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwap))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex),nameof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndex))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative),nameof(CreditDefaultSwapsDerivative3Choice.SingleNameCreditDefaultSwapDerivative))]
    [JsonDerivedType(typeof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative),nameof(CreditDefaultSwapsDerivative3Choice.CreditDefaultSwapIndexDerivative))]
    [IsoId("_xTXs0X5eEea2k7EBUopqxw")]
    [DisplayName("Credit Default Swaps Derivative 3 Choice")]
    public abstract partial record CreditDefaultSwapsDerivative3Choice_
    {
    }
}
