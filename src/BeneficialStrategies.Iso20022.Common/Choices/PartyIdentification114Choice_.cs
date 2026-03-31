// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification114Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification114Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification114Choice.AnyBIC),
        nameof(PartyIdentification114Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification114Choice.ProprietaryIdentification),
        nameof(PartyIdentification114Choice.ProprietaryIdentification)
    )]
    [IsoId("_W0FdgZjTEeW1SPbGMCLIOQ")]
    [DisplayName("Party Identification 114 Choice")]
    public abstract record PartyIdentification114Choice_ { }
}
