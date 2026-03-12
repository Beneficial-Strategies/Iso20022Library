// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemEventType3Choice
{
    /// <summary>
    /// Type of system event, as published in an external code list.
    /// </summary>
    [IsoId("_wCNH5MlcEeW3r6pl_9_bpw")]
    [DisplayName("Code")]
    public partial record Code : SystemEventType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the technical error, as published in an external technical error code list.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemEvent1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
