// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency3Choice.Code))]
    [KnownType(typeof(Frequency3Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency3Choice.Code), nameof(Frequency3Choice.Code))]
    [JsonDerivedType(typeof(Frequency3Choice.Proprietary), nameof(Frequency3Choice.Proprietary))]
    [IsoId("_QvHt09p-Ed-ak6NoX_4Aeg_-1581052955")]
    [DisplayName("Frequency 3 Choice")]
    public abstract record Frequency3Choice_ { }
}
