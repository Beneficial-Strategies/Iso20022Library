// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode4Choice
{
    /// <summary>
    /// Qualifies further the pending status.
    /// </summary>
    [IsoId("_RZlnINp-Ed-ak6NoX_4Aeg_1463454834")]
    [DisplayName("Pending Status")]
    public partial record PendingStatus : PaymentStatusCode4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the state of a payment at the clearing agent side is pending.
        /// </summary>
        [IsoXmlTag("PdgSts")]
        public required PendingStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
