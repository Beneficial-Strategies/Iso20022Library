// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SuspendedStatusReasonChoice
{
    /// <summary>
    /// Reason for the suspended status.
    /// </summary>
    [IsoId("_RfGZStp-Ed-ak6NoX_4Aeg_1537280903")]
    [DisplayName("Reason")]
    public partial record Reason : SuspendedStatusReasonChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a suspended status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required SuspendedStatusReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
