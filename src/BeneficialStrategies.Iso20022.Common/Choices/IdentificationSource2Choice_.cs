// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proprietary or domestic identification scheme that uniquely identifies a security.
    /// </summary>
    [KnownType(typeof(IdentificationSource2Choice.Domestic))]
    [KnownType(typeof(IdentificationSource2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationSource2Choice.Domestic),
        nameof(IdentificationSource2Choice.Domestic)
    )]
    [JsonDerivedType(
        typeof(IdentificationSource2Choice.Proprietary),
        nameof(IdentificationSource2Choice.Proprietary)
    )]
    [IsoId("_XKZIItp-Ed-ak6NoX_4Aeg_-2009895273")]
    [DisplayName("Identification Source 2 Choice")]
    public abstract record IdentificationSource2Choice_ { }
}
