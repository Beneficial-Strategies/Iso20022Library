// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventType1Choice
{
    /// <summary>
    /// Type of the event, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_71C2R6MgEeCJ6YNENx4h-w_-773786340")]
    [DisplayName("Code")]
    public partial record Code : EventType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type an event generated within a system, as published in an system event type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemEventType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
