// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a choice between one party or a group of parties.
    /// </summary>
    [KnownType(typeof(PartyOrGroup2Choice.GroupIdentification))]
    [KnownType(typeof(PartyOrGroup2Choice.Party))]
    [JsonDerivedType(typeof(PartyOrGroup2Choice.GroupIdentification),nameof(PartyOrGroup2Choice.GroupIdentification))]
    [JsonDerivedType(typeof(PartyOrGroup2Choice.Party),nameof(PartyOrGroup2Choice.Party))]
    [IsoId("_C3Ccd249EeiU9cctagi5ow")]
    [DisplayName("Party Or Group 2 Choice")]
    public abstract partial record PartyOrGroup2Choice_
    {
    }
}
