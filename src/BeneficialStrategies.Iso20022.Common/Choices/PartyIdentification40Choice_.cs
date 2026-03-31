// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification40Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification40Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification40Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification40Choice.AnyBIC),
        nameof(PartyIdentification40Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification40Choice.ProprietaryIdentification),
        nameof(PartyIdentification40Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification40Choice.NameAndAddress),
        nameof(PartyIdentification40Choice.NameAndAddress)
    )]
    [IsoId("_BfsUT_L-Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 40 Choice")]
    public abstract record PartyIdentification40Choice_ { }
}
