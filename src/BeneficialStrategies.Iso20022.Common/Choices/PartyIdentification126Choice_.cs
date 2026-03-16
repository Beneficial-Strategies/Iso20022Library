// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification126Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification126Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification126Choice.AnyBIC),
        nameof(PartyIdentification126Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification126Choice.ProprietaryIdentification),
        nameof(PartyIdentification126Choice.ProprietaryIdentification)
    )]
    [IsoId("_WdhEMWpVEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 126 Choice")]
    public abstract record PartyIdentification126Choice_ { }
}
