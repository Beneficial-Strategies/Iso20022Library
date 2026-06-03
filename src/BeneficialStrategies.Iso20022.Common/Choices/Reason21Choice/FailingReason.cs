// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the failing reason.</summary>
    [IsoId("32fcfacb-3d25-440b-91fe-015b8d3d5649")]
    [DisplayName("Failing Reason")]
    public record FailingReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FlngRsn")]
        public required FailingReason9Choice_ Value { get; init; }
    }
}
