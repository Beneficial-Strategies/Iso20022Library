// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus83Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("_lrsGgaogEfCG2_q2WT-90w")]
    [DisplayName("Pending Status 83 Choice")]
    [KnownType(typeof(PendingStatus83Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus83Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus83Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus83Choice.Reason))]
    public abstract record PendingStatus83Choice_
    {
    }
}
