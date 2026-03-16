// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError10Choice
{
    /// <summary>
    /// Cancellations.
    /// </summary>
    [DisplayName("Cancellations")]
    public partial record Cancellations : IntraBalanceOrOperationalError10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cxls")]
        public required IntraBalanceCancellation7 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
