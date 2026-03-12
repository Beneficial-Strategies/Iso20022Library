// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStage3Choice
{
    /// <summary>
    /// Corporate action event stage expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_RhjNMTqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventStage3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
