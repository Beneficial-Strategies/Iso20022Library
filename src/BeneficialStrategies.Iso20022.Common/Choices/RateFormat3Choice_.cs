// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat3Choice.Rate))]
    [KnownType(typeof(RateFormat3Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat3Choice.Rate), nameof(RateFormat3Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat3Choice.NotSpecifiedRate),
        nameof(RateFormat3Choice.NotSpecifiedRate)
    )]
    [IsoId("_UPO-ltp-Ed-ak6NoX_4Aeg_681666773")]
    [DisplayName("Rate Format 3 Choice")]
    public abstract record RateFormat3Choice_ { }
}
