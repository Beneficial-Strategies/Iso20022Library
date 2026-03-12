// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType51Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_7DbCQYruEeaNFeVGetd6Xw")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType51Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType22Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
