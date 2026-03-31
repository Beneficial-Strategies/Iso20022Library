// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification36Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification36Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification36Choice.AnyBIC),
        nameof(PartyIdentification36Choice.AnyBIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification36Choice.ProprietaryIdentification),
        nameof(PartyIdentification36Choice.ProprietaryIdentification)
    )]
    [IsoId("_qU9DBeaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 36 Choice")]
    public abstract record PartyIdentification36Choice_ { }
}
