// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat7Choice
{
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_cfsEr5KQEeWHWpTQn1FFVg")]
    [DisplayName("Balance")]
    public record Balance : BalanceFormat7Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_cfAum5KQEeWHWpTQn1FFVg")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Choice between different quantity of security formats.
        /// </summary>
        [IsoId("_cfAunZKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity Choice")]
        [IsoXmlTag("QtyChc")]
        public required Quantity21Choice_ QuantityChoice { get; init; }
    }
}
