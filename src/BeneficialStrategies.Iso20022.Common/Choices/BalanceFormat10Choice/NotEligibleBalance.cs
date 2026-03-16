// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat10Choice
{
    /// <summary>
    /// Provide not eligible balance information in different formats.
    /// </summary>
    [IsoId("_cjzu75KQEeWHWpTQn1FFVg")]
    [DisplayName("Not Eligible Balance")]
    public record NotEligibleBalance : BalanceFormat10Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_cfsEf5KQEeWHWpTQn1FFVg")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_cfsEgZKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; }
    }
}
