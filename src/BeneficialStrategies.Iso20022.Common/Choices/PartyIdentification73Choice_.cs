// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party by a choice between a BIC or a name and address or an LEI.
    /// </summary>
    [KnownType(typeof(PartyIdentification73Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification73Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification73Choice.PartyIdentification))]
    [JsonDerivedType(typeof(PartyIdentification73Choice.NameAndAddress),nameof(PartyIdentification73Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification73Choice.AnyBIC),nameof(PartyIdentification73Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification73Choice.PartyIdentification),nameof(PartyIdentification73Choice.PartyIdentification))]
    [IsoId("_JJOcQSjIEeKnA5P_jl2DUw")]
    [DisplayName("Party Identification 73 Choice")]
    public abstract partial record PartyIdentification73Choice_
    {
    }
}
