// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice
{
    /// <summary>
    /// Qualifies further the pending status.
    /// </summary>
    [IsoId("_72FYE6MgEeCJ6YNENx4h-w_85947767")]
    [DisplayName("Pending")]
    public partial record Pending : PaymentStatusCode5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the state of a payment at the clearing agent side is pending.
        /// </summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
