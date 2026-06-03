// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus80Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction processing pending status.</summary>
    [IsoId("_CVnhoaKuEfCHi7w3_0pcpw")]
    [DisplayName("Pending Status 80 Choice")]
    [KnownType(typeof(PendingStatus80Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus80Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus80Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus80Choice.Reason))]
    public abstract record PendingStatus80Choice_
    {
    }
}
