// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status19Choice.AffirmationStatus))]
    [KnownType(typeof(Status19Choice.AllocationStatus))]
    [KnownType(typeof(Status19Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status19Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status19Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status19Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status19Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status19Choice.MatchingStatus))]
    [KnownType(typeof(Status19Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status19Choice.ResponseStatus))]
    [KnownType(typeof(Status19Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status19Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status19Choice.SettlementStatus))]
    [KnownType(typeof(Status19Choice.SettlementConditionModificationStatus))]
    [JsonDerivedType(
        typeof(Status19Choice.AffirmationStatus),
        nameof(Status19Choice.AffirmationStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.AllocationStatus),
        nameof(Status19Choice.AllocationStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.RepoCallRequestStatus),
        nameof(Status19Choice.RepoCallRequestStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.CorporateActionEventProcessingStatus),
        nameof(Status19Choice.CorporateActionEventProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.CorporateActionEventStage),
        nameof(Status19Choice.CorporateActionEventStage)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.InferredMatchingStatus),
        nameof(Status19Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.InstructionProcessingStatus),
        nameof(Status19Choice.InstructionProcessingStatus)
    )]
    [JsonDerivedType(typeof(Status19Choice.MatchingStatus), nameof(Status19Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status19Choice.RegistrationProcessingStatus),
        nameof(Status19Choice.RegistrationProcessingStatus)
    )]
    [JsonDerivedType(typeof(Status19Choice.ResponseStatus), nameof(Status19Choice.ResponseStatus))]
    [JsonDerivedType(
        typeof(Status19Choice.ReplacementProcessingStatus),
        nameof(Status19Choice.ReplacementProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.CancellationProcessingStatus),
        nameof(Status19Choice.CancellationProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.SettlementStatus),
        nameof(Status19Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status19Choice.SettlementConditionModificationStatus),
        nameof(Status19Choice.SettlementConditionModificationStatus)
    )]
    [IsoId("_8nU2ETqpEeWyoP0PbocV1Q")]
    [DisplayName("Status 19 Choice")]
    public abstract record Status19Choice_ { }
}
