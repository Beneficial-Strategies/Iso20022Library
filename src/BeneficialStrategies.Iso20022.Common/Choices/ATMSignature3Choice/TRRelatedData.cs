// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ATMSignature3Choice
{
    /// <summary>The data block for a TR31 or TR34 block, where the block does not contain a key.</summary>
    [IsoId("_CObUY8PzEfCTf8R2j0RpdQ")]
    [DisplayName("TRRelated Data")]
    public record TRRelatedData : ATMSignature3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TRRltdData")]
        public required TRRelatedData2 Value { get; init; }
    }
}
