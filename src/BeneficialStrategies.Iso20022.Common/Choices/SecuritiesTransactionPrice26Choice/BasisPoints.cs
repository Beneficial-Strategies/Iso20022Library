// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice
{
    /// <summary>Price expressed as basis points.</summary>
    [IsoId("_HT_WF62kEfCfRtNoJv1jFQ")]
    [DisplayName("Basis Points")]
    public record BasisPoints : SecuritiesTransactionPrice26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BsisPts")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
