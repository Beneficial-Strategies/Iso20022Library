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
    [KnownType(typeof(Status1Choice.AffirmationStatus))]
    [KnownType(typeof(Status1Choice.AllocationStatus))]
    [KnownType(typeof(Status1Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status1Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status1Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status1Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status1Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status1Choice.MatchingStatus))]
    [KnownType(typeof(Status1Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status1Choice.ResponseStatus))]
    [KnownType(typeof(Status1Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status1Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status1Choice.SettlementStatus))]
    [KnownType(typeof(Status1Choice.SettlementConditionModificationStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status1Choice.AffirmationStatus),nameof(Status1Choice.AffirmationStatus))]
    [JsonDerivedType(typeof(Status1Choice.AllocationStatus),nameof(Status1Choice.AllocationStatus))]
    [JsonDerivedType(typeof(Status1Choice.RepoCallRequestStatus),nameof(Status1Choice.RepoCallRequestStatus))]
    [JsonDerivedType(typeof(Status1Choice.CorporateActionEventProcessingStatus),nameof(Status1Choice.CorporateActionEventProcessingStatus))]
    [JsonDerivedType(typeof(Status1Choice.CorporateActionEventStage),nameof(Status1Choice.CorporateActionEventStage))]
    [JsonDerivedType(typeof(Status1Choice.InferredMatchingStatus),nameof(Status1Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status1Choice.InstructionProcessingStatus),nameof(Status1Choice.InstructionProcessingStatus))]
    [JsonDerivedType(typeof(Status1Choice.MatchingStatus),nameof(Status1Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status1Choice.RegistrationProcessingStatus),nameof(Status1Choice.RegistrationProcessingStatus))]
    [JsonDerivedType(typeof(Status1Choice.ResponseStatus),nameof(Status1Choice.ResponseStatus))]
    [JsonDerivedType(typeof(Status1Choice.ReplacementProcessingStatus),nameof(Status1Choice.ReplacementProcessingStatus))]
    [JsonDerivedType(typeof(Status1Choice.CancellationProcessingStatus),nameof(Status1Choice.CancellationProcessingStatus))]
    [JsonDerivedType(typeof(Status1Choice.SettlementStatus),nameof(Status1Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status1Choice.SettlementConditionModificationStatus),nameof(Status1Choice.SettlementConditionModificationStatus))]
    #endif
    [IsoId("_UU5hs9p-Ed-ak6NoX_4Aeg_1668372789")]
    [DisplayName("Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status1Choice_
    #else
    public abstract partial class Status1Choice_
    #endif
    {
    }
}
