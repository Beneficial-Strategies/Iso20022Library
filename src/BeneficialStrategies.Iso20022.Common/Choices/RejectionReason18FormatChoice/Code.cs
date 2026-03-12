// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason18FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of an election advice.
    /// </summary>
    [IsoId("_RoV01Np-Ed-ak6NoX_4Aeg_202927158")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason18FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of an election advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason18Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
