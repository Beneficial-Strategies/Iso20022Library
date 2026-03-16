// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus31Choice
{
    /// <summary>
    /// Global Cancellation Status.
    /// </summary>
    [DisplayName("Global Cancellation Status")]
    public partial record GlobalCancellationStatus : CancellationStatus31Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("GblCxlSts")]
        public required CancellationStatus32Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
