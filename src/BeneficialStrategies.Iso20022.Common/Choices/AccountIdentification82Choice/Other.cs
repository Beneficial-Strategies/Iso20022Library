// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification82Choice
{
    /// <summary>Unique identification of an account, as assigned by the account servicer, using an identification scheme.</summary>
    [IsoId("0ea7fcff-df38-469b-8412-306607c0c809")]
    [DisplayName("Other")]
    public record Other : AccountIdentification82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Othr")]
        public required GenericAccountIdentification1 Value { get; init; }
    }
}
