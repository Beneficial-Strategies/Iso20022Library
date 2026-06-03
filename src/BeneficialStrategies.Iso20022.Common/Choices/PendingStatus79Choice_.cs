// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus79Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("_XtPBAeSkEe-qVZLXW4RRBw")]
    [DisplayName("Pending Status 79 Choice")]
    [KnownType(typeof(PendingStatus79Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus79Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus79Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus79Choice.Reason))]
    public abstract record PendingStatus79Choice_
    {
    }
}
