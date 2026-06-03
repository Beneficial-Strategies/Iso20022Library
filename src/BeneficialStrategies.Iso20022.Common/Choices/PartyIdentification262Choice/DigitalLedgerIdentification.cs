// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification262Choice
{
    /// <summary>Place of settlement expressed with a Digital Ledger Identifier.</summary>
    [IsoId("30bcce29-726f-45c7-b0d5-32ba878d562d")]
    [DisplayName("Digital Ledger Identification")]
    public record DigitalLedgerIdentification : PartyIdentification262Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlLdgrId")]
        public required IsoDTI2024Identifier Value { get; init; }
    }
}
