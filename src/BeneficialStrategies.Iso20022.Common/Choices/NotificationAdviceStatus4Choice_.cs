// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus4Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Provides the status of a notification advice.</summary>
    [IsoId("_4sPMkaUeEfCnE_wCEfCqTA")]
    [DisplayName("Notification Advice Status 4 Choice")]
    [KnownType(typeof(ProcessedStatus))]
    [JsonDerivedType(typeof(ProcessedStatus), nameof(ProcessedStatus))]
    [KnownType(typeof(RejectedStatus))]
    [JsonDerivedType(typeof(RejectedStatus), nameof(RejectedStatus))]
    [KnownType(typeof(PendingStatus))]
    [JsonDerivedType(typeof(PendingStatus), nameof(PendingStatus))]
    [KnownType(typeof(AcceptedWithWarningStatus))]
    [JsonDerivedType(typeof(AcceptedWithWarningStatus), nameof(AcceptedWithWarningStatus))]
    public abstract record NotificationAdviceStatus4Choice_;
}
