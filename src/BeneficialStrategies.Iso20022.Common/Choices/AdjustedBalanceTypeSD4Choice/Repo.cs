// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD4Choice
{
    /// <summary>
    /// Repurchase agreement (REPO) between a seller and a buyer whereby the seller agrees to repurchase the securities at an agreed upon price, and usually at a stated time.
    /// </summary>
    [IsoId("_RnUrWcSTEeeRJJtE9TSlkw")]
    [DisplayName("Repo")]
    [IsoXmlTag("Repo")]
    public record Repo : AdjustedBalanceTypeSD4Choice_
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
