// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the inquiry verification initiation message.</summary>
    [IsoId("_kNBjuW7-EfC68Y4jZPNEug")]
    [DisplayName("Inquiry Verification Initiation")]
    public record InquiryVerificationInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NqryVrfctnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
