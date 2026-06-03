// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuantitySearch2Choice
{
    /// <summary>Specifies the original and current face.</summary>
    [IsoId("_eaw7g2qWEemz04WrKJaMEA")]
    [DisplayName("Original And Current Face")]
    public record OriginalAndCurrentFace : QuantitySearch2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OrgnlAndCurFace")]
        public required FinancialInstrumentQuantitySearch2 Value { get; init; }
    }
}
