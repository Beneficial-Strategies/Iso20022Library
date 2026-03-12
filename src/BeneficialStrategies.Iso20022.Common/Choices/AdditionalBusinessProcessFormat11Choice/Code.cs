// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat11Choice
{
    /// <summary>
    /// Standard code to specify the additional business process &quot;tax refund&quot; linked to a corporate action event.
    /// </summary>
    [IsoId("_ZfuusUGPEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public partial record Code : AdditionalBusinessProcessFormat11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the additional business process linked to a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
