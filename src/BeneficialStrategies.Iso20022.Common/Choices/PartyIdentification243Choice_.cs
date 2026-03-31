// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification243Choice.BIC))]
    [KnownType(typeof(PartyIdentification243Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification243Choice.BIC),
        nameof(PartyIdentification243Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification243Choice.ProprietaryIdentification),
        nameof(PartyIdentification243Choice.ProprietaryIdentification)
    )]
    [IsoId("_vOLN0QauEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 243 Choice")]
    public abstract record PartyIdentification243Choice_ { }
}
