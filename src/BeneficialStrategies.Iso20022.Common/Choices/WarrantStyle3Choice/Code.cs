// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.WarrantStyle3Choice
{
    /// <summary>
    /// Warrant style expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_q6-rgeLbEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : WarrantStyle3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines how an option can be exercised.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WarrantStyle1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
