// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag13Choice
{
    /// <summary>
    /// Indicate that the security is not collateralised.
    /// </summary>
    [IsoId("_J_aqI8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Uncollateralised")]
    public partial record Uncollateralised : CollateralFlag13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Uncollsd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
