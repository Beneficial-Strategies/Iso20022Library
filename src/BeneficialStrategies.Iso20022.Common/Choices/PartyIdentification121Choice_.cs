// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification121Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification121Choice.LegalEntityIdentifier))]
    [KnownType(typeof(PartyIdentification121Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification121Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.AnyBIC),nameof(PartyIdentification121Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.LegalEntityIdentifier),nameof(PartyIdentification121Choice.LegalEntityIdentifier))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.NameAndAddress),nameof(PartyIdentification121Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification121Choice.ProprietaryIdentification),nameof(PartyIdentification121Choice.ProprietaryIdentification))]
    [IsoId("_c7VdkJQVEeiok48Eh9lW9Q")]
    [DisplayName("Party Identification 121 Choice")]
    public abstract partial record PartyIdentification121Choice_
    {
    }
}
