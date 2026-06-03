// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Indicates the compensation due for the request.</summary>
    [IsoId("007d9e8e-ecc4-4286-8425-524187aa22d2")]
    [DisplayName("Compensation")]
    public record Compensation : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Compstn")]
        public required CompensationResponse1 Value { get; init; }
    }
}
