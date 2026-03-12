// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References66Choice
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_MMl9B_yjEeiM0vtizCHcoA")]
    [DisplayName("Trade Identification")]
    public partial record TradeIdentification : References66Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ‘ + .
        /// </summary>
        [IsoXmlTag("TradId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax52Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
