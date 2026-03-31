// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency4Choice.Code))]
    [KnownType(typeof(Frequency4Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency4Choice.Code), nameof(Frequency4Choice.Code))]
    [JsonDerivedType(typeof(Frequency4Choice.Proprietary), nameof(Frequency4Choice.Proprietary))]
    [IsoId("_QxXJitp-Ed-ak6NoX_4Aeg_-163463652")]
    [DisplayName("Frequency 4 Choice")]
    public abstract record Frequency4Choice_ { }
}
