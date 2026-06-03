// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason80Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending reason.</summary>
    [IsoId("_lvwuDaogEfCG2_q2WT-90w")]
    [DisplayName("Pending Reason 80 Choice")]
    [KnownType(typeof(PendingReason80Choice.Code))]
    [KnownType(typeof(PendingReason80Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason80Choice.Code))]
    [JsonDerivedType(typeof(PendingReason80Choice.Proprietary))]
    public abstract record PendingReason80Choice_
    {
    }
}
