// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification254Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification254Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification254Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification254Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification254Choice.AnyBIC),
        nameof(PartyIdentification254Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification254Choice.NameAndAddress),
        nameof(PartyIdentification254Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification254Choice.ProprietaryIdentification),
        nameof(PartyIdentification254Choice.ProprietaryIdentification)
    )]
    [IsoId("_20dfx5IOEe-HRNGM304Vlw")]
    [DisplayName("Party Identification254Choice")]
    public abstract record PartyIdentification254Choice_ { }
}
