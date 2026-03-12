// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationRequestStatus1Choice
{
    /// <summary>
    /// Investigation status, as published in an external code set.
    /// </summary>
    [IsoId("_foSGg2QCEe297MhDQvVHLQ")]
    [DisplayName("Code")]
    public partial record Code : InvestigationRequestStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tracker investigation status, as published in an external investigation status code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTrackerInvestigationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
