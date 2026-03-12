// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GovernanceProcess1Choice
{
    /// <summary>
    /// Type of governance process expressed as a code.
    /// </summary>
    [IsoId("_my4H0ID4Eeiw-daIkkmMqQ")]
    [DisplayName("Code")]
    public partial record Code : GovernanceProcess1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of governance process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GovernanceProcessType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
