// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Currency Or Digital Token Amount2Choice.
    /// </summary>
    [KnownType(typeof(CurrencyOrDigitalTokenAmount2Choice.Amount))]
    [KnownType(typeof(CurrencyOrDigitalTokenAmount2Choice.DigitalTokenAmount))]
    [JsonDerivedType(
        typeof(CurrencyOrDigitalTokenAmount2Choice.Amount),
        nameof(CurrencyOrDigitalTokenAmount2Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(CurrencyOrDigitalTokenAmount2Choice.DigitalTokenAmount),
        nameof(CurrencyOrDigitalTokenAmount2Choice.DigitalTokenAmount)
    )]
    [IsoId("_jqWwgUj3Ee-KhcStGV4xTg")]
    [DisplayName("Currency Or Digital Token Amount2Choice")]
    public abstract record CurrencyOrDigitalTokenAmount2Choice_ { }
}
