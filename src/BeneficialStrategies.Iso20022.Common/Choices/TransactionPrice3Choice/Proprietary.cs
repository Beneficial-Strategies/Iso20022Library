// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice3Choice
{
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [IsoId("_tqJEMFkyEeGeoaLUQk__nA_1612231068")]
    [DisplayName("Proprietary")]
    public record Proprietary : TransactionPrice3Choice_
    {
        /// <summary>
        /// Specifies the type of price.
        /// </summary>
        [IsoId("_Rpr4pdp-Ed-ak6NoX_4Aeg_1562404617")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Type { get; init; }

        /// <summary>
        /// Proprietary price specification related to the underlying transaction.
        /// </summary>
        [IsoId("_Rpr4ptp-Ed-ak6NoX_4Aeg_1562404671")]
        [DisplayName("Price")]
        [IsoXmlTag("Pric")]
        public required ActiveOrHistoricCurrencyAndAmount Price { get; init; }
    }
}
