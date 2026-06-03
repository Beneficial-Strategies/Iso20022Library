// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the account servicer transaction identification.</summary>
    [IsoId("3d992178-443c-4f4a-af1f-c43af8b1ed30")]
    [DisplayName("Account Servicer Transaction Identification")]
    public record AccountServicerTransactionIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AcctSvcrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
