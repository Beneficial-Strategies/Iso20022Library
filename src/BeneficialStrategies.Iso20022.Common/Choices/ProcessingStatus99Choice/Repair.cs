// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus99Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("_XHwYGY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus99Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RejectionOrRepairStatus38Choice_ Value { get; init; }
    }
}
