// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice structure allowing a credit default swap derivative to be defined.
    /// </summary>
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative))]
    [KnownType(typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative))]
    [JsonDerivedType(
        typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap),
        nameof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwap)
    )]
    [JsonDerivedType(
        typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex),
        nameof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndex)
    )]
    [JsonDerivedType(
        typeof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative),
        nameof(CreditDefaultSwapsDerivative4Choice.SingleNameCreditDefaultSwapDerivative)
    )]
    [JsonDerivedType(
        typeof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative),
        nameof(CreditDefaultSwapsDerivative4Choice.CreditDefaultSwapIndexDerivative)
    )]
    [IsoId("_xH_acSe0Eei12pGEsJIAeQ")]
    [DisplayName("Credit Default Swaps Derivative 4 Choice")]
    public abstract record CreditDefaultSwapsDerivative4Choice_ { }
}
