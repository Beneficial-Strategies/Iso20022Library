// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice
{
    /// <summary>Single securities account identified by its identifier.</summary>
    [IsoId("_4H1_o-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Account")]
    public record Account : SecuritiesAccount2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Acct")]
        public required SecuritiesAccount19 Value { get; init; }
    }
}
