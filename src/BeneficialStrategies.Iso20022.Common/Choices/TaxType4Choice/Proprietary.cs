// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TaxType4Choice
{
    /// <summary>Tax type expressed as a proprietary code.</summary>
    [IsoId("4ebfa512-6c25-4c81-ae2b-7538c904a0e2")]
    [DisplayName("Proprietary")]
    public record Proprietary : TaxType4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
