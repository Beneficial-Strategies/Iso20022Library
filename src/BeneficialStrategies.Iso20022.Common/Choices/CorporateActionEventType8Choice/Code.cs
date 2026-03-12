// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType8Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_JPlZKfmREeC_eLZALo-S0A")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
