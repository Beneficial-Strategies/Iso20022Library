// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity7Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.</summary>
    [IsoId("7b70ec2e-7dd8-426a-af85-34a4cc91092d")]
    [DisplayName("Paired Or Turned Quantity 7 Choice")]
    [KnownType(typeof(PairedOffQuantity))]
    [JsonDerivedType(typeof(PairedOffQuantity), nameof(PairedOffQuantity))]
    [KnownType(typeof(TurnedQuantity))]
    [JsonDerivedType(typeof(TurnedQuantity), nameof(TurnedQuantity))]
    public abstract record PairedOrTurnedQuantity7Choice_;
}
