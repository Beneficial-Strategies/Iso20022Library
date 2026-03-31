// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification176Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification176Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification176Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification176Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification176Choice.AnyBIC),
        nameof(PartyIdentification176Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification176Choice.ProprietaryIdentification),
        nameof(PartyIdentification176Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification176Choice.NameAndAddress),
        nameof(PartyIdentification176Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification176Choice.Country),
        nameof(PartyIdentification176Choice.Country)
    )]
    [IsoId("_43Snp_fWEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 176 Choice")]
    public abstract record PartyIdentification176Choice_ { }
}
