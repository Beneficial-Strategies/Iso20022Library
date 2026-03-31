// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of rate formats.
    /// </summary>
    [KnownType(typeof(AmountAndRateFormat2Choice.Amount))]
    [KnownType(typeof(AmountAndRateFormat2Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(AmountAndRateFormat2Choice.Amount),
        nameof(AmountAndRateFormat2Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(AmountAndRateFormat2Choice.NotSpecifiedRate),
        nameof(AmountAndRateFormat2Choice.NotSpecifiedRate)
    )]
    [IsoId("_UH8Dydp-Ed-ak6NoX_4Aeg_568622010")]
    [DisplayName("Amount And Rate Format 2 Choice")]
    public abstract record AmountAndRateFormat2Choice_ { }
}
