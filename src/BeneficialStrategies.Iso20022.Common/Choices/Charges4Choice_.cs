// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Charges4Choice.
    /// </summary>
    [KnownType(typeof(Charges4Choice.PerTransaction))]
    [KnownType(typeof(Charges4Choice.PerType))]
    [KnownType(typeof(Charges4Choice.Single))]
    [JsonDerivedType(typeof(Charges4Choice.PerTransaction), nameof(Charges4Choice.PerTransaction))]
    [JsonDerivedType(typeof(Charges4Choice.PerType), nameof(Charges4Choice.PerType))]
    [JsonDerivedType(typeof(Charges4Choice.Single), nameof(Charges4Choice.Single))]
    [IsoId("_58rWoTEyEe6g-ffJsqGiSA")]
    [DisplayName("Charges4Choice")]
    public abstract record Charges4Choice_ { }
}
