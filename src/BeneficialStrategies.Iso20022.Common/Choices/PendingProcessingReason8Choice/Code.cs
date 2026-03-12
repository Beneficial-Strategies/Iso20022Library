// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason8Choice
{
    /// <summary>
    /// Reason for the pending status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Ooypv1jsEeOnqqBHs8Gasw")]
    [DisplayName("Code")]
    public partial record Code : PendingProcessingReason8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for pending status.
        /// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPendingProcessingReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
