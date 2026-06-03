// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the account servicer transaction identification.</summary>
    [IsoId("_4SiCyeSlEe-qVZLXW4RRBw")]
    [DisplayName("Account Servicer Transaction Identification")]
    public record AccountServicerTransactionIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AcctSvcrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
