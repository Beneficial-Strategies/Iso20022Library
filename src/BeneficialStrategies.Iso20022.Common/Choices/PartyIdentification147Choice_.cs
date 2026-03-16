// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification147Choice.BICFI))]
    [KnownType(typeof(PartyIdentification147Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification147Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification147Choice.BICFI),
        nameof(PartyIdentification147Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification147Choice.NameAndAddress),
        nameof(PartyIdentification147Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification147Choice.ProprietaryIdentification),
        nameof(PartyIdentification147Choice.ProprietaryIdentification)
    )]
    [IsoId("_8GnIGffREeiNZp_PtLohLw")]
    [DisplayName("Party Identification 147 Choice")]
    public abstract record PartyIdentification147Choice_ { }
}
