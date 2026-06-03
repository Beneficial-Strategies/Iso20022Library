// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.KeyValue3Choice
{
    /// <summary>Encrypted value of the cryptographic key.</summary>
    [IsoId("_Pa-OMcPzEfCTf8R2j0RpdQ")]
    [DisplayName("Encrypted Key Value")]
    public record EncryptedKeyValue : KeyValue3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NcrptdKeyVal")]
        public required ContentInformationType10 Value { get; init; }
    }
}
