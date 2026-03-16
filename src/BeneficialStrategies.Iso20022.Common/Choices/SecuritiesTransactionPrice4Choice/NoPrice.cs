// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice4Choice
{
    /// <summary>
    /// Captures where no price is yet known.
    /// </summary>
    [IsoId("_8RdkgOI-EeWWKb0jFHxViQ")]
    [DisplayName("No Price")]
    public record NoPrice : SecuritiesTransactionPrice4Choice_
    {
        /// <summary>
        /// Price is currently not available, but pending.
        /// </summary>
        [IsoId("_lr-v8OI_EeWWKb0jFHxViQ")]
        [DisplayName("Pending")]
        [IsoXmlTag("Pdg")]
        public required PriceStatus1Code Pending { get; init; }

        /// <summary>
        /// Currency that will be used but for which no price is yet known.
        /// </summary>
        [IsoId("_tbdkIOI_EeWWKb0jFHxViQ")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; }
    }
}
