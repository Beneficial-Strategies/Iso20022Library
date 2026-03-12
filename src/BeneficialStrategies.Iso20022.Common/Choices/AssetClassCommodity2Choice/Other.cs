// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Indicates other types of commodities.
    /// </summary>
    [IsoId("_2t5pYUDcEeWOL-OsSq2h6w")]
    [DisplayName("Other")]
    public partial record Other : AssetClassCommodity2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
