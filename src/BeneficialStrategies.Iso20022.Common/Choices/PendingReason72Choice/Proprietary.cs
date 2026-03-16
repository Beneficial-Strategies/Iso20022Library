// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingReason72Choice
{
    /// <summary>
    /// Proprietary.
    /// </summary>
    [DisplayName("Proprietary")]
    public partial record Proprietary : PendingReason72Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification47 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
