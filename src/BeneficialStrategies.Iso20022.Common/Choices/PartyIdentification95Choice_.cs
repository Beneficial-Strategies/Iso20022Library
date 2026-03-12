// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification95Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification95Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification95Choice.AnyBIC),nameof(PartyIdentification95Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification95Choice.ProprietaryIdentification),nameof(PartyIdentification95Choice.ProprietaryIdentification))]
    [IsoId("_VyhSAZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Party Identification 95 Choice")]
    public abstract partial record PartyIdentification95Choice_
    {
    }
}
