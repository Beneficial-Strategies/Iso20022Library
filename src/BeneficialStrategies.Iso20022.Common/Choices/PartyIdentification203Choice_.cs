// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification203Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification203Choice.LEI))]
    [JsonDerivedType(typeof(PartyIdentification203Choice.ProprietaryIdentification),nameof(PartyIdentification203Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification203Choice.LEI),nameof(PartyIdentification203Choice.LEI))]
    [IsoId("_N8PiUFSXEempisJfoIfvvQ")]
    [DisplayName("Party Identification 203 Choice")]
    public abstract partial record PartyIdentification203Choice_
    {
    }
}
