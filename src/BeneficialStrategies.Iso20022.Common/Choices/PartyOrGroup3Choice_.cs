// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Or Group3Choice.
    /// </summary>
    [KnownType(typeof(PartyOrGroup3Choice.GroupIdentification))]
    [KnownType(typeof(PartyOrGroup3Choice.Party))]
    [JsonDerivedType(typeof(PartyOrGroup3Choice.GroupIdentification),nameof(PartyOrGroup3Choice.GroupIdentification))]
    [JsonDerivedType(typeof(PartyOrGroup3Choice.Party),nameof(PartyOrGroup3Choice.Party))]
    [IsoId("_ya3yGTEyEe6g-ffJsqGiSA")]
    [DisplayName("Party Or Group3Choice")]
    public abstract partial record PartyOrGroup3Choice_
    {
    }
}
