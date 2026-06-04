// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TaxType4Choice
{
    /// <summary>Tax type expressed as a code.</summary>
    [IsoId("4af7fa58-d817-49a9-b06a-8cabd0bc024b")]
    [DisplayName("Code")]
    public record Code : TaxType4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required TaxType12Code Value { get; init; }
    }
}
