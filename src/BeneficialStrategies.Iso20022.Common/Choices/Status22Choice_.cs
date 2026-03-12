// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status22Choice.AffirmationStatus))]
    [KnownType(typeof(Status22Choice.AllocationStatus))]
    [KnownType(typeof(Status22Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status22Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status22Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status22Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status22Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status22Choice.MatchingStatus))]
    [KnownType(typeof(Status22Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status22Choice.ResponseStatus))]
    [KnownType(typeof(Status22Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status22Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status22Choice.SettlementStatus))]
    [KnownType(typeof(Status22Choice.SettlementConditionModificationStatus))]
    [JsonDerivedType(typeof(Status22Choice.AffirmationStatus),nameof(Status22Choice.AffirmationStatus))]
    [JsonDerivedType(typeof(Status22Choice.AllocationStatus),nameof(Status22Choice.AllocationStatus))]
    [JsonDerivedType(typeof(Status22Choice.RepoCallRequestStatus),nameof(Status22Choice.RepoCallRequestStatus))]
    [JsonDerivedType(typeof(Status22Choice.CorporateActionEventProcessingStatus),nameof(Status22Choice.CorporateActionEventProcessingStatus))]
    [JsonDerivedType(typeof(Status22Choice.CorporateActionEventStage),nameof(Status22Choice.CorporateActionEventStage))]
    [JsonDerivedType(typeof(Status22Choice.InferredMatchingStatus),nameof(Status22Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status22Choice.InstructionProcessingStatus),nameof(Status22Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status22Choice.MatchingStatus),nameof(Status22Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status22Choice.RegistrationProcessingStatus),nameof(Status22Choice.RegistrationProcessingStatus))]
    [JsonDerivedType(typeof(Status22Choice.ResponseStatus),nameof(Status22Choice.ResponseStatus))]
    [JsonDerivedType(typeof(Status22Choice.ReplacementProcessingStatus),nameof(Status22Choice.ReplacementProcessingStatus))]
    [JsonDerivedType(typeof(Status22Choice.CancellationProcessingStatus),nameof(Status22Choice.CancellationProcessingStatus))]
    [JsonDerivedType(typeof(Status22Choice.SettlementStatus),nameof(Status22Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status22Choice.SettlementConditionModificationStatus),nameof(Status22Choice.SettlementConditionModificationStatus))]
    [IsoId("_8QboH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Status 22 Choice")]
    public abstract partial record Status22Choice_
    {
    }
}
