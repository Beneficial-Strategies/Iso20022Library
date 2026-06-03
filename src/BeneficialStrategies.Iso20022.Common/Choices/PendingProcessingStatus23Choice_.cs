// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus23Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("_rZruc6ohEfCG2_q2WT-90w")]
    [DisplayName("Pending Processing Status 23 Choice")]
    [KnownType(typeof(PendingProcessingStatus23Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus23Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus23Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus23Choice.Reason))]
    public abstract record PendingProcessingStatus23Choice_
    {
    }
}
