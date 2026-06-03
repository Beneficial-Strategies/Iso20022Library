// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ModificationStatus6Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of modification status.</summary>
    [IsoId("fab9457b-4791-44b9-930f-eb7aaa526e40")]
    [DisplayName("Modification Status 6 Choice")]
    [KnownType(typeof(NoSpecifiedReason))]
    [JsonDerivedType(typeof(NoSpecifiedReason), nameof(NoSpecifiedReason))]
    [KnownType(typeof(Reason))]
    [JsonDerivedType(typeof(Reason), nameof(Reason))]
    public abstract record ModificationStatus6Choice_;
}
