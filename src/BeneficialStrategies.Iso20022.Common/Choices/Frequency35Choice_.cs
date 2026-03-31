// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency35Choice.Code))]
    [KnownType(typeof(Frequency35Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency35Choice.Code), nameof(Frequency35Choice.Code))]
    [JsonDerivedType(typeof(Frequency35Choice.Proprietary), nameof(Frequency35Choice.Proprietary))]
    [IsoId("_AAc8MeLaEeWFtOV72FbX9w")]
    [DisplayName("Frequency 35 Choice")]
    public abstract record Frequency35Choice_ { }
}
