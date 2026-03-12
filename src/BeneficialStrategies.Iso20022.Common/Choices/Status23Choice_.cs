// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status23Choice.Proprietary))]
    [KnownType(typeof(Status23Choice.MatchingStatus))]
    [KnownType(typeof(Status23Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status23Choice.SettlementStatus))]
    [KnownType(typeof(Status23Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status23Choice.Proprietary),nameof(Status23Choice.Proprietary))]
    [JsonDerivedType(typeof(Status23Choice.MatchingStatus),nameof(Status23Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status23Choice.InferredMatchingStatus),nameof(Status23Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status23Choice.SettlementStatus),nameof(Status23Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status23Choice.InstructionProcessingStatus),nameof(Status23Choice.InstructionProcessingStatus))]
    [IsoId("_8VHUK5NLEeWGlc8L7oPDIg")]
    [DisplayName("Status 23 Choice")]
    public abstract partial record Status23Choice_
    {
    }
}
