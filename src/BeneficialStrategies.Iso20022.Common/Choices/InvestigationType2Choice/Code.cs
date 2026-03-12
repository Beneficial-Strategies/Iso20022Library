// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationType2Choice
{
    /// <summary>
    /// Investigation type, as published in an external investigation type code set.
    /// </summary>
    [IsoId("_yblR43bkEe2GR4CRzIB77g")]
    [DisplayName("Code")]
    public partial record Code : InvestigationType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tracker investigation type, as published in an external tracker investigation type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTrackerInvestigationType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
