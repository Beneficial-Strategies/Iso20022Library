// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ATMSignature3Choice
{
    /// <summary>Digital signature of implicit data depending on the security scheme download procedure.</summary>
    [IsoId("_CObUYcPzEfCTf8R2j0RpdQ")]
    [DisplayName("Digital Signature")]
    public record DigitalSignature : ATMSignature3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlSgntr")]
        public required ContentInformationType14 Value { get; init; }
    }
}
