// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification133Choice.BICFI))]
    [KnownType(typeof(PartyIdentification133Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification133Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification133Choice.BICFI),nameof(PartyIdentification133Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification133Choice.NameAndAddress),nameof(PartyIdentification133Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification133Choice.ProprietaryIdentification),nameof(PartyIdentification133Choice.ProprietaryIdentification))]
    [IsoId("_HoinrdXWEeiN28wlpBQScw")]
    [DisplayName("Party Identification 133 Choice")]
    public abstract partial record PartyIdentification133Choice_
    {
    }
}
