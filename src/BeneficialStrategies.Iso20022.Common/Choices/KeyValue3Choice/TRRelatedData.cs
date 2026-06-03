// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.KeyValue3Choice
{
    /// <summary>Data block for a TR31 or TR34 block where the block does not contain a key.</summary>
    [IsoId("_Pa-OM8PzEfCTf8R2j0RpdQ")]
    [DisplayName("TR Related Data")]
    public record TRRelatedData : KeyValue3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TRRltdData")]
        public required TRRelatedData2 Value { get; init; }
    }
}
