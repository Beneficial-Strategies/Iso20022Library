// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the financial response message.</summary>
    [IsoId("_kNBjr27-EfC68Y4jZPNEug")]
    [DisplayName("Financial Response")]
    public record FinancialResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FinRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
