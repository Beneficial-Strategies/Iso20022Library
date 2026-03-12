// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProformaStatusReason2Choice
{
    /// <summary>
    /// Reason for the enabled account status expressed as a code.
    /// </summary>
    [IsoId("_MfWS0UzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public partial record Code : ProformaStatusReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for proforma status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProformaStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
