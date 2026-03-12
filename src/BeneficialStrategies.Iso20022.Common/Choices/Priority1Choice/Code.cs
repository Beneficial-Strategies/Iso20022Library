// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Priority1Choice
{
    /// <summary>
    /// Priority code, in a coded form.
    /// </summary>
    [IsoId("_SP24wX_REeiik6YN_dzlEA")]
    [DisplayName("Code")]
    public partial record Code : Priority1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the priority level of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Priority5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
