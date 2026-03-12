// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification104Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification104Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification104Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification104Choice.AnyBIC),nameof(PartyIdentification104Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification104Choice.ProprietaryIdentification),nameof(PartyIdentification104Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification104Choice.NameAndAddress),nameof(PartyIdentification104Choice.NameAndAddress))]
    [IsoId("_cdS3mZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 104 Choice")]
    public abstract partial record PartyIdentification104Choice_
    {
    }
}
