// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification335Choice
{
    /// <summary>Account identification.</summary>
    [IsoId("_KfJRganVEfC5VNwixU6YfQ")]
    [DisplayName("Account")]
    public record Account : PartyIdentification335Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Acct")]
        public required AccountIdentification84Choice_ Value { get; init; }
    }
}
