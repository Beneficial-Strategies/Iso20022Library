// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the financial initiation message.</summary>
    [IsoId("_kNBjrW7-EfC68Y4jZPNEug")]
    [DisplayName("Financial Initiation")]
    public record FinancialInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FinInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
