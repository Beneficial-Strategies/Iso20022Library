// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification137Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification137Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification137Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification137Choice.AnyBIC),
        nameof(PartyIdentification137Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification137Choice.ProprietaryIdentification),
        nameof(PartyIdentification137Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification137Choice.NameAndAddress),
        nameof(PartyIdentification137Choice.NameAndAddress)
    )]
    [IsoId("__2ajK_fDEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 137 Choice")]
    public abstract record PartyIdentification137Choice_ { }
}
