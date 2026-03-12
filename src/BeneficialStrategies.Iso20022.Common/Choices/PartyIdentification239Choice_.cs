// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation using a choice between a BIC or the name and addres or the country code.
    /// </summary>
    [KnownType(typeof(PartyIdentification239Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification239Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification239Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification239Choice.AnyBIC),nameof(PartyIdentification239Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification239Choice.NameAndAddress),nameof(PartyIdentification239Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification239Choice.Country),nameof(PartyIdentification239Choice.Country))]
    [IsoId("_dT1SEStKEeyOa655cLd-DQ")]
    [DisplayName("Party Identification 239 Choice")]
    public abstract partial record PartyIdentification239Choice_
    {
    }
}
