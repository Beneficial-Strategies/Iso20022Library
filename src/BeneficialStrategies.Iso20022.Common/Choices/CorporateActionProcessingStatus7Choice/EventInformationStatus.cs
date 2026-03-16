// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus7Choice
{
    /// <summary>
    /// Event Information Status.
    /// </summary>
    [DisplayName("Event Information Status")]
    public partial record EventInformationStatus : CorporateActionProcessingStatus7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("EvtInfSts")]
        public required CorporateActionProcessingStatus5Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
