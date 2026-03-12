// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderWaiverReason1Choice
{
    /// <summary>
    /// Reason why an order has to be handled differently, probably in a manual fashion, because, for example, the investment manager has agreed a waiver to the terms.
    /// </summary>
    [IsoId("_SdiXdtp-Ed-ak6NoX_4Aeg_-249935305")]
    [DisplayName("Reason")]
    public partial record Reason : OrderWaiverReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Relates to non-standard orders, to handle them differently, probably in a manual fashion.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required OrderWaiverReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
