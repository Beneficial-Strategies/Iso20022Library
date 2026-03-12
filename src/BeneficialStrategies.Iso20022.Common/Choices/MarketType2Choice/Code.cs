// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarketType2Choice
{
    /// <summary>
    /// Market type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qwwsktp-Ed-ak6NoX_4Aeg_-2098859549")]
    [DisplayName("Code")]
    public partial record Code : MarketType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
