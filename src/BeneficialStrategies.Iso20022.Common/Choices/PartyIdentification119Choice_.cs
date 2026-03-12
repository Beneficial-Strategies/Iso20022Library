// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification119Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification119Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification119Choice.AnyBIC),nameof(PartyIdentification119Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification119Choice.ProprietaryIdentification),nameof(PartyIdentification119Choice.ProprietaryIdentification))]
    [IsoId("_T0GcgYipEeefvMoXmllHqg")]
    [DisplayName("Party Identification 119 Choice")]
    public abstract partial record PartyIdentification119Choice_
    {
    }
}
