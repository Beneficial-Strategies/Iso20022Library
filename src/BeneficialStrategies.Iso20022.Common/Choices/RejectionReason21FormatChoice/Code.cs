// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason21FormatChoice
{
    /// <summary>
    /// Provides the interest rejection reason using an ISO 20022 code.
    /// </summary>
    [IsoId("_Qki1gtp-Ed-ak6NoX_4Aeg_-2000185214")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason21FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates whether the interest request is rejected due a value date or an interest amount difference.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestRejectionReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
