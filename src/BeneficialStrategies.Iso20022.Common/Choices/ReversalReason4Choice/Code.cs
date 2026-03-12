// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice
{
    /// <summary>
    /// Reason for the reversal, as published in an external reason code list.
    /// </summary>
    [IsoId("_TRGiYNp-Ed-ak6NoX_4Aeg_-340627868")]
    [DisplayName("Code")]
    public partial record Code : ReversalReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reversal reason, as published in an external reversal reason code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalReversalReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
