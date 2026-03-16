// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity23Choice
{
    /// <summary>
    /// Signed quantity of security.
    /// </summary>
    [IsoId("_cfsEYZKQEeWHWpTQn1FFVg")]
    [DisplayName("Signed Quantity")]
    public record SignedQuantity : Quantity23Choice_
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
