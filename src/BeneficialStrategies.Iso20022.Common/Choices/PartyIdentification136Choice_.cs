// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification136Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification136Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification136Choice.AnyBIC),nameof(PartyIdentification136Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification136Choice.ProprietaryIdentification),nameof(PartyIdentification136Choice.ProprietaryIdentification))]
    [IsoId("__2Yt9ffDEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 136 Choice")]
    public abstract partial record PartyIdentification136Choice_
    {
    }
}
