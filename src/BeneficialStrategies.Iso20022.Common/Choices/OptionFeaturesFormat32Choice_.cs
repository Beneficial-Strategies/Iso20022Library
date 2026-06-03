// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat32Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.</summary>
    [IsoId("8b7359b2-a67e-4a23-a44d-6a91a1fc2ed7")]
    [DisplayName("Option Features Format 32 Choice")]
    [KnownType(typeof(Code))]
    [JsonDerivedType(typeof(Code), nameof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Proprietary), nameof(Proprietary))]
    public abstract record OptionFeaturesFormat32Choice_;
}
