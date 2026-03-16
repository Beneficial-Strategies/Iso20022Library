// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus31Choice
{
    /// <summary>
    /// Detailed Cancellation Status.
    /// </summary>
    [DisplayName("Detailed Cancellation Status")]
    public partial record DetailedCancellationStatus : CancellationStatus31Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtldCxlSts")]
        public required DetailedInstructionCancellationStatus15 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
