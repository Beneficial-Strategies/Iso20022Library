// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the securities settlement transaction identification.</summary>
    [IsoId("51e8fcea-4a11-4244-bfb4-bcf488ca3288")]
    [DisplayName("Securities Settlement Transaction Identification")]
    public record SecuritiesSettlementTransactionIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SctiesSttlmTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
