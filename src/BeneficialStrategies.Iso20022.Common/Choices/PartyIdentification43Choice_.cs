// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification43Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification43Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification43Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification43Choice.AnyBIC),nameof(PartyIdentification43Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification43Choice.ProprietaryIdentification),nameof(PartyIdentification43Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification43Choice.NameAndAddress),nameof(PartyIdentification43Choice.NameAndAddress))]
    [IsoId("_eadcW-aOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 43 Choice")]
    public abstract partial record PartyIdentification43Choice_
    {
    }
}
