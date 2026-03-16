// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat6Choice.Rate))]
    [KnownType(typeof(RateFormat6Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat6Choice.Rate), nameof(RateFormat6Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat6Choice.NotSpecifiedRate),
        nameof(RateFormat6Choice.NotSpecifiedRate)
    )]
    [IsoId("_PO4fIOwOEd-sn-FiNtktcA")]
    [DisplayName("Rate Format 6 Choice")]
    public abstract record RateFormat6Choice_ { }
}
