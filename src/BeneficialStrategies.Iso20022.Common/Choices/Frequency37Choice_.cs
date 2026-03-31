// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency37Choice.Code))]
    [KnownType(typeof(Frequency37Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency37Choice.Code), nameof(Frequency37Choice.Code))]
    [JsonDerivedType(typeof(Frequency37Choice.Proprietary), nameof(Frequency37Choice.Proprietary))]
    [IsoId("_GlS6w2oFEearR-CA7eRZXQ")]
    [DisplayName("Frequency 37 Choice")]
    public abstract record Frequency37Choice_ { }
}
