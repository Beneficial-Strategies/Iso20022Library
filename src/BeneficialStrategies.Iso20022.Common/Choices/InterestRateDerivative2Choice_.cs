// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice element specifying the underlying types of an interest rate derivative.
    /// </summary>
    [KnownType(typeof(InterestRateDerivative2Choice.SwapRelated))]
    [KnownType(typeof(InterestRateDerivative2Choice.Other))]
    [JsonDerivedType(
        typeof(InterestRateDerivative2Choice.SwapRelated),
        nameof(InterestRateDerivative2Choice.SwapRelated)
    )]
    [JsonDerivedType(
        typeof(InterestRateDerivative2Choice.Other),
        nameof(InterestRateDerivative2Choice.Other)
    )]
    [IsoId("_xSfx_WlIEeaLAKoEUNsD9g")]
    [DisplayName("Interest Rate Derivative 2 Choice")]
    public abstract record InterestRateDerivative2Choice_ { }
}
