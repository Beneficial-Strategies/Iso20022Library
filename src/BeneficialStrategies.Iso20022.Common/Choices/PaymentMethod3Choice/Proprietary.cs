// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PaymentMethod3Choice
{
    /// <summary>Method of payment for the remittance of the CSD or the NCB to the invoicing party, in a proprietary free text format.</summary>
    [IsoId("_63Gwk9EvEfCli6pH8hj5ag")]
    [DisplayName("Proprietary")]
    public record Proprietary : PaymentMethod3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax210Text Value { get; init; }
    }
}
