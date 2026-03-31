// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proprietary or domestic identification scheme that uniquely identifies a security.
    /// </summary>
    [KnownType(typeof(IdentificationSource1Choice.Domestic))]
    [KnownType(typeof(IdentificationSource1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationSource1Choice.Domestic),
        nameof(IdentificationSource1Choice.Domestic)
    )]
    [JsonDerivedType(
        typeof(IdentificationSource1Choice.Proprietary),
        nameof(IdentificationSource1Choice.Proprietary)
    )]
    [IsoId("_RCMa1Np-Ed-ak6NoX_4Aeg_-823222621")]
    [DisplayName("Identification Source 1 Choice")]
    public abstract record IdentificationSource1Choice_ { }
}
