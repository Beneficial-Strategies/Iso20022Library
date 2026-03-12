// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification44Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification44Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification44Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification44Choice.AnyBIC),nameof(PartyIdentification44Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification44Choice.NameAndAddress),nameof(PartyIdentification44Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification44Choice.Country),nameof(PartyIdentification44Choice.Country))]
    [IsoId("_Rpl8aeaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 44 Choice")]
    public abstract partial record PartyIdentification44Choice_
    {
    }
}
