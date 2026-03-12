// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status30Choice.Proprietary))]
    [KnownType(typeof(Status30Choice.MatchingStatus))]
    [KnownType(typeof(Status30Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status30Choice.SettlementStatus))]
    [KnownType(typeof(Status30Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status30Choice.Proprietary),nameof(Status30Choice.Proprietary))]
    [JsonDerivedType(typeof(Status30Choice.MatchingStatus),nameof(Status30Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status30Choice.InferredMatchingStatus),nameof(Status30Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status30Choice.SettlementStatus),nameof(Status30Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status30Choice.InstructionProcessingStatus),nameof(Status30Choice.InstructionProcessingStatus))]
    [IsoId("_iE4L6ffZEeiNZp_PtLohLw")]
    [DisplayName("Status 30 Choice")]
    public abstract partial record Status30Choice_
    {
    }
}
