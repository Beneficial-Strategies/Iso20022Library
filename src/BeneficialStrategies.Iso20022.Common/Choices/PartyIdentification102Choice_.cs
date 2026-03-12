// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation using a choice between a BIC or the name and addres or the country code.
    /// </summary>
    [KnownType(typeof(PartyIdentification102Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification102Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification102Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification102Choice.AnyBIC),nameof(PartyIdentification102Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification102Choice.NameAndAddress),nameof(PartyIdentification102Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification102Choice.Country),nameof(PartyIdentification102Choice.Country))]
    [IsoId("_JIXkAYbCEeWguotXa4lFgg")]
    [DisplayName("Party Identification 102 Choice")]
    public abstract partial record PartyIdentification102Choice_
    {
    }
}
