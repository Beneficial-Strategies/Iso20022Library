// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus20Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("2435a58f-30dc-48b1-9e7e-d107a5562ea7")]
    [DisplayName("Pending Processing Status 20 Choice")]
    [KnownType(typeof(PendingProcessingStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus20Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus20Choice.Reason))]
    public abstract record PendingProcessingStatus20Choice_
    {
    }
}
