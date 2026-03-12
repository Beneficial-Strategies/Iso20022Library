// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType11Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_SzWnWQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
