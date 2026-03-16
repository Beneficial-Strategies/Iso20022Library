// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification32Choice.BIC))]
    [KnownType(typeof(PartyIdentification32Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification32Choice.NameAndAddress))]
    [JsonDerivedType(
        typeof(PartyIdentification32Choice.BIC),
        nameof(PartyIdentification32Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification32Choice.ProprietaryIdentification),
        nameof(PartyIdentification32Choice.ProprietaryIdentification)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification32Choice.NameAndAddress),
        nameof(PartyIdentification32Choice.NameAndAddress)
    )]
    [IsoId("_AUVtwdokEeC60axPepSq7g_2140402987")]
    [DisplayName("Party Identification 32 Choice")]
    public abstract record PartyIdentification32Choice_ { }
}
