// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason81Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_RsaVcbMVEfCEXew4g5B5oA")]
    [DisplayName("Pending Reason 81 Choice")]
    [KnownType(typeof(PendingReason81Choice.Code))]
    [KnownType(typeof(PendingReason81Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason81Choice.Code))]
    [JsonDerivedType(typeof(PendingReason81Choice.Proprietary))]
    public abstract record PendingReason81Choice_
    {
    }
}
