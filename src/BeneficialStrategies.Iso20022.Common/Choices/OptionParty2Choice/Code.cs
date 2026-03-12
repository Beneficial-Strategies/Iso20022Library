// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionParty2Choice
{
    /// <summary>
    /// Option party expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_4cSw4eLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : OptionParty2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if a trade party is a buyer or a seller.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionParty1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
