// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat6Choice
{
    /// <summary>
    /// Standard code to specify the stage of the corporate action event.
    /// </summary>
    [IsoId("_DcfjHCUoEeO8eOSw0QN9mA")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventStageFormat6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the CA lottery event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
