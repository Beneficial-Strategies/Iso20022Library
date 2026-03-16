// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus2Choice
{
    /// <summary>
    /// Processed Status.
    /// </summary>
    [DisplayName("Processed Status")]
    public partial record ProcessedStatus : NotificationAdviceStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrcdSts")]
        public required NotificationProcessingStatus2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
