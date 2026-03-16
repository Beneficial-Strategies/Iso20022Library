// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat3Choice
{
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    [IsoId("_qkh_cBFQEeKp2ZN13DI_pA")]
    [DisplayName("Part Way Period Units")]
    [IsoXmlTag("PartWayPrdUnits")]
    public record PartWayPeriodUnits : BalanceFormat3Choice_
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
