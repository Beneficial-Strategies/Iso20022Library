// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionNarrative3Choice
{
    /// <summary>
    /// Standard code to specify the narrative type of the message.
    /// </summary>
    [IsoId("_76NXIUGVEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionNarrative3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the narrative type of a corporate action.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionNarrative1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
