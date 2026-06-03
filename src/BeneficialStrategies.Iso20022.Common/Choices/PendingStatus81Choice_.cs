// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus81Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("b9005a97-e5d0-49c4-9ac3-3ebff8d20b2c")]
    [DisplayName("Pending Status 81 Choice")]
    [KnownType(typeof(PendingStatus81Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus81Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus81Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus81Choice.Reason))]
    public abstract record PendingStatus81Choice_
    {
    }
}
