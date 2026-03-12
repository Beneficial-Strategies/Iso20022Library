// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reporting9Choice
{
    /// <summary>
    /// Third party reporting information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mslk5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : Reporting9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information with regards to reporting.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reporting2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
