// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the inquiry verification response message.</summary>
    [IsoId("_kNBju27-EfC68Y4jZPNEug")]
    [DisplayName("Inquiry Verification Response")]
    public record InquiryVerificationResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NqryVrfctnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
