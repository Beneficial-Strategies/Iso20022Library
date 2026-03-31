// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat20Choice.Rate))]
    [KnownType(typeof(RateFormat20Choice.Amount))]
    [KnownType(typeof(RateFormat20Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat20Choice.Rate), nameof(RateFormat20Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat20Choice.Amount), nameof(RateFormat20Choice.Amount))]
    [JsonDerivedType(
        typeof(RateFormat20Choice.NotSpecifiedRate),
        nameof(RateFormat20Choice.NotSpecifiedRate)
    )]
    [IsoId("_CpHdYUENEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Format 20 Choice")]
    public abstract record RateFormat20Choice_ { }
}
