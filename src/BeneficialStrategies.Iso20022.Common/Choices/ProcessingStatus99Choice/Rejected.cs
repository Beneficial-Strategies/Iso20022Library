// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus99Choice
{
    /// <summary>Specifies the rejected status.</summary>
    [IsoId("_XHwYEY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus99Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionOrRepairStatus38Choice_ Value { get; init; }
    }
}
