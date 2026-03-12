// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationCompleteReason1Choice
{
    /// <summary>
    /// Cancelled complete reason expressed as a code.
    /// </summary>
    [IsoId("_inS8ICYwEeW_ZNn8gbfY7Q")]
    [DisplayName("Code")]
    public partial record Code : CancellationCompleteReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
