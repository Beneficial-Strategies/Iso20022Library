// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat20Choice
{
    /// <summary>
    /// Standard code to specify the stage of the corporate action event.
    /// </summary>
    [IsoId("_c5V6JZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventStageFormat20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
