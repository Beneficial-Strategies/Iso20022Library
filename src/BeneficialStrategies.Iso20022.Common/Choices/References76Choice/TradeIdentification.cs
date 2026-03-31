// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References76Choice
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_diXS3Ti8Eeydid5dcNPKvg")]
    [DisplayName("Trade Identification")]
    public record TradeIdentification : References76Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ‘ + .
        /// </summary>
        [IsoXmlTag("TradId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoRestrictedFINXMax52Text Value { get; init; }
    }
}
