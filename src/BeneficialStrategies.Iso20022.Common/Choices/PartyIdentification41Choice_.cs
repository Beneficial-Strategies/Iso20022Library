// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification41Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification41Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification41Choice.AnyBIC),nameof(PartyIdentification41Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification41Choice.ProprietaryIdentification),nameof(PartyIdentification41Choice.ProprietaryIdentification))]
    [IsoId("_ZZ4cgfL-Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 41 Choice")]
    public abstract partial record PartyIdentification41Choice_
    {
    }
}
