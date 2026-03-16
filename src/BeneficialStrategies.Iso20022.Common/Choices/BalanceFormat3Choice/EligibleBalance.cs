// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat3Choice
{
    /// <summary>
    /// Provide eligible balance information in different formats.
    /// </summary>
    [IsoId("_2-A6KhFPEeKp2ZN13DI_pA")]
    [DisplayName("Eligible Balance")]
    public record EligibleBalance : BalanceFormat3Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_Q0VlBtp-Ed-ak6NoX_4Aeg_-1839841874")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_Q0VlB9p-Ed-ak6NoX_4Aeg_838699823")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }
    }
}
