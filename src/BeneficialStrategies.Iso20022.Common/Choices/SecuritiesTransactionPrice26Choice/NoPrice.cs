// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice
{
    /// <summary>Descriptive fields capturing where no strike price is known.</summary>
    [IsoId("_L_nXsK2kEfCfRtNoJv1jFQ")]
    [DisplayName("No Price")]
    public record NoPrice : SecuritiesTransactionPrice26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoPric")]
        public required SecuritiesTransactionPrice1 Value { get; init; }
    }
}
