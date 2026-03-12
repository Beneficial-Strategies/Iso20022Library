// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationReason1Choice
{
    /// <summary>
    /// Reason for the cancellation request in a coded form.
    /// </summary>
    [IsoId("_TO3GtNp-Ed-ak6NoX_4Aeg_-748049469")]
    [DisplayName("Code")]
    public partial record Code : CancellationReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for requesting the cancellation of a payment instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
