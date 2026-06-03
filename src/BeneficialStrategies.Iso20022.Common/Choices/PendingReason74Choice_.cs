// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason74Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_FKokYd8FEe-NrtAAlrBEgQ")]
    [DisplayName("Pending Reason 74 Choice")]
    [KnownType(typeof(PendingReason74Choice.Code))]
    [KnownType(typeof(PendingReason74Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason74Choice.Code))]
    [JsonDerivedType(typeof(PendingReason74Choice.Proprietary))]
    public abstract record PendingReason74Choice_
    {
    }
}
