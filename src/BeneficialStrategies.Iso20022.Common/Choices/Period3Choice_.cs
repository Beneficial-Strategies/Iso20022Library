// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a period or a period code.
    /// </summary>
    [KnownType(typeof(Period3Choice.Period))]
    [KnownType(typeof(Period3Choice.PeriodCode))]
    [JsonDerivedType(typeof(Period3Choice.Period), nameof(Period3Choice.Period))]
    [JsonDerivedType(typeof(Period3Choice.PeriodCode), nameof(Period3Choice.PeriodCode))]
    [IsoId("_Nt3jceENEd-qUMZtd_eZuQ")]
    [DisplayName("Period 3 Choice")]
    public abstract record Period3Choice_ { }
}
