// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification145Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification145Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification145Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification145Choice.AnyBIC),
        nameof(PartyIdentification145Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification145Choice.NameAndAddress),
        nameof(PartyIdentification145Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification145Choice.Country),
        nameof(PartyIdentification145Choice.Country)
    )]
    [IsoId("_6slou_fVEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 145 Choice")]
    public abstract record PartyIdentification145Choice_ { }
}
