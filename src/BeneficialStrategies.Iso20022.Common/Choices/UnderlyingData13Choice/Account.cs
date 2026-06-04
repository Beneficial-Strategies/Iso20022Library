// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice
{
    /// <summary>Underlying data expressed as account details.</summary>
    [IsoId("4882e17b-a650-4f38-93a4-478608ff6a1e")]
    [DisplayName("Account")]
    public record Account : UnderlyingData13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Acct")]
        public required CashAccount40 Value { get; init; }
    }
}
