// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status8Choice.AffirmationStatus),nameof(Status8Choice.AffirmationStatus))]
    [JsonDerivedType(typeof(Status8Choice.AllocationStatus),nameof(Status8Choice.AllocationStatus))]
    [JsonDerivedType(typeof(Status8Choice.RepoCallRequestStatus),nameof(Status8Choice.RepoCallRequestStatus))]
    [JsonDerivedType(typeof(Status8Choice.CorporateActionEventProcessingStatus),nameof(Status8Choice.CorporateActionEventProcessingStatus))]
    [JsonDerivedType(typeof(Status8Choice.CorporateActionEventStage),nameof(Status8Choice.CorporateActionEventStage))]
    [JsonDerivedType(typeof(Status8Choice.InferredMatchingStatus),nameof(Status8Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status8Choice.InstructionProcessingStatus),nameof(Status8Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status8Choice.MatchingStatus),nameof(Status8Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status8Choice.RegistrationProcessingStatus),nameof(Status8Choice.RegistrationProcessingStatus))]
    [JsonDerivedType(typeof(Status8Choice.ResponseStatus),nameof(Status8Choice.ResponseStatus))]
    [JsonDerivedType(typeof(Status8Choice.ReplacementProcessingStatus),nameof(Status8Choice.ReplacementProcessingStatus))]
    [JsonDerivedType(typeof(Status8Choice.CancellationProcessingStatus),nameof(Status8Choice.CancellationProcessingStatus))]
    [JsonDerivedType(typeof(Status8Choice.SettlementStatus),nameof(Status8Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status8Choice.SettlementConditionModificationStatus),nameof(Status8Choice.SettlementConditionModificationStatus))]
    #endif
    [IsoId("_w2B7YUABEeCaq78Ig8ATcA")]
    [DisplayName("Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status8Choice_
    #else
    public abstract partial class Status8Choice_
    #endif
    {
    }
}
