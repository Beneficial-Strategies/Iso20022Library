// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource6Choice.Code))]
    [KnownType(typeof(IdentificationSource6Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationSource6Choice.Code), nameof(IdentificationSource6Choice.Code))]
    [JsonDerivedType(typeof(IdentificationSource6Choice.Proprietary), nameof(IdentificationSource6Choice.Proprietary))]
    [IsoId("09420273-6e0b-40f0-b994-3f62f2a474ec")]
    [DisplayName("Identification Source 6 Choice")]
    public abstract record IdentificationSource6Choice_ { }
}
