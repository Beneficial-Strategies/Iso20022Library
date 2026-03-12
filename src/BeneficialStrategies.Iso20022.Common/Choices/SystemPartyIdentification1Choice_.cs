// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an identification of a party or a combination of the responsible party identification and the business identifier.
    /// </summary>
    [KnownType(typeof(SystemPartyIdentification1Choice.OrganisationIdentification))]
    [KnownType(typeof(SystemPartyIdentification1Choice.CombinedIdentification))]
    [JsonDerivedType(typeof(SystemPartyIdentification1Choice.OrganisationIdentification),nameof(SystemPartyIdentification1Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(SystemPartyIdentification1Choice.CombinedIdentification),nameof(SystemPartyIdentification1Choice.CombinedIdentification))]
    [IsoId("_jBdh8u5NEeCisYr99QEiWA_-33298024")]
    [DisplayName("System Party Identification 1 Choice")]
    public abstract partial record SystemPartyIdentification1Choice_
    {
    }
}
