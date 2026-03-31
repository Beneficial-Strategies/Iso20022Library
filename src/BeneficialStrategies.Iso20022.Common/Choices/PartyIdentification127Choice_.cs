// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification127Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification127Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification127Choice.AnyBIC),
        nameof(PartyIdentification127Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification127Choice.ProprietaryIdentification),
        nameof(PartyIdentification127Choice.ProprietaryIdentification)
    )]
    [IsoId("_Y-_MD7XDEeiTob_PrFFUxA")]
    [DisplayName("Party Identification 127 Choice")]
    public abstract record PartyIdentification127Choice_ { }
}
