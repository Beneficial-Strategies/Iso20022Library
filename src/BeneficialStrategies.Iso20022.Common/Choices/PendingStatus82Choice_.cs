// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus82Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("_u9DEVaodEfCG2_q2WT-90w")]
    [DisplayName("Pending Status 82 Choice")]
    [KnownType(typeof(PendingStatus82Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus82Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus82Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus82Choice.Reason))]
    public abstract record PendingStatus82Choice_
    {
    }
}
