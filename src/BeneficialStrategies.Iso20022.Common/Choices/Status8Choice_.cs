// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status8Choice.AffirmationStatus))]
    [KnownType(typeof(Status8Choice.AllocationStatus))]
    [KnownType(typeof(Status8Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status8Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status8Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status8Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status8Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status8Choice.MatchingStatus))]
    [KnownType(typeof(Status8Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status8Choice.ResponseStatus))]
    [KnownType(typeof(Status8Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status8Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status8Choice.SettlementStatus))]
    [KnownType(typeof(Status8Choice.SettlementConditionModificationStatus))]
    [JsonDerivedType(
        typeof(Status8Choice.AffirmationStatus),
        nameof(Status8Choice.AffirmationStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.AllocationStatus),
        nameof(Status8Choice.AllocationStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.RepoCallRequestStatus),
        nameof(Status8Choice.RepoCallRequestStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.CorporateActionEventProcessingStatus),
        nameof(Status8Choice.CorporateActionEventProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.CorporateActionEventStage),
        nameof(Status8Choice.CorporateActionEventStage)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.InferredMatchingStatus),
        nameof(Status8Choice.InferredMatchingStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.InstructionProcessingStatus),
        nameof(Status8Choice.InstructionProcessingStatus)
    )]
    [JsonDerivedType(typeof(Status8Choice.MatchingStatus), nameof(Status8Choice.MatchingStatus))]
    [JsonDerivedType(
        typeof(Status8Choice.RegistrationProcessingStatus),
        nameof(Status8Choice.RegistrationProcessingStatus)
    )]
    [JsonDerivedType(typeof(Status8Choice.ResponseStatus), nameof(Status8Choice.ResponseStatus))]
    [JsonDerivedType(
        typeof(Status8Choice.ReplacementProcessingStatus),
        nameof(Status8Choice.ReplacementProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.CancellationProcessingStatus),
        nameof(Status8Choice.CancellationProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.SettlementStatus),
        nameof(Status8Choice.SettlementStatus)
    )]
    [JsonDerivedType(
        typeof(Status8Choice.SettlementConditionModificationStatus),
        nameof(Status8Choice.SettlementConditionModificationStatus)
    )]
    [IsoId("_w2B7YUABEeCaq78Ig8ATcA")]
    [DisplayName("Status 8 Choice")]
    public abstract record Status8Choice_ { }
}
