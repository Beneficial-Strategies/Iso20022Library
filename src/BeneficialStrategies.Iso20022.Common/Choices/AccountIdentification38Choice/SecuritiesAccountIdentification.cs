// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification38Choice
{
    /// <summary>Unique identification of the securities account as assigned by the account servicer.</summary>
    [IsoId("_mmlMgeF6EeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Identification")]
    public record SecuritiesAccountIdentification : AccountIdentification38Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SctiesAcctId")]
        public required SecuritiesAccount19 Value { get; init; }
    }
}
