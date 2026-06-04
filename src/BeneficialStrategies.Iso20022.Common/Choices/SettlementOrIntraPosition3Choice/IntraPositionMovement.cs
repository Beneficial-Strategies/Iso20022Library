// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrIntraPosition3Choice
{
    /// <summary>Intra-position movement details.</summary>
    [IsoId("_TgJxcWp9EemmaZLSPtWX5A")]
    [DisplayName("Intra Position Movement")]
    public record IntraPositionMovement : SettlementOrIntraPosition3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IntraPosMvmnt")]
        public required IntraPosition6 Value { get; init; }
    }
}
