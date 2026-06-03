// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification38Choice
{
    /// <summary>Unique identification of the cash account, as assigned by the account servicer.</summary>
    [IsoId("_mmlMg-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Cash Account Identification")]
    public record CashAccountIdentification : AccountIdentification38Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAcctId")]
        public required AccountIdentification4Choice_ Value { get; init; }
    }
}
