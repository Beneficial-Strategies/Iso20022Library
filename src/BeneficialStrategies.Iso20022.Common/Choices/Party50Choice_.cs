// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party50Choice.
    /// </summary>
    [KnownType(typeof(Party50Choice.Agent))]
    [KnownType(typeof(Party50Choice.Party))]
    [JsonDerivedType(typeof(Party50Choice.Agent),nameof(Party50Choice.Agent))]
    [JsonDerivedType(typeof(Party50Choice.Party),nameof(Party50Choice.Party))]
    [IsoId("_vqulsTEyEe6g-ffJsqGiSA")]
    [DisplayName("Party50Choice")]
    public abstract partial record Party50Choice_
    {
    }
}
