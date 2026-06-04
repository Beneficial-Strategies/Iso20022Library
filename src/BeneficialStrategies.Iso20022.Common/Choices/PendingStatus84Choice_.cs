// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus84Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason and no reason for the general meeting instruction processing pending status.</summary>
    [IsoId("_Rd70kbMVEfCEXew4g5B5oA")]
    [DisplayName("Pending Status 84 Choice")]
    [KnownType(typeof(PendingStatus84Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus84Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus84Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus84Choice.Reason))]
    public abstract record PendingStatus84Choice_
    {
    }
}
