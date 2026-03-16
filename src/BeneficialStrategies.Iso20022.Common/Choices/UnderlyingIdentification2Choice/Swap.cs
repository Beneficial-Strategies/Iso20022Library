// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingIdentification2Choice
{
    /// <summary>
    /// Underlying of a swap transaction.
    /// </summary>
    [IsoId("_Ky7eQYG-EeaalK9UbuVGFw")]
    [DisplayName("Swap")]
    public record Swap : UnderlyingIdentification2Choice_
    {
        /// <summary>
        /// Instrument received by the buyer.
        /// </summary>
        [IsoId("_K9fvgYG-EeaalK9UbuVGFw")]
        [DisplayName("Swap In")]
        [IsoXmlTag("SwpIn")]
        public FinancialInstrumentIdentification7Choice_? SwapIn { get; init; }

        /// <summary>
        /// Instrument paid by the buyer.
        /// </summary>
        [IsoId("_K9fvg4G-EeaalK9UbuVGFw")]
        [DisplayName("Swap Out")]
        [IsoXmlTag("SwpOut")]
        public FinancialInstrumentIdentification7Choice_? SwapOut { get; init; }
    }
}
