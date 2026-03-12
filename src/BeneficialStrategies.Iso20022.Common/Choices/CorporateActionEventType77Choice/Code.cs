// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType77Choice
{
    /// <summary>
    /// Event type expressed as a code.
    /// </summary>
    [IsoId("_ncxYe83hEee5nJBZsW8MFQ")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType77Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType26Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
