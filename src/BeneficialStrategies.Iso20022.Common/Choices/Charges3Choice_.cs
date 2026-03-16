// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Charges3Choice.
    /// </summary>
    [KnownType(typeof(Charges3Choice.PerTransaction))]
    [KnownType(typeof(Charges3Choice.PerType))]
    [KnownType(typeof(Charges3Choice.Single))]
    [JsonDerivedType(typeof(Charges3Choice.PerTransaction),nameof(Charges3Choice.PerTransaction))]
    [JsonDerivedType(typeof(Charges3Choice.PerType),nameof(Charges3Choice.PerType))]
    [JsonDerivedType(typeof(Charges3Choice.Single),nameof(Charges3Choice.Single))]
    [IsoId("_4A_GATEyEe6g-ffJsqGiSA")]
    [DisplayName("Charges3Choice")]
    public abstract partial record Charges3Choice_
    {
    }
}
