// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice22Choice
{
    /// <summary>
    /// Captures where no price is yet known.
    /// </summary>
    [IsoId("_i7Unc5iuEe2f7NHvXATP5g")]
    [DisplayName("No Price")]
    public record NoPrice : SecuritiesTransactionPrice22Choice_
    {
        /// <summary>
        /// Price is currently not available, but pending.
        /// </summary>
        [IsoId("_M65AsZivEe2f7NHvXATP5g")]
        [DisplayName("Pending")]
        [IsoXmlTag("Pdg")]
        public required PriceStatus1Code Pending { get; init; }

        /// <summary>
        /// Currency that will be used but for which no price is yet known.
        /// </summary>
        [IsoId("_M65As5ivEe2f7NHvXATP5g")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; }

        /// <summary>
        /// Specifies the digital token when the number of units may not be known.
        /// </summary>
        [IsoId("_NPG9MpivEe2f7NHvXATP5g")]
        [DisplayName("Digital Token")]
        [IsoXmlTag("DgtlTkn")]
        public DigitalTokenAmount2? DigitalToken { get; init; }
    }
}
