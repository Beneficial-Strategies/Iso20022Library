// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriorityCode2Choice
{
    /// <summary>
    /// Priority code, in a coded form.
    /// </summary>
    [IsoId("_74UMs6MgEeCJ6YNENx4h-w_1723672223")]
    [DisplayName("Code")]
    public partial record Code : PriorityCode2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the priority level of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Priority1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
