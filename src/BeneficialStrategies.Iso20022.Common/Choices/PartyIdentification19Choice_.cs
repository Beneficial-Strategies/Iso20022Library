// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party by a choice between a BIC or a name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification19Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification19Choice.AnyBIC))]
    [JsonDerivedType(
        typeof(PartyIdentification19Choice.NameAndAddress),
        nameof(PartyIdentification19Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification19Choice.AnyBIC),
        nameof(PartyIdentification19Choice.AnyBIC)
    )]
    [IsoId("_Sp1N6gEcEeCQm6a_G2yO_w_-1229608165")]
    [DisplayName("Party Identification 19 Choice")]
    public abstract record PartyIdentification19Choice_ { }
}
