// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification71Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification71Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification71Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification71Choice.AnyBIC),
        nameof(PartyIdentification71Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification71Choice.ProprietaryIdentification),
        nameof(PartyIdentification71Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification71Choice.NameAndAddress),
        nameof(PartyIdentification71Choice.NameAndAddress)
    )]
    [IsoId("_jLJCYe5NEeCisYr99QEiWA_-835354834")]
    [DisplayName("Party Identification 71 Choice")]
    public abstract record PartyIdentification71Choice_ { }
}
