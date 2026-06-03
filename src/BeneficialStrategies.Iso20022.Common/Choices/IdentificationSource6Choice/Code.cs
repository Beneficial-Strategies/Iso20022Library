// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource6Choice
{
    /// <summary>Unique and unambiguous identification source, as assigned via a pre-determined code list.</summary>
    [IsoId("89198044-a9a9-4533-97f0-a96aa633ec3f")]
    [DisplayName("Code")]
    public record Code : IdentificationSource6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required FinancialInstrumentIdentificationType1Code Value { get; init; }
    }
}
