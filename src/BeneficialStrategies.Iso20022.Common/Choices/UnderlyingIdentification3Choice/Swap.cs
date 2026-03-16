// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingIdentification3Choice
{
    /// <summary>
    /// Underlying of a swap transaction.
    /// </summary>
    [IsoId("_2EZuEZ3DEeuwmdq0KtnICg")]
    [DisplayName("Swap")]
    public record Swap : UnderlyingIdentification3Choice_
    {
        /// <summary>
        /// Instrument received by the buyer.
        /// </summary>
        [IsoId("_2fXy053DEeuwmdq0KtnICg")]
        [DisplayName("Swap In")]
        [IsoXmlTag("SwpIn")]
        public FinancialInstrumentIdentification8Choice_? SwapIn { get; init; }

        /// <summary>
        /// Instrument paid by the buyer.
        /// </summary>
        [IsoId("_2fXy1Z3DEeuwmdq0KtnICg")]
        [DisplayName("Swap Out")]
        [IsoXmlTag("SwpOut")]
        public FinancialInstrumentIdentification8Choice_? SwapOut { get; init; }
    }
}
