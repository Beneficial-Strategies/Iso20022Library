// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification83Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification83Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification83Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification83Choice.AnyBIC),
        nameof(PartyIdentification83Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification83Choice.ProprietaryIdentification),
        nameof(PartyIdentification83Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification83Choice.NameAndAddress),
        nameof(PartyIdentification83Choice.NameAndAddress)
    )]
    [IsoId("_H6bfUC6HEeSQQqw1BT_aMg")]
    [DisplayName("Party Identification 83 Choice")]
    public abstract record PartyIdentification83Choice_ { }
}
