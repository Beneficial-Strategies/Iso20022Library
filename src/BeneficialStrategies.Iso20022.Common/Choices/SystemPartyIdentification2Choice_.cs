// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an identification of a party or a combination of the responsible party identification and the business identifier.
    /// </summary>
    [KnownType(typeof(SystemPartyIdentification2Choice.OrganisationIdentification))]
    [KnownType(typeof(SystemPartyIdentification2Choice.CombinedIdentification))]
    [JsonDerivedType(typeof(SystemPartyIdentification2Choice.OrganisationIdentification),nameof(SystemPartyIdentification2Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(SystemPartyIdentification2Choice.CombinedIdentification),nameof(SystemPartyIdentification2Choice.CombinedIdentification))]
    [IsoId("_wwhf0Wc-EemvNLufWGIVOQ")]
    [DisplayName("System Party Identification 2 Choice")]
    public abstract partial record SystemPartyIdentification2Choice_
    {
    }
}
