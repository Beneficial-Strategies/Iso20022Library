// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralBalance1Choice
{
    /// <summary>
    /// Collateral currently received (+)/delivered (-) in the base currency. This amount is after the haircut has been applied.
    /// </summary>
    [IsoId("_UnXxyNp-Ed-ak6NoX_4Aeg_-1037666527")]
    [DisplayName("Total Collateral")]
    [IsoXmlTag("TtlColl")]
    public record TotalCollateral : CollateralBalance1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Currency")]
        [DisplayName("Active Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Amount")]
        [DisplayName("Active Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; }
    }
}
