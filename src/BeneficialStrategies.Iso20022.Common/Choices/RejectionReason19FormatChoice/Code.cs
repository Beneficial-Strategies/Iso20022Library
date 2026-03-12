// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason19FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of a global movement authorisation request.
    /// </summary>
    [IsoId("_Rofl0Np-Ed-ak6NoX_4Aeg_216780374")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason19FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of a global movement authorisation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason19Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
