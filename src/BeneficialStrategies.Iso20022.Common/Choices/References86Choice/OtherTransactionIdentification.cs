// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the other transaction identification.</summary>
    [IsoId("5147c52c-cde1-4d2c-a81d-fb58f63537b2")]
    [DisplayName("Other Transaction Identification")]
    public record OtherTransactionIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
