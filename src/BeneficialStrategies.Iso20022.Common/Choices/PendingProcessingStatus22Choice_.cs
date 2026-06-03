// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus22Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("_g_04QKoZEfCG2_q2WT-90w")]
    [DisplayName("Pending Processing Status 22 Choice")]
    [KnownType(typeof(PendingProcessingStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus22Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus22Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus22Choice.Reason))]
    public abstract record PendingProcessingStatus22Choice_
    {
    }
}
