// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus86Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction processing pending status.</summary>
    [IsoId("_G1EmMbMaEfCEXew4g5B5oA")]
    [DisplayName("Pending Status 86 Choice")]
    [KnownType(typeof(PendingStatus86Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus86Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus86Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus86Choice.Reason))]
    public abstract record PendingStatus86Choice_
    {
    }
}
