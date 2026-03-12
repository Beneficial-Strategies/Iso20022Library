// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TEFRARules3Choice
{
    /// <summary>
    /// TEFRA rules expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_irPNceLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : TEFRARules3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the IRS under which the security is issued.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TEFRARules1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
