// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification82Choice
{
    /// <summary>International Bank Account Number (IBAN).</summary>
    [IsoId("62a4e9f5-f372-4821-93ed-a3ce4d7cc784")]
    [DisplayName("IBAN")]
    public record IBAN : AccountIdentification82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IBAN")]
        public required IsoIBAN2007Identifier Value { get; init; }
    }
}
