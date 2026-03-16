// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification255Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification255Choice.BIC))]
    [KnownType(typeof(PartyIdentification255Choice.Country))]
    [KnownType(typeof(PartyIdentification255Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification255Choice.BIC),
        nameof(PartyIdentification255Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification255Choice.Country),
        nameof(PartyIdentification255Choice.Country)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification255Choice.NameAndAddress),
        nameof(PartyIdentification255Choice.NameAndAddress)
    )]
    [IsoId("_thqCEZIPEe-HRNGM304Vlw")]
    [DisplayName("Party Identification255Choice")]
    public abstract record PartyIdentification255Choice_ { }
}
