// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat3Choice
{
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_2-A6MhFPEeKp2ZN13DI_pA")]
    [DisplayName("Balance")]
    public record Balance : BalanceFormat3Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_Q0of9dp-Ed-ak6NoX_4Aeg_1211863483")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Choice between different quantity of security formats.
        /// </summary>
        [IsoId("_Q0of9tp-Ed-ak6NoX_4Aeg_1680090925")]
        [DisplayName("Quantity Choice")]
        [IsoXmlTag("QtyChc")]
        public required Quantity2Choice_ QuantityChoice { get; init; }
    }
}
