// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatusReason9Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RXWyiNp-Ed-ak6NoX_4Aeg_-1456677529")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatusReason9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Reason for which an instruction, request, report message is rejected.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
