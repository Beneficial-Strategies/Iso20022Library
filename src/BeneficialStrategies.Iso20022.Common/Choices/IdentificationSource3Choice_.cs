// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource3Choice.Code))]
    [KnownType(typeof(IdentificationSource3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationSource3Choice.Code),
        nameof(IdentificationSource3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationSource3Choice.Proprietary),
        nameof(IdentificationSource3Choice.Proprietary)
    )]
    [IsoId("_QmL0Sdp-Ed-ak6NoX_4Aeg_12523031")]
    [DisplayName("Identification Source 3 Choice")]
    public abstract record IdentificationSource3Choice_ { }
}
