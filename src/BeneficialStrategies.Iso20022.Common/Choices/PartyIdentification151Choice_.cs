// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification151Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification151Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification151Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification151Choice.LEI))]
    [JsonDerivedType(
        typeof(PartyIdentification151Choice.AnyBIC),
        nameof(PartyIdentification151Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification151Choice.ProprietaryIdentification),
        nameof(PartyIdentification151Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification151Choice.NameAndAddress),
        nameof(PartyIdentification151Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification151Choice.LEI),
        nameof(PartyIdentification151Choice.LEI)
    )]
    [IsoId("_ctD2W_fSEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 151 Choice")]
    public abstract record PartyIdentification151Choice_ { }
}
