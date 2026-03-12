// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancelledReason12Choice
{
    /// <summary>
    /// Cancelled reason expressed as a code.
    /// </summary>
    [IsoId("_fBNm0UHTEeasdbKMiqizqA")]
    [DisplayName("Code")]
    public partial record Code : CancelledReason12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
